using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCardType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Cards",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql(
"""
-- UNIVERSAL: All Level 1 cards (foundation, always available)
UPDATE "Cards" SET "Type" = 'Universal' WHERE "Slug" IN (
  'team-meeting', 'ambitious-goals', 'professional-training', 'exceptional-bonus',
  'conflict-mediation', 'flexible-remote-work', 'team-restructuring', 'individual-feedback',
  'collective-break', 'crisis-management', 'quick-wins', 'one-on-one',
  'skills-audit', 'team-charter', 'recognition-program'
);

-- REACTIVE: Level 2-3 cards that are immediate follow-ups
UPDATE "Cards" SET "Type" = 'Reactive' WHERE "Slug" IN (
  -- Level 2 reactive cards
  'mentoring-session', 'workspace-reorganization', 'performance-review', 'cross-team-project',
  'wellness-program', 'job-rotation', 'internal-communication', 'delegation-plan',
  'team-retrospective', 'peer-review',
  -- Level 3 reactive cards
  'agile-transformation', 'talent-retention-plan', 'strategic-retreat', 'process-optimization'
);

-- FOUNDATION: Level 3-5 cards requiring sustained strategic investment
UPDATE "Cards" SET "Type" = 'Foundation' WHERE "Slug" IN (
  -- Level 3 foundation
  'leadership-development',
  -- Level 4 foundation
  'merger-integration', 'remote-first-policy', 'culture-revamp', 'succession-planning', 'innovation-lab',
  -- Level 5 foundation
  'executive-coaching', 'zero-tolerance', 'autonomy-framework', 'purpose-driven-strategy', 'predictive-analytics'
);

-- EMERGENCY: Crisis intervention cards
UPDATE "Cards" SET "Type" = 'Emergency' WHERE "Slug" IN (
  'crisis-management', 
  'conflict-mediation',
  'quick-wins',
  'wellness-program'
);
"""
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Cards");
        }
    }
}
