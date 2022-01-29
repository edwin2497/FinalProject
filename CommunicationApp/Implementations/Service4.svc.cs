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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service4" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service4.svc or Service4.svc.cs at the Solution Explorer and start debugging.
    public class Service4 : IService4
    {
        Vehicle_TypeOperations vehicle_TypeOperations = new Vehicle_TypeOperations();

        public void DeleteVehicle_Type(int id)
        {
            vehicle_TypeOperations.Delete(id);
        }


        public Vehicle_TypeDTO GetVehicle_TypeId(int id)
        {
            Vehicle_Type sourceVehicle_Type = vehicle_TypeOperations.GetId(id);

            Vehicle_TypeDTO destinationdto = new Vehicle_TypeDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vehicle_Type, Vehicle_TypeDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<Vehicle_TypeDTO>(sourceVehicle_Type);

            destinationdto.Id = sourceVehicle_Type.Id;
            //...

            return destinationdto;
        }

        public void InsertVehicle_Type(Vehicle_TypeDTO vehicle_Type)
        {
            Vehicle_Type destination = new Vehicle_Type();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vehicle_TypeDTO, Vehicle_Type>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Vehicle_Type>(vehicle_Type);

            vehicle_TypeOperations.Insert(destination);
            //...

        }

        public void ModifyVehicle_Type(Vehicle_TypeDTO vehicle_Type)
        {
            Vehicle_Type destination = new Vehicle_Type();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vehicle_TypeDTO, Vehicle_Type>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Vehicle_Type>(vehicle_Type);

            vehicle_TypeOperations.Modify(destination);
            //...
        }

        public Vehicle_TypeList GetAllVehicle_Type()
        {
            List<Vehicle_Type> vehicle_Typelist = vehicle_TypeOperations.GetAll();

            Vehicle_TypeList destinationvehicle_Typelist = new Vehicle_TypeList();

            destinationvehicle_Typelist.lists = new List<Vehicle_TypeDTO>();

            foreach (Vehicle_Type vehicle_Type in vehicle_Typelist)
            {
                destinationvehicle_Typelist.lists.Add(new Vehicle_TypeDTO()
                {
                    Id = vehicle_Type.Id
                    ,
                    Name = vehicle_Type.Name
                    ,
                    Description = vehicle_Type.Description

                });
            }

            return destinationvehicle_Typelist;
        }

    }
}
