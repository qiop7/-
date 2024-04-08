using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour
{

    public float speed;
    public float stopingdistance;
    public float retreatDistance;

    public Transform ply;

    private void Start()
    {
        ply = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, ply.position) > stopingdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, ply.position, speed * Time.deltaTime);
        }

        else if (Vector2.Distance(transform.position, ply.position) < stopingdistance && (Vector2.Distance(transform.position, ply.position) > retreatDistance))
        {
            transform.position = this.transform.position;
        }

        else if (Vector2.Distance(transform.position, ply.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, ply.position, -speed * Time.deltaTime);
        }
    }
}
