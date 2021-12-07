using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScoreButton : MonoBehaviour
{
    public Score score;
    public void OnTriggerEnter(Collider other)
    {
        score.scoreAmount = 0;
    }
}
