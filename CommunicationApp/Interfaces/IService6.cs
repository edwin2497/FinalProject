using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationApp.Implementations
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService6" in both code and config file together.
    [ServiceContract]
    public interface IService6
    {
        [OperationContract]
        Service_TypeDTO GetService_TypeId(int id);

        [OperationContract]
        void InsertService_Type(Service_TypeDTO service);

        [OperationContract]
        void DeleteService_Type(int id);

        [OperationContract]
        void ModifyService_Type(Service_TypeDTO service);

        [OperationContract]
        Service_TypeList GetAllService_Type();
    }
}
