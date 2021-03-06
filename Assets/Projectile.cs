using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 5f;
    public float rotationSpeed = 10f;
    private Vector3 shootDir;
    

    public void Setup(Vector3 shootDir)
    {
        this.shootDir = shootDir;
        transform.eulerAngles = new Vector3(0, 0, GetAngleFromVectorFloat(shootDir));
        Destroy(gameObject, 5f);
    }

    private void Update()
    { 
        transform.position += shootDir * projectileSpeed * Time.deltaTime;
        transform.Rotate(0,0,rotationSpeed);
    }

    private float GetAngleFromVectorFloat(Vector3 dir)
    {
        dir = dir.normalized;
        float n = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        if (n<0)
        {
            n += 360;
        }

        return n;
    }
}
