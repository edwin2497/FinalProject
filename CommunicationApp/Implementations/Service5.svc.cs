using AutoMapper;
using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationApp.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service5" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service5.svc or Service5.svc.cs at the Solution Explorer and start debugging.
    public class Service5 : IService5
    {
        ServiceOperations service_operations = new ServiceOperations();

        public void DeleteService(int id)
        {
            service_operations.Delete(id);
        }


        public ServiceDTO GetServiceId(int id)
        {
            Service sourceService = service_operations.GetId(id);

            ServiceDTO destinationdto = new ServiceDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Service, ServiceDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<ServiceDTO>(sourceService);

            destinationdto.Id = sourceService.Id;
            //...

            return destinationdto;
        }

        public void InsertService(ServiceDTO service)
        {
            Service destination = new Service();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiceDTO, Service>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Service>(service);

            service_operations.Insert(destination);
            //...

        }

        public void ModifyService(ServiceDTO service)
        {
            Service destination = new Service();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ServiceDTO, Service>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Service>(service);

            service_operations.Modify(destination);
            //...
        }

        public ServiceList GetAllService()
        {
            List<Service> serviceList = service_operations.GetAll();

            ServiceList destinationServiceList = new ServiceList();

            destinationServiceList.lists = new List<ServiceDTO>();

            foreach (Service service in serviceList)
            {
                destinationServiceList.lists.Add(new ServiceDTO()
                {
                    Id = service.Id
                    ,
                    Cost = service.Cost
                    ,
                    ServiceType = service.ServiceType
                                        ,
                    Id_Customer = service.IdCustomer
                                        ,
                    Vehicle_Id = service.VehicleId

                });
            }

            return destinationServiceList;
        }

        public List<Service> ServiceCustomerList(int cardId)
        {
            return service_operations.ServiceCustomerList(cardId);
        }
    }
}
