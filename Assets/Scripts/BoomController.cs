//using System.Collections.IEnumerable;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{   
    public Vector3 direction;
    public float TimeToExplosion;
    public float Power;
    public float Radius;
    private float dis;
   
       void Update()
    {
        TimeToExplosion -= Time.deltaTime;
        if(TimeToExplosion <= 0 )
        {
            Boom();
        }
    }

    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody> ();
        foreach ( Rigidbody B in blocks )
        {
            dis = Vector3.Distance(transform.position, B.transform.position);
            if (dis < Radius)
            {
               // Vector3 direction = new Vector3 ( 6, 3, 5);
               // Vector3 direction = B.transform.position - transform.position;
                B.AddForce(Power * direction, ForceMode.Impulse);
                //B.AddForce((Radius - dis) * Power * direction.normalized, ForceMode.Impulse);
            }
        }
        TimeToExplosion = 3;
    }
}
