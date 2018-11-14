using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VigiaBehaviour : MonoBehaviour
{
    public GameObject[] posicoes;
    public GameObject player;

    public float speed;

    public bool moveTo0, moveTo1, moveTo2, moveTo3, moveTo4, followPlayer;

	void Start ()
    {
        this.transform.position = posicoes[4].transform.position;
        moveTo0 = true;
        moveTo1 = false;
        moveTo2 = false;
        moveTo3 = false;
        moveTo4 = false;

        followPlayer = false;
	}
	
	void Update ()
    {
        Move();

        if(followPlayer)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            moveTo0 = false;
            moveTo1 = false;
            moveTo2 = false;
            moveTo3 = false;
            moveTo4 = false;
        }
    }

    private void Move()
    {
        if (moveTo0)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicoes[0].transform.position, speed * Time.deltaTime);
        }
        if (moveTo1)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicoes[1].transform.position, speed * Time.deltaTime);
        }
        if (moveTo2)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicoes[2].transform.position, speed * Time.deltaTime);
        }
        if (moveTo3)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicoes[3].transform.position, speed * Time.deltaTime);
        }
        if (moveTo4)
        {
            transform.position = Vector3.MoveTowards(transform.position, posicoes[4].transform.position, speed * Time.deltaTime);
        }

        if (this.transform.position == posicoes[0].transform.position)
        {
            moveTo0 = false;
            moveTo1 = true;
            moveTo2 = false;
            moveTo3 = false;
            moveTo4 = false;
        }
        if (this.transform.position == posicoes[1].transform.position)
        {
            moveTo0 = false;
            moveTo1 = false;
            moveTo2 = true;
            moveTo3 = false;
            moveTo4 = false;
        }
        if (this.transform.position == posicoes[2].transform.position)
        {
            moveTo0 = false;
            moveTo1 = false;
            moveTo2 = false;
            moveTo3 = true;
            moveTo4 = false;
        }
        if (this.transform.position == posicoes[3].transform.position)
        {
            moveTo0 = false;
            moveTo1 = false;
            moveTo2 = false;
            moveTo3 = false;
            moveTo4 = true;
        }
        if (this.transform.position == posicoes[4].transform.position)
        {
            moveTo0 = true;
            moveTo1 = false;
            moveTo2 = false;
            moveTo3 = false;
            moveTo4 = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == player)
        {
            followPlayer = true;
        }
    }
}
