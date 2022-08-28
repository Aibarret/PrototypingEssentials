using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public float radius = 3f;
    public Transform player;
    public GameObject enemy;


    private void OnDrawGizmos()
    {
        float distanceToPlayer = (transform.position - player.position).magnitude;

        if (Mathf.Abs(distanceToPlayer) > radius)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
        else
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, radius);
            enemy.GetComponent<Enemy>().setPlayerMark(player);
        }
    }
}
