using UnityEngine;

public class HealthCollection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Medkit medkit))
        {  
            GetComponent<Health>().Heal(medkit.Use());
            Destroy(other.gameObject);
        }
    }
}
