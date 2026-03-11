using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
"""
INSERT INTO "Cards" (
    "Slug", "DisplayName", "Description", "RequiredLevel",
    "SuccessProbability",
    "MotivationEffect", "StressEffect", "PerformanceEffect", "TurnoverEffect",
    "MotivationEffectOnFailure", "StressEffectOnFailure", "PerformanceEffectOnFailure", "TurnoverEffectOnFailure",
    "RiskLevel", "SuccessMessage", "FailureMessage"
) VALUES
(
    'team-meeting', 'Réunion d''équipe',
    'Organisez une réunion pour aligner l''équipe sur les objectifs communs.',
    1, 0.80,
    8, -5, 5, -3,
    -5, 5, -3, 3,
    0,
    'La réunion s''est bien passée. L''équipe repart avec des objectifs clairs et une bonne cohésion.',
    'La réunion a tourné au règlement de comptes. Les tensions sont montées d''un cran.'
),
(
    'ambitious-goals', 'Objectifs ambitieux',
    'Fixez des objectifs élevés pour booster la performance de l''équipe.',
    1, 0.60,
    5, 8, 12, -2,
    -8, 15, -5, 5,
    1,
    'Le défi a galvanisé l''équipe. La performance est en nette hausse.',
    'Les objectifs étaient trop élevés. L''équipe se sent dépassée et démotivée.'
),
(
    'professional-training', 'Formation professionnelle',
    'Envoyez l''équipe en formation pour développer de nouvelles compétences.',
    1, 0.75,
    10, -3, 8, -5,
    -3, 5, 3, 2,
    0,
    'La formation a été un succès. L''équipe est montée en compétences et se sent valorisée.',
    'La formation n''a pas correspondu aux besoins réels. L''équipe se sent frustrée.'
),
(
    'exceptional-bonus', 'Prime exceptionnelle',
    'Accordez une prime exceptionnelle pour récompenser les efforts de l''équipe.',
    1, 0.85,
    15, -5, 5, -8,
    -5, 3, 0, 5,
    0,
    'La prime a été très bien accueillie. La motivation est au plus haut.',
    'La distribution inégale de la prime a créé des jalousies au sein de l''équipe.'
),
(
    'conflict-mediation', 'Médiation de conflit',
    'Intervenez pour résoudre un conflit latent entre membres de l''équipe.',
    1, 0.70,
    8, -10, 5, -5,
    -10, 10, -5, 8,
    1,
    'La médiation a permis de désamorcer la situation. L''ambiance s''est nettement améliorée.',
    'Votre intervention a été mal perçue. Le conflit s''est cristallisé davantage.'
),
(
    'flexible-remote-work', 'Télétravail flexible',
    'Mettez en place une politique de télétravail flexible pour améliorer l''équilibre vie pro/perso.',
    1, 0.75,
    10, -8, 0, -5,
    -3, 5, -5, 3,
    0,
    'L''équipe apprécie la flexibilité. La motivation grimpe et le turnover baisse.',
    'L''isolement commence à peser. La cohésion d''équipe s''est dégradée.'
),
(
    'team-restructuring', 'Restructuration de l''équipe',
    'Réorganisez les équipes pour optimiser la complémentarité des profils.',
    1, 0.55,
    -5, 10, 8, 5,
    -15, 20, -8, 10,
    2,
    'La nouvelle organisation a révélé des synergies insoupçonnées. La performance s''envole.',
    'La restructuration a semé la confusion. Les rôles ne sont pas clairs et la productivité chute.'
),
(
    'individual-feedback', 'Feedback individuel',
    'Organisez des entretiens individuels pour donner un retour personnalisé à chaque membre.',
    1, 0.80,
    10, -3, 8, -3,
    -8, 5, -3, 3,
    0,
    'Les entretiens ont été très appréciés. Chacun repart avec une vision claire de ses axes d''amélioration.',
    'Vos retours ont été perçus comme des critiques. Certains membres se sentent dévalorisés.'
),
(
    'collective-break', 'Pause collective',
    'Organisez une pause déjeuner ou une activité collective pour souder l''équipe.',
    1, 0.90,
    12, -8, 0, -5,
    -3, 3, -3, 2,
    0,
    'Ce moment de détente a renforcé les liens. L''ambiance est excellente.',
    'L''activité n''a pas plu à tout le monde. Certains se sont sentis mis à l''écart.'
),
(
    'crisis-management', 'Gestion de crise',
    'Prenez les rênes face à une situation critique et guidez l''équipe.',
    1, 0.60,
    5, 15, 10, 3,
    -10, 25, -10, 10,
    2,
    'Votre leadership en situation de crise a impressionné l''équipe. La confiance est renforcée.',
    'La gestion de crise chaotique a aggravé la situation. Le stress est à son comble.'
),
(
    'mentoring-session', 'Session de mentorat',
    'Mettez en place un programme de mentorat entre collaborateurs expérimentés et juniors.',
    2, 0.80,
    12, -5, 10, -8,
    -3, 5, 0, 3,
    0,
    'Le mentorat a renforcé la cohésion intergénérationnelle et boosté les compétences des juniors.',
    'Les mentors se sentent surchargés. La relation s''est transformée en source de stress.'
),
(
    'workspace-reorganization', 'Réorganisation des espaces',
    'Réaménagez les espaces de travail pour favoriser la collaboration et le bien-être.',
    2, 0.70,
    8, -5, 5, -3,
    -5, 8, -3, 2,
    0,
    'Le nouvel espace de travail est plébiscité. La créativité et la collaboration sont en hausse.',
    'La réorganisation a désorganisé les habitudes de travail. La productivité en pâtit.'
),
(
    'performance-review', 'Entretien annuel',
    'Conduisez les entretiens annuels d''évaluation de performance.',
    2, 0.65,
    5, 8, 10, -5,
    -10, 15, -5, 8,
    1,
    'Les entretiens bien conduits ont clarifié les attentes et renforcé l''engagement.',
    'Les évaluations ont été vécues comme injustes. Le ressentiment s''installe.'
),
(
    'cross-team-project', 'Projet inter-équipes',
    'Lancez un projet collaboratif impliquant plusieurs équipes.',
    2, 0.65,
    8, 5, 12, -3,
    -5, 10, -5, 5,
    1,
    'La collaboration inter-équipes a été fructueuse. De nouvelles synergies sont nées.',
    'Les frictions entre équipes ont paralysé le projet. La frustration est généralisée.'
),
(
    'wellness-program', 'Programme bien-être',
    'Lancez un programme de bien-être au travail (sport, mindfulness, espaces de détente).',
    2, 0.80,
    10, -12, 5, -8,
    -3, 5, -3, 2,
    0,
    'Le programme bien-être a transformé l''ambiance. Le stress chute et la motivation grimpe.',
    'Le programme a été perçu comme superficiel. Les vrais problèmes ne sont pas adressés.'
),
(
    'agile-transformation', 'Transformation Agile',
    'Introduisez les méthodes Agile pour gagner en flexibilité et en réactivité.',
    3, 0.60,
    5, 10, 15, -5,
    -10, 20, -8, 8,
    2,
    'L''adoption de l''Agile a fluidifié les processus. L''équipe gagne en autonomie et en efficacité.',
    'La transformation Agile mal accompagnée a créé de la confusion. Les anciens repères ont disparu sans être remplacés.'
),
(
    'talent-retention-plan', 'Plan de rétention des talents',
    'Mettez en place un plan de rétention pour fidéliser vos meilleurs éléments.',
    3, 0.70,
    10, -5, 5, -15,
    -5, 5, 0, 5,
    1,
    'Le plan de rétention a convaincu les talents clés de rester. La stabilité de l''équipe est assurée.',
    'Le plan a été jugé insuffisant par les talents visés. Certains ont quand même choisi de partir.'
),
(
    'strategic-retreat', 'Séminaire stratégique',
    'Organisez un séminaire hors les murs pour redéfinir la vision et la stratégie.',
    3, 0.75,
    12, -8, 8, -5,
    -3, 5, -3, 3,
    0,
    'Le séminaire a redonné du sens au travail de l''équipe. La vision partagée soude le collectif.',
    'Le séminaire s''est révélé être une perte de temps aux yeux de l''équipe. Le scepticisme s''installe.'
),
(
    'process-optimization', 'Optimisation des processus',
    'Analysez et rationalisez les processus internes pour gagner en efficacité.',
    3, 0.65,
    3, -3, 15, -3,
    -5, 8, -8, 5,
    1,
    'Les nouveaux processus ont éliminé les frictions. La productivité grimpe significativement.',
    'La rationalisation excessive a supprimé des garde-fous importants. Des erreurs se multiplient.'
),
(
    'leadership-development', 'Développement du leadership',
    'Identifiez et formez les futurs leaders au sein de votre équipe.',
    3, 0.70,
    10, -3, 8, -8,
    -5, 8, -3, 5,
    1,
    'Les nouveaux leaders émergents insufflent une nouvelle dynamique. L''équipe gagne en maturité.',
    'La compétition entre candidats leaders a créé des tensions. La cohésion s''est fragilisée.'
),
(
    'merger-integration', 'Intégration post-fusion',
    'Pilotez l''intégration culturelle et opérationnelle suite à une fusion d''équipes.',
    4, 0.50,
    -5, 15, 10, 8,
    -15, 25, -10, 15,
    2,
    'L''intégration maîtrisée a créé une entité plus forte que la somme de ses parties.',
    'Les cultures incompatibles ont généré des frictions profondes. Le turnover explose.'
),
(
    'remote-first-policy', 'Politique Remote First',
    'Faites du travail à distance la norme et restructurez l''organisation en conséquence.',
    4, 0.60,
    8, -10, 5, -10,
    -10, 15, -8, 8,
    2,
    'La politique Remote First a élargi le vivier de talents et amélioré la satisfaction.',
    'L''isolement généralisé a déchiré le tissu social de l''équipe. La collaboration s''est effondrée.'
),
(
    'culture-revamp', 'Refonte de la culture',
    'Engagez une transformation profonde de la culture d''entreprise.',
    4, 0.55,
    10, 5, 8, -8,
    -15, 20, -5, 12,
    2,
    'La nouvelle culture fédère et attire. L''équipe est fière d''appartenir à cette organisation.',
    'La transformation culturelle forcée a provoqué un rejet massif. Les départs se multiplient.'
),
(
    'succession-planning', 'Plan de succession',
    'Anticipez les départs clés en préparant les successeurs internes.',
    4, 0.70,
    8, -3, 5, -12,
    -3, 5, -3, 3,
    1,
    'La préparation des successeurs garantit la continuité. L''organisation gagne en résilience.',
    'Le plan de succession a créé des rivalités internes destructrices.'
),
(
    'innovation-lab', 'Laboratoire d''innovation',
    'Créez un espace dédié à l''expérimentation et à l''innovation.',
    4, 0.65,
    12, -3, 12, -8,
    -5, 8, -5, 3,
    1,
    'Le lab d''innovation génère des idées concrètes. L''équipe est galvanisée par cette liberté créative.',
    'Le lab est perçu comme un gadget sans lien avec les vrais enjeux. La frustration s''accumule.'
),
(
    'executive-coaching', 'Coaching exécutif',
    'Engagez un coach externe pour accompagner votre développement de leadership.',
    5, 0.75,
    8, -8, 10, -5,
    -3, 5, -3, 2,
    1,
    'Le coaching a révélé des angles morts et renforcé votre posture managériale.',
    'Le coaching a soulevé des remises en question que vous n''étiez pas prêt à affronter.'
),
(
    'zero-tolerance', 'Tolérance zéro',
    'Adoptez une politique de tolérance zéro envers les comportements toxiques.',
    5, 0.60,
    5, -5, 8, -10,
    -10, 20, -5, 5,
    2,
    'La politique claire a assaini l''environnement de travail. Les comportements toxiques ont disparu.',
    'La rigueur excessive a créé un climat de peur. La créativité et la prise d''initiative s''effondrent.'
),
(
    'autonomy-framework', 'Cadre d''autonomie',
    'Définissez un cadre clair pour responsabiliser l''équipe et déléguer davantage.',
    5, 0.70,
    12, -8, 10, -8,
    -8, 10, -5, 5,
    1,
    'L''autonomie encadrée a libéré le potentiel de l''équipe. La responsabilisation porte ses fruits.',
    'Sans accompagnement suffisant, l''autonomie a généré de l''anxiété et des erreurs coûteuses.'
),
(
    'purpose-driven-strategy', 'Stratégie orientée sens',
    'Redéfinissez la mission et les valeurs pour redonner du sens au travail.',
    5, 0.70,
    15, -10, 8, -10,
    -5, 5, -3, 3,
    1,
    'La stratégie orientée sens a transcendé l''équipe. L''engagement atteint un niveau exceptionnel.',
    'Le discours sur le sens a sonné creux. Le cynisme s''est installé durablement.'
),
(
    'predictive-analytics', 'Analyse prédictive RH',
    'Utilisez la data pour anticiper les risques RH et optimiser les décisions managériales.',
    5, 0.65,
    5, -5, 15, -8,
    -5, 8, -5, 3,
    1,
    'Les insights data ont permis d''anticiper et de prévenir plusieurs crises RH.',
    'La sur-quantification a déshumanisé le management. L''équipe se sent réduite à des chiffres.'
);
"""
            );

            migrationBuilder.Sql(
"""
INSERT INTO "Events" (
    "EventName", "Message", "Chance",
    "WeekRangeMin", "WeekRangeMax",
    "MotivationDelta", "StressDelta", "PerformanceDelta", "TurnoverDelta",
    "CardId"
)
SELECT
    'Tensions post-réunion',
    'La réunion a soulevé des non-dits qui ressurgissent maintenant.',
    0.20, 2, 4,
    -5, 8, -3, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'team-meeting'
UNION ALL
SELECT
    'Dépassement d''objectifs',
    'Les objectifs ambitieux ont créé une dynamique inattendue.',
    0.25, 2, 5,
    8, -5, 10, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'ambitious-goals'
UNION ALL
SELECT
    'Objectifs inatteignables',
    'L''équipe réalise que les objectifs fixés sont irréalistes.',
    0.30, 1, 3,
    -10, 15, -8, 8,
    "Id" FROM "Cards" WHERE "Slug" = 'ambitious-goals'
UNION ALL
SELECT
    'Application des nouvelles compétences',
    'Les compétences acquises en formation commencent à porter leurs fruits.',
    0.25, 3, 6,
    5, -3, 10, -3,
    "Id" FROM "Cards" WHERE "Slug" = 'professional-training'
UNION ALL
SELECT
    'Résistance au changement post-formation',
    'Certains membres rechignent à appliquer les nouvelles méthodes.',
    0.20, 2, 5,
    -5, 8, -5, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'professional-training'
UNION ALL
SELECT
    'Jalousies liées à la prime',
    'Des rumeurs sur l''inégalité des primes circulent dans l''équipe.',
    0.25, 1, 3,
    -8, 10, -3, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'exceptional-bonus'
UNION ALL
SELECT
    'Regain d''énergie post-pause',
    'La pause collective a rechargé les batteries de l''équipe.',
    0.30, 1, 2,
    8, -8, 5, -3,
    "Id" FROM "Cards" WHERE "Slug" = 'collective-break'
UNION ALL
SELECT
    'Résistance à la transformation Agile',
    'La résistance au changement refait surface plusieurs semaines après le lancement.',
    0.30, 4, 8,
    -8, 15, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'
UNION ALL
SELECT
    'Adoption complète de l''Agile',
    'L''équipe a pleinement intégré les pratiques Agile. Les résultats suivent.',
    0.25, 5, 9,
    10, -8, 12, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'agile-transformation'
UNION ALL
SELECT
    'Départ malgré le plan de rétention',
    'Un talent clé annonce sa démission malgré le plan de rétention.',
    0.20, 5, 8,
    -10, 10, -5, 15,
    "Id" FROM "Cards" WHERE "Slug" = 'talent-retention-plan'
UNION ALL
SELECT
    'Rivalités entre successeurs',
    'La compétition entre les candidats identifiés crée des tensions.',
    0.25, 3, 6,
    -8, 12, -3, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'succession-planning'
UNION ALL
SELECT
    'Innovation concrète issue du lab',
    'Une idée du lab d''innovation est retenue et mise en production.',
    0.20, 4, 8,
    12, -5, 15, -8,
    "Id" FROM "Cards" WHERE "Slug" = 'innovation-lab'
UNION ALL
SELECT
    'Insights prédictifs confirmés',
    'Les prédictions RH se révèlent exactes, évitant une crise de turnover.',
    0.25, 3, 6,
    8, -5, 8, -10,
    "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'
UNION ALL
SELECT
    'Rejet de la quantification',
    'L''équipe exprime son mal-être face à une gestion trop analytique.',
    0.20, 4, 7,
    -10, 12, -5, 8,
    "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics';
"""
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
