using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGiftBox : MonoBehaviour
{
    

    private SpriteRenderer sr;
    public Sprite reward;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player" && other.GetContact(0).point.y < transform.position.y) 
        { 
        sr.sprite = reward;
        Object.Destroy(gameObject, 0.3f);
            health =20;
            FindObjectOfType<PlayerStats>().health +=health;
            FindObjectOfType<PlayerStats>().healthUI.value += health;
        }
    }
}
