
var timerFade : float = 5;
var imageFade : Texture;
private var fadeaway : boolean = false;
private var tempTime : float;
private var time : float = 0.0;

function Start(){
	fadeaway = true;
}
function Update(){
	if (fadeaway){
		if(time < timerFade) time += Time.deltaTime;
		tempTime = Mathf.InverseLerp(0.0, timerFade, time);
	}
	
	if(tempTime >= 1.0) enabled = false;
}

function OnGUI(){
	if(fadeaway){
		GUI.color.a = 1 - tempTime;
		GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), imageFade);
	}
}