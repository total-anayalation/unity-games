using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private Vector2 preCollisionVelocity;
    public float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(speed, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.CompareTag("wall-bottom")) {
            preCollisionVelocity = rb.velocity - col.relativeVelocity;
            rb.velocity = new Vector2(preCollisionVelocity.x, 0f - preCollisionVelocity.y);
        }
        else if (col.gameObject.CompareTag("wall-top")) {
            preCollisionVelocity = rb.velocity - col.relativeVelocity;
            rb.velocity = new Vector2(preCollisionVelocity.x, 0f - preCollisionVelocity.y);
        }
        else if (col.gameObject.CompareTag("wall-right")) {
            preCollisionVelocity = rb.velocity - col.relativeVelocity;
            rb.velocity = new Vector2(0f - preCollisionVelocity.x, preCollisionVelocity.y);
        }
        else if (col.gameObject.CompareTag("wall-left")) {
            preCollisionVelocity = rb.velocity - col.relativeVelocity;
            rb.velocity = new Vector2(0f - preCollisionVelocity.x, preCollisionVelocity.y);
        }
        else if (col.gameObject.CompareTag("bat")) {
            preCollisionVelocity = rb.velocity - col.relativeVelocity;
            rb.velocity = new Vector2(0f - preCollisionVelocity.x, preCollisionVelocity.y);
        }
        rb.velocity = speed * 2 *  rb.velocity.normalized * new Vector2(1.1f, 1.2f);
        if (rb.velocity.magnitude == 0f) {
            print("zero");
            rb.velocity = speed * 2 * new Vector2(1.1f, 1.2f);
        }
    }
}
