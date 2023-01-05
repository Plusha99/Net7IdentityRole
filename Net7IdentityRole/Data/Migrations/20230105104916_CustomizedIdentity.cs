using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Net7IdentityRole.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustomizedIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictures",
                table: "AspNetUsers",
                newName: "ProfilePicture");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "AspNetUsers",
                newName: "ProfilePictures");
        }
    }
}
