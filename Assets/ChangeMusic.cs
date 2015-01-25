using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	public AudioClip[] levelMusic;
	private AudioSource source;

	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void OnLevelWasLoaded (int level) {
		Debug.Log ("Level " + level + " was loaded");
		if (level < levelMusic.Length && levelMusic [level] && levelMusic[level] != source.clip) {
			source.clip = levelMusic [level];
			source.Play ();
		} else {

		}
	}
}
