using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{

    private Camera _mainCamera;

    public Player _player;
    public Enemy _enemy;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;

        Debug.Log(rayHit.collider.gameObject.name);

        if (rayHit.collider.gameObject.name == "TorsoHitbox")
        {
            _enemy.TakeTorsoDamage(2);
        }

        if (rayHit.collider.gameObject.name == "HeadHitbox")
        {
            _enemy.TakeHeadDamage(2);
        }

        if (rayHit.collider.gameObject.name == "LeftArmHitbox")
        {
            _enemy.TakeLeftArmDamage(2);
        }

        if (rayHit.collider.gameObject.name == "RightArmHitbox")
        {
            _enemy.TakeRightArmDamage(2);
        }

        if (rayHit.collider.gameObject.name == "LeftLegHitbox")
        {
            _enemy.TakeLeftLegDamage(2);
        }

        if (rayHit.collider.gameObject.name == "RightLegHitbox")
        {
            _enemy.TakeRightLegDamage(2);
        }
    }

}
