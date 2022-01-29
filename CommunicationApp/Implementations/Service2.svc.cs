using AutoMapper;
using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommunicationApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        CustomerOperations customerOperations = new CustomerOperations();
        public void DeleteCustomer(int id)
        {
            customerOperations.Delete(id);
        }

        public CustomerDTO GetCustomerId(int id)
        {
            Customer sourceCustomer = customerOperations.GetId(id);

            CustomerDTO destinationdto = new CustomerDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<CustomerDTO>(sourceCustomer);

            destinationdto.Id = sourceCustomer.Id;
            //...

            return destinationdto;
        }

        public void InsertCustomer(CustomerDTO customer)
        {
            Customer destination = new Customer();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerDTO, Customer>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Customer>(customer);

            customerOperations.Insert(destination);
            //...
        }

        public void ModifyCustomer(CustomerDTO customer)
        {
            Customer destination = new Customer();

            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerDTO, Customer>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destination = mapper.Map<Customer>(customer);

            customerOperations.Modify(destination);
            //...
        }

        public CustomerList GetAllCustomer()
        {
            List<Customer> customerlist = customerOperations.GetAll();

            CustomerList destinationcustomerlist = new CustomerList();

            destinationcustomerlist.lists = new List<CustomerDTO>();

            foreach (Customer customer in customerlist)
            {
                destinationcustomerlist.lists.Add(new CustomerDTO()
                {
                    Id = customer.Id
                    ,
                    Name = customer.Name
                    ,
                    FirstLastName = customer.FirstLastName
                    ,
                    SecondLastName = customer.SecondLastName
                    ,
                    CardId = customer.CardId
                    ,
                    Password = customer.Password
                    ,
                    Email = customer.Email
                    ,
                    Phone = customer.Phone

                });
            }

            return destinationcustomerlist;
        }


        //------------ LOGIN  -------------
        public bool LoginCustomer(int id, string password)
        {
            return customerOperations.Login(id, password);
        }

        //-------------------------------

        public CustomerDTO GetCardIdCustomer(int cardId)
        {
            Customer sourceCustomer = customerOperations.GetCardId(cardId);

            CustomerDTO destinationdto = new CustomerDTO();
            //Create Mapping
            //Create Map<source,destination>
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>());
            var mapper = config.CreateMapper();

            //Perform Mapping
            destinationdto = mapper.Map<CustomerDTO>(sourceCustomer);

            destinationdto.CardId = sourceCustomer.CardId;
            //...

            return destinationdto;
        }
    }
}
