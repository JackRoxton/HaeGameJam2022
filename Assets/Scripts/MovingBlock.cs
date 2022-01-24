using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField]
    float timer = 4;
    Vector2 dir = Vector2.right;
    public Transform trs;
    void Start()
    {
        
    }

    void Update()
    {
        timer--;
        if(timer <= 0)
        {
            timer = 4;
            dir *= -1;
        }
        
    }
}
