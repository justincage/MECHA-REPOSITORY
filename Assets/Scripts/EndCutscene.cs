using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCutscene : MonoBehaviour {

    public void NextScene()
    {
        Debug.Log("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
