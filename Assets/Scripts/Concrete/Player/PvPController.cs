using UnityEngine;
using Concrete.Inputs;
using Concrete.Player;


public class PvPController : MonoBehaviour
{
    PlayerMovement _playerMovement1;
    PlayerMovement _playerMovement2;
    private PcInputController _inputService;
    [SerializeField] private Rigidbody2D rigidbodyP1;
    [SerializeField] private Rigidbody2D rigidbodyP2;
    [SerializeField] private float speed;
  
    private void Awake()
    {
        
        _inputService = new PcInputController();
        _playerMovement1 = new PlayerMovement(rigidbodyP1);
        _playerMovement2 = new PlayerMovement(rigidbodyP2);
    }

    void Update()
    {
        _inputService.InputControlP1();
        _inputService.InputControlP2();
    }
    private void FixedUpdate()
    {
        _playerMovement1.Movement(speed,_inputService.inputVerticalValueP1);
        _playerMovement2.Movement(speed,_inputService.inputVerticalValueP2);
    }


    
}
