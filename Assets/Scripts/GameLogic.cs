using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public Walk WALK;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public Text CurLevel;
    public Text NextLevel;

    private void Start()
    {
        
    }
    private void Awake()
    {
        WinScreen.SetActive(false);
        WinScreen.SetActive(false);
        CurLevel.text = LevelIndex.ToString();
        NextLevel.text = (LevelIndex+1).ToString();
    }
    public void OnPlayerDie()
    {
       WALK.enabled = false;
        
        LoseScreen.SetActive(true);
    }
    public void OnPlayerFinish()
    {
        Debug.Log("FInifs");
        WALK.enabled = false;
        
        LevelIndex++;
        WinScreen.SetActive(true);
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public int LevelIndex
    {
        get => PlayerPrefs.GetInt("LevelIndex", 0);
        private set
        {
            PlayerPrefs.SetInt("LevelIndex", value);
            PlayerPrefs.Save();
        }
    }

}
