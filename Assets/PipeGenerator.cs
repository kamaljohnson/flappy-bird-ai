using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipeHolder;

    public GameObject PipePrefab;
    public float randomY = 10;
    public float spacing = 10;
    public int maxPipes = 5;

    private List<GameObject> pipesObjs = new List<GameObject>();

    public void Start()
    {
        Create();
    }

    public void Update()
    {
        if(Mathf.Abs(pipesObjs[pipesObjs.Count - 1].transform.position.x - transform.position.x) >= spacing)
        {
            Create();
        }
        if(pipesObjs.Count > maxPipes)
        {
            RemoveFirst();
        }
    }

    public void Create()
    {
        var obj = Instantiate(PipePrefab);
        obj.transform.position = transform.position;
        obj.transform.position += Vector3.up * Random.Range(-randomY, randomY);

        obj.transform.SetParent(pipeHolder.transform);
        pipesObjs.Add(obj);
    }

    public void RemoveFirst()
    {
        var obj = pipesObjs[0];
        pipesObjs.RemoveAt(0);
        Destroy(obj);
    }
}
