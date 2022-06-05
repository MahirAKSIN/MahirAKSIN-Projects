using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        EfAboutRepository efAboutRepository;

        public AboutManager(EfAboutRepository efAboutRepository)
        {
            this.efAboutRepository = efAboutRepository;
        }

        public List<About> ListGetAbout()
        {
            return efAboutRepository.GetAllList();
        }
    }
}
