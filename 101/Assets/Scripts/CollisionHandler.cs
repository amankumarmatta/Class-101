using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Start":
                break;

            case "Finish":
                LoadNextLevel();
                break ;

            case "Ground":
                Debug.Log("You are on the ground");
                break ;
                                
            default:
                ReloadLevel();
                break;
        }
    }

    void ReloadLevel()
    {
        int currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(currentBuildIndex);
    }

    void LoadNextLevel()
    {
        int currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
        int nextBuildIndex = currentBuildIndex + 1;

        SceneManager.LoadScene(nextBuildIndex);
    }


}
