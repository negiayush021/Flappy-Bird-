using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    private float Velocity = 3f;
    private float RotationSpeed = 10f;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool tapped = false;

        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
            tapped = true;
        if (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
            tapped = true;

        if (tapped)
        {
            if (Time.timeScale == 1)
            {
                Audio.instance.PlayClip(0);
            }
            
            rb.linearVelocity = Vector2.up * Velocity;
            
        }
        
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.linearVelocity.y * RotationSpeed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Audio.instance.PlayClip(2);
        gameManager.instance.GameOver();
    }
}
