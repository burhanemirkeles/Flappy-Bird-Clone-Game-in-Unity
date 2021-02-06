using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public Rigidbody2D rbd2D;
    public float velocity = 1f;
    public bool isDead;
    public GameManager managerGame;
    public GameObject DeathScreen;

    
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbd2D.velocity = Vector2.up * velocity;
        } 

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PointArea")
        {
            managerGame.UpdateScore();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    }

}
