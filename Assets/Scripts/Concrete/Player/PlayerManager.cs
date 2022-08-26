using UnityEngine;
using Concrete.Inputs;
using Concrete.Player;

public class PlayerManager : MonoBehaviour
{
    PlayerMovement _playerMovement;
    private PcInputController _inputService;
    private Rigidbody2D rb;
    [SerializeField] private float speed;
  
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _inputService = new PcInputController();
        _playerMovement = new PlayerMovement(rb);
        
    }

    void Update()
    {
        _inputService.InputControl();
    }
    private void FixedUpdate()
    {
        _playerMovement.Movement(speed,_inputService.inputVerticalValue);
    }
}
