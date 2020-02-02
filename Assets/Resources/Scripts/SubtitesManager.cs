using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitesManager : MonoBehaviour
{

    private List<Subtitle> subtitles;

    public static SubtitesManager Instance { get; private set; }

    public Text changingText;
    

    void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);

        Instance = this;
    }

    public void ShowSubtitle()
    {

    }
}

public class Subtitle
{
    string Text { get; set; }
    int Time { get; set; }
}