using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public List<GameObject> Balls;
    public GameObject playerCamera;
    GameObject currentBall;

    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;

    private bool holdingBall = false;

    bool throwBall = false;
    bool pickBall = false;
    


    // Update is called once per frame
void Update()
{
    if (Input.GetMouseButtonDown(0) && holdingBall)
        throwBall = true;
    if (Input.GetMouseButtonDown(0) && !holdingBall)
        pickBall = true;
}

    void FixedUpdate()
    {
        if (holdingBall) {
            currentBall.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;

            if (throwBall) {
                holdingBall = false;
                currentBall.GetComponent<Rigidbody> ().useGravity = true;
                currentBall.GetComponent<Rigidbody> ().AddForce (playerCamera.transform.forward * ballThrowingForce);
                currentBall = null;

            }
        }
        else 
        {
            foreach(GameObject go in Balls)
            {
                if((transform.position - go.transform.position).magnitude <2)
                {
                    if(pickBall)
                    {
                        holdingBall = true; 
                        currentBall = go;
                    }

                }

            }

        if(currentBall != null)
            currentBall.GetComponent<Rigidbody> ().useGravity = false;  
        }
            pickBall = false;
            throwBall = false;
    }
}
