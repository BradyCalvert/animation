using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour {
    public static Singleton instance = null;

    public int myHealth = 5;
   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(Singleton.instance.myHealth);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Scene2");
        }

	}
}
