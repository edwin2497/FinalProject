using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Audit
    {
        #region Properties
        //-------------------------------------------------Person,Administrative, Customer
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string FirstLastName { get; set; }

        [MaxLength(50)]
        public string SecondLastName { get; set; }

        public int CardId { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        public int Phone { get; set; }

        //-------------------------------------------------Administrative
        public bool IsAdmin { get; set; }

        //-------------------------------------------------Service
        //Falta campo Id
        public int Cost { get; set; }

        public int ServiceType { get; set; }
  
        public int IdCustomer { get; set; }

        public int VehicleId { get; set; }

        //-------------------------------------------------ServiceType
        //Falta campo Id y nombre
        [MaxLength(100)]
        public string Description { get; set; }


        //-------------------------------------------------Vehicle
        //Falta campo Id y idcustomer

        [MaxLength(50)]
        public string Brand { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        public int Year { get; set; }

        [MaxLength(50)]
        public string Plate { get; set; }

        public int Type { get; set; }




        //-------------------------------------------------VehicleType
        //Falta campo Id, nombre y descripcion

        #endregion

        #region Constructors

        //All fields
        public Audit(int id, string name, string firstLastName, string secondLastName, int cardId, string password, string email, int phone, bool isAdmin, int cost, int serviceType, int idCustomer, int vehicleId, string description, string brand, string model, int year, string plate, int type)
        {
            Id = id;
            Name = name;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            CardId = cardId;
            Password = password;
            Email = email;
            Phone = phone;
            IsAdmin = isAdmin;
            Cost = cost;
            ServiceType = serviceType;
            IdCustomer = idCustomer;
            VehicleId = vehicleId;
            Description = description;
            Brand = brand;
            Model = model;
            Year = year;
            Plate = plate;
            Type = type;
        }

        //Admin
        public Audit(int id, string name, string firstLastName, string secondLastName, int cardId, string password, string email, int phone, bool isAdmin)
        {
            Id = id;
            Name = name;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            CardId = cardId;
            Password = password;
            Email = email;
            Phone = phone;
            IsAdmin = isAdmin;
        }
        //Customer
        public Audit(int id, string name, string firstLastName, string secondLastName, int cardId, string password, string email, int phone)
        {
            Id = id;
            Name = name;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            CardId = cardId;
            Password = password;
            Email = email;
            Phone = phone;

        }
        //Service
        public Audit(int id, int cost, int serviceType, int idCustomer, int vehicleId)
        {
            Id = id;
            Cost = cost;
            ServiceType = serviceType;
            IdCustomer = idCustomer;
            VehicleId = vehicleId;
        }

        //ServiceType - VehicleType
        public Audit(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;

        }

        //Vehicle
        public Audit(int id,string brand, int idCustomer, string model, int year, string plate, int type)
        {
            Id = id;
            IdCustomer = idCustomer;
            Model = model;
            Year = year;
            Plate = plate;
            Type = type;
            Brand = brand;
        }


        public Audit()
        {
        }



        #endregion
    }
}
