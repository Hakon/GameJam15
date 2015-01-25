using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public void LoadScene(string level) {
		Application.LoadLevel (level);
	}
}
