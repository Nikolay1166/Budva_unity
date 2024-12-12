using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;

public class GoodMove : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    public float jump = 8;
    public bool grounded = false;
    private AudioSource audio;
    public AudioClip audiojump;
    public SpriteRenderer SpriteRenderer;
    public Logic Logic;
    public Collider2D groundColl;
    public bool groundColliding = false;
    public bool sideColliding = false;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        SpriteRenderer SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1,0,0) * Time.deltaTime * speed);
            SpriteRenderer.flipX = false;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * speed);
            SpriteRenderer.flipX = true;
        }
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            audio.Stop();
            audio.clip =  audiojump;
            audio.Play();
            GetComponent<Rigidbody2D>().AddForce(transform.up * jump, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Logic.Keys[0] == 1 && !Collision2D.thisCollider2D == groundColl)
        {
            grounded = true;
            sideColliding = true;
        }
        if(Collision2D.thisCollider == groundColl)
        {
            grounded = true;
            audio.Stop();
            audio.clip =  audiojump;
            audio.Play();
            groundColliding = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(Logic.Keys[0] == 1 && groundColliding == false)
        {
            grounded = false;
        }
        if(Collision2D.thisCollider == groundColl && sideColliding == false)
        {
            grounded = false;
            groundColliding = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(Logic.Keys[0] == 0)
        {
            grounded = true;
            audio.Stop();
            audio.clip =  audiojump;
            audio.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(Logic.Keys[0] == 0)
        {
            grounded = false;
        }
    }
}