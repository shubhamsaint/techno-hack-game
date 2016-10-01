#pragma strict
 
 var camPos : Vector3; 
 var camTr  : Transform;
 var speed = 2;
 var audio : AudioSource;
 static var f=0;
 function Start() {
     camTr  = Camera.main.transform;
     camPos = camTr.position;
 }
 
 function Update() {
    
     if (Input.GetMouseButtonDown(0)) {
         var hit : RaycastHit;
         var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         if(f==0){
         if (Physics.Raycast(ray, hit) && hit.collider.tag == "Scroll") {
             var gyro = GameObject.FindGameObjectWithTag("gyro");
             Destroy(gyro);
             var blocks = GameObject.FindGameObjectsWithTag("Scroll");
             var sound = GameObject.FindGameObjectWithTag("SoundObject1");
             
             sound.GetComponent.<AudioSource>().Play();
                               
         
              
             for (var go : GameObject in blocks) {
             
                 if (go == hit.collider.gameObject) {
                 
                     if((camPos.x + 1.6)<=0.94)
                     {
                     camPos.x+=1.2;
                     } // Zoom
                 }
                 else {
                     go.SetActive(false);
                 
                 }
             }
         }
         f=1;
     }
     else if(f==1)
     {
     if (Physics.Raycast(ray, hit) && hit.collider.tag == "Scroll") {
             blocks = GameObject.FindGameObjectsWithTag("Scroll");
             for (var go : GameObject in blocks) {
                 if (go == hit.collider.gameObject) {
                 if(camPos.x-1.6>-0.90)
                     camPos.x -= 1.6; // Zoom
                 }
                 else {
                     go.SetActive(false);
             
                 }
             }
         }
         f=0;
     }
     }
     
     camTr.position = Vector3.Lerp(camTr.position, camPos, Time.deltaTime * speed);
 }
