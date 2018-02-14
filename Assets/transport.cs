using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transport : MonoBehaviour {

    public Animator anim;
    public float reachDistance;
    public GameObject player;
    public GameObject target;
    //public Transform platform;
    //public Transform newspot;
    //public float smooth;
    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        reachDistance = Vector3.Distance(player.transform.position, target.transform.position);

        if (reachDistance < 5.0f)
        {

            anim.Play("Platform");
            anim.speed = .9f;
            //platform.position = Vector3.Lerp(platform.position, newspot.position, smooth * Time.deltaTime);
        }
    }
}
