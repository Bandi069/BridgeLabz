using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IRepository
    {
        Task<string> LoginAsynChr(LoginModel loginModel);
     
    }
}
