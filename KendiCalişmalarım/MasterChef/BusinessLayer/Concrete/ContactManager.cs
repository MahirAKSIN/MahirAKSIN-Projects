using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {

        IContactDAL _contactDAL;
        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }
        public void ContactAdd(Contact contact)
        {
            _contactDAL.Add(contact);
        }
        public void ContactDelete(Contact contact)
        {
            _contactDAL.Delete(contact);
        }
        public void ContactUpdate(Contact contact)
        {
            _contactDAL.Update(contact);

        }
        public List<Contact> GetAllContact()
        {
            return _contactDAL.GetAll();
        }
        public Contact GetById(int id)
        {
            return _contactDAL.GetById(id);
        }
        public Contact GetSingle(Contact contact)
        {
            return _contactDAL.GetSingle(contact);
        }
    }
}
