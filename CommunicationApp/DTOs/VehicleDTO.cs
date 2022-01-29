using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CommunicationApp
{
    [DataContract]
    public class VehicleDTO
    {
        #region Attributes

        private int id;
        private string brand;
        private string model;
        private int year;
        private string plate;
        private int type;
        private int idCustomer;


        #endregion

        #region Properties
        [DataMember]
        public int Id { get => id; set => id = value; }

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

        [DataMember]
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }


        #endregion
    }


    [DataContract]
    public class VehicleList
    {
        [DataMember]
        public List<VehicleDTO> lists;

    }
}
