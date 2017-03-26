using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour {
    public Animator anim;
    const string GOING_LEFT = "going_left";
    const string GOING_RIGHT = "going_right";
    const string PLAYER_IDLE = "player_idle";
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.P))
        {
            anim.SetTrigger(GOING_RIGHT);
        }
        if (Input.GetKey(KeyCode.P))
        {
           transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            anim.SetTrigger(PLAYER_IDLE);
        }

    }
}
