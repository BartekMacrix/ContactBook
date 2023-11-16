using ContactBook.Core.Database;
using ContactBook.Core.Helpers;
using ContactBook.Core.ViewModel.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
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
        public ICommand UpdateDatabase {  get; set; }
        public PearsonPageViewModel()
        {
            AddPearsonCommand = new RelayCommand(AddNewPearson);
            UpdateDatabase = new RelayCommand(UpdateData);
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
                //DateOfBirth = DateOfBirth,
            };

            PearsonList.Add(NewPearson);
            //ClearFields(nameof(FirstName), nameof(LastName), nameof(StreetName),
            //    nameof(HouseNumber), nameof(ApartmentNumber), nameof(PostalCode),
            //nameof(Town), nameof(PhoneNumber)
        //);
        }

        public void UpdateData()
        {
            using (var dbContext = new DatabaseConfig())
            {
                foreach (var viewModel in PearsonList)
                {
                    var matchingViewModel = PearsonList.FirstOrDefault(p => p.Id == viewModel.Id);

                    if (matchingViewModel != null)
                    {

                        if (viewModel.FirstName != matchingViewModel.FirstName)
                            viewModel.FirstName = matchingViewModel.FirstName;

                        if (viewModel.LastName != matchingViewModel.LastName)
                            viewModel.LastName = matchingViewModel.LastName;

                        if (viewModel.StreetName != matchingViewModel.StreetName)
                            viewModel.StreetName = matchingViewModel.StreetName;

                        if (viewModel.HouseNumber != matchingViewModel.HouseNumber)
                            viewModel.HouseNumber = matchingViewModel.HouseNumber;

                        if (viewModel.ApartmentNumber != matchingViewModel.ApartmentNumber)
                            viewModel.ApartmentNumber = matchingViewModel.ApartmentNumber;

                        if (viewModel.PostalCode != matchingViewModel.PostalCode)
                            viewModel.PostalCode = matchingViewModel.PostalCode;

                        if (viewModel.Town != matchingViewModel.Town)
                            viewModel.Town = matchingViewModel.Town;

                        if (viewModel.PhoneNumber != matchingViewModel.PhoneNumber)
                            viewModel.PhoneNumber = matchingViewModel.PhoneNumber;


                        dbContext.SaveChanges();
                    }

                    var newPearson = new PearsonViewModel
                    {
                        FirstName = viewModel.FirstName,
                        LastName = viewModel.LastName,
                        StreetName = viewModel.StreetName,
                        HouseNumber = viewModel.HouseNumber,
                        ApartmentNumber = viewModel.ApartmentNumber,
                        PostalCode = viewModel.PostalCode,
                        Town = viewModel.Town,
                        PhoneNumber = viewModel.PhoneNumber,
                    };

                    dbContext.Pearson.Add(newPearson);
                    dbContext.SaveChanges();
                }
            }
        }

        public void LoadDataFromDatabase()
        {
            using (var dbContext = new DatabaseConfig())
            {
                PearsonList.Clear(); // Wyczyść listę przed ponownym pobraniem danych

                foreach (var pearson in dbContext.Pearson)
                {
                    PearsonList.Add(new PearsonViewModel
                    {
                        Id = pearson.Id,
                        FirstName = pearson.FirstName,
                        LastName = pearson.LastName,
                        StreetName = pearson.StreetName,
                        HouseNumber = pearson.HouseNumber,
                        ApartmentNumber = pearson.ApartmentNumber,
                        PostalCode = pearson.PostalCode,
                        Town = pearson.Town,
                        PhoneNumber = pearson.PhoneNumber,
                    });
                }
            }
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
