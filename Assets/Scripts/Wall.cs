using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject Block;
    public int Width = 200;
    public int Height = 80;

    void Start()
    {
        for (int i = 0; i < Height; i += 20)
        {
            for (int j = 0; j < Width; j += 20)
            {
                Instantiate(Block, new Vector3( 30, i - 80, j + 200), Quaternion.identity);
            }
        }
    }
}
