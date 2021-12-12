using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using System.Configuration;
using System.Data.Common;
using Model.DAO;


namespace Model.DAO
{
    public class UserDAO
    {

        InvoiceSystemDBContext db = null;

        public UserDAO()
        {
            db = new InvoiceSystemDBContext();
        }


        //Insert user function here! --- Chen User vao bang tbl_User
        public long Insert(tbl_User entity)
        {
            db.tbl_User.Add(entity);
            db.SaveChanges();
            return entity.User_ID;
        }

        public object Login(object user_ID)
        {
            throw new NotImplementedException();
        }

        //This function is using for USER SESSION - Dung cho viec cai dat session
        public tbl_User GetById(string userName)
        {
            return db.tbl_User.SingleOrDefault(x => x.User_FullName == userName);
        }

        //Login function --- Ham dang nhap cho user
        public int Login(string userName, string passWord)
        {
            var result = db.tbl_User.SingleOrDefault(x => x.User_Name == userName || x.User_Password==passWord);
            if (result == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
         }
    }


}
