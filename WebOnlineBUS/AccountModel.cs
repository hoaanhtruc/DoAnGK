using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebOnlineBUS.Entity;


namespace WebOnlineBUS
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }
        public bool Login(string TenDangNhap, string MatKhau)
        {
            object[] sqlparams = 
            {
                new SqlParameter("@username",TenDangNhap),
                new SqlParameter("@password", MatKhau)
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @username,@password", sqlparams).SingleOrDefault();
            return res;
        }
    }
}
