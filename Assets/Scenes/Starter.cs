using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public Rigidbody ball;
    public bool gravityEarth = true;
    // Start is called before the first frame update
    void Start(){
        ball.useGravity = false;
    }
    public void dropBall(){
        if(gravityEarth){
            ball.AddForce(Physics.gravity * (ball.mass * 10)*2f);
        }
        else{
            ball.AddForce(Physics.gravity * (ball.mass * 10)*1f);
        }
    }
    public void gravSet(){
        gravityEarth = false;
    }
    public void gravReset(){
        gravityEarth = true;
    }

}
