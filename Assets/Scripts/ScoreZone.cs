using UnityEngine;


public class ScoreZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Encapsulation
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(1);

            GetComponent<Collider2D>().enabled = false;
        }
    }
}