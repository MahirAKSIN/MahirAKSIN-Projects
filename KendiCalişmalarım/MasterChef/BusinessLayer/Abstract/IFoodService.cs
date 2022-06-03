using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFoodService
    {

        void FoddAdd(Food food);
        void FoodDelete(Food food);
        void FoodUpdate(Food food);
        List<Food> GetAllFood();
        List<Food> GetById(int id);
        Food GetSingle(Food food);
        List<Food> GetFoodListWithCategory();
        void Create(Food entity, int[] categoryIds);
    }
}
