using Microsoft.EntityFrameworkCore;
using Model.Label;
using Model.NoteModel;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UserDbContext
{
    /// <summary>
    /// This is user Db context
    /// </summary>
    public class UserContext : DbContext
    {
        /// <summary>
        /// This is user context constructor
        /// </summary>
        /// <param name="options"></param>
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        /// <summary>
        /// This is Register DbSet property
        /// </summary>
        public DbSet<RegistrationModel> Register { get; set; }

        /// <summary>
        /// This is NoteModels Dbset Property
        /// </summary>
        public DbSet<Notemodel> Notemodels { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public DbSet<LabelModel> Label { get; set; }

    }
}
