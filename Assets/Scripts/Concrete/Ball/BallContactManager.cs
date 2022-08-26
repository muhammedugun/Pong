using System;
using UnityEngine;
using TMPro;

namespace Concrete.Ball
{
    public class BallContactManager : MonoBehaviour
    {

        BounceManager _bounceManager;
        GoalManager _goalManager;
        private Rigidbody2D rb;
        [SerializeField] GameObject scoreText;
        


        BallBegin _ballBegin;


        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            _bounceManager = GameObject.Find("Ball(Clone)").GetComponent<BounceManager>();
            _goalManager = GameObject.Find("GameControl").GetComponent<GoalManager>();

            _ballBegin = GameObject.Find("GameControl").GetComponent<BallBegin>();
            scoreText = GameObject.Find("Score");
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "Player" || col.gameObject.tag == "AI" || col.gameObject.tag == "Player2")
            {
                if (col.gameObject.tag == "Player")
                {
                    _bounceManager.Bounce(rb, -Math.Abs(_bounceManager.ballBounceSpeedX), col);

                }

                else
                {
                    _bounceManager.Bounce(rb, Math.Abs(_bounceManager.ballBounceSpeedX), col);
                }
                col.gameObject.GetComponent<Animator>().SetTrigger("BallContact");
                gameObject.GetComponent<AudioSource>().Play();


            }

            if (col.gameObject.tag == "Goal")
            {
                if (col.gameObject.name == "Right")

                    _goalManager._leftScore++;
                else
                    _goalManager._rightScore++;

                scoreText.GetComponent<TextMeshProUGUI>().SetText(_goalManager._leftScore + "		" + _goalManager._rightScore);
                _goalManager.DestroyBall(gameObject, ref _ballBegin.getStarted);


            }


        }


    }

}
