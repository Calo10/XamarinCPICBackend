using System;
namespace ProyectoXamarinCPICBackend.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Detail
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public CustomerModel()
        {
        }
    }
}
