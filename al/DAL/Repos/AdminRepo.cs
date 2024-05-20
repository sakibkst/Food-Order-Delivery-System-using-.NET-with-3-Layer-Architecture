using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin, int, bool>
    {
        public bool Create(Admin type)
        {
            db.Admins.Add(type);
            return db.SaveChanges() > 0;

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int id)
        {

            return db.Admins.Find(id);
        }

        public bool Update(Admin type)
        {
            var exuser = Get(type.Id);
            exuser.Name = type.Name;
            exuser.Username = type.Username;
            exuser.Password = type.Password;
            exuser.Email = type.Email;

            return db.SaveChanges() > 0;

        }
    }
}
