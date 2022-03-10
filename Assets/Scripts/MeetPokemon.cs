using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class MeetPokemon : MonoBehaviour
{
    public Player.Player player;
    private Bounds _terrainBounds;
    private IfMeetController _ifMeetController;

    private CapsuleCollider _capsuleCollider;
    private Vector3 _postion;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Pokemon").gameObject.GetComponent<Player.Player>();
        _capsuleCollider = gameObject.GetComponent<CapsuleCollider>();
        _terrainBounds = _capsuleCollider.bounds;
        _ifMeetController = gameObject.GetComponent<IfMeetController>();
        //Debug.Log(""+gameObject.GetComponent<CapsuleCollider>().);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     //_postion = player.transform.position;
    //     if (_capsuleCollider.)
    //     {
    //         _ifMeetController.enabled = true;
    //         //Debug.Log("in");
    //     }
    //     else
    //     {
    //         _ifMeetController.enabled = false;
    //         //Debug.Log("notin");
    //     }
    // }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.parent.gameObject.name == "Pokemon")
        {
            _ifMeetController.enabled = true;
            Debug.Log("In");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.transform.parent.gameObject.name == "Pokemon")
        {
            _ifMeetController.enabled = false;
            Debug.Log("Out");
        }
    }
}