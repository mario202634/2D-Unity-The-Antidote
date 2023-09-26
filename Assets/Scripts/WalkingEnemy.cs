﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : EnemyController 
{
    public float health = 100;
    private Controller player;
    public float speedtowardplayer;
    public AudioClip ZombieDead;
    public AudioClip ZombieWalk1;
    public AudioClip ZombieWalk2;
    //Rigidbody2D rb;

    void FixedUpdate()
    {
        if (this.isFacingRight == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Wall")
        {
            Flip();
        }
        else if (collider.tag == "Enemy")
        {
           Flip();
        }
        if (collider.tag == "Player")
        {
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
            Flip();
        }
        
    }
    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speedtowardplayer * Time.deltaTime);
        //AudioManager.instance.RandomizeSfx(ZombieWalk1, ZombieWalk2);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(other.GetContact(0).point.x > this.transform.position.x)
            {
                //Destroy(this.gameObject, 0f);
                this.health -= 10;
            }
            else if (other.GetContact(0).point.y > this.transform.position.y)
            {
                //Destroy(this.gameObject, 0f);
                this.health -= 10;
            }
        }
    }

    public void EnemyDamage(int damage)
    {
        health -= damage;

        if (health == 0 || health < 0)
        {
            AudioManager.instance.PlaySingle(ZombieDead);
            Destroy(this.gameObject);
            //sr.sprite = reward;
            //anim.SetBool("Dead", true);
        }
        //else
        //{
        //    health -= damage;
        //}

        Debug.Log("Enemy Health:" + health.ToString());
    }

}
