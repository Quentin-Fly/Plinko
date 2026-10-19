
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    // Variables
    public GameObject ballPrefab;
    public ScoreManager scoreManager;

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
