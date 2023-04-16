using UnityEngine;

public class Level1 : MonoBehaviour
{
    private float _speed = 1;
    
    private void Update()
    {
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition;
    }
}