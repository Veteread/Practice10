using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpringController : MonoBehaviour
{    
    public Transform Target;
    public bool SpringStop;
    public float Speed;
    public float TimeToKick;
    void FixedUpdate()
    {
        TimeToKick -= Time.deltaTime;
        if (TimeToKick <= 0)
        {
           Kick();
        }
    }

    void Kick()
    {
        if (SpringStop == false)
        {
            for (int i = 0; i < 100; i++)
            {
                transform.position = Vector3.MoveTowards(transform.position, Target.position, Time.deltaTime * Speed);
            }
            TimeToKick = 5;
        }
    }
}
