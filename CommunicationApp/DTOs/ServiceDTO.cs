using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CommunicationApp
{
    [DataContract]
    public class ServiceDTO
    {
        #region Attributes

        private int id;
        private int cost;
        private int serviceType;
        private int id_Customer;
        private int vehicle_Id;


        #endregion

        #region Properties
        [DataMember]
        public int Id { get => id; set => id = value; }

        [DataMember]
        public int Cost { get => cost; set => cost = value; }

        [DataMember]
        public int ServiceType { get => serviceType; set => serviceType = value; }

        [DataMember]
        public int Id_Customer { get => id_Customer; set => id_Customer = value; }

        [DataMember]
        public int Vehicle_Id { get => vehicle_Id; set => vehicle_Id = value; }


        #endregion
    }


    [DataContract]
    public class ServiceList
    {
        [DataMember]
        public List<ServiceDTO> lists;

    }
}