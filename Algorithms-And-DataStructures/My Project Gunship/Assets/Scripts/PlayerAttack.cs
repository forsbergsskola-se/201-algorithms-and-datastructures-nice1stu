using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject explosionPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("tank"))
        {
            other.gameObject.SetActive(false);
            
            GameObject explosionObject = Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            
            ParticleSystem explosionParticleSystem = explosionObject.GetComponent<ParticleSystem>();
            explosionParticleSystem.Play();
        }
    }
}