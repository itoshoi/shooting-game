using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour {

	private Vector2 DFC; //distance from center
	private float radius = 1.5f;
	private float k;
	private bool ButtonHoldDown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DFC = Input.mousePosition;
		DFC = Camera.main.ScreenToWorldPoint(DFC);
		if (Input.GetMouseButton (0) == true && DFC.magnitude < radius) {
			ButtonHoldDown = true;
		}
		if (Input.GetMouseButtonUp (0) == true) {
			ButtonHoldDown = false;
			this.transform.position = new Vector2 (0,0);
		}
		if (ButtonHoldDown == true) {
			if (DFC.magnitude > radius) {
				k = radius / DFC.magnitude;
				this.transform.position = k * DFC;
			} else {
				this.transform.position = DFC;
			}
		}
	}
}
