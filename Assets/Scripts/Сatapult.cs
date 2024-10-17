using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ñatapult : MonoBehaviour
{
    [SerializeField] private SpringJoint _springJoint;

    private KeyCode _activateKey = KeyCode.F;
    private float _targetStiffness = 90;

    private void Update()
    {
        if (Input.GetKeyDown(_activateKey))
        {
            Activate();
        }
    }

    public void Activate()
    {
        _springJoint.spring = _targetStiffness;
    }
}
