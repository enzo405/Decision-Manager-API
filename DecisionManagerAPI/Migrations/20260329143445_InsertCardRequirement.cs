using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class InsertCardRequirement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(
"""
INSERT INTO "CardRequirement" ("Id", "CardId", "RequiredCardSlug") 
VALUES 
  -- LEVEL 2 CARDS
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'), 'professional-training'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'), 'one-on-one'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'), 'individual-feedback'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'workspace-reorganization'), 'collective-break'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'workspace-reorganization'), 'flexible-remote-work'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'performance-review'), 'individual-feedback'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'performance-review'), 'one-on-one'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'cross-team-project'), 'team-restructuring'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'cross-team-project'), 'team-charter'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'wellness-program'), 'collective-break'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'wellness-program'), 'flexible-remote-work'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'wellness-program'), 'conflict-mediation'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'job-rotation'), 'skills-audit'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'job-rotation'), 'professional-training'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'internal-communication'), 'team-meeting'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'internal-communication'), 'team-charter'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'delegation-plan'), 'one-on-one'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'delegation-plan'), 'individual-feedback'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'delegation-plan'), 'skills-audit'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'), 'team-meeting'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'), 'crisis-management'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'), 'conflict-mediation'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'peer-review'), 'performance-review'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'peer-review'), 'team-retrospective'),
  
  -- LEVEL 3 CARDS
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'), 'team-retrospective'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'), 'delegation-plan'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'), 'cross-team-project'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'), 'recognition-program'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'), 'exceptional-bonus'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'), 'mentoring-session'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'), 'professional-training'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'), 'team-retrospective'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'), 'team-charter'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'), 'internal-communication'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'process-optimization'), 'ambitious-goals'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'process-optimization'), 'performance-review'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'process-optimization'), 'skills-audit'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'leadership-development'), 'mentoring-session'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'leadership-development'), 'skills-audit'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'leadership-development'), 'delegation-plan'),
  
  -- LEVEL 4 CARDS
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 'team-restructuring'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 'agile-transformation'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 'cross-team-project'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'remote-first-policy'), 'flexible-remote-work'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'remote-first-policy'), 'internal-communication'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'), 'team-charter'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'), 'strategic-retreat'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'), 'wellness-program'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'succession-planning'), 'leadership-development'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'succession-planning'), 'mentoring-session'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'succession-planning'), 'talent-retention-plan'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 'delegation-plan'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 'workspace-reorganization'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 'agile-transformation'),
  
  -- LEVEL 5 CARDS
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'), 'leadership-development'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'), 'strategic-retreat'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'), 'crisis-management'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'zero-tolerance'), 'conflict-mediation'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'zero-tolerance'), 'team-charter'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'zero-tolerance'), 'culture-revamp'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'), 'delegation-plan'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'), 'agile-transformation'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'), 'leadership-development'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 'strategic-retreat'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 'culture-revamp'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 'wellness-program'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 'performance-review'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 'skills-audit'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 'process-optimization');
"""
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
