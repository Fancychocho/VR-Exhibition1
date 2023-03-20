using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitonManafer : MonoBehaviour
{
   // public FadeScreen fadescreen;

    public void GoToScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
