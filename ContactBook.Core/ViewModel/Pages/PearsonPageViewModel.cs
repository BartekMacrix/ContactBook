using ContactBook.Core.Helpers;
using ContactBook.Core.ViewModel.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ContactBook.Core.ViewModel.Pages
{
    public class PearsonPageViewModel : PearsonViewModel
    {
        public ObservableCollection<PearsonViewModel> PearsonList { get; set; } = new ObservableCollection<PearsonViewModel>();
        public ICommand AddPearsonCommand { get; set; }
        public int xyz;
        public PearsonPageViewModel()
        {
            AddPearsonCommand = new RelayCommand(AddNewPearson);
        }

        public void AddNewPearson()
        {
            var NewPearson = new PearsonViewModel
            {
                FirstName = FirstName,
                LastName = LastName,
                StreetName = StreetName,
                HouseNumber = HouseNumber,
                ApartmentNumber = ApartmentNumber,
                PostalCode = PostalCode,
                Town = Town,
                PhoneNumber = PhoneNumber,
                DateOfBirth = DateOfBirth,
            };


            PearsonList.Add(NewPearson);
            ClearFields(nameof(FirstName), nameof(LastName), nameof(StreetName),
            nameof(Town)
        );
        }

        private void ClearFields(params string[] propertyNames)
        {
            foreach(var propertyName in propertyNames)
            {
                GetType().GetProperty(propertyName)?.SetValue(this, string.Empty);
                OnPropertyChanged(propertyName);
            }
        }
    }
}
