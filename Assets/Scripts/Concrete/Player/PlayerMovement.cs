using UnityEngine;
using Abstract.Movement;

namespace Concrete.Player
{
    public class PlayerMovement : IMovingService
    {
        Rigidbody2D _rb;
        
        public PlayerMovement(Rigidbody2D rb)
        {
            _rb=rb;
            
        }

        public void Movement(float speed, float inputVerticalValue)
        {
            _rb.velocity = new Vector2(0f,inputVerticalValue*Time.deltaTime*speed);
        }

        

        
    }
}
