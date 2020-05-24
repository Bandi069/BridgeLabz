using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class fun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collobarator",
                columns: table => new
                {
                    NoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SenderMail = table.Column<string>(nullable: true),
                    ReceiverMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collobarator", x => x.NoteID);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    LabelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    NoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.LabelID);
                });

            migrationBuilder.CreateTable(
                name: "Notemodels",
                columns: table => new
                {
                    NoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AddImg = table.Column<string>(nullable: true),
                    AddColor = table.Column<string>(nullable: true),
                    Trash = table.Column<bool>(nullable: false),
                    PinNote = table.Column<bool>(nullable: false),
                    ModifiedTime = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Archive = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Reminder = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notemodels", x => x.NoteID);
                });

            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collobarator");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Notemodels");

            migrationBuilder.DropTable(
                name: "Register");
        }
    }
}
