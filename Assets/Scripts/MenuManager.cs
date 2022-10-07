using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string playerName;
    public TMP_InputField inputField;

    public void CreatePlayerName()
    {
        playerName = inputField.text;
    }
    public void StartGame()
    {
        
        SceneManager.LoadScene(1);
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
}