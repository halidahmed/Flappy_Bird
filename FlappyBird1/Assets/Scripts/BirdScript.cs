using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BirdScript : MonoBehaviour
{
    public float ziplama_araligi;
    Rigidbody2D rb;
    public Text skor_text;
    public float skor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        skor = 0;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * ziplama_araligi;
        }

        skor_text.text = skor.ToString();
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag=="Scorer")
        {
            skor++;
        }
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Pipe")
        {
            //Time.timeScale = 0;
            skor = 0;
        }
    }
}
