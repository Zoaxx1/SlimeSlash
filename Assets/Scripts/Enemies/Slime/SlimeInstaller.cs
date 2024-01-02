using Assets.Scripts.Enemies.DamagePlayer;
using Assets.Scripts.Enemies.Slimes;
using Assets.Scripts.Enemies.Slimes.Destroyer;
using Assets.Scripts.Enemies.Slimes.General;
using Assets.Scripts.Enemies.Spawner;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    [RequireComponent(typeof(Slime), typeof(SlimeMediator))]
    public class SlimeInstaller : MonoBehaviour
    {
        [Header("Slime Life")]
        [SerializeField] private float _life;

        [Header("Slime Movement")]
        [SerializeField] private float _speed;
        [SerializeField] private bool _useMoventHorizontal;
        [SerializeField] private bool _goToRight;
        private ISlimeMover _slimeMover;

        [Header("Slime Damage To Player")]
        [SerializeField] private bool _useCollisionToDamagePlayer;
        private IDamagePlayer _damagePlayer;

        private void Awake()
        {
            Slime slime = GetComponent<Slime>();
            SlimeMediator slimeMediator = GetComponent<SlimeMediator>();
            SlimeLife slimeLife = GetComponent<SlimeLife>();

            _slimeMover = GetSlimeMover();
            _damagePlayer = GetDamagePlayer();

            slime.Configure(_slimeMover);

            slimeMediator.Configure(
                _life,
                slimeLife,
                _damagePlayer
                );
        }

        private ISlimeMover GetSlimeMover()
        {
            if (_useMoventHorizontal)
            {
                if (_goToRight)
                {
                    return new SlimeMoverRight(_speed);
                }
                return new SlimeMoverLeft(_speed);
            }
            return new SlimeFallen();
        }

        private IDamagePlayer GetDamagePlayer()
        {
            if (_useCollisionToDamagePlayer)
            {
                return GetComponent<CollisionDamagePlayer>();
            }
            return GetComponent<TriggerDamagePlayer>();
        }
    }
}