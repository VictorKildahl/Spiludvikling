using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable_circle : MonoBehaviour
{
    public ContactFilter2D filter;
    private CircleCollider2D circleCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    protected virtual void Update()
    {
        //Collision work
        circleCollider.OverlapCollider(filter, hits);

        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
            {
                continue;
            }

            OnCollide(hits[i]);

            //the array is not cleaned up, so we do it ourself
            hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D coll)
    {
        Debug.Log(coll.name);
    }
}
