namespace Assets.Scripts.Player
{
    public interface IPlayerMediator
    {
        void TryMove();

        void TryJump();

        void TryFall();

        void TryRotate();

        void TryShoot();
    }
}