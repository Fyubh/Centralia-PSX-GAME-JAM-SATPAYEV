using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody _rb;
    private SubtitlesManager subtitlesManager;

    public bool isReadNode = false;
    public bool isRevers = false;
    public bool firstLevel = false;
    public bool firstMusicOff = false;
    public bool keyFromGate = false;

    public float rotationspeed = 10f;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        subtitlesManager = GameObject.Find("SubtitlesManager").GetComponent<SubtitlesManager>();
        animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
        if (firstLevel)
        {
            subtitlesManager.ShowSubtitles("Как я уснул?, наверное родители уехали домой. Нужно найти выход", 5);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (firstMusicOff)
        {
            GetComponent<AudioSource>().Stop();
        }
        if (!isReadNode)
        {
            if (isRevers)
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");

                Vector3 directionVector = new Vector3(v, 0, -h);

                if (directionVector.magnitude > Mathf.Abs(0.050f))
                {
                    transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * 15);
                }

                animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    _rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed * 1.5f;
                }
                else
                {
                    _rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
                }
            }

            else if (!isRevers)
            { 
                float v = Input.GetAxis("Horizontal");
                float h = -Input.GetAxis("Vertical");

                Vector3 directionVector = new Vector3(v, 0, -h);

                if (directionVector.magnitude > Mathf.Abs(0.005f))
                {
                    transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * 15);
                }

                animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    _rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed * 1.5f;
                }
                else
                {
                    _rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
                }
            }
        }
    }
}