using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform target; // ボールのTransform
    public Vector3 offset; // ボールとカメラの距離（オフセット）

    void Start()
    {
        // ボールとカメラの初期のオフセットを計算
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // カメラの位置をボールの位置に基づいて更新
        transform.position = target.position + offset;
    }
}
