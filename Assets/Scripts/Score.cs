using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{

    public int scoreAmount;

public ParticleSystem particle;

    public TMP_Text scoreText;

    void Start()
    {
        scoreAmount = 0;
    }

    void Update()
    {
        scoreText.text = scoreAmount.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball") && other.GetComponent<Rigidbody>().useGravity&& other.GetComponent<Rigidbody>().velocity.y < 0 )
        {
                    particle.Play(particle);
                                scoreAmount++;
                                Invoke("PauseParticle", 1f);

        }

    }
    public void PauseParticle()
    {
        particle.Pause();
    }
}
