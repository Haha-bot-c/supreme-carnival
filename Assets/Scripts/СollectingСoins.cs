
using UnityEngine;

public class �ollecting�oins : MonoBehaviour
{
    private int _countCoin = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Coin coin))
        {
            Destroy(other.gameObject);
            _countCoin++;
        }
    }
}
