using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Diva.Scoring
{
    public class DivaHitWindows : HitWindows
    {
        protected override DifficultyRange[] GetRanges() => new DifficultyRange[]
        {
            new(HitResult.Perfect, 80, 50, 20),
            new(HitResult.Great, 140, 100, 60),
            new(HitResult.Meh, 200, 150, 100),
            new(HitResult.Miss, 300, 350, 400),
        };

        public override bool IsHitResultAllowed(HitResult result) =>
            result switch {
                HitResult.Perfect => true,
                HitResult.Great => true,
                HitResult.Meh => true,
                HitResult.Miss => true,
                _ => false
            };
    }
}
