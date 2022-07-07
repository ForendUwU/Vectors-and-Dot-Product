using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    public Transform obj;

    [Range(0f, 5f)]
    public float radius = 1f;

    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 objTr = obj.position;

        float dist = Vector2.Distance(origin, objTr);
        bool isInside = dist < radius;

        Handles.color = isInside ? Color.green : Color.red;
        Handles.DrawWireDisc(origin, new Vector3(0,0,1), radius);
        
    }
}
