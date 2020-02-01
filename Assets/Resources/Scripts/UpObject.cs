using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpObject : MonoBehaviour
{
    private void OnCollision2D(Collision2D collision)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("something happened");
        }
    }
}
