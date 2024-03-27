using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{

    private Camera _mainCamera;

    public Player _player;
    public Enemy _enemy;

    public bool PlayerTurn;

    private Vector3 mousePosition;

    public TMP_Text _turn;

    private void Awake()
    {
        _mainCamera = Camera.main;
        PlayerTurn = true;
        //StartCoroutine(WaitForFunction());
    }

    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Done Waiting!");
        PlayerTurn = true;
        _turn.text = "Player's Turn";
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            OnClick();
        }
    }

    public void OnClick()
    {

        mousePosition = Input.mousePosition;

        //if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(mousePosition));
        if (!rayHit.collider) return;

        Debug.Log(rayHit.collider.gameObject.name);

        if (rayHit.collider.gameObject.name == "EnemyTorsoHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeTorsoDamage(2);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            //yield return new WaitForSeconds(1);
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }

        if (rayHit.collider.gameObject.name == "EnemyHeadHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeHeadDamage(2);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            //yield return new WaitForSeconds(1);
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }

        if (rayHit.collider.gameObject.name == "EnemyLeftArmHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeLeftArmDamage(2);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            //yield return new WaitForSeconds(1);
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }

        if (rayHit.collider.gameObject.name == "EnemyRightArmHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeRightArmDamage(2);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }

        if (rayHit.collider.gameObject.name == "EnemyLeftLegHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeLeftLegDamage(2);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }

        if (rayHit.collider.gameObject.name == "EnemyRightLegHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeRightLegDamage(2);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }
    }

}
