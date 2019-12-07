using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Models;

namespace Entity.Services
{
    public interface IUser
    {
        IEnumerable<User> getUsers { get; }

        User getUser(int? maUser);

        void add(User user);

        void remove(int? maUser);
    }
}
