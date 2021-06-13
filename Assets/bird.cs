using UnityEngine;

public static class birdStates
{
    public const int Idle = 0;
    public const int Flying = 1;
    public const int Hit = 2;
    public const int Dead = 3;
}

public class Bird : MonoBehaviour
{
    public int state = birdStates.Flying;
    
    public float flapForce;

    Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        switch(state)
        {
            case birdStates.Idle:
                Stop();
                break;
            case birdStates.Flying:
                print("Here");
                Move();
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    Flap();
                }
                break;
            case birdStates.Hit:
                Move();
                break;
            case birdStates.Dead:
                Stop();
                break;
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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");
        if(collision.collider.tag == "Pipe")
        {
            state = birdStates.Hit;
        }
    }
}
