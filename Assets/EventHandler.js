#pragma strict

function OnControllerColliderHit(hit : ControllerColliderHit)
{
    if(hit.collider.CompareTag ("Van"))
    {
    	// game over
	}	
}

function OnTriggerEnter(col : Collider)
{
	if(col.CompareTag("Police"))
	{
    	Debug.Log("Game Over");
	}
}
