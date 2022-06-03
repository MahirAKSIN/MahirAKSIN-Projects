using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IFoodDAL : IRepository<Food>
    {
        List<Food> GetListWithCategorg();
        void Create(Food entity, int[] categoryIds);
        void Update(Food entity, int[] categoryIds);

    }
}
