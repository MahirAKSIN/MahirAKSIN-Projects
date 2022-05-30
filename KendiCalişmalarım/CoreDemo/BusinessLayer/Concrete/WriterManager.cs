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

        public void WriterAdd(Writer writer)
        {
            writerDAL.Add(writer);
        }
    }
}
