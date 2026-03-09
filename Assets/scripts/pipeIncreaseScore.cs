using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class pipeIncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Audio.instance.PlayClip(1);
            score.instance.UpdateScore();
        }
    }
}
