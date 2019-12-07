using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Models;
using Entity.Services;

namespace Entity.Repository
{
    public class UserRepository : IUser
    {
        private DBContext db;

        public UserRepository(DBContext db)
        {
            this.db = db;
        }

        public IEnumerable<User> getUsers => db.UserT;

        public void add(User user)
        {
            db.UserT.Add(user);
            db.SaveChanges();
        }

        public User getUser(int? maUser)
        {
            User findResults = db.UserT.Find(maUser);
            return findResults;
        }

        public void remove(int? maUser)
        {
            User findResults = db.UserT.Find(maUser);
            db.UserT.Remove(findResults);
            db.SaveChanges();
        }
    }
}
