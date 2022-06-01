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
    public class WriterChefManager : IWriterChefService
    {
        IWriterChefDAL _writerChefDAL;

        public WriterChefManager(IWriterChefDAL writerChefDAL)
        {
            _writerChefDAL = writerChefDAL;
        }

        public List<WriterChef> GetAllWriterChef()
        {
            return _writerChefDAL.GetAll();
        }
        public WriterChef GetById(int id)
        {
            return _writerChefDAL.GetById(id);
        }
        public WriterChef GetSingle(WriterChef writerChef)
        {

            return _writerChefDAL.GetSingle(writerChef);

        }
        public void WriterChefAdd(WriterChef writerChef)
        {
            _writerChefDAL.Add(writerChef);
        }
        public void WriterChefDelete(WriterChef writerChef)
        {
            _writerChefDAL.Delete(writerChef);
        }
        public void WriterChefUpdate(WriterChef writerChef)
        {
            _writerChefDAL.Update(writerChef);
        }
    }
}
