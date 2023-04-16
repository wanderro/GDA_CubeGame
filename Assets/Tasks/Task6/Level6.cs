using UnityEngine;

public class Level6 : MonoBehaviour
{
    [SerializeField] 
    private GameObject _obstacle;

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