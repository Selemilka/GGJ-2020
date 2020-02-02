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
            FindObjectOfType<AudioManager>().Play(AudioNames.PickUp);
            Destroy(Object);
            SubtitesManager.Instance.ShowSubtitle("О, эта коробка выглядит так, словно я могу поставить её на ту большую красную кнопку", 5000);
        }
        if (Input.GetKeyDown(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveH") == false && Object.tag == "Hummer")
        {
            Input.ResetInputAxes();
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveH", true);
            FindObjectOfType<AudioManager>().Play(AudioNames.PickUp);
            Destroy(Object);
            SubtitesManager.Instance.ShowSubtitle("Хмммм, этим молотком можно что-нибудь и разби.... ой, починить", 5000);
        }
        if (Input.GetKeyDown(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveBH") == false && Object.tag == "BigHummer")
        {
            Input.ResetInputAxes();
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveBH", true);
            FindObjectOfType<AudioManager>().Play(AudioNames.PickUp);
            Destroy(Object);
            SubtitesManager.Instance.ShowSubtitle("Огооооо, какой он большой!!!!", 5000);
        }
        if (Input.GetKeyDown(KeyCode.Space) && collision.GetComponent<Animator>().GetBool("HaveTape") == false && Object.tag == "Tape")
        {
            Input.ResetInputAxes();
            Debug.Log("something happened");
            collision.GetComponent<Animator>().SetBool("HaveTape", true);
            FindObjectOfType<AudioManager>().Play(AudioNames.PickUp);
            Destroy(Object);
            SubtitesManager.Instance.ShowSubtitle("Синяя изолента - чинит то, что почниить невозможно!", 5000);
        }
    }
}
