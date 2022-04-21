using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public bool triggered;
    public GameObject enemy;
    

    public HealthBar healthBar;

    void Start()
    {
        enemy = GameObject.Find ("enemy");
        curHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && triggered)
            {
                DamagePlayer(10);
                triggered = false;
            }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            triggered = true;
        }
    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
        healthBar.SetHealth(curHealth);
        if(curHealth <= 0){
            Destroy(enemy);
        }
    }
}
