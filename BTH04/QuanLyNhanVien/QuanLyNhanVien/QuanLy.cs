using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class QuanLy
    {
        string userName;
        string password = "123456";

        public bool xacThuc(string userName,string password)
        {
            this.userName = userName;
            if (password != this.password)
            {
                return false;
            }
            return true;
        }
    }
}
