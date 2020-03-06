﻿using Microsoft.EntityFrameworkCore;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UserDbContext
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<RegistrationModel> Register { get; set; }
    }
}