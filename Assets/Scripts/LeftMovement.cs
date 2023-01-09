using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    public float _GroundSpeed;
    BoxCollider2D box;
    private float groundWidth;

    float obstacleWidth;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Ground"))
        {
            box = GetComponent<BoxCollider2D>();
            groundWidth = box.size.x;
        }
        else if (gameObject.CompareTag("Obstacle"))
        {
            obstacleWidth = GameObject.FindGameObjectWithTag("Column").GetComponent<BoxCollider2D>().size.x;
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - _GroundSpeed * Time.deltaTime, transform.position.y);
        if (gameObject.CompareTag("Ground"))
        {
            if (transform.position.x <= -groundWidth)
            {
                transform.position = new Vector2(transform.position.x + 2 * groundWidth, transform.position.y);
            }
        }
        else if (gameObject.CompareTag("Obstacle"))
        {
            if (transform.position.x<GameManager.bottomLeft.x-obstacleWidth)
            {
                Destroy(gameObject);
            }
        }
        

    }
}
