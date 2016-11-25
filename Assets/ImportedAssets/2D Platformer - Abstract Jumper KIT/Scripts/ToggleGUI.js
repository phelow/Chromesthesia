    var visible;
    var windowRect;
    var PauseTexture : Texture;
    
    function Start()
    
    {
    	visible = false;
    	windowRect = Rect( 510,510, 500,500);
    }
    
   		 function OnTriggerEnter(other : Collider) {
    	 OnGUI();
    
 	}
   		function OnGUI()
    {
    
   		if( visible )
   	{
    	GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), PauseTexture);
    }
    
   	}
    	function Update()
    {
    	if( Input.GetKeyDown( KeyCode.P ) )
    {
    	visible = !visible;
    	
    }
   }
     