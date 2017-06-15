using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using CarServiceAssistant.Utils;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarServiceAssistant.ViewModel
{
    class ServiceModificationViewModel : INotifyPropertyChanged
    {
        private string serviceStatusName;
        public string ServiceStatusName
        {
            get { return serviceStatusName; }
            set { serviceStatusName = value; NotifyPropertyChanged(); }
        }
        public Service Service { get; set; }
        public string PartName { get; set; }
        public string PartPrice { get; set; }
        public string TotalPrice { get; set; }
        public string DefectDescription { get; set; }
        public ObservableCollection<Part> Parts { get; set; }
        public ICommand AddPart { get; set; }
        public ICommand UpdateDescription { get; set; }
        public ICommand CompleteService { get; set; }
        private bool? paid;
        public bool Paid
        {
            get { return paid ?? false; }
            set
            {
                paid = value;
            }
        }

        public ServiceModificationViewModel()
        {
            using (var context = new CarServiceDBEntities())
            {
                Service = context.Service
                    .Include("Customer")
                    .Include("Car")
                    .Include("ServiceStatus")
                    .First(); //HARCODED
                serviceStatusName = Service.ServiceStatus.Name;
                Parts = new ObservableCollection<Part>(context.Part.Where(x => x.ServiceId == Service.Id));
                DefectDescription = Service.DefectDescription;
                //TotalPrice = Service.
            }
            InitializeCommands();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void InitializeCommands()
        {
            AddPart = new Command(x => PartFormFilledCorrectly(), x => AddPartToService());
            UpdateDescription = new Command(x => true, x => UpdateServiceDescription());
            CompleteService = new Command(x => TotalPriceIsInCorrectFormat(), x => ChangeServiceStatus("completed"));
        }
        private bool TotalPriceIsInCorrectFormat()
        {
            decimal totalPrice;
            return decimal.TryParse(TotalPrice,out totalPrice);
        }
        private bool PartFormFilledCorrectly()
        {
            decimal price;
            return !string.IsNullOrWhiteSpace(PartName) && decimal.TryParse(PartPrice, out price);
        }
        private void AddPartToService()
        {
            Part part = new Part();
            part.Name = PartName;
            part.Price = decimal.Parse(PartPrice);
            part.ServiceId = Service.Id;
            using (var context = new CarServiceDBEntities())
            {
                context.Part.Add(part);
                context.SaveChanges();
            }
            Parts.Add(part);
            ChangeServiceStatus("in progress");
        }
        private void UpdateServiceDescription()
        {
            using (var context = new CarServiceDBEntities())
            {
                context.Service.Find(Service.Id).DefectDescription = DefectDescription;
                context.SaveChanges();
            }
            ChangeServiceStatus("in progress");
        }
        private void ChangeServiceStatus(string statusName)
        {
            ServiceStatus status;
            using (var context = new CarServiceDBEntities())
            {
                status = context.ServiceStatus.First(x => x.Name == statusName);
                context.Service.Find(Service.Id).ServiceStatus = status;
                context.SaveChanges();
            }
            ServiceStatusName = status.Name;
        }
    }
}
