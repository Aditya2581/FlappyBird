using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class birdMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float upVelocity = 0f;
    private Vector2 vel;

    public GameObject gameOver;

    private int score = 0;
    //public Text ScoreUI;
    public TextMeshProUGUI scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        vel = new Vector2(0, upVelocity);
        gameOver.SetActive(false);
        score = 0;
        scoreUI.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = vel;
        }

        if (rb.velocity.y >= 1f)
        {
            transform.rotation = Quaternion.Euler(0, 0, 30f);
        }
        else if (rb.velocity.y <= -4f)
        {
            transform.rotation = Quaternion.Euler(0,0,-50f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (transform.position.y >= 5f)
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Time.timeScale = 0f;
        gameOver.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("score"))
        {
            score++;
            scoreUI.text = score.ToString();
        }
    }
}
