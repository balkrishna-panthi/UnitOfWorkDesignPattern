using Repository.DBContext;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitofWork.Interfaces;

namespace UnitofWork.Concrete
{
    public class LoginUnit : ILoginUnit
    {
        public DataContext dataContext { get; set; }
        public LoginUnit(DataContext dataContext, IUserRepository Users)
        {
            this.dataContext = dataContext;
            this.Users = Users;
        }
        public IUserRepository Users { get;  set; }

        public void Dispose()
        {
           dataContext.Dispose();
            //LoginUnit is being managed by a DI container, like in an ASP.NET Core application,
            //the DI container may automatically call Dispose on LoginUnit when the scope (like a request) ends.
        }
    }
}
