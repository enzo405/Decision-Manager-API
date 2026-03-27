using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjoutCardComboTriggerAndCardRequirementsAndCardCombo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_Cards_Slug",
                table: "Cards",
                column: "Slug");

            migrationBuilder.CreateTable(
                name: "CardCombo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameFr = table.Column<string>(type: "text", nullable: false),
                    NameEn = table.Column<string>(type: "text", nullable: false),
                    MessageFr = table.Column<string>(type: "text", nullable: false),
                    MessageEn = table.Column<string>(type: "text", nullable: false),
                    MotivationDelta = table.Column<int>(type: "integer", nullable: false),
                    StressDelta = table.Column<int>(type: "integer", nullable: false),
                    PerformanceDelta = table.Column<int>(type: "integer", nullable: false),
                    TurnoverDelta = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCombo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardRequirement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardId = table.Column<int>(type: "integer", nullable: false),
                    RequiredCardSlug = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardRequirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardRequirement_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardRequirement_Cards_RequiredCardSlug",
                        column: x => x.RequiredCardSlug,
                        principalTable: "Cards",
                        principalColumn: "Slug",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardComboTrigger",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardComboId = table.Column<Guid>(type: "uuid", nullable: false),
                    CardSlug = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardComboTrigger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardComboTrigger_CardCombo_CardComboId",
                        column: x => x.CardComboId,
                        principalTable: "CardCombo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardComboTrigger_Cards_CardSlug",
                        column: x => x.CardSlug,
                        principalTable: "Cards",
                        principalColumn: "Slug",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardComboTrigger_CardComboId",
                table: "CardComboTrigger",
                column: "CardComboId");

            migrationBuilder.CreateIndex(
                name: "IX_CardComboTrigger_CardSlug",
                table: "CardComboTrigger",
                column: "CardSlug");

            migrationBuilder.CreateIndex(
                name: "IX_CardRequirement_CardId",
                table: "CardRequirement",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardRequirement_RequiredCardSlug",
                table: "CardRequirement",
                column: "RequiredCardSlug");

            migrationBuilder.Sql(
"""
INSERT INTO "CardCombo" ("Id", "NameFr", "NameEn", "MessageFr", "MessageEn", "MotivationDelta", "StressDelta", "PerformanceDelta", "TurnoverDelta")
VALUES 
(
  'a1000000-0000-0000-0000-000000000001', 'Surmenage total', 'Total Burnout',
  'La pression accumulée a dépassé les limites. L''équipe est à bout.',
  'The accumulated pressure has crossed the line. The team is exhausted.',
  -20, 25, 0, 0
),
(
  'a1000000-0000-0000-0000-000000000002', 'Culture toxique', 'Toxic Culture',
  'Un climat de peur s''est installé. Les talents fuient.',
  'A climate of fear has set in. Talent is fleeing.',
  -15, 0, 0, 20
),
(
  'a1000000-0000-0000-0000-000000000003', 'Équipe de rêve', 'Dream Team',
  'Une synergie exceptionnelle s''est créée. L''équipe dépasse toutes les attentes.',
  'Exceptional synergy has emerged. The team exceeds all expectations.',
  20, 0, 15, 0
),
(
  'a1000000-0000-0000-0000-000000000004', 'Transformation réussie', 'Successful Transformation',
  'Le changement a été bien conduit. L''organisation est plus agile et performante.',
  'Change was well managed. The organization is more agile and efficient.',
  0, -10, 20, 0
),
(
  'a1000000-0000-0000-0000-000000000005', 'Exode des talents', 'Talent Exodus',
  'La pression et l''instabilité ont provoqué une vague de départs massifs.',
  'Pressure and instability triggered a wave of mass departures.',
  -20, 0, 0, 25
),
(
  'a1000000-0000-0000-0000-000000000006', 'Management bienveillant', 'Caring Management',
  'Le bien-être de l''équipe est au cœur des priorités. La confiance est renforcée.',
  'Team well-being is at the heart of priorities. Trust is strengthened.',
  15, -20, 0, 0
),
(
  'a1000000-0000-0000-0000-000000000007', 'Innovation débloquée', 'Unlocked Innovation',
  'La combinaison d''autonomie et d''optimisation libère le potentiel créatif.',
  'The combination of autonomy and optimization unlocks creative potential.',
  10, -10, 20, 0
),
(
  'a1000000-0000-0000-0000-000000000008', 'Fuite des compétences enrayée', 'Talent Drain Stopped',
  'Les plans de succession et de rétention ont stabilisé l''équipe durablement.',
  'Succession and retention plans have sustainably stabilized the team.',
  0, 0, 10, -25
),
(
  'a1000000-0000-0000-0000-000000000009', 'Crise de confiance', 'Trust Crisis',
  'La multiplication des évaluations et la tolérance zéro ont brisé la confiance.',
  'The multiplication of evaluations and zero tolerance have shattered trust.',
  -20, 20, 0, 15
),
(
  'a1000000-0000-0000-0000-000000000010', 'Leadership fort', 'Strong Leadership',
  'Un écosystème de développement du leadership inspire et fédère toute l''équipe.',
  'A leadership development ecosystem inspires and unites the entire team.',
  20, -10, 15, 0
),
(
  'a1000000-0000-0000-0000-000000000011', 'Surcharge cognitive', 'Cognitive Overload',
  'Trop de changements simultanés ont saturé l''équipe. La confusion règne.',
  'Too many simultaneous changes have overwhelmed the team. Confusion reigns.',
  -15, 25, 10, 0
),
(
  'a1000000-0000-0000-0000-000000000012', 'Cohésion maximale', 'Maximum Cohesion',
  'L''équipe partage une vision commune forte. La cohésion atteint son apogée.',
  'The team shares a strong common vision. Cohesion reaches its peak.',
  25, 0, 10, -15
),
(
  'a1000000-0000-0000-0000-000000000013', 'Restructuration ratée', 'Failed Restructuring',
  'La fusion et la réorganisation ont créé un chaos organisationnel difficile à maîtriser.',
  'The merger and reorganization created organizational chaos that is hard to control.',
  -20, 20, 0, 25
),
(
  'a1000000-0000-0000-0000-000000000014', 'Organisation apprenante', 'Learning Organization',
  'La culture d''apprentissage continu booste les compétences et la performance collective.',
  'A culture of continuous learning boosts skills and collective performance.',
  15, 0, 20, -10
);
"""
            );

            migrationBuilder.Sql(
"""
INSERT INTO "CardComboTrigger" ("Id", "CardComboId", "CardSlug") 
VALUES
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000014', 'professional-training'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000014', 'skills-audit'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000014', 'peer-review'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000010', 'executive-coaching'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000010', 'leadership-development'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000010', 'mentoring-session'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000011', 'agile-transformation'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000011', 'process-optimization'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000011', 'predictive-analytics'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000012', 'team-charter'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000012', 'team-retrospective'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000012', 'purpose-driven-strategy'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000013', 'merger-integration'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000013', 'team-restructuring'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000013', 'remote-first-policy'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000008', 'talent-retention-plan'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000008', 'succession-planning'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000008', 'job-rotation'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000007', 'innovation-lab'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000007', 'process-optimization'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000007', 'autonomy-framework'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000006', 'individual-feedback'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000006', 'wellness-program'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000006', 'collective-break'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000005', 'ambitious-goals'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000005', 'zero-tolerance'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000005', 'team-restructuring'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000004', 'agile-transformation'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000004', 'leadership-development'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000003', 'mentoring-session'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000003', 'recognition-program'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000003', 'team-charter'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000002', 'zero-tolerance'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000002', 'team-restructuring'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000001', 'ambitious-goals'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000001', 'crisis-management'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000009', 'performance-review'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000009', 'peer-review'),
  (gen_random_uuid(), 'a1000000-0000-0000-0000-000000000009', 'zero-tolerance');
"""
            );

            migrationBuilder.Sql(
"""
INSERT INTO "CardRequirement" ("Id", "CardId", "RequiredCardSlug") 
VALUES 
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'), 'executive-coaching'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'), 'skills-audit'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'), 'individual-feedback'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'), 'team-restructuring'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'), 'team-charter'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'), 'delegation-plan'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'), 'team-retrospective'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'), 'cross-team-project'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'), 'mentoring-session'),
  (gen_random_uuid(), (SELECT "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'), 'process-optimization');
"""
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardComboTrigger");

            migrationBuilder.DropTable(
                name: "CardRequirement");

            migrationBuilder.DropTable(
                name: "CardCombo");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Cards_Slug",
                table: "Cards");
        }
    }
}
