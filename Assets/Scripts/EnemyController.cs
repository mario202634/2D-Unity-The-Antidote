using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public bool isFacingRight = false;
    public float maxSpeed = 3f;
    public int damage = 6;
    private Animator anim;
    //public Sprite reward;
    //public SpriteRenderer sr;
    public void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        //anim.SetFloat("Health", health);
    }
   
    /*public void EnemyDamage(int damage)
    {
        health -= damage;
        if (health == 0 || health < 0)
        {
            //anim.SetBool("Dead", true);
            Destroy(this.gameObject);
            //sr.sprite = reward;
        }
        //else
        //{
        //    health -= damage;
        //}
            
            Debug.Log("Enemy Health:" + health.ToString());  
    }*/

        /*if (this.health < 0f)
        { 
            this.health = 0; 
        }*/
}
