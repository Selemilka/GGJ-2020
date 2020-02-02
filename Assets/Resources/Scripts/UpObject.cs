using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpObject : MonoBehaviour
{
    public GameObject Object;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveBox") == false && Object.tag == "Box")
        {
            Input.ResetInputAxes();
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveBox", true);
            Destroy(Object);
        }
        if (Input.GetKeyDown(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveH") == false && Object.tag == "Hummer")
        {
            Input.ResetInputAxes();
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveH", true);
            Destroy(Object);
        }
        if (Input.GetKeyDown(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveBH") == false && Object.tag == "BigHummer")
        {
            Input.ResetInputAxes();
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveBH", true);
            Destroy(Object);
        }
        if (Input.GetKeyDown(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveTape") == false && Object.tag == "Tape")
        {
            Input.ResetInputAxes();
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveTape", true);
            Destroy(Object);
        }
    }
}
