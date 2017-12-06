using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menuCanvas;
    public GameObject tutorialCanvas;
    public GameObject storyCanvas;

    private void Start()
    {
        tutorialCanvas.SetActive(false);
        storyCanvas.SetActive(false);   
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void OpenTutorial()
    {
        tutorialCanvas.SetActive(true);

        Debug.Log("Open Tutorial Button Pressed");
    }

    public void OpenStory()
    {
        storyCanvas.SetActive(true);
        
    }

    public void Close()
    {
        menuCanvas.SetActive(true);

        tutorialCanvas.SetActive(false);
        storyCanvas.SetActive(false);

    }
}
