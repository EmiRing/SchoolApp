using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolApp.Migrations
{
    public partial class addedSomeAssignments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "CourseId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 5, "Write a short song in a rock theme", "Compose a rock song" },
                    { 2, 5, "Spend at least 2h practising piano", "Practise piano" },
                    { 3, 1, "Do five pages in the math book related to multiplication", "Multiplication" },
                    { 4, 4, "Write a code that calculates the basic operations", "Calculator" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4);
        }
    }
}
