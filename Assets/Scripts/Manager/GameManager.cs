using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public static bool Gameover;

    public UIManager uiManager;
    public SceneManagers sceneManager;

    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }
    // Start is called before the first frame update
    void Start()
    {
        Gameover = false;
        uiManager.GameOverPanel.SetActive(false);
    }
    public void GameOver()
    {
        Gameover = true;
        uiManager.GameOverPanel.SetActive(true);

    }
}
