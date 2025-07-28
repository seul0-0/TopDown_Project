using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;         
    public float smoothSpeed = 5f;   
    public Vector2 minBounds;        
    public Vector2 maxBounds;        

    private Vector3 offset;          // 카메라와 플레이어의 초기 거리

    void Start()
    {
        // 카메라와 플레이어 사이 초기 거리 저장
        offset = transform.position - target.position;
        
        float halfHeight = Camera.main.orthographicSize;
        float halfWidth = halfHeight * Camera.main.aspect;

        minBounds = new Vector2(-8 + halfWidth, (float)(-4.5 + halfHeight));
        maxBounds = new Vector2(8 - halfWidth, (float)(4.5 - halfHeight));

    }

    void LateUpdate()
    {
        // 목표 위치 = 플레이어 위치 + 초기 거리
        Vector3 desiredPosition = target.position + offset;

        // z축은 카메라의 고정값 유지
        desiredPosition.z = transform.position.z;

        // 맵 범위 제한 걸기
        desiredPosition.x = Mathf.Clamp(desiredPosition.x, minBounds.x, maxBounds.x);
        desiredPosition.y = Mathf.Clamp(desiredPosition.y, minBounds.y, maxBounds.y);

        // 부드럽게 따라가기
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);
    }
}
