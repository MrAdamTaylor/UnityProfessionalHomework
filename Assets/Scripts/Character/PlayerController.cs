using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;

namespace ShootEmUp
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private GameManager _gameManager;

        public bool _fireRequired;
        

        private void FixedUpdate()
        {
            if (this._fireRequired)
            {
                _gameManager.OnFlyBullet();
                this._fireRequired = false;
            }
        }
    }
}