using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour {
    /* 
     * This class is used to store data that needs to persist across scenes
     * It is attached to a GameObject in the scene and will not be destroyed when loading a new scene
     * Handles setters and getters for player data
     * This is a singleton class, meaning there will only be one instance of it in the game
     */
    // Singleton instance
    public static PersistentData Instance;

    // Player data
    // All stats listed below are default when the game starts
    [SerializeField] string playerName = "Player";
    [SerializeField] int playerLevel = 1;
    [SerializeField] int playerMaxHealth = 50;
    [SerializeField] int currentHealth = 50;

    private void Awake()
    {
        // Check if instance already exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Don't destroy this object when loading a new scene
        }
        else
        {
            Destroy(gameObject); // Destroy this object if another instance already exists
        }
    }

    public void setPlayerName(string name) {
        playerName = name;
    }
    public string getPlayerName() {
        return playerName;
    }
    public void setPlayerLevel(int level) {
        playerLevel = level;    
    }
    public int getPlayerLevel() {
        return playerLevel;
    }
    public void setPlayerMaxHealth(int maxHealth) {
        playerMaxHealth = maxHealth;
    }
    public int getPlayerMaxHealth() {
        return playerMaxHealth;
    }
    public void setCurrentHealth(int health) {
        currentHealth = health;
    }
    public int getCurrentHealth() {
        return currentHealth;
    }

}

