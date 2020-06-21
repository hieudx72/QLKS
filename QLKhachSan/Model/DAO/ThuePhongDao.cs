using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Model.DAO
{
    public class ThuePhongDao
    {
        MyDataBase mydb = null;
        public ThuePhongDao()
        {
            mydb = new MyDataBase();
        }

        public DataTable GetKH(string ma)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE MaKH = '" + ma + "'";
            DataTable khachhang = DataProvider.Instance.ExecuteQuery(sql);
            return khachhang;
        }
        public DataTable DSPChon(string ma)
        {
            string str = "SELECT MaPhong, TenLoai, SoNguoi, Gia FROM PHONG, LOAIPHONG WHERE PHONG.idLoaiPhong = LOAIPHONG.MaLoai AND MaPhong = " +ma;
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }

        public DataTable DSPT()
        {
            string str = "SELECT MaPhong FROM PHONG WHERE TinhTrang = 'Trong'";
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }

        public DataTable DSThuePhong()
        {
            string str = "SELECT * FROM THUEPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public int addPT(THUEPHONG tp)
        {
            mydb.THUEPHONGs.Add(tp);
            mydb.SaveChanges();
            return tp.MaThue;
        }

        public bool updateRoom(int maPhong, string tinhtrang)
        {
            try
            {
                PHONG p = mydb.PHONGs.Find(maPhong);
                p.TinhTrang = tinhtrang;
                mydb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool xoaPT(int ma)
        {
            try
            {
                var pt = mydb.THUEPHONGs.Find(ma);
                mydb.THUEPHONGs.Remove(pt);
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
