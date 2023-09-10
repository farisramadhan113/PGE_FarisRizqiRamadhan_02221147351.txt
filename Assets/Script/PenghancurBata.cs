using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PenghancurBata : MonoBehaviour
{
    public int points = 10;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Bola")) return;
        Destroy(gameObject);

        Skoring skoring = FindObjectOfType<Skoring>();
        if (skoring != null)
        {
            skoring.IncreaseScore(points);
        }
    }
}
