using System.Collections;
using UnityEngine;

namespace Concrete.Ball
{
    public class BounceManager : MonoBehaviour
    {

        bool test;
        [SerializeField] internal float ballBounceSpeedX=500f, ballBounceSpeedY=187.5f;

        internal void Bounce(Rigidbody2D rb, float _ballBounceSpeedX, Collision2D col)
        {
            rb.velocity = new Vector2(_ballBounceSpeedX * Time.deltaTime, (rb.transform.position.y - col.transform.position.y) * Time.deltaTime * ballBounceSpeedY);
        }

        private void Start()
        {
            StartCoroutine(TemporalVelocity());
        }

        void Update()
        {
            if (test)
            {
                StartCoroutine(TemporalVelocity());
            }
        }

        IEnumerator TemporalVelocity()
        { 
            test=false;
            ballBounceSpeedX += ballBounceSpeedX * 0.1f;
            ballBounceSpeedY += ballBounceSpeedY * 0.1f;
            yield return new WaitForSeconds(15f);
            test=true;
        }




    }
}