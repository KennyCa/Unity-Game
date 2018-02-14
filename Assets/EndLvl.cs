using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLvl : MonoBehaviour {
    public float reachDistance;
    public GameObject player;
    public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        reachDistance = Vector3.Distance(player.transform.position, target.transform.position);
        if (reachDistance < 3.0f)
        {
            SceneManager.LoadScene("loadScreen");
        }
	}
}
