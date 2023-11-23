using UnityEngine;

namespace ShootEmUp
{
    public sealed class InputManagerHorizontal : InputManager
    {

        private void Update()
        {
            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                characterController._fireRequired = true;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.HorizontalDirection = -1;
                Debug.Log("Движемся влево");
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.HorizontalDirection = 1;
                Debug.Log("Движемся вправо");
            }
            else
            {
                this.HorizontalDirection = 0;
            }*/
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
                this.HorizontalDirection = -1;
                Debug.Log("Движемся влево");
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.HorizontalDirection = 1;
                Debug.Log("Движемся вправо");
            }
            else
            {
                this.HorizontalDirection = 0;
            }
        }

        //TODO - потом надо переместить в отдельный класс, отвечающий за смещение
        private void FixedUpdate()
        {
            character.GetComponent<MoveComponent>().MoveByRigidbodyVelocity(new Vector2(this.HorizontalDirection, 0) * Time.fixedDeltaTime);
        }
    }
}