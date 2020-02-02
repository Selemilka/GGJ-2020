using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpObject : MonoBehaviour
{
    public GameObject Box;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveBox", true);
            Destroy(Box);
        }
    }
}
