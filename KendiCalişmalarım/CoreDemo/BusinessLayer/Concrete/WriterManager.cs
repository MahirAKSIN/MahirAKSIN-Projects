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
    public class WriterManager : IWriterService
    {

        IWriterDAL writerDAL;

        public WriterManager(IWriterDAL writerDAL)
        {
            this.writerDAL = writerDAL;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return writerDAL.GetAllList(x => x.WriterId == id);

        }

        public void TAdd(Writer t)
        {
            writerDAL.Add(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            return writerDAL.GetById(id);


        }

        public void TUpdate(Writer t)
        {
            writerDAL.Update(t);
        }


    }
}
