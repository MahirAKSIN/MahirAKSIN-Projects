using MiniShopApp.Entityy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Abstract
{
    public interface ICategoryService
    {


    Category GEtById(int id);
        List<Category> GetAll();
        void Update(Category entity);
        void Create(Category entity);
        void Delete(Category entity);
    }
}
