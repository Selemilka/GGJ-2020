using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class SubtitesManager : MonoBehaviour
{

    public static SubtitesManager Instance { get; private set; }

    public Text changingText;
    
    static SubtitesManager() {
        Instance = new SubtitesManager();
    }

    void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);

        Instance = this;
    }

    public void ShowSubtitle(string text, int delay)
    {  
        StartCoroutine(ShowText(text, delay));
    }

    IEnumerator ShowText(string text, int delay) {

        changingText.text = text;
        yield return new WaitForSeconds(delay / 1000);
        changingText.text = "";
    }
}
