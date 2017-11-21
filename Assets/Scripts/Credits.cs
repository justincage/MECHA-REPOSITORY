using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

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
