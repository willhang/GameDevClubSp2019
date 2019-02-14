using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyPlayerScript : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") == 0)
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        }
        if ( Input.GetAxis("Horizontal") == 0)
        {
            rb.velocity = new Vector2(0, Input.GetAxis("Vertical") * speed);
        }
    }
}
