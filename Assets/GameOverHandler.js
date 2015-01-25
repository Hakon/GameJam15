#pragma strict

public var scoreUI : UI.Text;

function Start () {
	var score = ScoreManager.getScore();
	var highScore = ScoreManager.getHighScore();
	if(ScoreManager.isHighScore())
		scoreUI.text = "W00t! Highscore of " + score + "!!";
	else if(ScoreManager.isAlmostHighScore())
		scoreUI.text = "Hm. That was close. Your score was " + score + " and the previous best was " + highScore + "!";
	else
		scoreUI.text = "WHAT IS THIS? Puny "+ score + " points!\nThe previous best was " + highScore + "!!";
	
	if(ScoreManager.isHighScore())
		ScoreManager.storeHighScore();
}