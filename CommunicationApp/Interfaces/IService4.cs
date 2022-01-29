using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationApp.Implementations
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService4" in both code and config file together.
    [ServiceContract]
    public interface IService4
    {
        [OperationContract]
        Vehicle_TypeDTO GetVehicle_TypeId(int id);

        [OperationContract]
        void InsertVehicle_Type(Vehicle_TypeDTO vehicleType);

        [OperationContract]
        void DeleteVehicle_Type(int id);

        [OperationContract]
        void ModifyVehicle_Type(Vehicle_TypeDTO vehicleType);

        [OperationContract]
        Vehicle_TypeList GetAllVehicle_Type();

    }
}
