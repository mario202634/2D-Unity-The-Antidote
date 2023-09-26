using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{
    public int health = 100;
    public int lives = 3;
    public float flickerTime = 0f;
    public float flickerDuration = 0.1f;
    private SpriteRenderer spriteRenderer;
    public bool isImmune = false;
    public float immunityduration = 1.5f;
    public float immunityTime = 0f;
    public int ammo = 20;
    public Text AmmoUI;
    public Text livesUI;
    public Slider healthUI;
    public Gradient gradient;
    public Image fill;
    public float delayTime = 5f;
    public AudioClip PlayerDamage1;
    public AudioClip PlayerDamage2;
    public AudioClip PlayerDeath;
    public AudioClip AmmoPowerUp;
    public AudioClip HealthPowerUp; //try
    public Text EnemiesLeft;  //Add reference to UI Text here via the inspector
    private float timeToAppear = 2f;
    private float timeWhenDisappear;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        //fill.color = gradient.Evaluate(1f);
    }
    void SpriteFlicker()
    {
        if (this.flickerTime < this.flickerDuration)
            this.flickerTime += Time.deltaTime;
        else if (this.flickerTime >= this.flickerDuration)
        {
            spriteRenderer.enabled = !(spriteRenderer.enabled);
            this.flickerTime = 0;
        }
    }
    // Update is called once per frame

    void Update()
    {
        if (this.health > 100)
        {
            this.health = 100;
        }
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            Destroy(GameObject.FindWithTag("NextLevelWall"));
        }

        if (this.isImmune == true)
        {
            SpriteFlicker();
            immunityTime = immunityTime + Time.deltaTime;
            if (immunityTime >= immunityduration)
            {
                this.isImmune = false;
                this.spriteRenderer.enabled = true;
                Debug.Log("Immunity has ended");
            }
        }
        AmmoUI.text = "" + ammo;
        livesUI.text = "" + lives;

        healthUI.value = health;
        //fill.color = gradient.Evaluate(healthUI.normalizedValue);
    }
    void playHitReaction()
    {
        this.isImmune = true;
        this.immunityTime = 0f;
    }
    public void TakeDamage(int damage)
    {
        if (this.isImmune == false)
        {
            this.health = this.health - damage;
            AudioManager.instance.RandomizeSfx(PlayerDamage1, PlayerDamage2);
            if (this.health < 0f)
            { 
                this.health = 0;
            }
            if (this.lives > 0f && this.health == 0)
            {
                FindObjectOfType<LevelManager>().RespawnPlayer();
                AudioManager.instance.PlaySingle(PlayerDeath);
                this.health = 100;
                this.lives--;
            }
            else if (this.lives == 0 && this.health == 0)
            {
                (new NavigationController()).GoToGameOverScene();
                Debug.Log("GameOver");
                //Destroy(this.gameObject);
            }
            Debug.Log("Player Health:" + this.health.ToString());
            Debug.Log("Player lives:" + this.lives.ToString());
        }
        playHitReaction();
    }
    void ammocapacitylimit()
    {
        FindObjectOfType<Controller>().Shoot(); 
    }

    /*public IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2);
        (new NavigationController()).GoToGameOverScene();
    }*/

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "NextLevel")
        {
            int y = SceneManager.GetActiveScene().buildIndex;
            if (y == 2)
            {
                Application.LoadLevel(14);
            }
            if (y==4)
            {
                Application.LoadLevel(6);
            }
            if (y == 5)
            {
                Application.LoadLevel(4);
            }
            if (y == 6)
            {
                Application.LoadLevel(7);
            }
            if (y == 7)
            {
                Application.LoadLevel(8);
            }
            if (y == 8)
            {
                Application.LoadLevel(9);
            }
            if (y == 9)
            {
                Application.LoadLevel(10);
            }
            if (y == 10)
            {
                Application.LoadLevel(11);
            }
            if (y == 11)
            {
                Application.LoadLevel(12);
            }
            if (y == 12)
            {
                Application.LoadLevel(13);
            }
        }
        
    }
    void OnTriggerEnter2D(Collider2D other) //Lazem yb2a istrigger
    {
        if (other.gameObject.tag == "AmmoBox")
        {
            ammo += 30;
            Destroy(other.gameObject);
            AudioManager.instance.PlaySingle(AmmoPowerUp);
        }
        if (other.gameObject.tag == "HealthBox" && health < 100)
        {
            health += 20;
            Destroy(other.gameObject);
            AudioManager.instance.PlaySingle(HealthPowerUp);
        }
        if (other.gameObject.tag == "HealthBox" && health == 100)
        {
            health += 0;
        }
    }

    /*public void GainHealth(int health)
    {
        health = 5;
        this.health = this.health + health;
        healthUI.value += 5;


        Debug.Log("Player Health:" + this.health.ToString());
        
    }
    */
}