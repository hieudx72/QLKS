using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Model.DAO
{
    public class KHDao
    {
        MyDataBase mydb = null;
        public KHDao()
        {
            mydb = new MyDataBase();
        }

        public int addKH(KHACHHANG kh)
        {
            mydb.KHACHHANGs.Add(kh);
            mydb.SaveChanges();
            return kh.MaKH;
        }
        public DataTable DSKh()
        {
            string str = "SELECT * FROM KHACHHANG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);        
            return dt;
        }
        public bool xoaKH(int ma)
        {
            try
            {
                var kh = mydb.KHACHHANGs.Find(ma);
                mydb.KHACHHANGs.Remove(kh);
                mydb.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
           
        }

        public bool updateKH(KHACHHANG kh)
        {
            try
            {
                var khachhang = mydb.KHACHHANGs.Find(kh.MaKH);
                khachhang.TenKH = kh.TenKH;
                khachhang.GioiTinh = kh.GioiTinh;
                khachhang.NgaySinh = kh.NgaySinh;
                khachhang.DiaChi = kh.DiaChi;
                khachhang.SoDT = kh.SoDT;
                khachhang.CMT = kh.CMT;
                khachhang.GhiChu = kh.GhiChu;
                mydb.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
