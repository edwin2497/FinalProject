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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service6" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service6.svc or Service6.svc.cs at the Solution Explorer and start debugging.
    public class Service6 : IService6
    {
        Service_TypeOperations service_TypeOperations = new Service_TypeOperations();

        public void DeleteService_Type(int id)
        {
            service_TypeOperations.Delete(id);
        }


        public Service_TypeDTO GetService_TypeId(int id)
        {
            Service_Type sourceService_Type = service_TypeOperations.GetId(id);

            Service_TypeDTO destinationdto = new Service_TypeDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Service_Type, Service_TypeDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<Service_TypeDTO>(sourceService_Type);

            destinationdto.Id = sourceService_Type.Id;
            //...

            return destinationdto;
        }

        public void InsertService_Type(Service_TypeDTO service_Type)
        {
            Service_Type destination = new Service_Type();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Service_TypeDTO, Service_Type>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Service_Type>(service_Type);

            service_TypeOperations.Insert(destination);
            //...

        }

        public void ModifyService_Type(Service_TypeDTO service_Type)
        {
            Service_Type destination = new Service_Type();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Service_TypeDTO, Service_Type>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Service_Type>(service_Type);

            service_TypeOperations.Modify(destination);
            //...
        }

        public Service_TypeList GetAllService_Type()
        {
            List<Service_Type> service_TypeList = service_TypeOperations.GetAll();

            Service_TypeList destinationService_TypeList = new Service_TypeList();

            destinationService_TypeList.lists = new List<Service_TypeDTO>();

            foreach (Service_Type serviceType in service_TypeList)
            {
                destinationService_TypeList.lists.Add(new Service_TypeDTO()
                {
                    Id = serviceType.Id
                    ,
                    Name = serviceType.Name
                    ,
                    Description = serviceType.Description
                });
            }

            return destinationService_TypeList;
        }
    }
}
