using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOver : MonoBehaviour

{
    public int points = 10;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Bola")) return;
        SceneManager. LoadScene("Over");
    }
}