using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL dAL;

        public ContactManager(IContactDAL dAL)
        {
            this.dAL = dAL;
        }

        public void ContactAdd(Contact contact)
        {
             dAL.Add(contact);
        }
    }
}
