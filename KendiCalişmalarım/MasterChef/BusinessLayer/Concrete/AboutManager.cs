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
    public class AboutManager : IAboutService
    {
        IAboutDAL _aDal;
        public AboutManager(IAboutDAL aDal)
        {
            _aDal = aDal;
        }
        public void AboutAdd(About about)
        {
            _aDal.Add(about);

        }
        public void AboutDelete(About about)
        {
            _aDal.Delete(about);
        }
        public void AboutUpdate(About about)
        {

            _aDal.Update(about);
        }
        public List<About> GetAllAbout()
        {
            return _aDal.GetAll();

        }
        public About GetById(int id)
        {
            return _aDal.GetById(id);
        }
        public About GetSingle(About about)
        {
            return _aDal.GetSingle(about);

        }
    }
}
