using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        #region Properties
        public int Id { get; set; }

        [MaxLength(50)] 
        [Required] 
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstLastName { get; set; }

        [MaxLength(50)]
        [Required]
        public string SecondLastName { get; set; }

        [Required]
        public int CardId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Password { get; set; }

        [MaxLength(250)]
        [Required]
        public string Email { get; set; }

        [Required]
        public int Phone { get; set; }


        #endregion

        #region Constructors

        public Person(int id, string name, string firstLastName, string secondLastName, int cardId, string password, string email, int phone)
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


        public Person()
        {

        }

        #endregion
    }
}
