#pragma strict

public var Direction : Vector3;

function Start () {
	var controller : Rigidbody = GetComponent(Rigidbody);
	controller.velocity = Direction;
}