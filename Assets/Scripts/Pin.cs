using UnityEngine;
using System.Collections;

public class Pin : MonoBehaviour {
	
	public float standingThreshold = 3f;
	
	public bool IsStanding () {
		Vector3 rotationInEuler = transform.rotation.eulerAngles;
		float titltInX = Mathf.Abs (rotationInEuler.x);
		float titltInZ = Mathf.Abs (rotationInEuler.z);
		print (name+""+ titltInX +"   "+ titltInZ);
		if (titltInX < standingThreshold && titltInZ < standingThreshold) {
			return true;
		} else {
		return false;
		}
	}
	
	// Use this for initialization
	void Start () {
	IsStanding();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
