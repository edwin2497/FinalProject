using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vehicle
    {
        #region Properties

        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Brand { get; set; }

        [MaxLength(50)]
        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [MaxLength(50)]
        [Required]
        public string Plate { get; set; }

        [ForeignKey("Vehicle_Type")]
        [Required]
        public int Type { get; set; }
        public Vehicle_Type Vehicle_Type { get; set; }


        [ForeignKey("Customer")]
        [Required]
        public int IdCustomer { get; set; }
        public Customer Customer { get; set; }


        #endregion

        #region Constructors

        public Vehicle(int id, string brand, string model, int year, string plate, int type, int idCustomer)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Plate = plate;
            Type = type;
            IdCustomer = idCustomer;
        }

        public Vehicle()
        {

        }

        #endregion
    }
}
