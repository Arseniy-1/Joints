using UnityEngine;

public class Ñatapult : MonoBehaviour
{
    [SerializeField] private SpringJoint _springJoint;
    [SerializeField] private Transform _bulletSpawnPoint;
    [SerializeField] private Bullet _bulletPrefab;

    private KeyCode _activateKey = KeyCode.F;
    private KeyCode _reloadKey = KeyCode.G;
    private float _targetStiffness = 90;

    private void Update()
    {
        if (Input.GetKeyDown(_activateKey))
        {
            Activate();
        }
        else if (Input.GetKeyDown(_reloadKey))
        {
            Reload();
        }
    }

    private void Activate()
    {
        _springJoint.spring = _targetStiffness;
    }

    private void Reload()
    {
        _springJoint.spring = 0;
        Instantiate(_bulletPrefab, _bulletSpawnPoint.transform.position, _bulletSpawnPoint.transform.rotation);
    }
}
