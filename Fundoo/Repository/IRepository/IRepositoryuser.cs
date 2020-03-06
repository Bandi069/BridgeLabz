﻿using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IRepositoryuser
    {
        Task<string> LoginAsynChr(LoginModel loginModel);
        Task<string> ResetPassword(ResetPassword resetPassword);
        Task<string> ForgotPassword(ForgotPasswordModel forgotPasswordModel);
    }
}