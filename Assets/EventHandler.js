#pragma strict

function OnControllerColliderHit(hit : ControllerColliderHit)
{
    if(hit.collider.CompareTag ("Money"))
    {
    	Debug.Log("Get money");
	}	
	else if(hit.collider.CompareTag ("Van"))
	{
    	Debug.Log("Crashed into big obstacle");
	}	
	
}

function OnTriggerEnter(col : Collider)
{
	if(col.CompareTag("Police"))
	{
    	Debug.Log("Game Over");
	}
}
