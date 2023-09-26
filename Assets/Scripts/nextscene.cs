using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextscene : MonoBehaviour
{
    int nextSceneIndex;
       // Start is called before the first frame update
       void Start()
    {
         nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
   
    /*
    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
    */
}
