using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ace : MonoBehaviour
{
    public Animator aceAnimator;
    void Start()
    {

    }


    void Update()
    {
        RaycastHit2D ray = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (ray.collider == null)
        {
            return;
        }

        if ((ray.collider.tag == "ace") && Input.GetMouseButtonDown(0))
        {
            aceAnimator.SetBool("OnClick", true);
        }

    }
}
