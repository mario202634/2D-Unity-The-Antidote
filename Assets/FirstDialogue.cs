using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDialogue : MonoBehaviour
{
    public Dialogue DManager;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        //Panel = GameObject.Find("Panel"); Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            string[] dialogue = { "Daryl: Not the perfect timing for the doctor to get kidnapped", "i must find her to get to the antidote and safe the world" };
            DManager.SetSentences(dialogue);
            DManager.StartCoroutine(DManager.TypeDialogue());
            Panel.SetActive(true);
            Destroy(this.gameObject, 1f);

        }
        
    }



    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }

    /* private IEnumerator test()
     {
         Panel.SetActive(true);
         yield return new WaitForSeconds(5);
         Panel.SetActive(false);
     }
    */
}
