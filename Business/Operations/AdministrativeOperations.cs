using Data_Access;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AdministrativeOperations
    {
        IUnitOfWork uow = new UnitOfWork();


        public List<Administrative> GetAll()
        {
            return uow.Administrative.GetAll();
        }

        public Administrative GetId(int id)
        {
            return uow.Administrative.GetId(id);
        }

        public void Modify(Administrative a)
        {
            Administrative administrative = uow.Administrative.GetId(a.Id);
            if (administrative != null)
            {
                uow.DbContext.Entry(administrative).CurrentValues.SetValues(a);
                uow.Administrative.Modify(administrative);
            }
        }

        public void Delete(int id)
        {
            Administrative administrative = uow.Administrative.GetId(id);
            if (administrative != null)
            {
                uow.Administrative.Delete(administrative);
            }
        }

        public void Insert(Administrative a)
        {
            try
            {

                int id = a.Id;
                string name = a.Name;
                string firstLastName = a.FirstLastName;
                string secondLastName = a.SecondLastName;
                int cardId = a.CardId;
                string password = a.Password;
                string email = a.Email;
                int phone = a.Phone;
                bool isAdmin = a.IsAdmin;

                Audit audit = new Audit(id,name,firstLastName,secondLastName,cardId,password,email,phone,isAdmin);

                uow.Audit.Insert(audit);

                uow.Administrative.Insert(a);
            }
            catch (Exception exp)
            {
                Console.WriteLine($"Error AdministrativeOperations.Insert: {exp.Message}");
            }
        }

        //------------ LOGIN  -------------

        public bool Login(int cardId, string password)
        {
            return uow.Administrative.Login(cardId, password);
        }

        public bool IsAdmin(int cardId)
        {
            return uow.Administrative.IsAdmin(cardId);
        }


        //-------------------------------

        public Administrative GetCardId(int cardId)
        {
            return uow.Administrative.GetCardId(cardId);
        }
    }
}
