﻿using UnityEngine;

public class Bottom : MonoBehaviour
{
    public float tileSize = 3.36f;

    void LateUpdate()
    {
        transform.localPosition += Vector3.left * Time.deltaTime;
        if (transform.localPosition.x < -tileSize)
        {
            transform.localPosition += Vector3.right * tileSize;
        }
    }
}