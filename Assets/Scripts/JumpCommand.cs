using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : MonoBehaviour
{
    public bool onGround;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, 5f, 0f);
                onGround = false;
            }
        }
    }

    void OnCollisionEnter(Collision any)
      {  
        any.gameObject.CompareTag("Ground");
        onGround = true;
    }
}
