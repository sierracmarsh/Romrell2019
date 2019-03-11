using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBar : MonoBehaviour
{
	private Image BarImage;
	public FloatData FillNumber;

	// Use this for initialization
	void Start ()
	{
		BarImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		BarImage.fillAmount = FillNumber.Value;
	}
}
