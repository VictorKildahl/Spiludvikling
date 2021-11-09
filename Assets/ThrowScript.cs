using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowScript : MonoBehaviour
{
    [SerializeField] private Transform pfBullet;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerAim>().onThrow += PlayerThrowProjectile;
    }

    private void PlayerThrowProjectile(object sender, PlayerAim.OnThrowEventArgs e)
    {
        Transform bulletTransform = Instantiate(pfBullet, e.pencilEndPointPosition, Quaternion.identity);

        Vector3 throwDir = (e.throwPosition - e.pencilEndPointPosition).normalized;
        bulletTransform.GetComponent<Projectile>().Setup(throwDir);
    }
}
