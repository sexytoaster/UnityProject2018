using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //References to Game Objects
    public GameObject exitButton;
    public GameObject playButton;
    public GameObject settingsButton;
    public GameObject shopButton;
    public GameObject highscoreButton;
    public GameObject homeButton;
    public GameObject GameTitleGo;
    public GameObject GameOverGo;
    public GameObject SettingsGo;
    public GameObject ShopGo;
    public GameObject HighscoreGo;
    public GameObject Player;

    //Establish the different game states
    public enum GameManagerState
    {
        Title,
        Settings,
        Shop,
        Highscore,
        Gameplay,
        GameOver,
    }

    GameManagerState GMState;


    //Initialize to the opening game state
    void Start ()
    {
        GMState = GameManagerState.Title;
    }

    //Function to update the game manager state
    void UpdateGameManagerState()
    {
        switch (GMState)
        {
            case GameManagerState.Title:

                //display game title screen
                GameTitleGo.SetActive(true);

                //hide game over screen 
                GameOverGo.SetActive(false);

                //hide settings screen 
                SettingsGo.SetActive(false);

                //hide shop screen 
                ShopGo.SetActive(false);

                //hide highscore screen 
                HighscoreGo.SetActive(false);

                //set play button visible
                playButton.SetActive(true);

                //set exit button visible
                exitButton.SetActive(true);

                //set settings button visible
                settingsButton.SetActive(true);

                //set shop button visible
                shopButton.SetActive(true);

                //set highscore button visible
                highscoreButton.SetActive(true);

                //set home button invisible
                homeButton.SetActive(false);

                break;


            case GameManagerState.Settings:

                //hide game title screen
                GameTitleGo.SetActive(false);

                //hide game over screen 
                GameOverGo.SetActive(false);

                //display settings screen 
                SettingsGo.SetActive(true);

                //hide shop screen 
                ShopGo.SetActive(false);

                //hide highscore screen 
                HighscoreGo.SetActive(false);

                //set play button invisible
                playButton.SetActive(false);

                //set exit button visible
                exitButton.SetActive(true);

                //set settings button invisible
                settingsButton.SetActive(false);

                //set shop button visible
                shopButton.SetActive(true);

                //set highscore button visible
                highscoreButton.SetActive(true);

                //set home button visible
                homeButton.SetActive(true);

                break;


            case GameManagerState.Shop:

                //hide game title screen
                GameTitleGo.SetActive(false);

                //hide game over screen 
                GameOverGo.SetActive(false);

                //hide settings screen 
                SettingsGo.SetActive(false);

                //display shop screen 
                ShopGo.SetActive(true);

                //hide highscore screen 
                HighscoreGo.SetActive(false);

                //set play button invisible
                playButton.SetActive(false);

                //set exit button visible
                exitButton.SetActive(true);

                //set settings button visible
                settingsButton.SetActive(true);

                //set shop button invisible
                shopButton.SetActive(false);

                //set Highscore button visible
                highscoreButton.SetActive(true);

                //set home button visible
                homeButton.SetActive(true);

                break;


            case GameManagerState.Highscore:

                //hide game title screen
                GameTitleGo.SetActive(false);

                //hide game over screen 
                GameOverGo.SetActive(false);

                //hide settings screen 
                SettingsGo.SetActive(false);

                //hide shop screen 
                ShopGo.SetActive(false);

                //show highscore screen 
                HighscoreGo.SetActive(true);

                //set play button invisible
                playButton.SetActive(false);

                //set exit button visible
                exitButton.SetActive(true);

                //set settings button visible
                settingsButton.SetActive(true);

                //set shop button visible
                shopButton.SetActive(true);

                //set highscore button visible
                highscoreButton.SetActive(false);

                //set home button visible
                homeButton.SetActive(true);

                break;


            case GameManagerState.Gameplay:

                //hide menu buttons and Go's during gameplay
                playButton.SetActive(false);
                settingsButton.SetActive(false);
                shopButton.SetActive(false);
                highscoreButton.SetActive(false);

                GameTitleGo.SetActive(false);
                SettingsGo.SetActive(false);
                ShopGo.SetActive(false);
                HighscoreGo.SetActive(false);

                //set player visible and initialise 
                //Player.GetComponent<PlayerControl>().Init();

                break;


            case GameManagerState.GameOver:

                //display game over screen
                GameOverGo.SetActive(true);

                //change game manager state to opening after 8 seconds
                Invoke("ChangeToTitleState", 8f);
                break;
        }
    }

    //function to set the game manager state
    public void SetGameManagerState(GameManagerState state)
    {
        GMState = state;
        UpdateGameManagerState();
    }

    //function to be called by clicking on the play button
    public void StartGamePlay()
    {
        GMState = GameManagerState.Gameplay;
        UpdateGameManagerState();
    }

    //function to change game manager to opening state
    public void ChangeToTitleState()
    {
        SetGameManagerState(GameManagerState.Title);
    }
}
