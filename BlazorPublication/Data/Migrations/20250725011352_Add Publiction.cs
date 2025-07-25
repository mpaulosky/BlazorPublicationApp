using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorPublication.Migrations
{
    /// <inheritdoc />
    public partial class AddPubliction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubstackUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscribers = table.Column<int>(type: "int", nullable: false),
                    Category1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutPublication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutWriter = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publications");
        }
    }
}
