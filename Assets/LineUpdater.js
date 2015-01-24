#pragma strict

public var object1 : Transform;
public var object2 : Transform;

function Start () {

}

function Update () {
	var linerenderer : LineRenderer = GetComponent(LineRenderer);
	
	linerenderer.SetPosition(0, object1.transform.position);
	linerenderer.SetPosition(1, object2.transform.position);
}