using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

// reference for this script: https://www.youtube.com/watch?v=-7I0slJyi8g
public class NextScene : MonoBehaviour
{
    public int sceneBuildIndex;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered:");

        if(other.tag == "Player")
    {
            Debug.Log("Switching Scene to" + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
