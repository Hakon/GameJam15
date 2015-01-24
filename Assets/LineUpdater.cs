﻿using UnityEngine;
using System.Collections;

public class LineUpdater : MonoBehaviour {

	public GameObject object1;
	public GameObject object2;
	LineRenderer linerenderer;

	public float maksDistance;

	private Vector3 prevPos1;
	private Vector3 prevPos2;
	
	void Start () {
		
		linerenderer = gameObject.GetComponent<LineRenderer>();
	}
	
	void Update () {
		
		linerenderer.SetPosition(0, object1.transform.position);
		linerenderer.SetPosition(1, object2.transform.position);
		
		Ray ray = new Ray(object1.transform.position, object2.transform.position - object1.transform.position);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, Vector3.Distance(object2.transform.position,object1.transform.position), LayerMask.GetMask("Hinder"))){
			object1.transform.position = prevPos1;
			object2.transform.position = prevPos2;
		}

		/*if(Vector3.Distance(object2.transform.position,object1.transform.position) > maksDistance){
			object1.transform.position = prevPos1;
			object2.transform.position = prevPos2;
		}*/

		prevPos1 = object1.transform.position;
		prevPos2 = object2.transform.position;
	}
}