
using UnityEngine;
using UnityEngine.InputSystem;

public class BallSpawner : MonoBehaviour
{
    // Variables
    public GameObject ballPrefab;
    public ScoreManager scoreManager;
    
    public InputActionReference moveAction;
    public float moveSpeed = 5f;

    // Appelée au démarrage
    void Start()
    {
        SpawnBall();
    }

    // Génère une bille
    public void SpawnBall()
    {
        GameObject newBalle = Instantiate(
            ballPrefab,
            transform.position,
            Quaternion.identity
        );
    }
}
