using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationApp.Implementations
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService3" in both code and config file together.
    [ServiceContract]
    public interface IService3
    {

        [OperationContract]
        VehicleDTO GetVehicleId(int id);

        [OperationContract]
        void InsertVehicle(VehicleDTO vehicle);

        [OperationContract]
        void DeleteVehicle(int id);

        [OperationContract]
        void ModifyVehicle(VehicleDTO vehicle);

        [OperationContract]
        VehicleList GetAllVehicle();

        [OperationContract]
        List<Vehicle> VehicleCustomerList(int cardId);

    }
}
