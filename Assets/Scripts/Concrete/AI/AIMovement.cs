using UnityEngine;

namespace Concrete.AI
{
    public class AIMovement
    {
        private GameObject _ball;

        internal void Movement(GameObject ai, float speed)
        {
            _ball = GameObject.Find("Ball(Clone)");
            ai.GetComponent<Rigidbody2D>().velocity=new Vector2(0f,(_ball.transform.position.y - ai.transform.position.y)*speed*Time.deltaTime);
            
        }

    }
    

}
