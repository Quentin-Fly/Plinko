using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Un objet est entré dans la zone !");
    }
}
