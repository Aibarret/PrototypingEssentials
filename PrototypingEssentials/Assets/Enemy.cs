using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform playerMark;

    public void setPlayerMark(Transform playerTransform)
    {
        playerMark = playerTransform;
    }

    private void OnDrawGizmos()
    {
        if (playerMark != null)
        {
            Gizmos.DrawLine(transform.position, playerMark.position);
        }
    }
}
