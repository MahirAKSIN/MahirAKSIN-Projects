using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterChefService
    {
        void WriterChefAdd(WriterChef writerChef);
        void WriterChefDelete(WriterChef writerChef);
        void WriterChefUpdate(WriterChef writerChef);

        List<WriterChef> GetAllWriterChef();
        WriterChef GetById(int id);
        WriterChef GetSingle(WriterChef writerChef);
    }
}
