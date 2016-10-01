using UnityEngine;
using System.Collections;


public class TextController : MonoBehaviour 
{

	
	// Use this for initialization
	void Start () 
	{
		//instruction.GetComponent<TextMesh>().text = "Press left arrow key to navigate LEFT and right arrow key to navigate RIGHT";

	}
	
	// Update is called once per frame
	void Update () {
		GameObject instruction = GameObject.FindGameObjectWithTag ("instruction");
		instruction.GetComponent<TextMesh>().text = "Press left arrow key to navigate LEFT and right arrow key to navigate RIGHT";

		if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.RightArrow) )
		{
			Destroy(instruction);
		}
	}
}