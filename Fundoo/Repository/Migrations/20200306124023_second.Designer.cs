﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.UserDbContext;

namespace Repository.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20200306124023_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.UserModel.LoginModel", b =>
                {
                    b.Property<string>("Emailid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.HasKey("Emailid");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("Model.UserModel.RegistrationModel", b =>
                {
                    b.Property<string>("Emailid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirtsName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Emailid");

                    b.ToTable("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
