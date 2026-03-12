using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class StatsInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatsInits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InitialMotivation = table.Column<int>(type: "integer", nullable: false),
                    InitialStress = table.Column<int>(type: "integer", nullable: false),
                    InitialPerformance = table.Column<int>(type: "integer", nullable: false),
                    InitialTurnover = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatsInits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StatsInits",
                columns: new[] { "Id", "InitialMotivation", "InitialPerformance", "InitialStress", "InitialTurnover" },
                values: new object[] { 1, 50, 40, 20, 30 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatsInits");
        }
    }
}
