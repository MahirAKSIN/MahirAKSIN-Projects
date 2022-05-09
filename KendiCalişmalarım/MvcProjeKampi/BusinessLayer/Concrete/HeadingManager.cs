using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager
    {
        GenericRepository<Heading> h = new GenericRepository<Heading>();


        public List<Heading> GetAll()
        {
            return h.GetAll();
        }

        public void Add(Heading p)
        {
            if (p.CategoryID > 0)
            {
                h.Insert(p);
            }

        }


    }
}
