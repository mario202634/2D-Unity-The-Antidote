using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoGiftBox : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite reward;
    int ammo;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.gameObject.tag == "Player" && other.GetContact(0).point.y < transform.position.y)
        {
            sr.sprite = reward;
            Object.Destroy(gameObject, 0.3f);
            ammo = 20;
            FindObjectOfType<PlayerStats>().ammo += ammo;
        }
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().ammo += 20;
            Destroy(this.gameObject);
        }*/
    }
}
