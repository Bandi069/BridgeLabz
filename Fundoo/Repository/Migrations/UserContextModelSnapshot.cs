﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.UserDbContext;

namespace Repository.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Collaborator.ModelCollaborator", b =>
                {
                    b.Property<int>("NoteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ReceiverMail");

                    b.Property<string>("SenderMail");

                    b.HasKey("NoteID");

                    b.ToTable("Collobarator");
                });

            modelBuilder.Entity("Model.Label.LabelModel", b =>
                {
                    b.Property<string>("Emailid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.Property<int>("LabelID");

                    b.HasKey("Emailid");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("Model.NoteModel.Notemodel", b =>
                {
                    b.Property<int>("NoteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddColor");

                    b.Property<string>("AddImg");

                    b.Property<bool>("Archive");

                    b.Property<DateTime?>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<string>("Emailid");

                    b.Property<DateTime?>("ModifiedTime");

                    b.Property<bool>("PinNote");

                    b.Property<string>("Remainder");

                    b.Property<string>("Title");

                    b.Property<bool>("Trash");

                    b.HasKey("NoteID");

                    b.ToTable("Notemodels");
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
