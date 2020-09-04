using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb2d;
    public float speed;
    int score;
    public Text scoreText;
    public Text winText;
    public GameObject restartButton;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scoreText.text = "Score: " + score;
        restartButton.SetActive(false);
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 vector2 = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(vector2 * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            score += 1;
            scoreText.text = "Score: " + score;
        }

        if(score >= 12)
        {
            winText.text = "You Win!";
            restartButton.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
