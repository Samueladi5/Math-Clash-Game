using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovePlayer : MonoBehaviour
{
    public float speed = 5.0f;

    private enum MovementState { idle, running, jumping, falling, attacking }

    private Animator anim;

    private GameObject enemy;

    private MovementState state;

    void Start()
    {
        anim = GetComponent<Animator>();
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }


    void Update()
    {
        if(Vector2.Distance(transform.position, enemy.transform.position) > 0.1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemy.transform.position, speed * Time.deltaTime);
            state = MovementState.running;
            anim.SetInteger("state", (int)state);
        }

        if (Vector2.Distance(transform.position, enemy.transform.position) < 0.1f)
        {
            OnCollisionEnter2D(new Collision2D()); // call OnCollisionEnter2D method to destroy the enemy
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            anim.SetInteger("state", (int)MovementState.attacking);
        }
    }

}