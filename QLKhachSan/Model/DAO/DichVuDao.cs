using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Model.DAO
{
    public class DichVuDao
    {
        MyDataBase mydb = null;
        public DichVuDao()
        {
            mydb = new MyDataBase();
        }

        public int addDV(DICHVU dv)
        {
            mydb.DICHVUs.Add(dv);
            mydb.SaveChanges();
            return dv.MaDV;
        }
        public DataTable DSDV()
        {
            string str = "SELECT * FROM DICHVU";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public bool xoaDV(int ma)
        {
            try
            {
                var dichvu = mydb.DICHVUs.Find(ma);
                mydb.DICHVUs.Remove(dichvu);
                mydb.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool updateDV(DICHVU dv)
        {
            try
            {
                var dichvu = mydb.DICHVUs.Find(dv.MaDV);
                dichvu.TenDichVu = dv.TenDichVu;
                dichvu.Gia = dv.Gia;            
                mydb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
