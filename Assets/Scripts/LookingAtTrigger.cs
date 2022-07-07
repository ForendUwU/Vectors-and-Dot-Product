using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LookingAtTrigger : MonoBehaviour
{
    public Transform target;
    private void OnDrawGizmos()
    {
        Vector2 pt = transform.position;
        Vector2 dirToPt = pt.normalized;

        Vector2 targetVector = target.position;

        if ((pt.x * targetVector.x + pt.y * targetVector.y) == 1)
        {
            Gizmos.color = Color.green;
        }
        else if ((pt.x * targetVector.x + pt.y * targetVector.y) > 0)
        {
            Gizmos.color = Color.blue;
        }
        else
        {
            Gizmos.color = Color.red;
        }

        Gizmos.DrawLine(Vector2.zero, dirToPt);
    }
}
