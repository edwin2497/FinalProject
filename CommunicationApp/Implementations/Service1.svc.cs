using AutoMapper;
using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CommunicationApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        AdministrativeOperations administrativeOperations = new AdministrativeOperations();

        public void DeleteAdministrative(int id)
        {
            administrativeOperations.Delete(id);
        }


        public AdministrativeDTO GetAdministrativeId(int id)
        {
            Administrative sourceAdministrative = administrativeOperations.GetId(id);

            AdministrativeDTO destinationdto = new AdministrativeDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Administrative, AdministrativeDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<AdministrativeDTO>(sourceAdministrative);

            destinationdto.Id = sourceAdministrative.Id;
            //...

            return destinationdto;
        }

        public void InsertAdministrative(AdministrativeDTO administrative)
        {
            Administrative destination = new Administrative();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdministrativeDTO, Administrative>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Administrative>(administrative);

            administrativeOperations.Insert(destination);
            //...

        }

        public void ModifyAdministrative(AdministrativeDTO administrative)
        {
            Administrative destination = new Administrative();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdministrativeDTO, Administrative>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Administrative>(administrative);

            administrativeOperations.Modify(destination);
            //...
        }

        public AdministrativeList GetAllAdministrative()
        {
            List<Administrative> administrativelist = administrativeOperations.GetAll();

            AdministrativeList destinationadministrativelist = new AdministrativeList();

            destinationadministrativelist.lists = new List<AdministrativeDTO>();

            foreach (Administrative administrative in administrativelist)
            {
                destinationadministrativelist.lists.Add(new AdministrativeDTO()
                {
                    Id = administrative.Id
                    ,
                    Name = administrative.Name
                    ,
                    FirstLastName = administrative.FirstLastName
                    ,
                    SecondLastName = administrative.SecondLastName
                    ,
                    CardId = administrative.CardId
                    ,
                    Password = administrative.Password
                    ,
                    Email = administrative.Email
                    ,
                    Phone = administrative.Phone
                    ,
                    IsAdmin = administrative.IsAdmin

                });
            }

            return destinationadministrativelist;
        }

        //------------ LOGIN  -------------
        public bool LoginAdministrative(int cardId, string password)
        {
            return administrativeOperations.Login(cardId, password);
        }

        public bool IsAdministrative(int id)
        {
            return administrativeOperations.IsAdmin(id);
        }

        //-------------------------------

        public AdministrativeDTO GetAdministrativeCardId(int cardId)
        {
            Administrative sourceAdministrative = administrativeOperations.GetCardId(cardId);

            AdministrativeDTO destinationdto = new AdministrativeDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Administrative, AdministrativeDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<AdministrativeDTO>(sourceAdministrative);

            destinationdto.CardId = sourceAdministrative.CardId;
            //...

            return destinationdto;
        }
    }
}