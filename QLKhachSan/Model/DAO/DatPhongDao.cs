using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Model.DAO
{
    public class DatPhongDao
    {
        MyDataBase mydb = null;
        public DatPhongDao()
        {
            mydb = new MyDataBase();
        }

        public DataTable GetKH(string ma)
        {
            string sql = "SELECT * FROM KHACHHANG WHERE MaKH = '"+ma+"'";
            DataTable khachhang = DataProvider.Instance.ExecuteQuery(sql);            
            return khachhang;
        }
        public DataTable DSPT(string songuoi)
        {
            string str = "SELECT MaPhong, TenLoai, SoNguoi, Gia FROM PHONG, LOAIPHONG WHERE PHONG.idLoaiPhong = LOAIPHONG.MaLoai AND TinhTrang = 'Trong' AND SoNguoi >= "+ songuoi;
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public DataTable DSDatPhong()
        {
            string str = "SELECT * FROM DATPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }
        public int addDP(DATPHONG dp)
        {
            mydb.DATPHONGs.Add(dp);
            mydb.SaveChanges();
            return dp.MaPhieuDat;
        }

        public bool updateRoom(int maPhong)
        {
            try
            {
                PHONG p = mydb.PHONGs.Find(maPhong);
                p.TinhTrang = "Da dat";
                mydb.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool xoaPD(int ma)
        {
            try
            {
                var pd = mydb.DATPHONGs.Find(ma);
                mydb.DATPHONGs.Remove(pd);
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
