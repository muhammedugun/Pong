using Unity.Mathematics;
using UnityEngine;
using Concrete.AI;
using Random = UnityEngine.Random;

namespace Concrete.Ball
{
    public class BallBegin : MonoBehaviour
    {
        [Header("GameObjects")]
        [SerializeField] private GameObject ballPrefab;
        GameObject _ball;

        [Header("Variables")]
        [SerializeField] private float beginSpeed = 300;
        int row = 1;
        internal bool getStarted = true;

        [Header("Physics")]
        Vector2 targetPlayerPosition;

        private void Awake()
        {
            if (GameObject.FindGameObjectWithTag("AI"))
            {
                GameObject.FindGameObjectWithTag("AI").GetComponent<AIManager>().enabled = false; // bug fix amaçlı
            }

        }

        private void FixedUpdate()
        {
            if (getStarted)
            {
                Create();
                Throw();
                if (GameObject.FindGameObjectWithTag("AI"))
                {
                    GameObject.FindGameObjectWithTag("AI").GetComponent<AIManager>().enabled = true;
                }

                getStarted = false;
            }
        }

        void Create()
        {
            row = -1 * row;
            Instantiate(ballPrefab, new Vector3(row * 2, Random.Range(-3, 4), 0f), quaternion.identity);

        }

        void Throw()
        {
            _ball = GameObject.Find("Ball(Clone)");
            if (row != 1)
            {
                targetPlayerPosition = GameObject.Find("Players").transform.GetChild(1).position;
            }
            else
            {
                targetPlayerPosition = GameObject.Find("Players").transform.GetChild(0).position;
            }

            float ratio = (float)(targetPlayerPosition.y - _ball.transform.position.y) / 10.5f;


            _ball.GetComponent<Rigidbody2D>().velocity = new Vector2(-row * Time.deltaTime * beginSpeed, Time.deltaTime * ratio * beginSpeed);



        }



    }

}
