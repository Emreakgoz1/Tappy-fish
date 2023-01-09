using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody2D _rb;
    public float _speed;
    int angle;
    int maxAngle = 20;
    int minAngle = -60;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FishSwim();
        FishRotatin();
      
    }

    public void FishSwim()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb.velocity = Vector2.zero;
            _rb.velocity = new Vector2(_rb.velocity.x, _speed);
        }
    }
    public void FishRotatin()
    {
        if (_rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }

        }
        else if (_rb.velocity.y<-1.2f)
        {
            if (angle>minAngle)
            {
                angle = angle - 2;
            }
        }

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    
}
