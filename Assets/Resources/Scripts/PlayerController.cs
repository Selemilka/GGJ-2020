using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private Animator anim;
    private bool wasMoving = false;
    public GameObject Box, Hummer, BigHummer, Tape;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        anim.SetFloat("MoveX", moveInput.x);
        anim.SetFloat("MoveY", moveInput.y);
        if(anim.GetBool("HaveBox") == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.GetAxisRaw("Horizontal") == 1 || anim.GetFloat("LastMoveX") == 1)
            {
                Instantiate(Box, new Vector2(this.transform.position.x + 1, this.transform.position.y), Quaternion.identity);
                anim.SetBool("HaveBox", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Horizontal") == -1 || anim.GetFloat("LastMoveX") == -1)
            {
                Instantiate(Box, new Vector2(this.transform.position.x - 1, this.transform.position.y), Quaternion.identity);
                anim.SetBool("HaveBox", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Vertical") == 1 || anim.GetFloat("LastMoveY") == 1)
            {
                Instantiate(Box, new Vector2(this.transform.position.x, this.transform.position.y + 1), Quaternion.identity);
                anim.SetBool("HaveBox", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Vertical") == -1 || anim.GetFloat("LastMoveY") == -1)
            {
                Instantiate(Box, new Vector2(this.transform.position.x, this.transform.position.y -1), Quaternion.identity);
                anim.SetBool("HaveBox", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
        }
        if (anim.GetBool("HaveH") == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.GetAxisRaw("Horizontal") == 1 || anim.GetFloat("LastMoveX") == 1)
            {
                Instantiate(Hummer, new Vector2(this.transform.position.x + 1, this.transform.position.y), Quaternion.identity);
                anim.SetBool("HaveH", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Horizontal") == -1 || anim.GetFloat("LastMoveX") == -1)
            {
                Instantiate(Hummer, new Vector2(this.transform.position.x - 1, this.transform.position.y), Quaternion.identity);
                anim.SetBool("HaveH", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Vertical") == 1 || anim.GetFloat("LastMoveY") == 1)
            {
                Instantiate(Hummer, new Vector2(this.transform.position.x, this.transform.position.y + 1), Quaternion.identity);
                anim.SetBool("HaveH", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Vertical") == -1 || anim.GetFloat("LastMoveY") == -1)
            {
                Instantiate(Hummer, new Vector2(this.transform.position.x, this.transform.position.y - 1), Quaternion.identity);
                anim.SetBool("HaveH", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
        }
        if (anim.GetBool("HaveBH") == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.GetAxisRaw("Horizontal") == 1 || anim.GetFloat("LastMoveX") == 1)
            {
                Instantiate(BigHummer, new Vector2(this.transform.position.x + 1, this.transform.position.y), Quaternion.identity);
                anim.SetBool("HaveBH", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Horizontal") == -1 || anim.GetFloat("LastMoveX") == -1)
            {
                Instantiate(BigHummer, new Vector2(this.transform.position.x - 1, this.transform.position.y), Quaternion.identity);
                anim.SetBool("HaveBH", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Vertical") == 1 || anim.GetFloat("LastMoveY") == 1)
            {
                Instantiate(BigHummer, new Vector2(this.transform.position.x, this.transform.position.y + 1), Quaternion.identity);
                anim.SetBool("HaveBH", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Vertical") == -1 || anim.GetFloat("LastMoveY") == -1)
            {
                Instantiate(BigHummer, new Vector2(this.transform.position.x, this.transform.position.y - 1), Quaternion.identity);
                anim.SetBool("HaveBH", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
        }
        if (anim.GetBool("HaveTape") == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.GetAxisRaw("Horizontal") == 1 || anim.GetFloat("LastMoveX") == 1)
            {
                Instantiate(Tape, new Vector2(this.transform.position.x + 1, this.transform.position.y), Quaternion.identity);
                anim.SetBool("HaveTape", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Horizontal") == -1 || anim.GetFloat("LastMoveX") == -1)
            {
                Instantiate(Tape, new Vector2(this.transform.position.x - 1, this.transform.position.y), Quaternion.identity);
                anim.SetBool("HaveTape", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Vertical") == 1 || anim.GetFloat("LastMoveY") == 1)
            {
                Instantiate(Tape, new Vector2(this.transform.position.x, this.transform.position.y + 1), Quaternion.identity);
                anim.SetBool("HaveTape", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
            if (Input.GetAxisRaw("Vertical") == -1 || anim.GetFloat("LastMoveY") == -1)
            {
                Instantiate(Tape, new Vector2(this.transform.position.x, this.transform.position.y - 1), Quaternion.identity);
                anim.SetBool("HaveTape", false);
                FindObjectOfType<AudioManager>().Play(AudioNames.PutDown);
                return;
            }
        }
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            anim.SetFloat("LastMoveX", moveInput.x);
            anim.SetFloat("LastMoveY", moveInput.y);
            FindObjectOfType<AudioManager>().Play("steps", restart: false);
            wasMoving = true;
        }
        else
        {
            if (wasMoving)
                FindObjectOfType<AudioManager>().Stop("steps");
            wasMoving = false;
        }
        moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
