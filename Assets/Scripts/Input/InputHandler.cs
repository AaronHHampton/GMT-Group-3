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

    public GameplayHandler _handler;

    public int playerWeaponDamage;
    public int playerHitChance;

    //public TMP_Text _playerCombatLog;

    //int randomNumber;

    //public EnemyHeadArt enemyHeadArt;

    private void Awake()
    {
        _mainCamera = Camera.main;
        PlayerTurn = true;
        playerWeaponDamage = 2;
        playerHitChance = 45;
        //StartCoroutine(WaitForFunction());
    }

    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Done Waiting!");
        PlayerTurn = true;
        _turn.text = "Player's Turn";
        _handler.enemyHasShotThisTurn = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            OnClick();
        }

        //HoveringOver();

    }

    /*public void HoveringOver()
    {
        mousePosition = Input.mousePosition;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(mousePosition));
        if (!rayHit.collider) return;

        Debug.Log(rayHit.collider.gameObject.name);

        if (rayHit.collider.gameObject.name == "EnemyHeadHitbox")
        {
            //rayHit.collider.gameObject.name;
            _enemy.EnablePart(6);
        }
        else
        {
            _enemy.DisablePart(6);
        }

        if (rayHit.collider.gameObject.name == "EnemyTorsoHitbox")
        {
            //rayHit.collider.gameObject.name;
            _enemy.EnablePart(7);
        }
        else
        {
            _enemy.DisablePart(7);
        }

        if (rayHit.collider.gameObject.name == "EnemyLeftArmHitbox")
        {
            //rayHit.collider.gameObject.name;
            _enemy.EnablePart(8);
        }
        else
        {
            _enemy.DisablePart(8);
        }

        if (rayHit.collider.gameObject.name == "EnemyRightArmHitbox")
        {
            //rayHit.collider.gameObject.name;
            _enemy.EnablePart(9);
        }
        else
        {
            _enemy.DisablePart(9);
        }

        if (rayHit.collider.gameObject.name == "EnemyLeftLegHitbox")
        {
            //rayHit.collider.gameObject.name;
            _enemy.EnablePart(10);
        }
        else
        {
            _enemy.DisablePart(10);
        }

        if (rayHit.collider.gameObject.name == "EnemyRightLegHitbox")
        {
            //rayHit.collider.gameObject.name;
            _enemy.EnablePart(11);
        }
        else
        {
            _enemy.DisablePart(11);
        }

        //if (!rayHit.collider) return;

    }*/

    public void OnClick()
    {

        mousePosition = Input.mousePosition;

        //if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(mousePosition));
        if (!rayHit.collider) return;

        Debug.Log(rayHit.collider.gameObject.name);

        if (rayHit.collider.gameObject.name == "EnemyTorsoHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeTorsoDamage(playerWeaponDamage, playerHitChance);
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
            _enemy.EnemyTakeHeadDamage(playerWeaponDamage, playerHitChance);
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
            _enemy.EnemyTakeLeftArmDamage(playerWeaponDamage, playerHitChance);
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
            _enemy.EnemyTakeRightArmDamage(playerWeaponDamage, playerHitChance);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }

        if (rayHit.collider.gameObject.name == "EnemyLeftLegHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeLeftLegDamage(playerWeaponDamage, playerHitChance);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }

        if (rayHit.collider.gameObject.name == "EnemyRightLegHitbox" && PlayerTurn == true)
        {
            _enemy.EnemyTakeRightLegDamage(playerWeaponDamage, playerHitChance);
            PlayerTurn = false;
            _turn.text = "Enemy's Turn";
            //_enemy.ShootBack();
            StartCoroutine(WaitForFunction());
            //PlayerTurn = true;
            //_turn.text = "Player's Turn";
        }
    }

}
