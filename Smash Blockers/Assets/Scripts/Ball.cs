using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Config params
    [SerializeField]
    Paddle paddle;
    [SerializeField]
    Vector2 launchVelocity;
    [SerializeField] AudioClip[] ballSounds;

    //Member variables
    private bool ballLaunched;
    private Vector2 offsetVec;
    private AudioSource ballAudioSrc;

    // Start is called before the first frame update
    void Start()
    {
        ballAudioSrc = GetComponent<AudioSource>();
        ballLaunched = false;
        offsetVec = new Vector2();
        offsetVec = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ballLaunched)
        {
            LockToPaddle();
            Launch();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ballLaunched)
        {
            ballAudioSrc.clip = ballSounds[Random.Range(0, ballSounds.Length)];
            ballAudioSrc.Play();
        }
    }

    private void LockToPaddle()
    {
        transform.position = (Vector2)(paddle.transform.position) + offsetVec;
    }

    private void Launch()
    {
        if (Input.GetMouseButtonDown(0) &&
            !ballLaunched)
        {
            GetComponent<Rigidbody2D>().velocity = launchVelocity;
            ballAudioSrc.clip = ballSounds[0];
            ballAudioSrc.Play();
            ballLaunched = true;
        }
    }
}
