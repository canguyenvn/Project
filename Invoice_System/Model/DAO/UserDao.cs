using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class  UserDao
    {
        IVSDBContext db = null;

        public UserDao()
        {
            db = new IVSDBContext();
        }

        public long Insert(tbl_User entity)
        {
            db.tbl_User.Add(entity);
            db.SaveChanges();
            return entity.User_ID;
        }

        public bool Login(string userName, string passWord)
        {
            var result = db.tbl_User.Count(x=>x.User_ID=userName && x.User_Password = passWord );
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(tbl_User entity)
        {
            try
            {
                var user = db.tbl_User.Find(entity.ID);
                user.Name = entity.User_Name;
                if (!string.IsNullOrEmpty(entity.User_Password))
                {
                    user.Password = entity.User_Password;
                }
                user.Address = entity.Address;
                user.ModifiedBy = entity.ModifiedBy;
                user.ModifiedDate = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //logging
                return false;
            }

        }

        public IEnumerable<tbl_User> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<tbl_User> model = db.tbl_User;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.User_Name.Contains(searchString));
            }

            return model.OrderByDescending(x => x.Date_Register).ToPagedList(page, pageSize);
        }

        public tbl_User GetById(string userName)
        {
            return db.tbl_User.SingleOrDefault(x => x.User_Name == userName);
        }

        //Function View detail for user
        public User ViewDetail(int id)
        {
            return db.tbl_User.Find(id);
        }
        
        //Function Login for user - Ham dang nhap cho user
        public int Login(string userName, string passWord, bool isLoginAdmin = false)
        {
            var result = db.tbl_User.SingleOrDefault(x => x.User_Name == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (isLoginAdmin == true)
                {
                    if (result.tbl_User_Relationship == CommonConstants.ADMIN_GROUP || result.GroupID == CommonConstants.MOD_GROUP)
                    {
                        if (result.Status == false)
                        {
                            return -1;
                        }
                        else
                        {
                            if (result.Password == passWord)
                                return 1;
                            else
                                return -2;
                        }
                    }
                    else
                    {
                        return -3;
                    }
                }
                else
                {
                    if (result.Status == false)
                    {
                        return -1;
                    }
                    else
                    {
                        if (result.Password == passWord)
                            return 1;
                        else
                            return -2;
                    }
                }
            }
        }

        public bool ChangeStatus(long id)
        {
            var user = db.tbl_User.Find(id);
            user.Status = !user.Status;
            db.SaveChanges();
            return user.Status;
        }
        public bool Delete(int id)
        {
            try
            {
                var user = db.tbl_User.Find(id);
                db.tbl_User.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
}
