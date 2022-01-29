using Data_Access;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CustomerOperations
    {
        IUnitOfWork uow = new UnitOfWork();


        public List<Customer> GetAll()
        {
            return uow.Customer.GetAll();
        }

        public Customer GetId(int id)
        {
            return uow.Customer.GetId(id);
        }

        public void Modify(Customer c)
        {
            Customer customer = uow.Customer.GetId(c.Id);
            if (customer != null)
            {
                uow.DbContext.Entry(customer).CurrentValues.SetValues(c);
                uow.Customer.Modify(customer);
            }
        }

        public void Delete(int id)
        {
            Customer customer = uow.Customer.GetId(id);
            if (customer != null)
            {
                uow.Customer.Delete(customer);
            }
        }

        public void Insert(Customer c)
        {
            try
            {
                int id = c.Id;
                string name = c.Name;
                string firstLastName = c.FirstLastName;
                string secondLastName = c.SecondLastName;
                int cardId = c.CardId;
                string password = c.Password;
                string email = c.Email;
                int phone = c.Phone;

                Audit audit = new Audit(id, name, firstLastName, secondLastName, cardId, password, email, phone);

                uow.Audit.Insert(audit);
                uow.Customer.Insert(c);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error CustomerOperations.Insert: {exp.Message}");
            }
        }

        //------------ LOGIN  -------------

        public bool Login(int id, string password)
        {
            return uow.Customer.Login(id, password);
        }

        //-------------------------------

        public Customer GetCardId(int cardId)
        {
            return uow.Customer.GetCardId(cardId);
        }

    }
}
