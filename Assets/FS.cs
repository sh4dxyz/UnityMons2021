using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FS : MonoBehaviour
{
    [SerializeField]
    public AudioClip grassSound, sandSound, curSound;
    [SerializeField]
    public float volmin, volmax, pitchmin, pitchmax;
    
    AudioSource audioS;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (!audioS.isPlaying)
            {
                /*Son des pas randomisés*/
                audioS.volume = Random.Range(volmin, volmax);
                audioS.pitch = Random.Range(pitchmin, pitchmax);
                audioS.PlayOneShot(curSound);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "grass":
                curSound = grassSound;
                break;

            case "sand":
                curSound = sandSound;
                break;
        }
    }
}
