using UnityEngine;

public class Medkit : MonoBehaviour
{
    [SerializeField] private float _healAmount = 20f;

    public float Use()
    {
        return _healAmount;
    }
}
