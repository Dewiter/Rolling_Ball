using System.Collections;
using UnityEngine;

public class Obstacle : MonoBehaviour {	
	void FixedUpdate () 
	{
		if (gameObject.tag == "Left")
		{		
			transform.Translate(Vector3.forward *  Time.deltaTime);
		}
		if (gameObject.tag == "Right")
		{		
			transform.Translate((Vector3.forward * -1) *  Time.deltaTime);
		}
	}
}