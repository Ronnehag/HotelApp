using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.DataModule
{
    public partial class Customer
    {
        [NotMapped]
        public string FullName => FirstName + " " + LastName;
    }
}
