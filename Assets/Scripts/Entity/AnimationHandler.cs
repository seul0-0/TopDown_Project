using UnityEngine;

namespace Entity
{
    public class AnimationHandler : MonoBehaviour
    {
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");

        [SerializeField] private Animator animator; // ← 여기에 이 줄 있어야 함

    
    
        protected virtual void Awake()
        {
            if (animator == null)
                animator = GetComponentInChildren<Animator>();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public void Move(Vector2 obj)
        {
            if (animator is null)
            {
                Debug.LogWarning("Animator가 연결되어 있지 않습니다!");
                return;
            }
        
            animator.SetBool(IsMoving, obj.magnitude > .5f);
        
        }
    }
}