using System;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    [SerializeField] float destroyVFXDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(gameObject);
            triggerDeathVFX();
        }

    }

    private void triggerDeathVFX()
    {
        if (!deathVFX) { return; }

        GameObject deathObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathObject, destroyVFXDelay);
    }
}
