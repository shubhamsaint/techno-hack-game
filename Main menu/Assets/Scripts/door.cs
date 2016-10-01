using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {

	private int m_LastIndex;
	void OnGo()
	{
		if (gameObject.tag == "Door1") {
			Debug.Log ("Transition");
			Application.LoadLevel ("PhysicsRoom");
		}

		if (gameObject.tag == "Door2") {
			Debug.Log ("Transition");
			Application.LoadLevel ("ChemistryRoom");
		}
     if (gameObject.tag == "Door3") {
				Debug.Log ("Transition");
			Application.LoadLevel ("BiologyRoom");

		}
           if (gameObject.tag == "Door4") {
			Debug.Log ("Transition");
			Application.LoadLevel ("Aptitudes");
		}
			if (gameObject.tag == "Door5") {
			Debug.Log ("Transition");
			Application.LoadLevel ("HistoryGeography");
		}
			
				if (gameObject.tag == "Door6") {
			Debug.Log ("Transition");
			Application.LoadLevel ("Mathematics");
		}
		       if (gameObject.tag == "PhysicsDoor") {
			Application.LoadLevel("PhysicsRoom");
		}

	}
	public void PlayDoorAnim()
	{
		GameObject soundDoor = GameObject.FindGameObjectWithTag ("DoorSound");
		 if (m_LastIndex == 0) {
			soundDoor.GetComponent<AudioSource>().Play ();
			gameObject.GetComponent<Animation>().Play ("DoorOpen");
			m_LastIndex = 1;
		}
		Invoke("OnGo", 1);//this will happen after 2 seconds

	}

}
