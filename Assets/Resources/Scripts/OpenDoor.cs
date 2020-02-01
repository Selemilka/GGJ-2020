using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform PlayerPoint, CameraPoint;
    public Camera Camera;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("khgib");
        collision.transform.position = PlayerPoint.position;
        Camera.transform.position = CameraPoint.position;
    }
}
