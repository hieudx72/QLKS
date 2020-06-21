using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Model.DAO
{
    public class ThietBiDao
    {
        MyDataBase mydb = null;
        public ThietBiDao()
        {
            mydb = new MyDataBase();
        }

        public DataTable DSPhong()
        {
            string str = "SELECT MaPhong FROM PHONG";
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }
        public DataTable DsTBTheoPhong(string ma)
        {
            string str = "SELECT TenThietBi, SoLuong FROM THIETBI WHERE idPhong =" + ma;
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }

        public int addTB(THIETBI tb)
        {
            mydb.THIETBIs.Add(tb);
            mydb.SaveChanges();
            return tb.SoLuong;
        }

        public bool xoaTB(THIETBI tb)
        {
            try
            {               
                mydb.THIETBIs.Remove(tb);
                mydb.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
      
    }
}
