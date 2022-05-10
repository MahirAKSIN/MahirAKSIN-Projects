using MiniShopApp.Entityy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Abstract
{
    interface ICategoryRepository: IRepository<Category>
    {
        Category GetByIdWithCategories(int CategoryId);


    }
}
