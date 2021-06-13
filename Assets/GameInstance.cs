using UnityEngine;

public class GameInstance : MonoBehaviour
{
    public float speed = 1;
    public void Awake()
    {
        Time.timeScale = speed;
    }
}
