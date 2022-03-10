using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float distanceAway;
	public float distanceUp;
	public float smooth;               // how smooth the camera movement is

	private Vector3 m_TargetPosition;       // the position the camera is trying to be in)

	Transform follow;        //the position of Player

	void Start()
	{
		follow = GameObject.FindWithTag("Player").transform;
	}

	void Update()
	{
		// setting the target position to be the correct offset from the 
		Vector3 realForward = new Vector3(0, 0, 0);
		realForward.x = follow.forward.y;
		realForward.z = follow.forward.x;
		realForward.y = follow.forward.z;
		m_TargetPosition = follow.position + Vector3.up * distanceUp + follow.right* distanceAway;

        // making a smooth transition between it's current position and the position it wants to be in
        transform.position = Vector3.Lerp(transform.position, m_TargetPosition, Time.deltaTime * smooth);

        // make sure the camera is looking the right way!
        transform.LookAt(follow);
	}

}
