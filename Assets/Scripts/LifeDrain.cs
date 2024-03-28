using UnityEngine;
using System.Collections;

public class LifeDrain : TriggerAttak
{
    [SerializeField] private float _duration = 6f;

    private void Update()
    {
        if (_attack == null && Input.GetKeyDown(KeyCode.E))
        {
            _attack = StartCoroutine(Attack());
        }
    }

    private IEnumerator Attack()
    {
        float elapsedTime = 0f;

        WaitForSeconds wait = new WaitForSeconds(_attackCooldown);

        Health thisHealth = GetComponent<Health>();
        Health character = _nearestCharacterInRange.GetComponent<Health>();

        while (_nearestCharacterInRange != null && elapsedTime < _duration)
        {
            character.TakeDamage(_attackDamage);
            thisHealth.Heal(_attackDamage);
            elapsedTime += _attackCooldown;

            yield return wait;

            if (elapsedTime >= _duration)
                _attack = null;
        }
    }
}