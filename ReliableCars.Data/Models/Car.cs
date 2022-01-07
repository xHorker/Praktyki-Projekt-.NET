using System;
namespace ReliableCars.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Engine { get; set; }
        public DateTime PostedOn { get; set; }
    }
}
