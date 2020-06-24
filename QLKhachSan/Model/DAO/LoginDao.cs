﻿using QuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.Model.DAO
{
    public class LoginDao
    {
        MyDataBase mydb = null;
        public LoginDao()
        {
            mydb = new MyDataBase();
        }
        public bool check(string tk, string mk)
        {
            int c = mydb.NHANVIENs.Count(x => x.TenDangNhap.Equals(tk) && x.MatKhau.Equals(mk));
            if (c > 0)
                return true;
            else
                return false;
        }

        public DataTable quyen(string tenDN)
        {
            string str = "SELECT idChucVu FROM NHANVIEN WHERE TenDangNhap = '" + tenDN + "'";
            DataTable da = DataProvider.Instance.ExecuteQuery(str);
            return da;
        }

    }
}
