using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action<Vector3> OnMouseClick;
    RaycastHit _HitInfo = new();
    public LayerMask _clickLayerMask;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction,
                out _HitInfo, 100, _clickLayerMask))
            {
                OnMouseClick?.Invoke(_HitInfo.point);
                Debug.Log($"Selected position is {_HitInfo.point}");
            }

        }
    }

}
