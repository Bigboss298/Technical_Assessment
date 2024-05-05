using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Technical_Assessment_API.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imdbID",
                table: "searchQueries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imdbID",
                table: "searchQueries",
                type: "longtext",
                nullable: false);
        }
    }
}
