﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTransform : MonoBehaviour
{
    [SerializeField] private bool _lockLocalPosition;
    [SerializeField] private bool _lockRotation;

    private Quaternion _rotation;
    private Vector3 _localPosition;

    void Start()
    {
        _rotation = transform.rotation;
        _localPosition = transform.localPosition;
    }

    void Update()
    {
        if (_lockLocalPosition)
        {
            transform.localPosition = _localPosition;
        }

        if (_lockRotation)
        {
            transform.rotation = _rotation;
        }
    }
}
