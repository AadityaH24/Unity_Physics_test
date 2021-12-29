using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformMovement : MonoBehaviour
{
    public float xSpeed;
    public InputField platVel;
    public GameObject point1;
    public GameObject point2;
    public int dirFlag = 1;
    public GameObject winscreen;
    // Update is called once per frame
    void Update()
    {   
        if(platVel.text != null){    
            xSpeed = float.Parse(platVel.text);
            transform.position += transform.forward * Time.deltaTime * xSpeed*dirFlag;
            if(transform.position.x > point2.transform.position.x && dirFlag > 0){
                dirFlag = -1;
            }
            else if(transform.position.x < point1.transform.position.x && dirFlag <0){
                dirFlag = 1;
            }
        }   
    }
    private void OnTriggerEnter(Collider other) {
        Time.timeScale = 0;
        winscreen.SetActive(true);
    }
}
