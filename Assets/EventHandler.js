#pragma strict

function OnControllerColliderHit(hit : ControllerColliderHit)
{
    if(hit.collider.CompareTag ("Police"))
    {
    	// game over
	}	
}
