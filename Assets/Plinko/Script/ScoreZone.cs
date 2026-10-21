using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public int points = 10;

    void OnTriggerEnter(Collider other)
    {
        Ball balle = other.GetComponent<Ball>();

        if (balle != null)
        {
            switch (gameObject.tag)
            {
                case "Boite10":
                    points = 10;
                    break;
                case "Boite100":
                    points = 100;
                    break;
                case "Boite500":
                    points = 500;
                    break;
                default:
                    points = 0;
                    break;
            }
            balle.scoreManager.AddScore(points);
            Debug.Log("Bille détectée : " + points + " points !");
            Destroy(balle.gameObject);
        }
    }
}
