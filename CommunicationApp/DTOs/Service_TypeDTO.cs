using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CommunicationApp
{
    [DataContract]
    public class Service_TypeDTO

    {
        #region Attributes

        private int id;
        private string name;
        private string description;

        #endregion

        #region Properties
        [DataMember]
        public int Id { get => id; set => id = value; }

        [DataMember]
        public string Name { get => name; set => name = value; }

        [DataMember]
        public string Description { get => description; set => description = value; }




        #endregion
    }


    [DataContract]
    public class Service_TypeList
    {
        [DataMember]
        public List<Service_TypeDTO> lists;

    }
}