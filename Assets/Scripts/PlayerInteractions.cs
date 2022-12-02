using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("q")) {
            print("You currently have "+EventBus.Current.ReturnLives()+" lives remaining");
        }

        if(Input.GetKeyDown("e")) {
            EventBus.Current.RemoveLife();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
