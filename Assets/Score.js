#pragma strict

private var score = 0;
public var scoreUI : UI.Text;
public var gamePaused = false;


function Start() 
{
	score = 0;
}

function IncreaseScore()
{

	score++;
	
	scoreUI.text = "" + score;
}

function gameOver()
{

}


function Update () 
{

}