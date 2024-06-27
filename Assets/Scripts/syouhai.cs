using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syouhai : MonoBehaviour
{
    public Player player;
    public Enemy[] enemies;

    void Start()
    {
        // ゲームの初期化
        InitializeGame();
    }

    void Update()
    {
        // ゲームの状態をチェック
        CheckGameState();
    }

    void InitializeGame()
    {
        // プレイヤーを初期化
        player = new Player();
        player.health = 100;
        player.isAlive = true;

        // 敵を初期化
        enemies = new Enemy[10];
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i] = new Enemy();
            enemies[i].isAlive = true;
        }
    }

    void CheckGameState()
    {
        bool allEnemiesDefeated = true;
        foreach (Enemy enemy in enemies)
        {
            if (enemy.isAlive)
            {
                allEnemiesDefeated = false;
                break;
            }
        }

        if (allEnemiesDefeated)
        {
            Debug.Log("プレイヤーの勝利！敵を全滅させました。");
        }
        else if (!player.isAlive)
        {
            Debug.Log("プレイヤーの敗北！敵に摂食されました。");
        }
        else
        {
            Debug.Log("ゲーム続行中...");
        }
    }
    [System.Serializable]
    public class Player
    {
        public int health;
        public bool isAlive;
    }

    [System.Serializable]
    public class Enemy
    {
        public bool isAlive;
    }
}

