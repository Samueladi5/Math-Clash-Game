using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    public int maxHealth = 100;

    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Animator animator = GetComponent<Animator>();
            animator.SetBool("isDead", true);
            float delay = animator.GetCurrentAnimatorStateInfo(0).length;
            StartCoroutine(DestroyEnemy(delay));
        }
    }

    IEnumerator DestroyEnemy(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position + new Vector3(0, 2.5f, 0), 2.3f);
    }
}
