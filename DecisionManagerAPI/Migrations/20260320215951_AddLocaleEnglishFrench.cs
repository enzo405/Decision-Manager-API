using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DecisionManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddLocaleEnglishFrench : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

          #region Column Rename

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Events",
                newName: "MessageFr");

            migrationBuilder.RenameColumn(
                name: "EventName",
                table: "Events",
                newName: "EventNameFr");

            migrationBuilder.RenameColumn(
                name: "SuccessMessage",
                table: "Cards",
                newName: "SuccessMessageFr");

            migrationBuilder.RenameColumn(
                name: "FailureMessage",
                table: "Cards",
                newName: "FailureMessageFr");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "Cards",
                newName: "DisplayNameFr");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cards",
                newName: "DescriptionFr");
                
          #endregion
          
          #region Add Column
          
            migrationBuilder.AddColumn<string>(
                name: "EventNameEn",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MessageEn",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DisplayNameEn",
                table: "Cards",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Cards",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SuccessMessageEn",
                table: "Cards",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FailureMessageEn",
                table: "Cards",
                type: "text",
                nullable: false,
                defaultValue: "");

          #endregion
          
          #region Seeding UPDATE to add English text

          #region Cards

            migrationBuilder.Sql("""
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Team Meeting',
    "DescriptionEn"     = 'Organize a meeting to align the team on shared objectives.',
    "SuccessMessageEn"  = 'The meeting went well. The team leaves with clear goals and strong cohesion.',
    "FailureMessageEn"  = 'The meeting devolved into score-settling. Tensions escalated significantly.'
WHERE "Slug" = 'team-meeting';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Ambitious Goals',
    "DescriptionEn"     = 'Set high targets to boost the team''s performance.',
    "SuccessMessageEn"  = 'The challenge galvanized the team. Performance is clearly on the rise.',
    "FailureMessageEn"  = 'The goals were too high. The team feels overwhelmed and demotivated.'
WHERE "Slug" = 'ambitious-goals';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Professional Training',
    "DescriptionEn"     = 'Send the team to training to develop new skills.',
    "SuccessMessageEn"  = 'The training was a success. The team has levelled up and feels valued.',
    "FailureMessageEn"  = 'The training didn''t match actual needs. The team feels frustrated.'
WHERE "Slug" = 'professional-training';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Exceptional Bonus',
    "DescriptionEn"     = 'Award an exceptional bonus to reward the team''s efforts.',
    "SuccessMessageEn"  = 'The bonus was very well received. Motivation is at an all-time high.',
    "FailureMessageEn"  = 'The unequal distribution of the bonus created jealousy within the team.'
WHERE "Slug" = 'exceptional-bonus';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Conflict Mediation',
    "DescriptionEn"     = 'Step in to resolve a simmering conflict between team members.',
    "SuccessMessageEn"  = 'The mediation defused the situation. The atmosphere has noticeably improved.',
    "FailureMessageEn"  = 'Your intervention was poorly received. The conflict has become more entrenched.'
WHERE "Slug" = 'conflict-mediation';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Flexible Remote Work',
    "DescriptionEn"     = 'Implement a flexible remote work policy to improve work-life balance.',
    "SuccessMessageEn"  = 'The team appreciates the flexibility. Motivation rises and turnover drops.',
    "FailureMessageEn"  = 'Isolation is starting to take a toll. Team cohesion has deteriorated.'
WHERE "Slug" = 'flexible-remote-work';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Team Restructuring',
    "DescriptionEn"     = 'Reorganize the teams to optimize complementarity of profiles.',
    "SuccessMessageEn"  = 'The new organization revealed unexpected synergies. Performance is soaring.',
    "FailureMessageEn"  = 'The restructuring sowed confusion. Roles are unclear and productivity is dropping.'
WHERE "Slug" = 'team-restructuring';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Individual Feedback',
    "DescriptionEn"     = 'Run one-on-one interviews to provide personalized feedback to each team member.',
    "SuccessMessageEn"  = 'The interviews were greatly appreciated. Everyone leaves with a clear picture of their areas for improvement.',
    "FailureMessageEn"  = 'Your feedback was perceived as criticism. Some members feel undervalued.'
WHERE "Slug" = 'individual-feedback';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Team Break',
    "DescriptionEn"     = 'Organize a team lunch or group activity to strengthen bonds.',
    "SuccessMessageEn"  = 'This relaxing moment strengthened relationships. The atmosphere is excellent.',
    "FailureMessageEn"  = 'The activity didn''t appeal to everyone. Some people felt left out.'
WHERE "Slug" = 'collective-break';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Crisis Management',
    "DescriptionEn"     = 'Take charge in a critical situation and guide the team through it.',
    "SuccessMessageEn"  = 'Your leadership under pressure impressed the team. Trust has been reinforced.',
    "FailureMessageEn"  = 'The chaotic crisis response made things worse. Stress is at an all-time high.'
WHERE "Slug" = 'crisis-management';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Quick Wins',
    "DescriptionEn"     = 'Identify and celebrate small victories to rebuild the team''s momentum.',
    "SuccessMessageEn"  = 'Celebrating small wins restored the team''s confidence. The dynamic is positive.',
    "FailureMessageEn"  = 'The highlighted wins felt artificial. The team feels patronized.'
WHERE "Slug" = 'quick-wins';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'One-on-One',
    "DescriptionEn"     = 'Schedule regular one-on-one meetings with each team member.',
    "SuccessMessageEn"  = 'One-on-ones strengthened individual trust. Everyone feels heard and supported.',
    "FailureMessageEn"  = 'The interviews surfaced deep frustrations you were not ready to deal with.'
WHERE "Slug" = 'one-on-one';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Skills Audit',
    "DescriptionEn"     = 'Assess the team''s current skills to identify gaps and strengths.',
    "SuccessMessageEn"  = 'The audit revealed hidden talents and clear improvement areas. The team feels better guided.',
    "FailureMessageEn"  = 'The audit was experienced as a judgment. Some members feel called into question.'
WHERE "Slug" = 'skills-audit';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Team Charter',
    "DescriptionEn"     = 'Co-create a charter defining the team''s values, rules, and commitments.',
    "SuccessMessageEn"  = 'The co-created charter establishes a strong shared framework. The team refers to it naturally.',
    "FailureMessageEn"  = 'The co-creation process crystallized disagreements. The result lacks consensus.'
WHERE "Slug" = 'team-charter';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Recognition Program',
    "DescriptionEn"     = 'Implement a formal system to recognize individual efforts and achievements.',
    "SuccessMessageEn"  = 'The recognition program values everyone''s contributions. Motivation has surged.',
    "FailureMessageEn"  = 'The system was perceived as unfair, creating jealousy. Some feel invisible.'
WHERE "Slug" = 'recognition-program';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Mentoring Session',
    "DescriptionEn"     = 'Set up a mentoring program pairing experienced staff with junior colleagues.',
    "SuccessMessageEn"  = 'Mentoring strengthened intergenerational cohesion and boosted junior skills.',
    "FailureMessageEn"  = 'Mentors feel overloaded. The relationship has become a source of stress.'
WHERE "Slug" = 'mentoring-session';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Workspace Reorganization',
    "DescriptionEn"     = 'Redesign workspaces to foster collaboration and well-being.',
    "SuccessMessageEn"  = 'The new workspace is a hit. Creativity and collaboration are on the rise.',
    "FailureMessageEn"  = 'The reorganization disrupted working habits. Productivity is suffering.'
WHERE "Slug" = 'workspace-reorganization';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Annual Review',
    "DescriptionEn"     = 'Conduct annual performance appraisal interviews.',
    "SuccessMessageEn"  = 'Well-conducted reviews clarified expectations and reinforced engagement.',
    "FailureMessageEn"  = 'The evaluations were perceived as unfair. Resentment is setting in.'
WHERE "Slug" = 'performance-review';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Cross-Team Project',
    "DescriptionEn"     = 'Launch a collaborative project involving multiple teams.',
    "SuccessMessageEn"  = 'Cross-team collaboration was fruitful. New synergies have emerged.',
    "FailureMessageEn"  = 'Friction between teams paralyzed the project. Frustration is widespread.'
WHERE "Slug" = 'cross-team-project';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Wellness Program',
    "DescriptionEn"     = 'Launch a workplace wellness program (sports, mindfulness, relaxation spaces).',
    "SuccessMessageEn"  = 'The wellness program transformed the atmosphere. Stress drops and motivation rises.',
    "FailureMessageEn"  = 'The program was perceived as superficial. The real issues remain unaddressed.'
WHERE "Slug" = 'wellness-program';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Job Rotation',
    "DescriptionEn"     = 'Offer job rotations to develop versatility and break up routine.',
    "SuccessMessageEn"  = 'Rotation revealed hidden talents and broke down silos. The team gains in flexibility.',
    "FailureMessageEn"  = 'Forced rotation disrupted teams. Productivity drops during the transition period.'
WHERE "Slug" = 'job-rotation';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Internal Communication Plan',
    "DescriptionEn"     = 'Structure internal communication to reduce misunderstandings and align the team.',
    "SuccessMessageEn"  = 'The communication plan clarified information flows. Misunderstandings are rare.',
    "FailureMessageEn"  = 'Too much communication created information overload. The team feels overwhelmed.'
WHERE "Slug" = 'internal-communication';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Delegation Plan',
    "DescriptionEn"     = 'Delegate key responsibilities to develop the team''s autonomy and confidence.',
    "SuccessMessageEn"  = 'Well-framed delegation empowered the team. Members gain in autonomy and confidence.',
    "FailureMessageEn"  = 'Delegation without a safety net put some members in difficulty. Costly mistakes were made.'
WHERE "Slug" = 'delegation-plan';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Team Retrospective',
    "DescriptionEn"     = 'Organize a retrospective to collectively analyze successes and areas for improvement.',
    "SuccessMessageEn"  = 'The retrospective identified concrete improvements. The team feels heard.',
    "FailureMessageEn"  = 'The retrospective turned into a score-settling session. Tensions resurfaced.'
WHERE "Slug" = 'team-retrospective';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Peer Review',
    "DescriptionEn"     = 'Implement a mutual evaluation system between colleagues to enrich feedback.',
    "SuccessMessageEn"  = 'Peer evaluations provided rich and nuanced feedback. Progress is visible.',
    "FailureMessageEn"  = 'The evaluation system generated interpersonal tensions. Trust has eroded.'
WHERE "Slug" = 'peer-review';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Agile Transformation',
    "DescriptionEn"     = 'Introduce Agile methods to gain flexibility and responsiveness.',
    "SuccessMessageEn"  = 'Adopting Agile streamlined processes. The team gains in autonomy and efficiency.',
    "FailureMessageEn"  = 'The poorly supported Agile transformation created confusion. Old reference points disappeared without replacement.'
WHERE "Slug" = 'agile-transformation';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Talent Retention Plan',
    "DescriptionEn"     = 'Implement a retention plan to keep your best people.',
    "SuccessMessageEn"  = 'The retention plan convinced key talents to stay. Team stability is secured.',
    "FailureMessageEn"  = 'The plan was deemed insufficient by the targeted talents. Some chose to leave anyway.'
WHERE "Slug" = 'talent-retention-plan';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Strategic Retreat',
    "DescriptionEn"     = 'Organize an offsite seminar to redefine vision and strategy.',
    "SuccessMessageEn"  = 'The seminar gave the team''s work renewed meaning. A shared vision unites the group.',
    "FailureMessageEn"  = 'The seminar was seen as a waste of time by the team. Scepticism is setting in.'
WHERE "Slug" = 'strategic-retreat';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Process Optimization',
    "DescriptionEn"     = 'Analyze and streamline internal processes to improve efficiency.',
    "SuccessMessageEn"  = 'The new processes eliminated friction. Productivity climbs significantly.',
    "FailureMessageEn"  = 'Excessive rationalization removed important safeguards. Errors are multiplying.'
WHERE "Slug" = 'process-optimization';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Leadership Development',
    "DescriptionEn"     = 'Identify and train future leaders within your team.',
    "SuccessMessageEn"  = 'Emerging leaders are injecting new energy. The team gains in maturity.',
    "FailureMessageEn"  = 'Competition between leadership candidates created tensions. Cohesion has been weakened.'
WHERE "Slug" = 'leadership-development';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Post-Merger Integration',
    "DescriptionEn"     = 'Lead the cultural and operational integration following a team merger.',
    "SuccessMessageEn"  = 'The controlled integration created an entity stronger than the sum of its parts.',
    "FailureMessageEn"  = 'Incompatible cultures generated deep friction. Turnover is exploding.'
WHERE "Slug" = 'merger-integration';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Remote-First Policy',
    "DescriptionEn"     = 'Make remote work the norm and restructure the organization accordingly.',
    "SuccessMessageEn"  = 'The Remote-First policy broadened the talent pool and improved satisfaction.',
    "FailureMessageEn"  = 'Widespread isolation tore apart the team''s social fabric. Collaboration has collapsed.'
WHERE "Slug" = 'remote-first-policy';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Culture Revamp',
    "DescriptionEn"     = 'Engage in a deep transformation of the company culture.',
    "SuccessMessageEn"  = 'The new culture unites and attracts. The team is proud to belong to this organization.',
    "FailureMessageEn"  = 'The forced cultural transformation triggered mass rejection. Departures are multiplying.'
WHERE "Slug" = 'culture-revamp';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Succession Planning',
    "DescriptionEn"     = 'Anticipate key departures by preparing internal successors.',
    "SuccessMessageEn"  = 'Preparing successors ensures continuity. The organization gains in resilience.',
    "FailureMessageEn"  = 'The succession plan created destructive internal rivalries.'
WHERE "Slug" = 'succession-planning';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Innovation Lab',
    "DescriptionEn"     = 'Create a dedicated space for experimentation and innovation.',
    "SuccessMessageEn"  = 'The innovation lab generates concrete ideas. The team is galvanized by this creative freedom.',
    "FailureMessageEn"  = 'The lab is perceived as a gimmick disconnected from real challenges. Frustration accumulates.'
WHERE "Slug" = 'innovation-lab';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Executive Coaching',
    "DescriptionEn"     = 'Engage an external coach to support your leadership development.',
    "SuccessMessageEn"  = 'Coaching revealed blind spots and strengthened your managerial posture.',
    "FailureMessageEn"  = 'Coaching raised questions you were not ready to face.'
WHERE "Slug" = 'executive-coaching';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Zero Tolerance Policy',
    "DescriptionEn"     = 'Adopt a zero-tolerance policy towards toxic behaviour.',
    "SuccessMessageEn"  = 'The clear policy cleaned up the work environment. Toxic behaviour has disappeared.',
    "FailureMessageEn"  = 'Excessive rigidity created a climate of fear. Creativity and initiative have collapsed.'
WHERE "Slug" = 'zero-tolerance';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Autonomy Framework',
    "DescriptionEn"     = 'Define a clear framework to empower the team and delegate more.',
    "SuccessMessageEn"  = 'Structured autonomy unlocked the team''s potential. Empowerment is paying off.',
    "FailureMessageEn"  = 'Without sufficient support, autonomy generated anxiety and costly mistakes.'
WHERE "Slug" = 'autonomy-framework';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Purpose-Driven Strategy',
    "DescriptionEn"     = 'Redefine the mission and values to restore meaning to work.',
    "SuccessMessageEn"  = 'The purpose-driven strategy transcended the team. Engagement has reached an exceptional level.',
    "FailureMessageEn"  = 'The discourse on meaning rang hollow. Cynicism has taken a lasting hold.'
WHERE "Slug" = 'purpose-driven-strategy';
 
UPDATE "Cards" SET
    "DisplayNameEn"     = 'Predictive HR Analytics',
    "DescriptionEn"     = 'Use data to anticipate HR risks and optimize managerial decisions.',
    "SuccessMessageEn"  = 'Data insights made it possible to anticipate and prevent several HR crises.',
    "FailureMessageEn"  = 'Over-quantification dehumanized management. The team feels reduced to numbers.'
WHERE "Slug" = 'predictive-analytics';
""");

          #endregion

          #region Events

            migrationBuilder.Sql("""
UPDATE "Events" SET
    "EventNameEn" = 'Post-Meeting Tensions',
    "MessageEn"   = 'The meeting surfaced unspoken issues that are now resurfacing.'
WHERE "EventNameFr" = 'Tensions post-réunion';
 
UPDATE "Events" SET
    "EventNameEn" = 'Goal Overachievement',
    "MessageEn"   = 'The ambitious goals created an unexpected dynamic.'
WHERE "EventNameFr" = 'Dépassement d''objectifs';
 
UPDATE "Events" SET
    "EventNameEn" = 'Unachievable Targets',
    "MessageEn"   = 'The team realizes the set goals are unrealistic.'
WHERE "EventNameFr" = 'Objectifs inatteignables';
 
UPDATE "Events" SET
    "EventNameEn" = 'New Skills in Action',
    "MessageEn"   = 'The skills acquired in training are starting to bear fruit.'
WHERE "EventNameFr" = 'Application des nouvelles compétences';
 
UPDATE "Events" SET
    "EventNameEn" = 'Resistance to Post-Training Change',
    "MessageEn"   = 'Some members are reluctant to apply the new methods.'
WHERE "EventNameFr" = 'Résistance au changement post-formation';
 
UPDATE "Events" SET
    "EventNameEn" = 'Bonus-Related Jealousy',
    "MessageEn"   = 'Rumours about unequal bonuses are circulating within the team.'
WHERE "EventNameFr" = 'Jalousies liées à la prime';
 
UPDATE "Events" SET
    "EventNameEn" = 'Post-Break Energy Boost',
    "MessageEn"   = 'The team break recharged everyone''s batteries.'
WHERE "EventNameFr" = 'Regain d''énergie post-pause';
 
UPDATE "Events" SET
    "EventNameEn" = 'Resistance to Agile Transformation',
    "MessageEn"   = 'Resistance to change resurfaces several weeks after the launch.'
WHERE "EventNameFr" = 'Résistance à la transformation Agile';
 
UPDATE "Events" SET
    "EventNameEn" = 'Full Agile Adoption',
    "MessageEn"   = 'The team has fully integrated Agile practices. Results are following.'
WHERE "EventNameFr" = 'Adoption complète de l''Agile';
 
UPDATE "Events" SET
    "EventNameEn" = 'Departure Despite Retention Plan',
    "MessageEn"   = 'A key talent announces their resignation despite the retention plan.'
WHERE "EventNameFr" = 'Départ malgré le plan de rétention';
 
UPDATE "Events" SET
    "EventNameEn" = 'Rivalry Between Successors',
    "MessageEn"   = 'Competition between identified candidates is creating tensions that harm cohesion.'
WHERE "EventNameFr" = 'Rivalités entre successeurs';
 
UPDATE "Events" SET
    "EventNameEn" = 'Concrete Innovation from the Lab',
    "MessageEn"   = 'An idea from the innovation lab has been approved and put into production.'
WHERE "EventNameFr" = 'Innovation concrète issue du lab';
 
UPDATE "Events" SET
    "EventNameEn" = 'Predictive Insights Confirmed',
    "MessageEn"   = 'HR predictions proved accurate, preventing a turnover crisis.'
WHERE "EventNameFr" = 'Insights prédictifs confirmés';
 
UPDATE "Events" SET
    "EventNameEn" = 'Rejection of Quantification',
    "MessageEn"   = 'The team expresses its discomfort with an overly analytical management style.'
WHERE "EventNameFr" = 'Rejet de la quantification';
 
UPDATE "Events" SET
    "EventNameEn" = 'Conflict Recurrence',
    "MessageEn"   = 'The conflict seemed resolved but resurfaced with greater intensity.'
WHERE "EventNameFr" = 'Récidive du conflit';
 
UPDATE "Events" SET
    "EventNameEn" = 'Stronger Cohesion Post-Mediation',
    "MessageEn"   = 'The difficult episode ultimately united the team around more open communication.'
WHERE "EventNameFr" = 'Cohésion renforcée post-médiation';
 
UPDATE "Events" SET
    "EventNameEn" = 'Progressive Isolation',
    "MessageEn"   = 'Several members report a growing sense of isolation since switching to remote work.'
WHERE "EventNameFr" = 'Isolement progressif';
 
UPDATE "Events" SET
    "EventNameEn" = 'Rising Productivity',
    "MessageEn"   = 'Without office interruptions, several members have seen their productivity soar.'
WHERE "EventNameFr" = 'Productivité en hausse';
 
UPDATE "Events" SET
    "EventNameEn" = 'Persistent Role Confusion',
    "MessageEn"   = 'Weeks after the restructuring, responsibility boundaries remain unclear.'
WHERE "EventNameFr" = 'Confusion des rôles persistante';
 
UPDATE "Events" SET
    "EventNameEn" = 'Unexpected Synergies',
    "MessageEn"   = 'New pairings created by the restructuring have generated highly productive collaborations.'
WHERE "EventNameFr" = 'Synergies inattendues';
 
UPDATE "Events" SET
    "EventNameEn" = 'Demotivation Following Feedback',
    "MessageEn"   = 'Poorly received feedback caused visible disengagement in a key member.'
WHERE "EventNameFr" = 'Démotivation suite au feedback';
 
UPDATE "Events" SET
    "EventNameEn" = 'Accelerated Progress',
    "MessageEn"   = 'Clearly defined improvement areas enabled rapid skill development.'
WHERE "EventNameFr" = 'Progression accélérée';
 
UPDATE "Events" SET
    "EventNameEn" = 'Psychological Aftermath of the Crisis',
    "MessageEn"   = 'The pressure endured during the crisis is leaving marks. Several members show signs of burnout.'
WHERE "EventNameFr" = 'Séquelles psychologiques de la crise';
 
UPDATE "Events" SET
    "EventNameEn" = 'Leadership Acknowledged',
    "MessageEn"   = 'Your crisis management boosted your credibility. The team trusts you more.'
WHERE "EventNameFr" = 'Leadership reconnu';
 
UPDATE "Events" SET
    "EventNameEn" = 'Mentor Overload',
    "MessageEn"   = 'Mentor colleagues feel overwhelmed by this additional responsibility.'
WHERE "EventNameFr" = 'Surcharge des mentors';
 
UPDATE "Events" SET
    "EventNameEn" = 'Visible Skill Improvement',
    "MessageEn"   = 'Mentored junior staff are progressing at a remarkable pace. Work quality is improving.'
WHERE "EventNameFr" = 'Montée en compétences visible';
 
UPDATE "Events" SET
    "EventNameEn" = 'Post-Reorganization Disorientation',
    "MessageEn"   = 'The team struggles to find its footing in the new spaces. Routine has been disrupted.'
WHERE "EventNameFr" = 'Désorientation post-réorganisation';
 
UPDATE "Events" SET
    "EventNameEn" = 'Spontaneous Collaboration on the Rise',
    "MessageEn"   = 'The new spaces encourage informal exchanges. Ideas emerge naturally.'
WHERE "EventNameFr" = 'Collaboration spontanée en hausse';
 
UPDATE "Events" SET
    "EventNameEn" = 'Disputed Evaluations',
    "MessageEn"   = 'Several members are contesting their evaluations with HR. The climate is tense.'
WHERE "EventNameFr" = 'Contestation des évaluations';
 
UPDATE "Events" SET
    "EventNameEn" = 'Better-Understood Objectives',
    "MessageEn"   = 'Following the reviews, members have a clearer vision of their goals. Performance improves.'
WHERE "EventNameFr" = 'Objectifs mieux compris';
 
UPDATE "Events" SET
    "EventNameEn" = 'Inter-Team Friction',
    "MessageEn"   = 'Disagreements on working methods between teams are slowing project progress.'
WHERE "EventNameFr" = 'Frictions inter-équipes';
 
UPDATE "Events" SET
    "EventNameEn" = 'Best Practices Shared',
    "MessageEn"   = 'The cross-team project spread best practices throughout the organization.'
WHERE "EventNameFr" = 'Meilleures pratiques partagées';
 
UPDATE "Events" SET
    "EventNameEn" = 'Program Perceived as Cosmetic',
    "MessageEn"   = 'The wellness program is seen as a facade that doesn''t address the real causes of stress.'
WHERE "EventNameFr" = 'Programme perçu comme cosmétique';
 
UPDATE "Events" SET
    "EventNameEn" = 'Significant Drop in Absenteeism',
    "MessageEn"   = 'The wellness program had a measurable impact on employee health. Absenteeism drops.'
WHERE "EventNameFr" = 'Baisse significative de l''absentéisme';
 
UPDATE "Events" SET
    "EventNameEn" = 'Shared Vision Under Pressure',
    "MessageEn"   = 'The vision defined at the seminar is being tested by operational reality. Adjustments are needed.'
WHERE "EventNameFr" = 'Vision partagée mise à l''épreuve';
 
UPDATE "Events" SET
    "EventNameEn" = 'Renewed Strategic Commitment',
    "MessageEn"   = 'Decisions made at the seminar are being applied with conviction. Alignment is strong.'
WHERE "EventNameFr" = 'Engagement stratégique renouvelé';
 
UPDATE "Events" SET
    "EventNameEn" = 'Resistance to New Processes',
    "MessageEn"   = 'Part of the team refuses to adopt new procedures, deemed too rigid.'
WHERE "EventNameFr" = 'Résistance aux nouveaux processus';
 
UPDATE "Events" SET
    "EventNameEn" = 'Measurable Productivity Gains',
    "MessageEn"   = 'The new processes reduced processing time by 20%. The results speak for themselves.'
WHERE "EventNameFr" = 'Gains de productivité mesurables';
 
UPDATE "Events" SET
    "EventNameEn" = 'Jealousy Among Leadership Candidates',
    "MessageEn"   = 'Competition between identified profiles creates tensions that harm cohesion.'
WHERE "EventNameFr" = 'Jalousies entre candidats leaders';
 
UPDATE "Events" SET
    "EventNameEn" = 'Effective Distributed Leadership',
    "MessageEn"   = 'New leaders are taking relevant initiatives. The management load is better distributed.'
WHERE "EventNameFr" = 'Leadership distribué efficace';
 
UPDATE "Events" SET
    "EventNameEn" = 'Post-Merger Culture Clash',
    "MessageEn"   = 'Differences in working culture between the two entities create deep misunderstandings.'
WHERE "EventNameFr" = 'Choc culturel post-fusion';
 
UPDATE "Events" SET
    "EventNameEn" = 'Post-Merger Synergies Realized',
    "MessageEn"   = 'Complementarity between the two teams yields results neither could have achieved alone.'
WHERE "EventNameFr" = 'Synergies post-fusion concrétisées';
 
UPDATE "Events" SET
    "EventNameEn" = 'Remote Onboarding Difficulties',
    "MessageEn"   = 'New hires struggle to integrate without physical presence. The learning curve is longer.'
WHERE "EventNameFr" = 'Difficultés d''onboarding à distance';
 
UPDATE "Events" SET
    "EventNameEn" = 'Expanded Talent Attraction',
    "MessageEn"   = 'The Remote-First policy attracts profiles previously out of geographical reach. Hiring accelerates.'
WHERE "EventNameFr" = 'Attraction de talents élargies';
 
UPDATE "Events" SET
    "EventNameEn" = 'Old Habits Resisting',
    "MessageEn"   = 'Ingrained behaviours resist the new culture despite efforts made.'
WHERE "EventNameFr" = 'Résistance des anciennes habitudes';
 
UPDATE "Events" SET
    "EventNameEn" = 'New Culture as Competitive Advantage',
    "MessageEn"   = 'The reputation of the new culture attracts talent and retains the best.'
WHERE "EventNameFr" = 'Nouvelle culture comme avantage concurrentiel';
 
UPDATE "Events" SET
    "EventNameEn" = 'Deep Self-Questioning',
    "MessageEn"   = 'Coaching raised identity questions that temporarily destabilize your posture.'
WHERE "EventNameFr" = 'Remise en question profonde';
 
UPDATE "Events" SET
    "EventNameEn" = 'Visible Shift in Management Style',
    "MessageEn"   = 'The team notices a positive evolution in your management style. Trust is growing.'
WHERE "EventNameFr" = 'Changement de posture managériale visible';
 
UPDATE "Events" SET
    "EventNameEn" = 'Departure Following Zero-Tolerance Policy',
    "MessageEn"   = 'A borderline member chose to leave rather than change their behaviour.'
WHERE "EventNameFr" = 'Départ suite à la politique zéro tolérance';
 
UPDATE "Events" SET
    "EventNameEn" = 'Healthier Work Environment',
    "MessageEn"   = 'The team breathes easier since toxic behaviours disappeared. Psychological safety is back.'
WHERE "EventNameFr" = 'Climat de travail assaini';
 
UPDATE "Events" SET
    "EventNameEn" = 'Drift Without Guardrails',
    "MessageEn"   = 'Without sufficient oversight, some autonomous decisions led to costly mistakes.'
WHERE "EventNameFr" = 'Dérive sans garde-fous';
 
UPDATE "Events" SET
    "EventNameEn" = 'Bottom-Up Innovation',
    "MessageEn"   = 'The autonomy granted has unleashed creativity. Relevant initiatives are emerging from the field.'
WHERE "EventNameFr" = 'Innovation bottom-up';
 
UPDATE "Events" SET
    "EventNameEn" = 'Cynicism Toward Purpose Discourse',
    "MessageEn"   = 'The purpose-driven strategy is perceived as internal marketing. Cynicism is settling in.'
WHERE "EventNameFr" = 'Cynisme face au discours sur le sens';
 
UPDATE "Events" SET
    "EventNameEn" = 'Exceptional Engagement',
    "MessageEn"   = 'Members who buy into the mission demonstrate commitment that exceeds all expectations.'
WHERE "EventNameFr" = 'Engagement exceptionnel';
 
UPDATE "Events" SET
    "EventNameEn" = 'Momentum Fizzled Out',
    "MessageEn"   = 'The enthusiasm from quick wins has faded. The team is waiting for more substantial challenges.'
WHERE "EventNameFr" = 'Effet soufflé retombé';
 
UPDATE "Events" SET
    "EventNameEn" = 'Self-Sustaining Positive Dynamic',
    "MessageEn"   = 'Celebrated successes triggered a virtuous cycle. The team naturally pushes itself further.'
WHERE "EventNameFr" = 'Dynamique positive auto-entretenue';
 
UPDATE "Events" SET
    "EventNameEn" = 'Frustrations Surfaced in One-on-Ones',
    "MessageEn"   = 'Individual meetings brought up deep dissatisfaction you did not anticipate.'
WHERE "EventNameFr" = 'Frustrations remontées en one-on-one';
 
UPDATE "Events" SET
    "EventNameEn" = 'Stronger Manager-Employee Bond',
    "MessageEn"   = 'Regular one-on-ones built lasting trust. Individual engagement is progressing.'
WHERE "EventNameFr" = 'Lien manager-collaborateur renforcé';
 
UPDATE "Events" SET
    "EventNameEn" = 'Post-Audit Inferiority Complex',
    "MessageEn"   = 'Some poorly evaluated members feel devalued and lose confidence.'
WHERE "EventNameFr" = 'Complexe d''infériorité post-audit';
 
UPDATE "Events" SET
    "EventNameEn" = 'Targeted Training Pays Off',
    "MessageEn"   = 'Gaps identified in the audit enabled focused training that quickly delivers results.'
WHERE "EventNameFr" = 'Formation ciblée efficace';
 
UPDATE "Events" SET
    "EventNameEn" = 'Charter Not Respected',
    "MessageEn"   = 'Despite collective drafting, the charter is not being followed. It remains a dead letter.'
WHERE "EventNameFr" = 'Charte non respectée';
 
UPDATE "Events" SET
    "EventNameEn" = 'Consolidated Common Reference',
    "MessageEn"   = 'The team spontaneously refers to the charter to settle disagreements. It becomes a real governance tool.'
WHERE "EventNameFr" = 'Référentiel commun consolidé';
 
UPDATE "Events" SET
    "EventNameEn" = 'Feeling of Unfairness in Recognition',
    "MessageEn"   = 'Members who feel their contributions are undervalued express their dissatisfaction openly.'
WHERE "EventNameFr" = 'Sentiment d''injustice dans la reconnaissance';
 
UPDATE "Events" SET
    "EventNameEn" = 'Healthy Competition Among Members',
    "MessageEn"   = 'The recognition program stimulated positive emulation. Work quality is improving.'
WHERE "EventNameFr" = 'Compétition saine entre membres';
 
UPDATE "Events" SET
    "EventNameEn" = 'Expertise Loss During Rotation',
    "MessageEn"   = 'Rotation moved experts away from their preferred domains. Quality temporarily suffers.'
WHERE "EventNameFr" = 'Perte d''expertise pendant la rotation';
 
UPDATE "Events" SET
    "EventNameEn" = 'Increased Versatility, Broken Silos',
    "MessageEn"   = 'Members better understand their colleagues'' constraints. Collaboration improves naturally.'
WHERE "EventNameFr" = 'Polyvalence accrue et silos brisés';
 
UPDATE "Events" SET
    "EventNameEn" = 'Information Overload',
    "MessageEn"   = 'The structured information flow has become too dense. The team struggles to separate essential from peripheral.'
WHERE "EventNameFr" = 'Surcharge informationnelle';
 
UPDATE "Events" SET
    "EventNameEn" = 'Sharp Drop in Misunderstandings',
    "MessageEn"   = 'Errors caused by miscommunication dropped significantly. Collective efficiency improves.'
WHERE "EventNameFr" = 'Malentendus en forte baisse';
 
UPDATE "Events" SET
    "EventNameEn" = 'Feeling of Abandonment',
    "MessageEn"   = 'Some delegated members experience delegation as the manager stepping back. They feel left on their own.'
WHERE "EventNameFr" = 'Sentiment d''abandon';
 
UPDATE "Events" SET
    "EventNameEn" = 'Successful Responsibility Takeover',
    "MessageEn"   = 'Delegated members fully took ownership of their new responsibilities. Trust is mutual.'
WHERE "EventNameFr" = 'Montée en responsabilité réussie';
 
UPDATE "Events" SET
    "EventNameEn" = 'Retrospective Without Follow-Through',
    "MessageEn"   = 'Actions identified in the retrospective are not being implemented. The process''s credibility is eroding.'
WHERE "EventNameFr" = 'Rétrospective sans suite';
 
UPDATE "Events" SET
    "EventNameEn" = 'Continuous Improvement Underway',
    "MessageEn"   = 'Changes from the retrospective produced visible results. The team believes in the process.'
WHERE "EventNameFr" = 'Amélioration continue enclenchée';
 
UPDATE "Events" SET
    "EventNameEn" = 'Post-Evaluation Grudges',
    "MessageEn"   = 'Poorly worded peer feedback created lasting grudges. The atmosphere deteriorated.'
WHERE "EventNameFr" = 'Rancune post-évaluation';
 
UPDATE "Events" SET
    "EventNameEn" = 'High-Quality Feedback',
    "MessageEn"   = 'Peer evaluations provided more concrete and actionable feedback than managerial reviews.'
WHERE "EventNameFr" = 'Feedbacks de haute qualité';
""");

          #endregion
          
          #endregion
          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventNameEn",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "MessageEn",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "DisplayNameEn",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "SuccessMessageEn",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "FailureMessageEn",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "MessageFr",
                table: "Events",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "EventNameFr",
                table: "Events",
                newName: "EventName");

            migrationBuilder.RenameColumn(
                name: "SuccessMessageFr",
                table: "Cards",
                newName: "SuccessMessage");

            migrationBuilder.RenameColumn(
                name: "FailureMessageFr",
                table: "Cards",
                newName: "FailureMessage");

            migrationBuilder.RenameColumn(
                name: "DisplayNameFr",
                table: "Cards",
                newName: "DisplayName");

            migrationBuilder.RenameColumn(
                name: "DescriptionFr",
                table: "Cards",
                newName: "Description");
        }
    }
}
