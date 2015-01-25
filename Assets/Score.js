#pragma strict

public var scoreUI : UI.Text;
public var gamePaused = false;


function IncreaseScore()
{

	ScoreManager.incrementScore();
	
	scoreUI.text = "" + ScoreManager.getScore();
}

function gameOver()
{
	Application.LoadLevel("game-over");
}

function finishedLevel()
{
	Application.LoadLevel("game-finished");
}


function Update () 
{

}