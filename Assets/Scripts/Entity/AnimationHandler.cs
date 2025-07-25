using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int IsMoving = Animator.StringToHash("IsMoving");

    [SerializeField] private Animator animator; // ← 여기에 이 줄 있어야 함

    protected virtual void Awake()
    {
        if (animator == null)
            animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        if (animator == null)
        {
            Debug.LogWarning("Animator가 연결되어 있지 않습니다!");
            return;
        }

        animator.SetBool(IsMoving, obj.magnitude > 0.5f);
    }
}