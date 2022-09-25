using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PacStudent_Move : MonoBehaviour
{
    public float speed = 0.5f;
    private Vector2 dir = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        dir = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 pos = Vector2.MoveTowards(transform.position, dir, speed);

        if ((Vector2)transform.position == dir)
        {
            if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))){
                dir = (Vector2)transform.position + Vector2.up;
            }
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))){
                dir = (Vector2)transform.position + Vector2.left;
            }
            if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
            {
                dir = (Vector2)transform.position + Vector2.down;
            }
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
            {
                dir = (Vector2)transform.position + Vector2.right;
            }
        }
    }

  }
