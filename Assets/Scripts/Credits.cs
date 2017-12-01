using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public Animation anim;

    void GetUp()
    {
        if (anim.IsPlaying("GetUp"))
        {
            
        }
    }

    void StandingToFighting()
    {
    }

    void Fight()
    {

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
