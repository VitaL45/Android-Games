using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rabbit : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed = 1f;

    public GameObject winText;

    public TMP_Text scoreText;

    float hInput, vInput;

    int score = 0;
    int winScore = 4;
    void FixedUpdate()
    {
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical * moveSpeed;

        transform.Translate(hInput, vInput, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Carrot")
        {
            score++;
            scoreText.text = "Score: " + score + " / " + winScore;
            Destroy(other.gameObject);

            if (score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}
