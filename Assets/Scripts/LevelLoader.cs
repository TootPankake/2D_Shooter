using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
   {
    SceneManager.LoadScene(sceneName:"GameOver Screen");
   }
}