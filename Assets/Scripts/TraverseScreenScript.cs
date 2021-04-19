using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverseScreenScript : MonoBehaviour
{    
    void OnGUI()
    {
        Scene scene = SceneManager.GetActiveScene();
        int sceneToLoad = scene.buildIndex;
        if (sceneToLoad < 1)
        {
            sceneToLoad += 1;
        }
        else
        {
            sceneToLoad = 0;
        }
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 80, 200, 30), "Current Scene: " + ("Scene " + (scene.buildIndex +1)));
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 50, 100, 40), "Load Scene " + (sceneToLoad + 1)))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
