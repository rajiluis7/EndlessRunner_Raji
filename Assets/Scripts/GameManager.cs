using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float speed;

    public bool startGame { get; set; }
    public bool gameOver { get; set; }

}


