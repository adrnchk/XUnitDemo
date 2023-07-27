using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemoDAL;

namespace UnitTestDemoBLL
{
    public interface IUserService
    {
        public User GetUserById(int id);
        public IEnumerable<User> GetAllUsers();
        public User UpdateUser(User user);
        public int DeleteUserById(int id);
        public User CreateUser(User user);
    }
}
