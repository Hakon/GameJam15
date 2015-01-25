using UnityEngine;
using System.Collections;

public class MoviePlayer : MonoBehaviour {

	public Texture[] texture;
	public float fadeSpeed = 10.5f;

	private bool fadeUt = false;
	private bool fadeIn = true;

	void Start() {
		StartCoroutine(kjor());
	}

	void Update(){
		if(fadeUt){
			fadeUt = false;
			RenderSettings.ambientLight = Color.Lerp(RenderSettings.ambientLight, Color.black, fadeSpeed);
		}
		if(fadeIn){
			fadeIn = false;
			RenderSettings.ambientLight = Color.Lerp(RenderSettings.ambientLight, Color.white, fadeSpeed);
		}
	}

	IEnumerator kjor(){
		RenderSettings.ambientLight = Color.black;
		renderer.material.mainTexture = texture[0];
		yield return new WaitForSeconds(12);
		renderer.material.mainTexture = texture[1];
		yield return new WaitForSeconds(8);
		renderer.material.mainTexture = texture[2];
		yield return new WaitForSeconds(1);
		RenderSettings.ambientLight = Color.black;
		yield return new WaitForSeconds(2);
		renderer.material.mainTexture = texture[3];
		RenderSettings.ambientLight = Color.white;
		yield return new WaitForSeconds(7);
		renderer.material.mainTexture = texture[4];
		yield return new WaitForSeconds(5);
		renderer.material.mainTexture = texture[5];
		yield return new WaitForSeconds(5);
		renderer.material.mainTexture = texture[6];
		yield return new WaitForSeconds(6);
		renderer.material.mainTexture = texture[7];
		yield return new WaitForSeconds(7);
		renderer.material.mainTexture = texture[8];
		yield return new WaitForSeconds(7);
		RenderSettings.ambientLight = Color.black;

	}
}
