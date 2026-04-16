using System;
using UnityEngine;


public class PointSystem : MonoBehaviour
{
    public int Points = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag("Player"))
        {
            Points++;
        }
 
    }
}
