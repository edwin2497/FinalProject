using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Service_Type
    {
        #region Properties

        public int Id { get; set; }

        [Required]    
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description{ get; set; }

        #endregion

        #region Constructors
        public Service_Type(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Service_Type()
        {
        }

        #endregion
    }
}

