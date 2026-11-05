using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject ObstaclePrefab;
    private Vector3 spawnPos = new Vector3(25f, 0f,  0f);

    private float startDelay = 2;

    private float repeatRate = 2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}