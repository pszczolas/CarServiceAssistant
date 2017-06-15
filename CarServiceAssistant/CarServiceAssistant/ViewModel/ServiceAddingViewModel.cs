using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceAssistant.Utils;
using System.Windows.Input;

namespace CarServiceAssistant.ViewModel
{
    class ServiceAddingViewModel
    {
        public Car CarForService { get; set; }
        public Customer CarOwner { get; set; }
        public string SearchedVin { get; set; }
        public string SearchedPhoneNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string DefectDescription { get; set; }
        public ICommand FindCarByVin { get; set; }
        public ICommand FindCustomerByPhone { get; set; }
        public ICommand AddService { get; set; }

        public ServiceAddingViewModel()
        {
            InitializeCommands();
        }
        private void InitializeCommands()
        {
            AddService = new Command(x => FormIsFilled(), x => AddServiceToDB());
        }
        private void AddServiceToDB()
        {
            CarForService = new Car();
            CarForService.Brand = Brand;
            CarForService.Model = Model;
            CarForService.Vin = Vin ?? "";
            CarOwner = new Customer();
            CarOwner.Name = Name;
            CarOwner.Surname = Surname;
            CarOwner.PhoneNumber = PhoneNumber;
            Service newService = new Service();
            newService.Car = CarForService;
            newService.Customer = CarOwner;
            newService.DefectDescription = DefectDescription ?? "no information";
            newService.StartDate = DateTime.Now;
            ServiceStatus awaiting;
            using (var context = new CarServiceDBEntities())
            {
                awaiting = context.ServiceStatus.First(x => x.Name == "awaiting");
                newService.ServiceStatus = awaiting;
                context.Service.Add(newService);
                context.SaveChanges();
            }
        }
        private bool FormIsFilled()
        {
            return !(string.IsNullOrWhiteSpace(Brand) || string.IsNullOrWhiteSpace(Model) || 
                    string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Surname) || 
                    string.IsNullOrWhiteSpace(PhoneNumber));
        }

    }
}
