using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallUp : MonoBehaviour {

    public Animator anim;
    public float reachDistance;
    public GameObject player;
    public GameObject target;


    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        reachDistance = Vector3.Distance(player.transform.position,
            target.transform.position);

        if (Input.GetKeyDown("m") && reachDistance < 5.0f)
        {

            anim.Play("WallUp");
            anim.speed = .9f;
        }
    }
}
