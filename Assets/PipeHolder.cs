using UnityEngine;

public class PipeHolder : MonoBehaviour
{
    public float distance = 0;
    public float speed = 10;

    public Bird bird;

    private void Update()
    {
        if(bird.state == birdStates.Flying)
        {
            Move();
        }
    }

    void Move()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
        distance = -transform.position.x;
    }
}
