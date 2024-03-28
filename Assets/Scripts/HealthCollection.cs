using UnityEngine;

public class HealthCollection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Heal heal))
        {  
            GetComponent<Health>().Heal(other.gameObject.GetComponent<Heal>().GiveHealth());
            Destroy(other.gameObject);
        }
    }
}
