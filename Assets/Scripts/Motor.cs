using UnityEngine;

public class Motor : MonoBehaviour
{
    private KeyCode _gasKey = KeyCode.E;

    private Rigidbody _rigidbody;
    private float _force = 90;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(_gasKey))
        {
            _rigidbody.AddForce(transform.up * _force, ForceMode.Force);
        }
    }
}
