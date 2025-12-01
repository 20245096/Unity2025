using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    float dropSpeed = -2f;
    int ratio = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed * Time.deltaTime, 0);
        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
