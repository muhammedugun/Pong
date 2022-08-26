using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameObject.Find("Pause").GetComponent<TextMeshProUGUI>().enabled == false)
            {
                GameObject.Find("Pause").GetComponent<TextMeshProUGUI>().enabled = true;
                Time.timeScale = 0f;
            }
            else
            {
                GameObject.Find("Pause").GetComponent<TextMeshProUGUI>().enabled = false;
                Time.timeScale = 1f;
            }




        }

        if (GameObject.Find("Pause").GetComponent<TextMeshProUGUI>().enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }




    }
}
