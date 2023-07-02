using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{   
    public Vector3 Direction;
    public AudioSource Audio;
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
                B.AddForce(Power * Direction, ForceMode.Impulse);
                Audio.Play();
            }
        }
        TimeToExplosion = 0.1f;
    }
}
