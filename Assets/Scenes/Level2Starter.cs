using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level2Starter : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody puck;
    public float mass;
    public InputField m;
    public float speed;
    public InputField v;

    public float friction;
    public InputField f;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    
    public GameObject p4;
    public GameObject startpoint;
    public Text score;
    public int points = 0;
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {  

    //     Debug.Log(p4.transform.position.x);
    //     Debug.Log(p3.transform.position.x);
    //     Debug.Log(p1.transform.position.x);
        // "transform.hasChanged" is an official unity bool that checks whether all the tranform values have stopped (Position,Rotation,Scale)
        if(puck.velocity.x <= 0.1f && puck.transform.position.x > startpoint.transform.position.x){
            score.text = "Score: "+points;
            score.gameObject.SetActive(true);
            puck.transform.hasChanged = false;
            // Debug.Log("OutputsScore");
            
        }else{
            if( puck.transform.position.x > p4.transform.position.x){
                points = 100;
            }
            else if (puck.transform.position.x > p3.transform.position.x)
            {
                points = 50;
            }
            else if (puck.transform.position.x > p2.transform.position.x)
            {
                points = 20;
            }
            else if (puck.transform.position.x > p1.transform.position.x)
            {
                points = 10;
            }
        }
    }
    // Update is called once per frame
    public void GameStart(){
        mass = float.Parse(m.text);
        speed = float.Parse(v.text);
        friction = float.Parse(f.text);
        Vector3 velocity = new Vector3(speed,0f,0f);

    
        Time.timeScale = 1;
        puck.drag = friction;
        puck.AddForce(velocity*mass, ForceMode.Impulse);
        
    }
    public void ResetGame(){
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
