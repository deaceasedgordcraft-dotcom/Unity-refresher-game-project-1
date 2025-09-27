using UnityEngine;

public class DeathRespawn : MonoBehaviour
{
    public Transform respawnPoint;  
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Respawn();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FallZone"))
        {
            Respawn();
        }
    }

    void Respawn()
    {
        if (respawnPoint != null)
        {
            transform.position = respawnPoint.position;
        }
        else
        {
            Debug.LogWarning("Respawn Point not assigned in Inspector!");
        }
    }
}
