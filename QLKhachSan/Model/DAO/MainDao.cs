using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        
        public bool updatePass(string tenDN, string mkmoi)
        {
            try
            {
                var nhanvien = myDB.NHANVIENs.Where(x=> x.TenDangNhap.Equals(tenDN)).FirstOrDefault();              
                nhanvien.MatKhau = mkmoi;
                myDB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable DSP()
        {
            string str = "SELECT MaPhong, TinhTrang FROM PHONG";
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }
    }
}
