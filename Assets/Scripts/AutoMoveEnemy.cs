using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveEnemy : MonoBehaviour
{
    public float speed = 5.0f;

    private enum MovementState { idle, running, jumping, falling, attacking }

    private Animator anim;

    private GameObject player;

    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetInteger("state", (int)MovementState.attacking);
        }
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        MovementState state;
        state = MovementState.running;
        anim.SetInteger("state", (int)state);

        if (Vector2.Distance(transform.position, player.transform.position) < 0.1f)
        {
            OnCollisionEnter2D(new Collision2D()); // call OnCollisionEnter2D method to destroy the enemy
        }
    }

}