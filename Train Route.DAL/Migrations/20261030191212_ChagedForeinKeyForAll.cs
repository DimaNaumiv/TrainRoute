using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Train_Route.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChagedForeinKeyForAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RouteSationId",
                table: "Stations",
                newName: "RouteStationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RouteStationsId",
                table: "Stations",
                newName: "RouteSationId");
        }
    }
}
