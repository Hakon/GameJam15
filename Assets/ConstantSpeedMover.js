#pragma strict

public var Direction : Vector3;

function Start () {

}

function Update () {
	transform.position = transform.position + Direction;
}