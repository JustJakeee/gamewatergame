using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 100;
    public PlayParticles particles;

    public void TakeDamage(int damage)
    {
        health -= damage;
        particles.play();
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            Destroy(collision.gameObject);
            TakeDamage(34);
        }
    }
}
