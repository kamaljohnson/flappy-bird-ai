using UnityEngine;

public class bird : MonoBehaviour
{
    public bool isPlaying;
    
    public float flapForce;

    Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isPlaying)
        {
            Move();
            
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Flap();
            }
        
        } else
        {
            Stop();
        }

    }

    void Move()
    {
            rb.isKinematic = false;
    }

    void Stop()
    {
            rb.isKinematic = true;
    }

    void Flap()
    {
        rb.velocity = Vector2.up * flapForce;
    }    
}
