using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Faculty.Migrations
{
    public partial class DBCREATE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "dbo",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lastname = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                schema: "dbo",
                columns: table => new
                {
                    TeacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lastname = table.Column<string>(type: "varchar(25)", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(15)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                schema: "dbo",
                columns: table => new
                {
                    TeacherID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    Phone = table.Column<string>(type: "char(9)", nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.TeacherID);
                    table.UniqueConstraint("AK_Contacts_StudentID", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Contacts_Student_StudentID",
                        column: x => x.StudentID,
                        principalSchema: "dbo",
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Teacher_TeacherID",
                        column: x => x.TeacherID,
                        principalSchema: "dbo",
                        principalTable: "Teacher",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Teacher",
                schema: "dbo");
        }
    }
}
