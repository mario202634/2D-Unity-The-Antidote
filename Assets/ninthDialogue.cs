using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninthDialogue : MonoBehaviour
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
            string[] dialogue = { "Daryl: Doctor! are you okay? did he hurt you?", "Doctor: Daryl! Oh my god i thought you wouldn't be here soon", "Doctor: I'm fine I'm fine , let's just hurry up before it's too late" };
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


}