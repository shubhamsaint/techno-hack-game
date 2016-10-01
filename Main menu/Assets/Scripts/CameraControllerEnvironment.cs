using UnityEngine;
using System.Collections;


public class CameraControllerEnvironment : MonoBehaviour {
	int speed=1;
	//var sensitivity : float;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
			if (Input.GetKey (KeyCode.RightArrow)) {
			if (transform.position.z >= (-1.83) ) 
				transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
			if ( transform.position.z <= (-0.1)) 
				transform.Translate (new Vector3 (-speed * Time.deltaTime, 0, 0));
			}
		/*if(Input.mousePosition.x != Screen.width/2f || Input.mousePosition.y != Screen.height/2f){
			transform.Rotate(Input.mousePosition.y * sensitivity,Input.mousePosition.x * sensitivity,0,Space.World);
		}*/
		/*if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
		}*/
	}
}
