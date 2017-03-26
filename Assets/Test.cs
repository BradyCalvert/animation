using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Test : MonoBehaviour {
    public AudioClip shootingSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      if (Input.GetKeyDown(KeyCode.P))
        {
            Singleton.instance.myHealth = 5;
            Debug.Log(Singleton.instance.myHealth);
        }
      if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Scene1");

            AudioManager.instance.PlayPlayerSFX(shootingSound);
        }


    }
}
