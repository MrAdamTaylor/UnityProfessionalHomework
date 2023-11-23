using UnityEngine;
using UnityEngine.Serialization;

namespace ShootEmUp
{
    public abstract class InputManager : MonoBehaviour, IInputService
    {
        public float HorizontalDirection { get; protected set; }

        [SerializeField]
        protected GameObject character;

        [FormerlySerializedAs("characterController")] [SerializeField]
        protected PlayerController _playerController;

        public abstract void CheckKeyCode();
    }
}