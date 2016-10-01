#pragma strict

  public var time : float;
  var textTime : String;
  var timerOn = false;
  var audio : AudioSource;

  var buttonText : String;
  var camPos : Vector3;
  var over : GameObject;

  static var score : float;
 // var beep1 : AudioClip;
 // var beep2 : AudioClip;
  var buttonTexture: Texture2D;
   	function Final()
	{
	    score=0;
		Application.LoadLevel("ResultShow");
	}
  function Start() {
      buttonText = "Start";
      timerOn = true;
      
      //Application.LoadLevel("ResultShow");
      //timerStop = false;
  }
   
  function Update(){
     if(PlayerPrefs.GetInt("Index",0)==0)
     {
     score=0;
     }
      if(timerOn){
      
      if(time<=120){
          time += Time.deltaTime;
          score = score + time;
          	PlayerPrefs.SetFloat("score",score);
         }
      else if( time>= 120)
       {
       PlayerPrefs.SetFloat("score",score);
       print("stop");

      over = GameObject.FindGameObjectWithTag ("over");
    
      Application.LoadLevel("ResultShow");
     
    // over.GetComponent<TextMesh>
      }
      
  }
  }
  
  
   
  function OnGUI () {
       var guiTime = time;
     
       var minutes : int = guiTime / 60; //Divide the guiTime by sixty to get the minutes.
       var seconds : int = guiTime % 60;//Use the euclidean division for the seconds.
       var fraction : int = (guiTime * 100) % 100;
    
       textTime = String.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction); 
       //text.Time is the time that will be displayed.
       GetComponent(GUIText).text=textTime;
   }
   
   public function TimerOnOff()
  {
      // do your timer on/off stuff
      timerOn = !timerOn;
           if(timerOn) buttonText = "Stop";
           else buttonText = "Start";
       //    GetComponent<AudioSource>().PlayOneShot(beep1);
  }
  
   public function TimerReset()
  {
      // do your timer reset stuff
      time = 0;
       //   GetComponent<AudioSource>().PlayOneShot(beep2);
  }