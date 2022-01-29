using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationApp.Implementations
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService7" in both code and config file together.
    [ServiceContract]
    public interface IService7
    {
        [OperationContract]
        AuditDTO GetAuditId(int id);

        [OperationContract]
        void InsertAudit(AuditDTO audit);

        [OperationContract]
        void DeleteAudit(int id);

        [OperationContract]
        void ModifyAudit(AuditDTO audit);

        [OperationContract]
        AuditList GetAllAudit();
    }
}
