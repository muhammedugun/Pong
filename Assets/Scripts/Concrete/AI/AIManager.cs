
using UnityEngine;

namespace Concrete.AI
{
    public class AIManager : MonoBehaviour
    {
        AIMovement _aIMovement;
        [SerializeField] private float movementSpeed;
        
        private void Start() 
        {
            _aIMovement=new AIMovement();
        }

        private void FixedUpdate() 
        {
            _aIMovement.Movement(gameObject, movementSpeed);
        }
    }

}
