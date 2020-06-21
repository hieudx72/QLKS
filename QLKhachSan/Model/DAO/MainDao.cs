using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Model.DAO
{
    public class MainDao
    {
        MyDataBase myDB = null;
        public MainDao()
        {
            myDB = new MyDataBase();
        }
        public int loadSPT()
        {
            int sp = myDB.PHONGs.Count(x=>x.TinhTrang.Equals("Trong"));
            return sp;
        }
        public int loadSPDD()
        {
            int sp = myDB.PHONGs.Count(x => x.TinhTrang.Equals("Da dat"));
            return sp;
        }
        public int loadSPDT()
        {
            int sp = myDB.PHONGs.Count(x => x.TinhTrang.Equals("Da thue"));
            return sp;
        }
    }
}
