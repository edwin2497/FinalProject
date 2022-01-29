using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CommunicationApp
{
    [DataContract]
    public class AuditDTO
    {
        #region Attributes

        private int id;
        public string name;
        public string firstLastName;
        public string secondLastName;
        private int cardId;
        public string password;
        public string email;
        public int phone;
        public bool isAdmin;
        public int cost;
        public int serviceType;
        public int idCustomer;
        public int vehicleId;
        public string description;
        public string brand;
        public string model;
        public int year;
        public string plate;
        public int type;


        #endregion

        #region Properties
        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public string Name { get => name; set => name = value; }

        [DataMember]
        public string FirstLastName { get => firstLastName; set => firstLastName = value; }

        [DataMember]
        public string SecondLastName { get => secondLastName; set => secondLastName = value; }

        [DataMember]
        public int CardId { get => cardId; set => cardId = value; }

        [DataMember]
        public string Password { get => password; set => password = value; }

        [DataMember]
        public string Email { get => email; set => email = value; }

        [DataMember]
        public int Phone { get => phone; set => phone = value; }

        [DataMember]
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }

        //-------------------------------------------------

        [DataMember]
        public int Cost { get => cost; set => cost = value; }

        [DataMember]
        public int ServiceType { get => serviceType; set => serviceType = value; }

        [DataMember]
        public int Id_Customer { get => idCustomer; set => idCustomer = value; }

        [DataMember]
        public int Vehicle_Id { get => vehicleId; set => vehicleId = value; }


        //-------------------------------------------------

        [DataMember]
        public string Description { get => description; set => description = value; }

        //-------------------------------------------------

        [DataMember]
        public string Brand { get => brand; set => brand = value; }

        [DataMember]
        public string Model { get => model; set => model = value; }

        [DataMember]
        public int Year { get => year; set => year = value; }

        [DataMember]
        public string Plate { get => plate; set => plate = value; }

        [DataMember]
        public int Type { get => type; set => type = value; }

        #endregion
    }

    [DataContract]
    public class AuditList
    {
        [DataMember]
        public List<AuditDTO> lists;

    }
}