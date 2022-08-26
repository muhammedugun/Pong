
using UnityEngine;

namespace Concrete.Inputs
{
    public class PcInputController
    {
        public float inputVerticalValue { get; set; }
        public float inputVerticalValueP1 { get; set; }
        public float inputVerticalValueP2 { get; set; }

        public void InputControl()
        {
            
            inputVerticalValue = Input.GetAxisRaw("Vertical");
            
        }

        public void InputControlP1()
        {
            
            if (Input.GetKey(KeyCode.W))
                inputVerticalValueP1 = 1f;
            else if (Input.GetKey(KeyCode.S))
                inputVerticalValueP1 = -1f;
            else
                inputVerticalValueP1 = 0f;
        }

        public void InputControlP2()
        {
            if (Input.GetKey(KeyCode.UpArrow))
                inputVerticalValueP2 = 1f;
            else if (Input.GetKey(KeyCode.DownArrow))
                inputVerticalValueP2 = -1f;
            else
            inputVerticalValueP2 = 0f;
        }
    }
}
