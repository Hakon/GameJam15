#pragma strict

public var gameHandler : Score;

function OnControllerColliderHit(hit : ControllerColliderHit)
{
    if(hit.collider.CompareTag ("Money"))
    {
    	Destroy(hit.collider.gameObject);
    	gameHandler.IncreaseScore();
	}	
	else if(hit.collider.CompareTag ("LargeObject"))
	{
    	// crashed into large obstacle
	}	
	else if(hit.collider.CompareTag ("SmallObject"))
	{
    	// crashed into large obstacle
	}	

	
}

function OnTriggerEnter(col : Collider)
{
	if(col.CompareTag("Police"))
	{
    	Debug.Log("Game Over");
    	
	}
	else if(col.CompareTag("Goal"))
	{
    	// heist successful
	}
	else if(col.CompareTag ("Boundary"))
	{
    	Debug.Log("has run too far");
	}	
	
}

function Update()
{
	
	if(Input.GetKeyDown(KeyCode.Escape) && !gameHandler.gamePaused) 
	{
		Debug.Log("Pause menu");
		Time.timeScale = 0.0;
		gameHandler.gamePaused = !gameHandler.gamePaused;
		
	}
	
	
}
