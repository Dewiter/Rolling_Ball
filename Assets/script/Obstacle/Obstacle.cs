using System.Collections;
using UnityEngine;

public class Obstacle : MonoBehaviour {	
	void FixedUpdate () 
	{
		transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
	}
}