using UnityEngine;
using System.Collections;

public class CheckBox : MonoBehaviour { 
	public static int i=1;

	public static int k=0;

	string[,] questions =new string[11,100] ;
	string[,] option2 = new string[11,100];
	string[,] option3 = new string[11,100];
	string[,] option4 = new string[11,100];
	string[,] option1 = new string[11,100];
	string[,] correct = new string[11, 100];
    

	//Transform camTr;
	//Vector3 camPos;
	//Renderer rend;

	void start()
	{
		//  camTr  = Camera.main.transform;
		 //camPos = camTr.position;
	}
	//animating the door and call load level
		void GoOn()
	{
		GameObject door = GameObject.FindGameObjectWithTag ("PhysicsDoor");
		door.GetComponent<Animation> ().Play ("DoorOpen");
		//delay 1sec
		Invoke("loadLevelAgain",1);
	}
	//load level
	void loadLevelAgain()
	{

		Application.LoadLevel ("PhysicsRoom");
		i++;
	}
	void Final()
	{
		k = 0;
		Application.LoadLevel("ResultShow");
	}
	void Update () {

		GameObject status = GameObject.FindGameObjectWithTag ("Status");

		status.GetComponent<TextMesh> ().color = Color.green;
		status.GetComponent<TextMesh> ().text = "Question" + i;

		questions [1, 0] = "If an electron and a proton have the same \nde-Broglie wavelength, then the kinetic energy \nof the electron is";
		option1 [1, 0] = "zero";
		option2 [1, 0] = "less than that of a proton";
		option3 [1, 0] = "more than that of a proton";
		option4 [1, 0] = "equal to that of a proton";
		correct [1, 0] = "Option3";
		questions [2, 0] = "If the linear momentum of a body is increased by 50%,\nthen the kinetic energy of that body increases by _____";
		option1 [2, 0] = "225%";
		option2 [2, 0] = "25%";
		option3 [2, 0] = "100";
		option4 [2, 0] = "125%";
		correct [2, 0] = "Option4";
		questions [3, 0] = "In a Fraunhofer diffraction experiment at a single \nslit using a light of wavelength 400 nm,\n the first minimum is formed at an angle of 300.\n The direction of the first secondary maximum is given by";
		option1 [3, 0] = "sin-1";
		option2 [3, 0] = "cos-1";
		option3 [3, 0] = "tan-1";
		option4 [3, 0] = "sec-1";
		correct [3, 0] = "Option2";
		questions [4, 0] = "In an unbiased p-n junction";
		option1 [4, 0] = " Potential at p is more than that at n";
		option2 [4, 0] = " Potential at p is less than that at n";
		option3 [4, 0] = " Potential at p is equal to that at n";
		option4 [4, 0] = " Potential at p is +ve and that at n is -ve";
		correct [4, 0] = "Option2";
		questions [5, 0] = " In Young's double slit experiment,\na third slit is made in between the \ndouble slits. Then";
		option1 [5, 0] = "intensity of fringes totally disappears.";
		option2 [5, 0] = "only bright light is observed on the screen.";
		option3 [5, 0] = "fringes of unequal width are formed.";
		option4 [5, 0] = "contrast between bright and dark fringes is reduced.";
		correct [5, 0] = "Option4";
		questions [6, 0] = "lf a black body emits 0.5 joules of energy\nper second when it is at 27°C , \nthen the amount of energy emitted by it \nwhen it is at 627°C will be";
		option1 [6,0] = "40.5 J";
		option2 [6, 0] = "60 J";
		option3 [6, 0] = "13.5";
		option4 [6, 0] = "135";
		correct [6, 0] = "Option1";
		questions [7, 0] = "The dimensions of 'resistance' are same as\nthose of _____ where h is the Planck's constant,\n e is the charge.";
		option1 [7, 0] = "option1";
		option2 [7, 0] = "option2";
		option3 [7, 0] = "option3";
		option4 [7, 0] = "option4";
		correct [7, 0] = "Option1";
		questions [8, 0] = "The forbidden energy gap in Ge is 0.72 eV.\n Given, hc = 12400 eV - . The maximum \nwavelength of radiation that will generate \nan electron hole pair is ______.";
		option1 [8, 0] = "17222";
		option2 [8, 0] = "1722";
		option3 [8, 0] = "17220";
		option4 [8, 0] = "172.2";
		correct [8, 0] = "Option1";
		questions [9, 0] = "The masses of two radioactive substances \nare same and their half lives are 1 year \nand 2 years respectively. The ratio of their\n activities after 6 years will be";
		option1 [9, 0] = "1:4";
		option2 [9, 0] = "1:2";
		option3 [9, 0] = "1:3";
		option4 [9, 0] = "1:6";
		correct [9, 0] = "Option1";
		questions [10, 0] = "The maximum kinetic energy of emitted \nelectrons in a photoelectric effect does not \ndepend upon";
		option1 [10, 0] = "wavelength";
		option2 [10, 0] = "frequency";
		option3 [10, 0] = "intensity";
		option4 [10, 0] = "work function";
		correct [10, 0] = "Option3";

		GameObject soundOnCheck = GameObject.FindGameObjectWithTag ("SoundObject2");


		GameObject question = GameObject.FindGameObjectWithTag ("question");
		GameObject choice1 = GameObject.FindGameObjectWithTag ("choice1");
		GameObject choice2 = GameObject.FindGameObjectWithTag ("choice2");
		GameObject choice3 = GameObject.FindGameObjectWithTag ("choice3");
		GameObject choice4 = GameObject.FindGameObjectWithTag ("choice4");

		question.GetComponent<TextMesh> ().text = questions [i, 0];
		choice1.GetComponent<TextMesh> ().text = option1 [i, 0];
		choice2.GetComponent<TextMesh> ().text = option2 [i, 0];
		choice3.GetComponent<TextMesh> ().text = option3 [i, 0];
		choice4.GetComponent<TextMesh> ().text = option4 [i, 0];
		if(i==1)
		{
			k=0;
		}
		if (Input.GetMouseButtonDown (0)) {
			Ray toMouse = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit rhInfo;

			PlayerPrefs.SetInt("Index",k);
			bool didHit = Physics.Raycast (toMouse, out rhInfo, 500.0f);
			if (didHit) {
				Debug.Log (rhInfo.collider.name + "-" + rhInfo.point);
				if(rhInfo.collider.name == "Exit")
				{
					i=1;
					k=0;
					Application.LoadLevel("MainMenu");
				}
				if (rhInfo.collider.name == correct [i, 0]) 
				{
					soundOnCheck.GetComponent<AudioSource>().Play ();
					rhInfo.collider.GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);
					soundOnCheck.GetComponent<AudioSource>().Play ();

					Debug.Log ("Correct");

					Destroy (status);

					k=k+1;

					PlayerPrefs.SetInt("Index",k);
				
					if (i == 10)
					{
						i=1;
						k=0;
						status = GameObject.FindGameObjectWithTag ("Status");
						status.GetComponent<TextMesh> ().text = "Finish Level";
						GameObject over = GameObject.FindGameObjectWithTag ("over");
						over.GetComponent<TextMesh> ().color = Color.blue;
						over.GetComponent<TextMesh> ().text = "Finish Levels!";
						Invoke ("Final", 2);
					}
					Invoke ("GoOn", 1);

				} else if (rhInfo.collider.name == "Option1" || rhInfo.collider.name == "Option2" || rhInfo.collider.name == "Option3" || rhInfo.collider.name == "Option4") {
					i=1;
					k=0;

					soundOnCheck.GetComponent<AudioSource>().Play ();

					Destroy (status);

					Debug.Log ("wrong answer");
					status.GetComponent<TextMesh> ().text = " ";
					GameObject over = GameObject.FindGameObjectWithTag ("over");
					over.GetComponent<TextMesh> ().color = Color.red;
					over.GetComponent<TextMesh> ().text = "Game Over";
					rhInfo.collider.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);
					Invoke ("Final", 2);
				}
			} else {
				Debug.Log ("Hit on empty space");
			}
		}
	}
	}