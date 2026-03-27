using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class CardRequirementMoreSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("""
-- FOUNDATION → ADVANCED PROGRESSIONS
-- Basic team practices unlock more sophisticated versions

INSERT INTO "CardRequirement" ("Id", "CardId", "RequiredCardSlug") VALUES
  -- Team building foundation
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-charter'), 'team-meeting'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'), 'team-meeting'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'cross-team-project'), 'team-restructuring'),
  
  -- Feedback & evaluation progression
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'performance-review'), 'individual-feedback'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'peer-review'), 'performance-review'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'), 'one-on-one'),
  
  -- Remote work escalation
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'remote-first-policy'), 'flexible-remote-work'),
  
  -- Recognition & retention chain
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'), 'recognition-program'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'exceptional-bonus'), 'recognition-program'),
  
  -- Skills development chain
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'leadership-development'), 'skills-audit'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'succession-planning'), 'leadership-development'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'job-rotation'), 'skills-audit'),

-- ORGANIZATIONAL TRANSFORMATION CHAINS
-- Major changes require foundation or trigger consequences

  -- Communication & transparency foundation
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'internal-communication'), 'team-meeting'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 'internal-communication'),
  
  -- Cultural transformation requires groundwork
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'), 'team-charter'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 'culture-revamp'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 'culture-revamp'),
  
  -- Agile & process chains
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'process-optimization'), 'agile-transformation'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'delegation-plan'), 'agile-transformation'),
  
  -- Autonomy progression
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'), 'delegation-plan'),
  
  -- Integration challenges
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 'team-restructuring'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 'culture-revamp'),

-- CRISIS & RECOVERY CHAINS
-- Problems unlock reactive solutions

  -- Crisis management unlocks reflection
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'), 'crisis-management'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'quick-wins'), 'crisis-management'),
  
  -- Conflict resolution unlocks policy
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'zero-tolerance'), 'conflict-mediation'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'team-charter'), 'conflict-mediation'),
  
  -- Ambitious goals failure path
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'quick-wins'), 'ambitious-goals'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'wellness-program'), 'ambitious-goals'),

-- WELLNESS & SUPPORT CHAINS
-- Well-being initiatives build on each other

  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'wellness-program'), 'collective-break'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'workspace-reorganization'), 'wellness-program'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 'wellness-program'),

-- TRAINING & DEVELOPMENT CHAINS
-- Learning initiatives unlock advanced programs

  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'), 'professional-training'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'), 'leadership-development'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'), 'executive-coaching'),

-- STRATEGIC ALIGNMENT CHAINS
-- Vision work requires preparation

  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'), 'team-retrospective'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 'strategic-retreat'),

-- CROSS-FUNCTIONAL CHAINS
-- Complex initiatives need multiple prerequisites

  -- Data-driven management needs foundation
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 'skills-audit'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 'performance-review'),
  
  -- Innovation requires culture & space
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 'autonomy-framework'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 'workspace-reorganization');
""");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
