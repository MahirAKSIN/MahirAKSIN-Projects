using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FoodManager : IFoodService
    {
        EfFoodRepository ef;
       
        public FoodManager( EfFoodRepository ef)
        {

            this.ef = ef;
        }

        public void Create(Food entity, int[] categoryIds)
        {
           
        }

        //public FoodManager(EfFoodRepository ef, IFoodDAL foodDAL)
        //{
        //    this.ef = ef;
        //    _foodDAL = foodDAL;
        //}

        public void FoddAdd(Food food)
        {
            ef.Add(food);
        }
        public void FoodDelete(Food food)
        {
            ef.Delete(food); ;

        }
        public void FoodUpdate(Food food)
        {
            ef.Update(food);
        }
        public List<Food> GetAllFood()
        {
            return ef.GetAll();
        }

        public List<Food> GetById(int id)
        {
            return ef.GetAllList(i => i.FoodId == id);
        }

        public List<Food> GetFoodListWithCategory()
        {
            return ef.GetListWithCategorg();
        }

        public Food GetSingle(Food food)
        {
            return ef.GetSingle(food);

        }
    }
}
