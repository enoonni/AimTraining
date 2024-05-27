namespace Gameplay.GameMode
{
    public class GameModeSurvival : IGameModeSelector
    {
        private TargetGenerator _targetGenerator;
        public GameModeSurvival(TargetGenerator targetGenerator)
        {
            _targetGenerator = targetGenerator;
        }

        public void PlayGameMode()
        {

        }
    }
}



