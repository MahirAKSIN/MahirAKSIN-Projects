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
    public class FoodManager : IFoodService
    {

        IFoodDAL _foodDAL;
        public FoodManager(IFoodDAL foodDAL)
        {
            _foodDAL = foodDAL;
        }
        public void FoddAdd(Food food)
        {
            _foodDAL.Add(food);
        }
        public void FoodDelete(Food food)
        {
            _foodDAL.Delete(food); ;

        }
        public void FoodUpdate(Food food)
        {
            _foodDAL.Update(food);
        }
        public List<Food> GetAllFood()
        {
            return _foodDAL.GetAll();
        }
        public Food GetById(int id)
        {
            return _foodDAL.GetById(id);


        }
        public Food GetSingle(Food food)
        {
            return _foodDAL.GetSingle(food);

        }
    }
}
