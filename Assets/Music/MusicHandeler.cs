using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class MusicHandeler : MonoBehaviour {

	public AudioClip[] musikk;
	private AudioSource kilde;
	
	void Start () {
		for(int i=0; i<musikk.Length; i++){
			if(musikk[i] == null){
				Debug.LogWarning("Det manglar element i tabellen. (index = " + i + ")");
			}
		}
		kilde = GetComponent<AudioSource>();
	}
	
	// PLAY, STOP AND LOOPING
	public void play(int m){
		kilde.clip = musikk[m];
		kilde.Play();
	}
	public void stop(){
		kilde.Stop();
	}
	public void toggleLooping(){
		if(kilde.loop){
			kilde.loop = false;
		}else{
			kilde.loop = true;
		}
	}


	// TIME
	public float getTime(){
		return kilde.time;
	}
	public void setTime(float t){
		kilde.time = t;
	}


	// VOLUME
	public float getVolume(){
		return kilde.volume;
	}
	public void setVolume(float v){
		kilde.volume = v;
	}
}