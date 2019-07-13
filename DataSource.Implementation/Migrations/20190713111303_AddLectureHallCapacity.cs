using Microsoft.EntityFrameworkCore.Migrations;

namespace ScheduleSystem.DataSource.Implementation.Migrations
{
    public partial class AddLectureHallCapacity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "LectureHalls",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "LectureHalls");
        }
    }
}
