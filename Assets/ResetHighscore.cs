using UnityEngine;
using System.Collections;

public class ResetHighscore : MonoBehaviour {

	public void reset() {
		ScoreManager.resetHighScore();
	}
}