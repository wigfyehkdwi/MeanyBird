using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    // When an object collides with a trigger
    public void OnTriggerEnter2D (Collider2D collision) {
      // Add score
      Score.score++;
    }
}
