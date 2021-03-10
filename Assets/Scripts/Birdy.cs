using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Birdy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity;
    public bool isDead;
    public GameManager gm;
    void Start()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "TriggerZone")
        {
            gm.UpdateText();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            isDead = true;
            Time.timeScale = 0;
        }
    }

    void Update()
    {
        //Bu dokunma inputu olarak da çalışır mobil için
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }        
    }
}
