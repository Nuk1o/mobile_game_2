using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    [SerializeField] bool isStatic = false;
    [SerializeField] float offset = 0;
    private int sortingorderBase = 0;
    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        render.sortingOrder = (int)(sortingorderBase - transform.position.y+offset);

        if (isStatic)
            Destroy(this);
    }
}
