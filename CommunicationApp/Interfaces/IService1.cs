using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CommunicationApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        AdministrativeDTO GetAdministrativeId(int id);

        [OperationContract]
        void InsertAdministrative(AdministrativeDTO administrative);

        [OperationContract]
        void DeleteAdministrative(int id);

        [OperationContract]
        void ModifyAdministrative(AdministrativeDTO administrative);

        [OperationContract]
        AdministrativeList GetAllAdministrative();

        [OperationContract]
        bool LoginAdministrative(int id, string password);

        [OperationContract]
        bool IsAdministrative(int id);

        [OperationContract]
        AdministrativeDTO GetAdministrativeCardId(int id);

    }
}
