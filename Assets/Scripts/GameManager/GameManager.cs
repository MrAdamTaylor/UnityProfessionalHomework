using ShootEmUp;
using UnityEngine;
using UnityEngine.Serialization;
using CharacterController = UnityEngine.CharacterController;

namespace DefaultNamespace
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private InputManager _input;

        [SerializeField] private GameObject _character;
        [SerializeField] private BulletSystem _bulletSystem;
        [SerializeField] private GameFinisher _gameFinisher;
        [SerializeField] private BulletConfig _bulletConfig;
        
        //Тут тоже посредник должен действовать
        private void OnEnable()
        {
            this._character.GetComponent<HitPointsComponent>().hpEmpty += this.OnCharacterDeath;
        }

        private void OnCharacterDeath(GameObject obj) => _gameFinisher.FinishGame();

        private void OnDisable()
        {
            this._character.GetComponent<HitPointsComponent>().hpEmpty -= this.OnCharacterDeath;
        }
        
        //private void OnCharacterDeath(GameObject _) => this.gameManager.FinishGame();

        //private void OnCharactersDeath(GameObject _) => _gameFinisher.FinishGame();

        //TODO - дважды написанный код. Двойник в EnemyAttackAgent 
        public void OnFlyBullet()
        {
            var weapon = this._character.GetComponent<WeaponComponent>();
            _bulletSystem.FlyBulletByArgs(new BulletSystem.Args
            {
                isPlayer = true,
                physicsLayer = (int) this._bulletConfig.physicsLayer,
                color = this._bulletConfig.color,
                damage = this._bulletConfig.damage,
                position = weapon.Position,
                velocity = weapon.Rotation * Vector3.up * this._bulletConfig.speed
            });
        }
        
    }
}