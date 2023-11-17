using ContactBook.Core.Database;
using ContactBook.Core.Helpers;
using ContactBook.Core.ViewModel.Controls;
using Microsoft.Identity.Client;
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
        public ICommand CancelUpdates {  get; set; }
        public PearsonPageViewModel()
        {
            AddPearsonCommand = new RelayCommand(AddNewPearson);
            UpdateDatabase = new RelayCommand(UpdateData);
            CancelUpdates = new RelayCommand(LoadDataFromDatabase);
        }

        public void AddNewPearson()
        {
            using(var dbContext = new DatabaseConfig())
            {
                int maxId = dbContext.Pearson.Max(p => (int?)p.Id) ?? 0;
                Id = maxId + 1;
            var NewPearson = new PearsonViewModel
            {
                Id = Id,
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
        }

        public void UpdateData()
        {
            using (var dbContext = new DatabaseConfig())
            {
                foreach (var viewModel in PearsonList)
                {
                    int matchingIdFromDatabase = dbContext.Pearson
                     .Where(p => p.Id == viewModel.Id)
                     .Select(p => (int?)p.Id)
                     .FirstOrDefault() ?? 0;


                    if (matchingIdFromDatabase != 0)
                    {

                        if (viewModel.FirstName != FirstName)
                            viewModel.FirstName = FirstName;

                        if (viewModel.LastName != LastName)
                            viewModel.LastName = LastName;

                        if (viewModel.StreetName != StreetName)
                            viewModel.StreetName = StreetName;

                        if (viewModel.HouseNumber != HouseNumber)
                            viewModel.HouseNumber = HouseNumber;

                        if (viewModel.ApartmentNumber != ApartmentNumber)
                            viewModel.ApartmentNumber = ApartmentNumber;

                        if (viewModel.PostalCode != PostalCode)
                            viewModel.PostalCode = PostalCode;

                        if (viewModel.Town != Town)
                            viewModel.Town = Town;

                        if (viewModel.PhoneNumber != PhoneNumber)
                            viewModel.PhoneNumber = PhoneNumber;

                    }
                    else
                    {
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
                    }
                }
                dbContext.SaveChanges();
            }
        }

        public void LoadDataFromDatabase()
        {
            using (var dbContext = new DatabaseConfig())
            {
                PearsonList.Clear();

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
