using Domain;
using Repository.DBContext;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
