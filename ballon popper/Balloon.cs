using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Balloon : MonoBehaviour
{
    public float upSpeed;
    int score;
    public TMP_Text scoreText;

    AudioSource audioSource;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        if(transform.position.y > 7f) {
            SceneManager.LoadScene("Game");
        }
    }

    private void FixedUpdate() {
        transform.Translate(0, upSpeed, 0);
    }

    private void OnMouseDown() {
        score++;
        scoreText.text = score.ToString();
        audioSource.Play();
        ResetPosition();
    }

    private void ResetPosition() {
        float randomX = Random.Range(-2.5f, 2.5f);
        transform.position = new Vector2(randomX, -7f);
    }
}
