using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarServiceAssistant.ViewModel
{
    class ServiceSelectionViewModel
    {
        private ServiceStatus selectedStatus;
        private string searchedPhrase;
        public ServiceSelectionViewModel()
        {
            using (var context = new CarServiceDBEntities())
            {
                Services = new ObservableCollection<Service>(context.Service.Include("Car").Include("Customer"));
                ServiceStatuses = new ObservableCollection<ServiceStatus>(context.ServiceStatus);
            }
            SelectedStatus = ServiceStatuses.First();
            SearchedPhrase = "";
        }
        public ICommand WorkWithService { get; private set; }
        public ObservableCollection<ServiceStatus> ServiceStatuses { get; set; }
        public ObservableCollection<Service> Services { get; set; }
        public Service SelectedService { get; set; }
        public ServiceStatus SelectedStatus
        {
            get { return selectedStatus; }
            set
            {
                selectedStatus = value;
                FilterServices();
            }
        }
        public string SearchedPhrase
        {
            get { return searchedPhrase; }
            set
            {
                searchedPhrase = value;
                FilterServices();
            }
        }
        private void InitializeCommands()
        {

        }
        private void FilterServices()
        {
            using (var contex = new CarServiceDBEntities())
            {
                var filteredServices = contex.Service
                    .Include("Car").Include("Customer")
                    .Where(x => (x.ServiceStatus.Id == selectedStatus.Id) /*&& x.DefectDescription.Contains(searchedPhrase)*/);
                Services.Clear();
                filteredServices.ToList().ForEach(x => Services.Add(x));
            }
        }

    }
}
