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
    	// game over
	}
}
