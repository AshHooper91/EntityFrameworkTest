using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWorkTutorial.Migrations
{
    public partial class CreateSchoolDatabaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    SchoolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    SchoolName = table.Column<string>(maxLength: 100, nullable: false),
                    SchoolAddressLineOne = table.Column<string>(maxLength: 255, nullable: false),
                    SchoolAddressLineTwo = table.Column<string>(maxLength: 255, nullable: true),
                    SchoolAddressLineThree = table.Column<string>(maxLength: 255, nullable: true),
                    SchoolAddressCity = table.Column<string>(maxLength: 100, nullable: false),
                    SchoolAddressCounty = table.Column<string>(maxLength: 100, nullable: true),
                    SchoolAddressCountry = table.Column<string>(maxLength: 100, nullable: false),
                    SchoolAddressPostcode = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolId);
                });

            migrationBuilder.CreateTable(
                name: "SchoolTeacherAddress",
                columns: table => new
                {
                    SchoolTeacherAddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLineOne = table.Column<string>(maxLength: 255, nullable: false),
                    AddressLineTwo = table.Column<string>(maxLength: 255, nullable: true),
                    AddressLineThree = table.Column<string>(maxLength: 255, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    County = table.Column<string>(maxLength: 100, nullable: false),
                    Postcode = table.Column<string>(maxLength: 10, nullable: false),
                    SchoolTeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTeacherAddress", x => x.SchoolTeacherAddressId);
                });

            migrationBuilder.CreateTable(
                name: "SchoolTeacherContact",
                columns: table => new
                {
                    SchoolTeacherContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    PrimaryContactName = table.Column<string>(maxLength: 100, nullable: false),
                    PrimaryContactTelephoneNumber = table.Column<string>(maxLength: 11, nullable: false),
                    PrimaryContactEmailAddresss = table.Column<string>(maxLength: 255, nullable: false),
                    SecondaryContactName = table.Column<string>(maxLength: 100, nullable: false),
                    SecondaryContactTelephoneNumber = table.Column<string>(maxLength: 11, nullable: false),
                    SecondaryContactEmailAddresss = table.Column<string>(maxLength: 255, nullable: false),
                    SchoolTeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTeacherContact", x => x.SchoolTeacherContactId);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    StudentCourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    CourseName = table.Column<string>(maxLength: 150, nullable: false),
                    CourseDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => x.StudentCourseId);
                });

            migrationBuilder.CreateTable(
                name: "StudentGrade",
                columns: table => new
                {
                    StudentGradeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    GradeName = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGrade", x => x.StudentGradeId);
                });

            migrationBuilder.CreateTable(
                name: "SchoolTeacher",
                columns: table => new
                {
                    SchoolTeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    JobTitle = table.Column<string>(maxLength: 100, nullable: false),
                    SchoolTeacherAddressId = table.Column<int>(nullable: false),
                    SchoolTeacherContactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTeacher", x => x.SchoolTeacherId);
                    table.ForeignKey(
                        name: "FK_SchoolTeacher_SchoolTeacherAddress_SchoolTeacherAddressId",
                        column: x => x.SchoolTeacherAddressId,
                        principalTable: "SchoolTeacherAddress",
                        principalColumn: "SchoolTeacherAddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolTeacher_SchoolTeacherContact_SchoolTeacherContactId",
                        column: x => x.SchoolTeacherContactId,
                        principalTable: "SchoolTeacherContact",
                        principalColumn: "SchoolTeacherContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    StudentName = table.Column<string>(maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    SchoolId = table.Column<int>(nullable: true),
                    GradeId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_StudentCourse_CourseId",
                        column: x => x.CourseId,
                        principalTable: "StudentCourse",
                        principalColumn: "StudentCourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_StudentGrade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "StudentGrade",
                        principalColumn: "StudentGradeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "SchoolId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentAddress",
                columns: table => new
                {
                    StudentAddressId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLineOne = table.Column<string>(maxLength: 255, nullable: false),
                    AddressLineTwo = table.Column<string>(maxLength: 255, nullable: true),
                    AddressLineThree = table.Column<string>(maxLength: 255, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    County = table.Column<string>(maxLength: 100, nullable: false),
                    Postcode = table.Column<string>(maxLength: 10, nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddress", x => x.StudentAddressId);
                    table.ForeignKey(
                        name: "FK_StudentAddress_Student_StudentAddressId",
                        column: x => x.StudentAddressId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentContact",
                columns: table => new
                {
                    StudentContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    PrimaryContactName = table.Column<string>(maxLength: 100, nullable: false),
                    PrimaryContactTelephoneNumber = table.Column<string>(maxLength: 11, nullable: false),
                    PrimaryContactEmailAddresss = table.Column<string>(maxLength: 255, nullable: false),
                    SecondaryContactName = table.Column<string>(maxLength: 100, nullable: false),
                    SecondaryContactTelephoneNumber = table.Column<string>(maxLength: 11, nullable: false),
                    SecondaryContactEmailAddresss = table.Column<string>(maxLength: 255, nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentContact", x => x.StudentContactId);
                    table.ForeignKey(
                        name: "FK_StudentContact_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolTeacher_SchoolTeacherAddressId",
                table: "SchoolTeacher",
                column: "SchoolTeacherAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SchoolTeacher_SchoolTeacherContactId",
                table: "SchoolTeacher",
                column: "SchoolTeacherContactId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_CourseId",
                table: "Student",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SchoolId",
                table: "Student",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentContact_StudentId",
                table: "StudentContact",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolTeacher");

            migrationBuilder.DropTable(
                name: "StudentAddress");

            migrationBuilder.DropTable(
                name: "StudentContact");

            migrationBuilder.DropTable(
                name: "SchoolTeacherAddress");

            migrationBuilder.DropTable(
                name: "SchoolTeacherContact");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "StudentGrade");

            migrationBuilder.DropTable(
                name: "School");
        }
    }
}
