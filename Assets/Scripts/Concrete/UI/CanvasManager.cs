
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Concrete.UI
{
    public class CanvasManager : MonoBehaviour
    {
        [SerializeField] GameObject mainPanel, startPanel;
        
        public void StartButton()
        {
            startPanel.SetActive(true);
            mainPanel.SetActive(false);
        }

        public void OnePlayerButton()
        {
            SceneManager.LoadScene("1 Player");
        }


        public void TwoPlayerButton()
        {
            SceneManager.LoadScene("2 Player");
        }

        public void ExitButton()
        {
            Application.Quit();
        }

        public void BackButton()
        {
            mainPanel.SetActive(true);
            startPanel.SetActive(false);
        }

    }

}
