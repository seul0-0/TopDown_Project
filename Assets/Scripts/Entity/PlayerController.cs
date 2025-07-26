using UnityEngine;

namespace Entity
{
    public class PlayerController : BaseController
    {
        private new void Update()
        {
            var moveX = Input.GetAxisRaw("Horizontal");
            var moveY = Input.GetAxisRaw("Vertical");
            movementDirection = new Vector2(moveX, moveY).normalized;

            Vector3 move = new Vector3(moveX, moveY, 0).normalized;
            transform.position += move * (Time.deltaTime * 5f);

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }
}
