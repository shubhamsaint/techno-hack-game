﻿using UnityEngine;
using System.Collections;

public class inputHandler : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButton (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit rayCastHit;

			if (Physics.Raycast (ray.origin, ray.direction, out rayCastHit, Mathf.Infinity)) {
				Debug.Log ("Mouse Click");
				door Door = rayCastHit.transform.GetComponent<door>();
				if(Door)
				{
					Door.PlayDoorAnim();
			}
		}
	}
}
}
