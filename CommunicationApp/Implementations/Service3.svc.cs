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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service3" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service3.svc or Service3.svc.cs at the Solution Explorer and start debugging.
    public class Service3 : IService3
    {
        VehicleOperations vehicleOperations = new VehicleOperations();

        public void DeleteVehicle(int id)
        {
            vehicleOperations.Delete(id);
        }


        public VehicleDTO GetVehicleId(int id)
        {
            Vehicle sourceVehicle = vehicleOperations.GetId(id);

            VehicleDTO destinationdto = new VehicleDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vehicle, VehicleDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<VehicleDTO>(sourceVehicle);

            destinationdto.Id = sourceVehicle.Id;
            //...

            return destinationdto;
        }

        public void InsertVehicle(VehicleDTO vehicle)
        {
            Vehicle destination = new Vehicle();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VehicleDTO, Vehicle>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Vehicle>(vehicle);

            vehicleOperations.Insert(destination);
            //...

        }

        public void ModifyVehicle(VehicleDTO vehicle)
        {
            Vehicle destination = new Vehicle();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<VehicleDTO, Vehicle>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Vehicle>(vehicle);

            vehicleOperations.Modify(destination);
            //...
        }

        public VehicleList GetAllVehicle()
        {
            List<Vehicle> vehiclelist = vehicleOperations.GetAll();

            VehicleList destinationvehiclelist = new VehicleList();

            destinationvehiclelist.lists = new List<VehicleDTO>();

            foreach (Vehicle vehicle in vehiclelist)
            {
                destinationvehiclelist.lists.Add(new VehicleDTO()
                {
                    Id = vehicle.Id
                    ,
                    Brand = vehicle.Brand
                    ,
                    Model = vehicle.Model
                    ,
                    Year = vehicle.Year
                    ,
                    Plate = vehicle.Plate
                    ,
                    Type = vehicle.Type
                    ,
                    IdCustomer = vehicle.IdCustomer

                });
            }

            return destinationvehiclelist;
        }

        public List<Vehicle> VehicleCustomerList(int cardId)
        {
            return vehicleOperations.VehicleCustomerList(cardId);
        }

    }
}
