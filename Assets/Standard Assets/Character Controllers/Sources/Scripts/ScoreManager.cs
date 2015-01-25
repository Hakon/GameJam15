using UnityEngine;
using System.Collections;

public static class ScoreManager {
	private static int score = 0;

	public static void incrementScore() {
		score++;
	}

	public static int getScore() {
		return score;
	}

	public static int getHighScore() {
		return PlayerPrefs.GetInt ("HighScore");
	}

	public static bool isAlmostHighScore() {
		int highScore = getHighScore();
		return (highScore - getScore () <= 2);
	}

	public static bool isHighScore() {
		int highScore = getHighScore();
		return (highScore < getScore());
	}

	public static void storeHighScore() {
		PlayerPrefs.SetInt("HighScore", score);
	}

	public static void resetHighScore() {
		PlayerPrefs.SetInt ("HighScore", 0);
	}

	public static void reset() {
		score = 0;
	}


}
