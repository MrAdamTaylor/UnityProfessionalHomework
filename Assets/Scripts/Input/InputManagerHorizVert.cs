using UnityEngine;

namespace ShootEmUp
{
    public sealed class InputManagerHorizVert : InputManager
    {
        public float VerticalDirection { get; private set; }
        
        private void Update()
        {
            CheckKeyCode();
        }
        
        public override void CheckKeyCode()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _playerController._fireRequired = true;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                HorizontalDirection = -1;
                Debug.Log("Движемся влево");
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                HorizontalDirection = 1;
                Debug.Log("Движемся вправо");
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                VerticalDirection = 1;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                VerticalDirection = -1;
            }
            else
            {
                HorizontalDirection = 0;
                VerticalDirection = 0;
            }
        }
        private void FixedUpdate()
        {
            //character.GetComponent<MoveComponent>().MoveByRigidbodyVelocity(new Vector2(this.HorizontalDirection, 0) * Time.fixedDeltaTime);
            character.GetComponent<MoveComponent>().MoveByRigidbodyVelocity(new Vector2(HorizontalDirection, VerticalDirection) * Time.fixedDeltaTime);
        }
    }
}