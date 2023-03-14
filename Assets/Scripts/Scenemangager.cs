using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemangager : MonoBehaviour
{
    public void sceneYeeter()
    {
        SceneManager.LoadScene("Playground");
    }
    public void gameoverscreen()
    {
        SceneManager.LoadScene("GameOver");
    }


} 



