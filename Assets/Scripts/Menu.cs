using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject tutorialCanvas;
    public GameObject tutorialCanvas2;

    private void Start()
    {
        tutorialCanvas.SetActive(false);
        tutorialCanvas2.SetActive(false);   
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenTutorial()
    {
        tutorialCanvas.SetActive(true);

        Debug.Log("Open Tutorial Button Pressed");
    }

    public void NextPage()
    {
        Debug.Log("Next Page Button Pressed");
        tutorialCanvas.SetActive(false);

        tutorialCanvas2.SetActive(true);
    }

    public void Close()
    {
        tutorialCanvas2.SetActive(false);
    }
}
