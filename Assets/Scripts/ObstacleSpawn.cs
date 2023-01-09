using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject _obstacle;
    public float MaxTime;
    float timer;
    public float maxY;
    public float minY;
    float randomY;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Gameover==false)
        {
            timer += Time.deltaTime;
            if (timer >= MaxTime)
            {
                randomY = Random.Range(minY, maxY);
                InstantiateObstacle();
                timer = 0;
            }
        }
      
    }
    public void InstantiateObstacle()
    {
        GameObject newObstacle = Instantiate(_obstacle);
        newObstacle.transform.position = new Vector2(transform.position.x, randomY);
    }
}
