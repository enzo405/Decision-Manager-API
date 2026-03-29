using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class PostRefactorConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardComboTrigger_CardCombo_CardComboId",
                table: "CardComboTrigger");

            migrationBuilder.DropForeignKey(
                name: "FK_CardComboTrigger_Cards_CardSlug",
                table: "CardComboTrigger");

            migrationBuilder.DropForeignKey(
                name: "FK_CardRequirement_Cards_CardId",
                table: "CardRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_CardRequirement_Cards_RequiredCardSlug",
                table: "CardRequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_CardStatThreshold_Cards_CardId",
                table: "CardStatThreshold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardStatThreshold",
                table: "CardStatThreshold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardRequirement",
                table: "CardRequirement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardComboTrigger",
                table: "CardComboTrigger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardCombo",
                table: "CardCombo");

            migrationBuilder.EnsureSchema(
                name: "decision_manager");

            migrationBuilder.RenameTable(
                name: "StatsInits",
                newName: "StatsInits",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "Progressions",
                newName: "Progressions",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Players",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "GameConfigs",
                newName: "GameConfigs",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Events",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "DefeatConditions",
                newName: "DefeatConditions",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Cards",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "CardStatThreshold",
                newName: "CardStatThresholds",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "CardRequirement",
                newName: "CardRequirements",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "CardComboTrigger",
                newName: "CardComboTriggers",
                newSchema: "decision_manager");

            migrationBuilder.RenameTable(
                name: "CardCombo",
                newName: "CardCombos",
                newSchema: "decision_manager");

            migrationBuilder.RenameIndex(
                name: "IX_CardStatThreshold_CardId",
                schema: "decision_manager",
                table: "CardStatThresholds",
                newName: "IX_CardStatThresholds_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardRequirement_RequiredCardSlug",
                schema: "decision_manager",
                table: "CardRequirements",
                newName: "IX_CardRequirements_RequiredCardSlug");

            migrationBuilder.RenameIndex(
                name: "IX_CardRequirement_CardId",
                schema: "decision_manager",
                table: "CardRequirements",
                newName: "IX_CardRequirements_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardComboTrigger_CardSlug",
                schema: "decision_manager",
                table: "CardComboTriggers",
                newName: "IX_CardComboTriggers_CardSlug");

            migrationBuilder.RenameIndex(
                name: "IX_CardComboTrigger_CardComboId",
                schema: "decision_manager",
                table: "CardComboTriggers",
                newName: "IX_CardComboTriggers_CardComboId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "decision_manager",
                table: "Players",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardStatThresholds",
                schema: "decision_manager",
                table: "CardStatThresholds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardRequirements",
                schema: "decision_manager",
                table: "CardRequirements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardComboTriggers",
                schema: "decision_manager",
                table: "CardComboTriggers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardCombos",
                schema: "decision_manager",
                table: "CardCombos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardComboTriggers_CardCombos_CardComboId",
                schema: "decision_manager",
                table: "CardComboTriggers",
                column: "CardComboId",
                principalSchema: "decision_manager",
                principalTable: "CardCombos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardComboTriggers_Cards_CardSlug",
                schema: "decision_manager",
                table: "CardComboTriggers",
                column: "CardSlug",
                principalSchema: "decision_manager",
                principalTable: "Cards",
                principalColumn: "Slug",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardRequirements_Cards_CardId",
                schema: "decision_manager",
                table: "CardRequirements",
                column: "CardId",
                principalSchema: "decision_manager",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardRequirements_Cards_RequiredCardSlug",
                schema: "decision_manager",
                table: "CardRequirements",
                column: "RequiredCardSlug",
                principalSchema: "decision_manager",
                principalTable: "Cards",
                principalColumn: "Slug",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardStatThresholds_Cards_CardId",
                schema: "decision_manager",
                table: "CardStatThresholds",
                column: "CardId",
                principalSchema: "decision_manager",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardComboTriggers_CardCombos_CardComboId",
                schema: "decision_manager",
                table: "CardComboTriggers");

            migrationBuilder.DropForeignKey(
                name: "FK_CardComboTriggers_Cards_CardSlug",
                schema: "decision_manager",
                table: "CardComboTriggers");

            migrationBuilder.DropForeignKey(
                name: "FK_CardRequirements_Cards_CardId",
                schema: "decision_manager",
                table: "CardRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_CardRequirements_Cards_RequiredCardSlug",
                schema: "decision_manager",
                table: "CardRequirements");

            migrationBuilder.DropForeignKey(
                name: "FK_CardStatThresholds_Cards_CardId",
                schema: "decision_manager",
                table: "CardStatThresholds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardStatThresholds",
                schema: "decision_manager",
                table: "CardStatThresholds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardRequirements",
                schema: "decision_manager",
                table: "CardRequirements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardComboTriggers",
                schema: "decision_manager",
                table: "CardComboTriggers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardCombos",
                schema: "decision_manager",
                table: "CardCombos");

            migrationBuilder.RenameTable(
                name: "StatsInits",
                schema: "decision_manager",
                newName: "StatsInits");

            migrationBuilder.RenameTable(
                name: "Progressions",
                schema: "decision_manager",
                newName: "Progressions");

            migrationBuilder.RenameTable(
                name: "Players",
                schema: "decision_manager",
                newName: "Players");

            migrationBuilder.RenameTable(
                name: "GameConfigs",
                schema: "decision_manager",
                newName: "GameConfigs");

            migrationBuilder.RenameTable(
                name: "Events",
                schema: "decision_manager",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "DefeatConditions",
                schema: "decision_manager",
                newName: "DefeatConditions");

            migrationBuilder.RenameTable(
                name: "Cards",
                schema: "decision_manager",
                newName: "Cards");

            migrationBuilder.RenameTable(
                name: "CardStatThresholds",
                schema: "decision_manager",
                newName: "CardStatThreshold");

            migrationBuilder.RenameTable(
                name: "CardRequirements",
                schema: "decision_manager",
                newName: "CardRequirement");

            migrationBuilder.RenameTable(
                name: "CardComboTriggers",
                schema: "decision_manager",
                newName: "CardComboTrigger");

            migrationBuilder.RenameTable(
                name: "CardCombos",
                schema: "decision_manager",
                newName: "CardCombo");

            migrationBuilder.RenameIndex(
                name: "IX_CardStatThresholds_CardId",
                table: "CardStatThreshold",
                newName: "IX_CardStatThreshold_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardRequirements_RequiredCardSlug",
                table: "CardRequirement",
                newName: "IX_CardRequirement_RequiredCardSlug");

            migrationBuilder.RenameIndex(
                name: "IX_CardRequirements_CardId",
                table: "CardRequirement",
                newName: "IX_CardRequirement_CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardComboTriggers_CardSlug",
                table: "CardComboTrigger",
                newName: "IX_CardComboTrigger_CardSlug");

            migrationBuilder.RenameIndex(
                name: "IX_CardComboTriggers_CardComboId",
                table: "CardComboTrigger",
                newName: "IX_CardComboTrigger_CardComboId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Players",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardStatThreshold",
                table: "CardStatThreshold",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardRequirement",
                table: "CardRequirement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardComboTrigger",
                table: "CardComboTrigger",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardCombo",
                table: "CardCombo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardComboTrigger_CardCombo_CardComboId",
                table: "CardComboTrigger",
                column: "CardComboId",
                principalTable: "CardCombo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardComboTrigger_Cards_CardSlug",
                table: "CardComboTrigger",
                column: "CardSlug",
                principalTable: "Cards",
                principalColumn: "Slug",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardRequirement_Cards_CardId",
                table: "CardRequirement",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardRequirement_Cards_RequiredCardSlug",
                table: "CardRequirement",
                column: "RequiredCardSlug",
                principalTable: "Cards",
                principalColumn: "Slug",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardStatThreshold_Cards_CardId",
                table: "CardStatThreshold",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
