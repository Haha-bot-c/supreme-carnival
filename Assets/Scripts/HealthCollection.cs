using UnityEngine;

public class HealthCollection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Medkit heal))
        {  
            GetComponent<Health>().Heal(heal.Use());
            Destroy(other.gameObject);
        }
    }
}
