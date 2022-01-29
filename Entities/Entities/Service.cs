using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Service
    {
        #region Properties
        public int Id { get; set; }

        [Required]
        public int Cost { get; set; }

        [ForeignKey("Service_Type")]
        [Required]
        public int ServiceType { get; set; }
        public Service_Type Service_Type { get; set; }

        [ForeignKey("Customer")]
        [Required]
        public int IdCustomer { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Vehicle")]
        [Required]
        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }


        #endregion

        #region Constructors

        public Service(int id, int cost, int serviceType, int idCustomer, int vehicleId)
        {
            this.Id = id;
            this.Cost = cost;
            this.ServiceType = serviceType;
            this.IdCustomer = idCustomer;
            this.VehicleId = vehicleId;
        }

        public Service()
        {

        }

        #endregion
    }
}
