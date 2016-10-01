var isQuit=false;

function OnMouseEnter(){
//change text color
  var rend = GetComponent.<Renderer>();
	rend.material.SetColor("_Color",Color.red);
   //rend.GetComponent.<AudioSource>().audio.Play(
}
function OnMouseExit(){
var rend = GetComponent.<Renderer>();
	
	rend.material.SetColor("_Color",Color.white);
	}

function OnMouseUp(){
//is this quit
if (isQuit==true) {
//quit the game
Application.Quit();
}
    else{    Application.LoadLevel("GameEnvironment");
}
}
function Update () {
		if (Input.GetKey ("escape")) {
			Application.Quit();
		}
}

