using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public event EventHandler<OnThrowEventArgs> onThrow;

    public class OnThrowEventArgs : EventArgs
    {
        public Vector3 pencilEndPointPosition;
        public Vector3 throwPosition;
    }
    private Transform aimTransform;
    private Transform aimPencilEndPointTransform;
    private Animator aimAnimator;
    void Start()
    {
        aimTransform = transform.Find("Aim");
        aimAnimator = aimTransform.GetComponent<Animator>();
        aimPencilEndPointTransform = aimTransform.Find("Pencil");
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
        RangedAttack();
    }

    private void Aim()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 aimDirection = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }

    private void RangedAttack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            aimAnimator.SetTrigger("Throw");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            onThrow?.Invoke(this,new OnThrowEventArgs
            {
                pencilEndPointPosition = aimPencilEndPointTransform.position,
                throwPosition = mousePos,
            });
        }
    }
}


