#pragma strict

public var object1 : Transform;
public var object2 : Transform;
var linerenderer : LineRenderer;

function Start () {

	linerenderer = GetComponent(LineRenderer);
}

function Update () {
	
	linerenderer.SetPosition(0, object1.transform.position);
	linerenderer.SetPosition(1, object2.transform.position);
}