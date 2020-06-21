using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Model.DAO
{
    public class PhongDao
    {
        MyDataBase mydb = null;
        public PhongDao()
        {
            mydb = new MyDataBase();
        }
       //------------------------------
        public DataTable DSLoaiPhong()
        {
            string str = "SELECT * FROM LOAIPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }

        public int addLP(LOAIPHONG lp)
        {
            mydb.LOAIPHONGs.Add(lp);
            mydb.SaveChanges();
            return lp.MaLoai;
        }
        public bool xoaLP(int ma)
        {
            try
            {
                var lp = mydb.LOAIPHONGs.Find(ma);
                mydb.LOAIPHONGs.Remove(lp);
                mydb.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool updateLP(LOAIPHONG p)
        {
            try
            {
                var lp = mydb.LOAIPHONGs.Find(p.MaLoai);
                lp.TenLoai = p.TenLoai;
                lp.SoNguoi = p.SoNguoi;
                lp.Gia = p.Gia;
                mydb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //------------------------------
        public DataTable DSPhong()
        {
            string str = "SELECT * FROM PHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(str);
            return dt;
        }

        public int addPhong(PHONG p)
        {
            mydb.PHONGs.Add(p);
            mydb.SaveChanges();
            return p.MaPhong;
        }
        public bool xoaPhong(int ma)
        {
            try
            {
                var p = mydb.PHONGs.Find(ma);
                mydb.PHONGs.Remove(p);
                mydb.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool updatePhong(PHONG p)
        {
            try
            {
                var phong = mydb.PHONGs.Find(p.MaPhong);
                phong.idLoaiPhong = p.idLoaiPhong;
                phong.TinhTrang = p.TinhTrang;              
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
