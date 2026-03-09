using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    private float speed = 1f;
    private float width = 6f;

    private SpriteRenderer Renderer;

    private Vector2 startSize;

    private void Start()
    {
        Renderer = GetComponent<SpriteRenderer>();

        startSize = new Vector2(Renderer.size.x, Renderer.size.y); 
    }

    private void Update()
    {
        Renderer.size = new Vector2(Renderer.size.x + speed * Time.deltaTime, Renderer.size.y);

        if (Renderer.size.x > width )
        {
            Renderer.size = startSize;
        }
    }
}
