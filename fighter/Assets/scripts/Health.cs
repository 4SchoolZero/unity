using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public GameObject enemy;

    public HealthBar healthBar;

    void Start()
    {
        enemy = GameObject.Find ("enemy");
        curHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
                DamagePlayer(10);
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
