using UnityEngine;

public class Level5 : MonoBehaviour
{
    private float _speed = 5;

    private void Start()
    {
      
    }

    private void Update()
    {
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition; 
    }
}