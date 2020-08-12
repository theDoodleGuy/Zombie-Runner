using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    // TODO create a method to reduce hitPoints
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        print("Enemy hp = " + hitPoints);
    }
}
