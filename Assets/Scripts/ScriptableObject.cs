using UnityEngine;

[CreateAssetMenu(fileName = "DefaultGameMenuSettings", menuName = "UI/Game Menu Settings")]
public class GameMenuSettings : ScriptableObject
{
    public enum GameMode
    {
        InfiniteGame = 0,
        OneMinuteGame = 1
    }

    [Header("Default HUD Values")]
    public int initialScore = 0;
    public float initialTimeRemaining = 0f;

    [Header("Mode Configuration")]
    public GameMode defaultGameMode = GameMode.InfiniteGame;
    public float oneMinuteDurationSeconds = 60f;

    [Header("UI Labels")]
    public string scorePrefix = "Score: ";
    public string timePrefix = "Time Remaining: ";
    public string startButtonText = "Start";
}