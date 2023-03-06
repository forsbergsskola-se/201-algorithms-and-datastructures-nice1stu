using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject explosionPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target"))
        {
            other.gameObject.SetActive(false);
            
            GameObject explosionObject = Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            
            ParticleSystem explosionParticleSystem = explosionObject.GetComponent<ParticleSystem>();
            explosionParticleSystem.Play();
        }
    }
}

