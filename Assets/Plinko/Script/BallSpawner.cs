
using UnityEngine;
using UnityEngine.InputSystem;

public class BallSpawner : MonoBehaviour
{
    // Variables
    public GameObject ballPrefab;
    public ScoreManager scoreManager;
    
    public InputActionReference moveAction;
    public float moveSpeed = 5f;

    public InputActionReference dropAction;

    public float cooldown = 1f;
    private float prochainLancement  = 0f;

    // Appelée au démarrage
    void Start()
    {
        //SpawnBall();
    }

    // Génère une bille
    public void SpawnBall()
    {
        GameObject newBalle = Instantiate(
            ballPrefab,
            transform.position,
            Quaternion.identity
        );
        Ball ballScript = newBalle.GetComponent<Ball>();
        ballScript.scoreManager = scoreManager;
    }
    // Gére le déplacement du spawn de la balle
    void OnEnable()
    {
        moveAction.action.Enable();
        dropAction.action.Enable();
    }
    void OnDisable()
    {
        moveAction.action.Disable();
        dropAction.action.Disable();
    }
    void Update()
    {
        float direction = moveAction.action.ReadValue<float>();
        transform.position += Vector3.right * direction * moveSpeed * Time.deltaTime;

        float clampedX = Mathf.Clamp(transform.position.x, -3.5f, 3.5f);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

        if (dropAction.action.WasPressedThisFrame() && Time.time >= prochainLancement)
        {
            SpawnBall();
            prochainLancement = Time.time + cooldown;
        }
    }
}
