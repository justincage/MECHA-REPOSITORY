using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public GameObject menuCanvas;
    public GameObject creditsCanvas;
 
    private void Start()
    {
        creditsCanvas.SetActive(false);
       
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenCredits()
    {
        creditsCanvas.SetActive(true);

        Debug.Log("Open Tutorial Button Pressed");
    }


    public void Close()
    {
        menuCanvas.SetActive(true);

        creditsCanvas.SetActive(false);

    }

    public void Quit()
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

    public void RunAgain()
    {
        SceneManager.LoadScene(1);
    }
}
