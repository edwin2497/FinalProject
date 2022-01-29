using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationApp.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService5" in both code and config file together.
    [ServiceContract]
    public interface IService5
    {
        [OperationContract]
        ServiceDTO GetServiceId(int id);

        [OperationContract]
        void InsertService(ServiceDTO service);

        [OperationContract]
        void DeleteService(int id);

        [OperationContract]
        void ModifyService(ServiceDTO service);

        [OperationContract]
        ServiceList GetAllService();

        [OperationContract]
        List<Service> ServiceCustomerList(int cardId);
    }
}
