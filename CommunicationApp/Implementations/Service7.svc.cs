using AutoMapper;
using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationApp.Implementations
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service7" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service7.svc or Service7.svc.cs at the Solution Explorer and start debugging.
    public class Service7 : IService7
    {
        AuditOperations auditOperations = new AuditOperations();

        public void DeleteAudit(int id)
        {
            auditOperations.Delete(id);
        }


        public AuditDTO GetAuditId(int id)
        {
            Audit sourceAudit = auditOperations.GetId(id);

            AuditDTO destinationdto = new AuditDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Audit, AuditDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<AuditDTO>(sourceAudit);

            destinationdto.Id = sourceAudit.Id;
            //...

            return destinationdto;
        }

        public void InsertAudit(AuditDTO audit)
        {
            Audit destination = new Audit();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AuditDTO, Audit>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Audit>(audit);

            auditOperations.Insert(destination);
            //...

        }

        public void ModifyAudit(AuditDTO audit)
        {
            Audit destination = new Audit();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AuditDTO, Audit>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Audit>(audit);

            auditOperations.Modify(destination);
            //...
        }

        public AuditList GetAllAudit()
        {
            List<Audit> auditList = auditOperations.GetAll();

            AuditList destinationAuditList = new AuditList();

            destinationAuditList.lists = new List<AuditDTO>();

            foreach (Audit audit in auditList)
            {
                destinationAuditList.lists.Add(new AuditDTO()
                {
                    Id = audit.Id
                    ,
                    Name = audit.Name
                    ,
                    Description = audit.Description
                    ,
                    FirstLastName = audit.FirstLastName
                     ,
                    SecondLastName = audit.SecondLastName
                     ,
                    CardId = audit.CardId
                     ,
                    Password = audit.Password
                     ,
                    Email = audit.Email
                     ,
                    Phone = audit.Phone
                     ,
                    IsAdmin = audit.IsAdmin
                     ,
                    Cost = audit.Cost
                     ,
                    ServiceType = audit.ServiceType
                     ,
                    Id_Customer = audit.IdCustomer
                     ,
                    Vehicle_Id = audit.VehicleId
                     ,
                    Brand = audit.Brand
                     ,
                    Model = audit.Model
                     ,
                    Year = audit.Year
                     ,
                    Plate = audit.Plate
                     ,
                    Type = audit.Type
                });
            }

            return destinationAuditList;
        }
    }
}
