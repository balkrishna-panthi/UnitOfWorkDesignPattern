using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnitofWork.Interfaces
{
    public interface ILoginUnit : IDisposable
    {
        IUserRepository Users { get; }
    }
}
