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
   public class NewsLetterManager : INewsLetterService
    {

        INewsLetterDAL newsLetterDAL;

        public NewsLetterManager(INewsLetterDAL newsLetterDAL)
        {
            this.newsLetterDAL = newsLetterDAL;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            newsLetterDAL.Add(newsLetter);
        }
    }
}
