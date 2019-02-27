using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//I tookt hsi code off of UnityAnswers because I'm stupid
public class LightSwitch : MonoBehaviour {


	void Update ()
	{
		if (Input.GetKey(KeyCode.UpArrow))
			this.GetComponent<Light>().enabled = true;
		if (Input.GetKey(KeyCode.DownArrow))
			this.GetComponent<Light>().enabled = false;

	}
}
