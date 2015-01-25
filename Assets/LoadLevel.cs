using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	public GameObject loadingImage;
	public Text hintText;
	string[] hints = {"Coins are not edible", "There is no cow level"};

	public void LoadScene(string level) {
		loadingImage.SetActive (true);
		hintText.text = "Hint: " + generateHint ();
		Application.LoadLevel (level);
	}

	public string generateHint() {
		int i = Random.Range(0,hints.Length);
		return (string) hints.GetValue(i);
	}
}
