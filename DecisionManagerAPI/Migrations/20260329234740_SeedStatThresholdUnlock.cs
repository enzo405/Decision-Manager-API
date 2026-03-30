using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedStatThresholdUnlock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
"""
-- ========================================
-- CRISIS INTERVENTION CARDS (High negative stats)
-- ========================================

-- crisis-management: appears when things are falling apart
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'crisis-management'), 0, 0, 80),  -- Stress > 80
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'crisis-management'), 3, 1, 40);  -- Performance < 40

-- conflict-mediation: appears when team relationships are strained
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'conflict-mediation'), 0, 0, 70),  -- Stress > 70
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'conflict-mediation'), 1, 1, 35);  -- Motivation < 35

-- wellness-program: appears when burnout threatens
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'wellness-program'), 0, 0, 75),  -- Stress > 75
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'wellness-program'), 2, 0, 65);  -- Turnover > 65

-- quick-wins: appears when morale/performance are tanking
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'quick-wins'), 1, 1, 40),  -- Motivation < 40
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'quick-wins'), 3, 1, 45);  -- Performance < 45

-- ========================================
-- RETENTION CRISIS CARDS (High turnover)
-- ========================================

-- talent-retention-plan: appears when people are leaving
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'talent-retention-plan'), 2, 0, 70);  -- Turnover > 70

-- exceptional-bonus: emergency retention measure
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'exceptional-bonus'), 2, 0, 65),  -- Turnover > 65
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'exceptional-bonus'), 1, 1, 30);  -- Motivation < 30

-- collective-break: emergency team bonding when fragmented
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'collective-break'), 2, 0, 60);  -- Turnover > 60

-- ========================================
-- OPPORTUNITY CARDS (High positive stats)
-- ========================================

-- ambitious-goals: appears when team is ready for challenge
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'ambitious-goals'), 1, 0, 75),  -- Motivation > 75
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'ambitious-goals'), 3, 0, 70);  -- Performance > 70

-- strategic-retreat: appears when team is stable and engaged
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'strategic-retreat'), 1, 0, 70),  -- Motivation > 70
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'strategic-retreat'), 0, 1, 40);  -- Stress < 40

-- innovation-lab: appears when high-performing and motivated
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'innovation-lab'), 1, 0, 75),  -- Motivation > 75
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'innovation-lab'), 3, 0, 75);  -- Performance > 75

-- leadership-development: appears when stable and performing
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'leadership-development'), 3, 0, 65),  -- Performance > 65
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'leadership-development'), 2, 1, 30);  -- Turnover < 30

-- ========================================
-- ADVANCED TRANSFORMATION CARDS (Requires stability)
-- ========================================

-- agile-transformation: needs calm environment
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'agile-transformation'), 0, 1, 50),  -- Stress < 50
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'agile-transformation'), 3, 0, 60);  -- Performance > 60

-- culture-revamp: needs engaged team
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'culture-revamp'), 1, 0, 65),  -- Motivation > 65
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'culture-revamp'), 2, 1, 40);  -- Turnover < 40

-- purpose-driven-strategy: premium opportunity card
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'purpose-driven-strategy'), 1, 0, 75),  -- Motivation > 75
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'purpose-driven-strategy'), 3, 0, 70);  -- Performance > 70

-- autonomy-framework: needs capable, stable team
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'autonomy-framework'), 3, 0, 70),  -- Performance > 70
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'autonomy-framework'), 2, 1, 35);  -- Turnover < 35

-- ========================================
-- PERFORMANCE RECOVERY CARDS (Low performance)
-- ========================================

-- process-optimization: appears when performance struggles
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'process-optimization'), 3, 1, 50);  -- Performance < 50

-- skills-audit: appears when capability gaps suspected
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'skills-audit'), 3, 1, 55);  -- Performance < 55

-- performance-review: appears when accountability needed
INSERT INTO "decision_manager"."CardUnlockStatThresholds" ("Id", "CardId", "StatName", "Condition", "Threshold") VALUES
  (gen_random_uuid(), (SELECT "Id" FROM "decision_manager"."Cards" WHERE "Slug" = 'performance-review'), 3, 1, 50);  -- Performance < 50
"""
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
