using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneloader : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Island", LoadSceneMode.Single);
    }
}
