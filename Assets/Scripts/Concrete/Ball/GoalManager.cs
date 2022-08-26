
using UnityEngine;
using Concrete.AI;

namespace Concrete.Ball
{
    public class GoalManager : MonoBehaviour
    {
       internal int _rightScore, _leftScore;
       internal void DestroyBall(GameObject _gameObject, ref bool isBegin)
       {
            Destroy(_gameObject);
            isBegin=true;
            if(GameObject.FindGameObjectWithTag("AI"))
            {
                GameObject.FindGameObjectWithTag("AI").GetComponent<AIManager>().enabled=false;
       }
            }
            
         
    }
}

