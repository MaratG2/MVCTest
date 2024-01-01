using Game.Models;
using UnityEngine;

namespace Game.Controllers
{
    public class MovementController
    {
        private readonly MovementModel _model;

        public MovementController(MovementModel model)
        {
            _model = model;
        }

        public void Jump(Rigidbody2D rb2d, Transform body, float bodyHalfHeigh = 0.5f, float distanceCheck = 0.01f)
        {
            if (Physics2D.Raycast(new Vector2(body.position.x, body.position.y - bodyHalfHeigh - 0.01f),
                    -Vector2.up, distanceCheck))
                rb2d.AddForce(Vector2.up * _model.jumpStrength);
        }

        public void Move(Rigidbody2D rb2d, float horizontal)
        {
            rb2d.velocity = new Vector2(horizontal * _model.speed, rb2d.velocity.y);
        }
    }
}