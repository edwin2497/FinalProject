using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CommunicationApp
{
    [DataContract]
    public class AdministrativeDTO
    {
        #region Attributes

        private int id;
        private string name;
        private string firstLastName;
        private string secondLastName;
        private int cardId;
        private string password;
        private string email;
        private int phone;
        private bool isAdmin;


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


        #endregion
    }


    [DataContract]
    public class AdministrativeList
    {
        [DataMember]
        public List<AdministrativeDTO> lists;

    }
}