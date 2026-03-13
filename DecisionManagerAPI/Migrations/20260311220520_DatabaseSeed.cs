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
    'quick-wins', 'Victoires rapides',
    'Identifiez et célébrez de petites victoires pour redonner de l''élan à l''équipe.',
    1, 0.85,
    10, -5, 5, -3,
    -3, 3, -2, 2,
    0,
    'Les petites victoires célébrées ont redonné confiance à l''équipe. La dynamique est positive.',
    'Les victoires mises en avant ont semblé artificielles. L''équipe se sent infantilisée.'
),
(
    'one-on-one', 'Entretien one-on-one',
    'Planifiez des réunions régulières en tête-à-tête avec chaque membre de l''équipe.',
    1, 0.80,
    12, -5, 5, -5,
    -5, 5, -3, 3,
    0,
    'Les one-on-ones ont renforcé la confiance individuelle. Chacun se sent écouté et soutenu.',
    'Les entretiens ont mis en lumière des frustrations profondes que vous n''étiez pas prêt à gérer.'
),
(
    'skills-audit', 'Audit des compétences',
    'Évaluez les compétences actuelles de l''équipe pour identifier les lacunes et les forces.',
    1, 0.75,
    5, 5, 10, -3,
    -5, 10, -5, 3,
    0,
    'L''audit a révélé des talents cachés et des axes d''amélioration clairs. L''équipe se sent mieux orientée.',
    'L''audit a été vécu comme un jugement. Certains membres se sentent remis en question.'
),
(
    'team-charter', 'Charte d''équipe',
    'Co-construisez une charte définissant les valeurs, règles et engagements de l''équipe.',
    1, 0.75,
    10, -8, 5, -5,
    -5, 5, -3, 3,
    0,
    'La charte co-construite crée un cadre commun fort. L''équipe s''y réfère naturellement.',
    'Le processus de co-construction a cristallisé les désaccords. Le résultat ne fait pas consensus.'
),
(
    'recognition-program', 'Programme de reconnaissance',
    'Mettez en place un système formel de reconnaissance des efforts et des réussites individuelles.',
    1, 0.80,
    15, -5, 5, -8,
    -8, 5, -3, 5,
    0,
    'Le programme de reconnaissance valorise les efforts de chacun. La motivation est en forte hausse.',
    'Le système perçu comme inéquitable a créé des jalousies. Certains se sentent invisibles.'
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
    'job-rotation', 'Rotation de postes',
    'Proposez des rotations de postes pour développer la polyvalence et briser la routine.',
    2, 0.65,
    8, 5, 8, -5,
    -8, 12, -8, 5,
    1,
    'La rotation a révélé des talents insoupçonnés et brisé les silos. L''équipe gagne en flexibilité.',
    'La rotation imposée a désorganisé les équipes. La productivité chute pendant la période de transition.'
),
(
    'internal-communication', 'Plan de communication interne',
    'Structurez la communication interne pour réduire les malentendus et aligner l''équipe.',
    2, 0.75,
    8, -8, 8, -5,
    -5, 8, -5, 3,
    0,
    'Le plan de communication a clarifié les flux d''information. Les malentendus se font rares.',
    'Le surplus de communication a créé une surcharge informationnelle. L''équipe se sent noyée.'
),
(
    'delegation-plan', 'Plan de délégation',
    'Déléguez des responsabilités clés pour développer l''autonomie et la confiance de l''équipe.',
    2, 0.70,
    10, -5, 8, -8,
    -8, 10, -8, 5,
    1,
    'La délégation bien encadrée a responsabilisé l''équipe. Les membres gagnent en autonomie et en confiance.',
    'La délégation sans filet a mis certains membres en difficulté. Des erreurs coûteuses ont été commises.'
),
(
    'team-retrospective', 'Rétrospective d''équipe',
    'Organisez une rétrospective pour analyser collectivement les succès et les points d''amélioration.',
    2, 0.80,
    10, -8, 8, -5,
    -5, 5, -3, 3,
    0,
    'La rétrospective a permis d''identifier des améliorations concrètes. L''équipe se sent entendue.',
    'La rétrospective s''est transformée en séance de règlement de comptes. Les tensions ont resurgi.'
),
(
    'peer-review', 'Évaluation par les pairs',
    'Mettez en place un système d''évaluation mutuelle entre collègues pour enrichir les retours.',
    2, 0.60,
    5, 8, 10, -3,
    -10, 15, -5, 8,
    1,
    'Les évaluations entre pairs ont apporté des retours riches et nuancés. La progression est visible.',
    'Le système d''évaluation a généré des tensions interpersonnelles. La confiance s''est érodée.'
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
    "Id" FROM "Cards" WHERE "Slug" = 'predictive-analytics'
UNION ALL
SELECT 
    'Récidive du conflit', 
    'Le conflit semblait réglé mais refait surface avec plus d''intensité.', 
    0.25, 2, 5, 
    -8, 12, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'conflict-mediation'
UNION ALL
SELECT 
    'Cohésion renforcée post-médiation', 
    'L''épisode difficile a finalement soudé l''équipe autour d''une communication plus ouverte.', 
    0.20, 3, 6, 
    10, -8, 5, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'conflict-mediation'
UNION ALL
SELECT 
    'Isolement progressif', 
    'Plusieurs membres signalent un sentiment d''isolement croissant depuis le passage au télétravail.', 
    0.25, 3, 6, 
    -8, 8, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'flexible-remote-work'
UNION ALL
SELECT 
    'Productivité en hausse', 
    'Sans les interruptions du bureau, plusieurs membres ont vu leur productivité s''envoler.', 
    0.30, 2, 5, 
    5, -8, 12, -3,
    "Id" FROM "Cards" WHERE "Slug" = 'flexible-remote-work'
UNION ALL
SELECT 
    'Confusion des rôles persistante', 
    'Plusieurs semaines après la restructuration, les périmètres de responsabilité restent flous.', 
    0.30, 2, 5, 
    -8, 12, -8, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'team-restructuring'
UNION ALL
SELECT 
    'Synergies inattendues', 
    'Les nouveaux binômes créés par la restructuration ont généré des collaborations très productives.', 
    0.20, 4, 7, 
    8, -5, 12, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'team-restructuring'
UNION ALL
SELECT 
    'Démotivation suite au feedback', 
    'Un feedback mal reçu a provoqué un désengagement visible chez un membre clé.', 
    0.20, 1, 3, 
    -10, 8, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'individual-feedback'
UNION ALL
SELECT 
    'Progression accélérée', 
    'Les axes d''amélioration clairement définis ont permis une montée en compétences rapide.', 
    0.25, 3, 6, 
    8, -3, 12, -3,
    "Id" FROM "Cards" WHERE "Slug" = 'individual-feedback'
UNION ALL
SELECT 
    'Séquelles psychologiques de la crise', 
    'La pression vécue pendant la crise laisse des traces. Plusieurs membres montrent des signes d''épuisement.', 
    0.30, 2, 5, 
    -8, 15, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'crisis-management'
UNION ALL
SELECT 
    'Leadership reconnu', 
    'Votre gestion de la crise a renforcé votre crédibilité. L''équipe vous fait davantage confiance.', 
    0.25, 3, 6, 
    10, -8, 8, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'crisis-management'
UNION ALL
SELECT 
    'Surcharge des mentors', 
    'Les collaborateurs mentors se sentent surchargés par cette responsabilité supplémentaire.', 
    0.25, 3, 6, 
    -5, 12, -3, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'
UNION ALL
SELECT 
    'Montée en compétences visible', 
    'Les juniors mentorés progressent à une vitesse remarquable. La qualité du travail s''améliore.', 
    0.30, 4, 8, 
    10, -5, 12, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'mentoring-session'
UNION ALL
SELECT 
    'Désorientation post-réorganisation', 
    'L''équipe peine à retrouver ses marques dans les nouveaux espaces. La routine est perturbée.', 
    0.20, 1, 3, 
    -5, 8, -5, 2,
    "Id" FROM "Cards" WHERE "Slug" = 'workspace-reorganization'
UNION ALL
SELECT 
    'Collaboration spontanée en hausse', 
    'Les nouveaux espaces favorisent les échanges informels. Les idées émergent naturellement.', 
    0.25, 3, 5, 
    8, -5, 8, -3,
    "Id" FROM "Cards" WHERE "Slug" = 'workspace-reorganization'
UNION ALL
SELECT 
    'Contestation des évaluations', 
    'Plusieurs membres contestent leurs évaluations auprès des RH. Le climat se tend.', 
    0.25, 2, 4, 
    -8, 12, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'performance-review'
UNION ALL
SELECT 
    'Objectifs mieux compris', 
    'Suite aux entretiens, les membres ont une vision plus claire de leurs objectifs. La performance s''améliore.', 
    0.30, 3, 6, 
    8, -5, 10, -3,
    "Id" FROM "Cards" WHERE "Slug" = 'performance-review'
UNION ALL
SELECT 
    'Frictions inter-équipes', 
    'Des désaccords sur les méthodes de travail entre équipes ralentissent l''avancement du projet.', 
    0.25, 2, 5, 
    -5, 10, -8, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'cross-team-project'
UNION ALL
SELECT 
    'Meilleures pratiques partagées', 
    'Le projet inter-équipes a permis de diffuser des bonnes pratiques dans toute l''organisation.', 
    0.20, 4, 7, 
    8, -5, 12, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'cross-team-project'
UNION ALL
SELECT 
    'Programme perçu comme cosmétique', 
    'L''équipe perçoit le programme bien-être comme une façade qui ne s''attaque pas aux vraies causes de stress.', 
    0.25, 3, 5, 
    -5, 8, -3, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'wellness-program'
UNION ALL
SELECT 
    'Baisse significative de l''absentéisme', 
    'Le programme bien-être a eu un impact mesurable sur la santé des collaborateurs. L''absentéisme chute.', 
    0.25, 4, 8, 
    10, -10, 8, -8,
    "Id" FROM "Cards" WHERE "Slug" = 'wellness-program'
UNION ALL
SELECT 
    'Vision partagée mise à l''épreuve', 
    'La vision définie en séminaire se heurte à la réalité opérationnelle. Des ajustements s''imposent.', 
    0.20, 3, 6, 
    -5, 8, -3, 2,
    "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'
UNION ALL
SELECT 
    'Engagement stratégique renouvelé', 
    'Les décisions prises en séminaire sont appliquées avec conviction. L''alignement est fort.', 
    0.25, 4, 8, 
    12, -8, 8, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'strategic-retreat'
UNION ALL
SELECT 
    'Résistance aux nouveaux processus', 
    'Une partie de l''équipe refuse d''adopter les nouvelles procédures jugées trop rigides.', 
    0.25, 2, 5, 
    -8, 10, -5, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'process-optimization'
UNION ALL
SELECT 
    'Gains de productivité mesurables', 
    'Les nouveaux processus ont réduit le temps de traitement de 20%. Les résultats parlent d''eux-mêmes.', 
    0.25, 4, 7, 
    5, -5, 15, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'process-optimization'
UNION ALL
SELECT 
    'Jalousies entre candidats leaders', 
    'La compétition entre les profils identifiés crée des tensions qui nuisent à la cohésion.', 
    0.25, 3, 6, 
    -8, 10, -3, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'leadership-development'
UNION ALL
SELECT 
    'Leadership distribué efficace', 
    'Les nouveaux leaders prennent des initiatives pertinentes. La charge managériale se répartit mieux.', 
    0.20, 5, 8, 
    10, -8, 10, -8,
    "Id" FROM "Cards" WHERE "Slug" = 'leadership-development'
UNION ALL
SELECT 
    'Choc culturel post-fusion', 
    'Les différences de culture de travail entre les deux entités créent des incompréhensions profondes.', 
    0.30, 2, 5, 
    -10, 15, -8, 8,
    "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'
UNION ALL
SELECT 
    'Synergies post-fusion concrétisées', 
    'Les complémentarités entre les deux équipes génèrent des résultats que ni l''une ni l''autre n''aurait atteints seule.', 
    0.20, 5, 9, 
    10, -8, 15, -8,
    "Id" FROM "Cards" WHERE "Slug" = 'merger-integration'
UNION ALL
SELECT 
    'Difficultés d''onboarding à distance', 
    'Les nouvelles recrues peinent à s''intégrer sans présence physique. La courbe d''apprentissage s''allonge.', 
    0.25, 3, 6, 
    -8, 8, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'remote-first-policy'
UNION ALL
SELECT 
    'Attraction de talents élargies', 
    'La politique Remote First attire des profils géographiquement inaccessibles auparavant. Le recrutement s''accélère.', 
    0.20, 4, 8, 
    8, -5, 10, -8,
    "Id" FROM "Cards" WHERE "Slug" = 'remote-first-policy'
UNION ALL
SELECT 
    'Résistance des anciennes habitudes', 
    'Les comportements ancrés résistent à la nouvelle culture malgré les efforts déployés.', 
    0.30, 3, 6, 
    -8, 10, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'
UNION ALL
SELECT 
    'Nouvelle culture comme avantage concurrentiel', 
    'La réputation de la nouvelle culture attire des talents et fidélise les meilleurs éléments.', 
    0.20, 6, 10, 
    12, -8, 8, -10,
    "Id" FROM "Cards" WHERE "Slug" = 'culture-revamp'
UNION ALL
SELECT 
    'Remise en question profonde', 
    'Le coaching a soulevé des questionnements identitaires qui fragilisent temporairement votre posture.', 
    0.20, 2, 5, 
    -5, 10, -3, 2,
    "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'
UNION ALL
SELECT 
    'Changement de posture managériale visible', 
    'L''équipe perçoit une évolution positive dans votre style de management. La confiance se renforce.', 
    0.25, 4, 8, 
    10, -8, 8, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'executive-coaching'
UNION ALL
SELECT 
    'Départ suite à la politique zéro tolérance', 
    'Un membre dont le comportement était borderline a préféré partir plutôt que de changer.', 
    0.25, 2, 5, 
    -3, 5, -3, 8,
    "Id" FROM "Cards" WHERE "Slug" = 'zero-tolerance'
UNION ALL
SELECT 
    'Climat de travail assaini', 
    'L''équipe respire mieux depuis que les comportements toxiques ont disparu. La sécurité psychologique est revenue.', 
    0.25, 4, 8, 
    12, -10, 8, -8,
    "Id" FROM "Cards" WHERE "Slug" = 'zero-tolerance'
UNION ALL
SELECT 
    'Dérive sans garde-fous', 
    'Sans supervision suffisante, certaines décisions autonomes ont conduit à des erreurs coûteuses.', 
    0.25, 3, 6, 
    -8, 10, -8, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'
UNION ALL
SELECT 
    'Innovation bottom-up', 
    'L''autonomie accordée a libéré la créativité. Des initiatives pertinentes émergent du terrain.', 
    0.25, 5, 8, 
    12, -8, 12, -8,
    "Id" FROM "Cards" WHERE "Slug" = 'autonomy-framework'
UNION ALL
SELECT 
    'Cynisme face au discours sur le sens', 
    'La stratégie orientée sens est perçue comme du marketing interne. Le cynisme s''installe.', 
    0.25, 3, 6, 
    -8, 8, -3, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'
UNION ALL
SELECT 
    'Engagement exceptionnel', 
    'Les membres qui adhèrent à la mission font preuve d''un engagement qui dépasse les attentes.', 
    0.20, 5, 9, 
    15, -10, 10, -10,
    "Id" FROM "Cards" WHERE "Slug" = 'purpose-driven-strategy'
UNION ALL
SELECT 
    'Effet soufflé retombé', 
    'L''enthousiasme généré par les victoires rapides s''est essoufflé. L''équipe attend des défis plus substantiels.', 
    0.25, 2, 4, 
    -5, 5, -3, 2,
    "Id" FROM "Cards" WHERE "Slug" = 'quick-wins'
UNION ALL
SELECT 
    'Dynamique positive auto-entretenue', 
    'Les succès célébrés ont enclenché une dynamique vertueuse. L''équipe cherche naturellement à se dépasser.', 
    0.20, 3, 6, 
    10, -8, 8, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'quick-wins'
UNION ALL
SELECT 
    'Frustrations remontées en one-on-one', 
    'Les entretiens individuels ont fait remonter des insatisfactions profondes que vous n''anticipiez pas.', 
    0.25, 2, 4, 
    -5, 10, -3, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'one-on-one'
UNION ALL
SELECT 
    'Lien manager-collaborateur renforcé', 
    'Les one-on-ones réguliers ont créé une relation de confiance durable. L''engagement individuel progresse.', 
    0.30, 3, 6, 
    12, -8, 8, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'one-on-one'
UNION ALL
SELECT 
    'Complexe d''infériorité post-audit', 
    'Certains membres mal évalués lors de l''audit se sentent dévalorisés et perdent confiance.', 
    0.20, 1, 3, 
    -8, 8, -5, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'skills-audit'
UNION ALL
SELECT 
    'Formation ciblée efficace', 
    'Les lacunes identifiées lors de l''audit ont permis de cibler des formations qui portent rapidement leurs fruits.', 
    0.25, 3, 7, 
    5, -3, 12, -3,
    "Id" FROM "Cards" WHERE "Slug" = 'skills-audit'
UNION ALL
SELECT 
    'Charte non respectée', 
    'Malgré son élaboration collective, la charte n''est pas appliquée. Elle reste lettre morte.', 
    0.20, 3, 6, 
    -8, 8, -5, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'team-charter'
UNION ALL
SELECT 
    'Référentiel commun consolidé', 
    'L''équipe se réfère spontanément à la charte pour trancher les désaccords. Elle devient un vrai outil de gouvernance.', 
    0.25, 4, 8, 
    10, -8, 8, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'team-charter'
UNION ALL
SELECT 
    'Sentiment d''injustice dans la reconnaissance', 
    'Des membres estimant leurs contributions sous-évaluées expriment leur mécontentement ouvertement.', 
    0.25, 2, 4, 
    -10, 8, -3, 8,
    "Id" FROM "Cards" WHERE "Slug" = 'recognition-program'
UNION ALL
SELECT 
    'Compétition saine entre membres', 
    'Le programme de reconnaissance a stimulé une émulation positive. La qualité du travail s''améliore.', 
    0.20, 3, 6, 
    8, -5, 10, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'recognition-program'
UNION ALL
SELECT 
    'Perte d''expertise pendant la rotation', 
    'La rotation a éloigné des experts de leurs domaines de prédilection. La qualité en pâtit temporairement.', 
    0.25, 2, 5, 
    -5, 10, -8, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'job-rotation'
UNION ALL
SELECT 
    'Polyvalence accrue et silos brisés', 
    'Les membres comprennent mieux les contraintes de leurs collègues. La collaboration s''améliore naturellement.', 
    0.25, 4, 7, 
    8, -5, 10, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'job-rotation'
UNION ALL
SELECT 
    'Surcharge informationnelle', 
    'Le flux d''informations structuré est devenu trop dense. L''équipe peine à distinguer l''essentiel de l''accessoire.', 
    0.20, 2, 5, 
    -5, 10, -5, 2,
    "Id" FROM "Cards" WHERE "Slug" = 'internal-communication'
UNION ALL
SELECT 
    'Malentendus en forte baisse', 
    'Les erreurs dues à des incompréhensions ont chuté significativement. L''efficacité collective progresse.', 
    0.25, 3, 6, 
    8, -8, 10, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'internal-communication'
UNION ALL
SELECT 
    'Sentiment d''abandon', 
    'Certains membres délégués vivent la délégation comme un désengagement du manager. Ils se sentent livrés à eux-mêmes.', 
    0.25, 2, 5, 
    -8, 10, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'delegation-plan'
UNION ALL
SELECT 
    'Montée en responsabilité réussie', 
    'Les membres délégués ont pleinement pris en main leurs nouvelles responsabilités. La confiance est mutuelle.', 
    0.25, 4, 8, 
    12, -8, 10, -8,
    "Id" FROM "Cards" WHERE "Slug" = 'delegation-plan'
UNION ALL
SELECT 
    'Rétrospective sans suite', 
    'Les actions identifiées en rétrospective ne sont pas mises en oeuvre. La crédibilité du processus s''érode.', 
    0.25, 2, 5, 
    -8, 8, -5, 3,
    "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'
UNION ALL
SELECT 
    'Amélioration continue enclenchée', 
    'Les changements issus de la rétrospective ont produit des résultats visibles. L''équipe croit au processus.', 
    0.25, 3, 7, 
    8, -8, 10, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'team-retrospective'
UNION ALL
SELECT 
    'Rancune post-évaluation', 
    'Des feedbacks mal formulés entre pairs ont créé des rancunes durables. L''ambiance s''est dégradée.', 
    0.25, 2, 5, 
    -10, 12, -5, 5,
    "Id" FROM "Cards" WHERE "Slug" = 'peer-review'
UNION ALL
SELECT 
    'Feedbacks de haute qualité', 
    'Les évaluations entre pairs ont apporté des retours plus concrets et actionnables que les évaluations managériales.', 
    0.20, 3, 6, 
    8, -5, 12, -5,
    "Id" FROM "Cards" WHERE "Slug" = 'peer-review';
"""
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""DELETE FROM "Events";""");
            migrationBuilder.Sql("""DELETE FROM "Cards" ;""");
        }
    }
}
