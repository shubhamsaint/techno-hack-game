var isResult=false;
var isRestart=false;
var score : int;
var m : int;

function Start()
{

var scored : GameObject;
var correct : GameObject;
score = PlayerPrefs.GetFloat("score",0);
m = PlayerPrefs.GetInt("Index",-1);

score = (score/100);

scored= GameObject.FindGameObjectWithTag("Score");
correct = GameObject.FindGameObjectWithTag("correct");
scored.GetComponent.<TextMesh>().text ="" + score;
correct.GetComponent.<TextMesh>().text ="" + m;
}
function OnMouseEnter(){
//change text color
  var rend = GetComponent.<Renderer>();
	rend.material.SetColor("_Color",Color.red);
}
function OnMouseExit(){
//change text color
//renderer.material.color=Color.white;
var rend = GetComponent.<Renderer>();
	
	rend.material.SetColor("_Color",Color.white);
	}

function OnMouseUp(){
//is this quit
if (isResult==true) {
//quit the game
Application.LoadLevel("Answer");
print("Loaded");
}
if(isRestart==true)
{
Application.LoadLevel("MainMenu");
}

}

