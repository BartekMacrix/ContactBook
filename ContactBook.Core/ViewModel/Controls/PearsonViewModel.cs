using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Core.ViewModel.Controls
{
    [Table("Pearson")]
    public class PearsonViewModel : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public int PostalCode { get; set; }
        public string Town { get; set; }
        public int PhoneNumber { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public int Age { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged = (s, e) => { };

        protected void OnPropertyChanged(string name) => PropertyChanged(this, new PropertyChangedEventArgs(name));
    }
}
