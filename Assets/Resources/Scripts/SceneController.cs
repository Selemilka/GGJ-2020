using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject Player, Main;

    public void Quit()
    {
        Application.Quit();
    }

    public void SetPlayer(bool state)
    {
        foreach (Behaviour behaviour in Player.GetComponents<Behaviour>())
        {
            behaviour.enabled = state;
        }
    }

    public void Start()
    {
        SetPlayer(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SetPlayer(false);
            Main.SetActive(true);
        }
    }
}
