using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
//using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{

    private Camera _mainCamera;

    public Player _player;
    public Enemy _enemy;
    public SecondEnemy _secondEnemy;
    public ThirdEnemy _thirdEnemy;

    public bool PlayerTurn;

    private Vector3 mousePosition;

    public TMP_Text _turn;

    public TMP_Text _headHitChance;
    public TMP_Text _torsoHitChance;
    public TMP_Text _leftArmHitChance;
    public TMP_Text _rightArmHitChance;
    public TMP_Text _leftLegHitChance;
    public TMP_Text _rightLegHitChance;

    public TMP_Text _1stenemyCurrentHeadHealth;
    public TMP_Text _1stenemyCurrentTorsoHealth;
    public TMP_Text _1stenemyCurrentLeftArmHealth;
    public TMP_Text _1stenemyCurrentRightArmHealth;
    public TMP_Text _1stenemyCurrentLeftLegHealth;
    public TMP_Text _1stenemyCurrentRightLegHealth;

    public TMP_Text _2ndenemyCurrentHeadHealth;
    public TMP_Text _2ndenemyCurrentTorsoHealth;
    public TMP_Text _2ndenemyCurrentLeftArmHealth;
    public TMP_Text _2ndenemyCurrentRightArmHealth;
    public TMP_Text _2ndenemyCurrentLeftLegHealth;
    public TMP_Text _2ndenemyCurrentRightLegHealth;

    public TMP_Text _3rdenemyCurrentHeadHealth;
    public TMP_Text _3rdenemyCurrentTorsoHealth;
    public TMP_Text _3rdenemyCurrentLeftArmHealth;
    public TMP_Text _3rdenemyCurrentRightArmHealth;
    public TMP_Text _3rdenemyCurrentLeftLegHealth;
    public TMP_Text _3rdenemyCurrentRightLegHealth;

    public TMP_Text _playerCurrentHeadHealth;
    public TMP_Text _playerCurrentTorsoHealth;
    public TMP_Text _playerCurrentLeftArmHealth;
    public TMP_Text _playerCurrentRightArmHealth;
    public TMP_Text _playerCurrentLeftLegHealth;
    public TMP_Text _playerCurrentRightLegHealth;


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
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (Input.GetButtonDown("Fire1"))
        {
            OnClick();
        }

        _headHitChance.text = (playerHitChance + 5).ToString() + "%";
        _torsoHitChance.text = (playerHitChance + 45).ToString() + "%";
        _leftArmHitChance.text = (playerHitChance + 35).ToString() + "%";
        _rightArmHitChance.text = (playerHitChance + 35).ToString() + "%";
        _leftLegHitChance.text = (playerHitChance + 30).ToString() + "%";
        _rightLegHitChance.text = (playerHitChance + 30).ToString() + "%";

        _playerCurrentHeadHealth.text = _player.currentHeadHealth.ToString() + " / " + _player.maxHeadHealth.ToString();
        _playerCurrentTorsoHealth.text = _player.currentTorsoHealth.ToString() + " / 20";
        _playerCurrentLeftArmHealth.text = _player.currentLeftArmHealth.ToString() + " / 10";
        _playerCurrentRightArmHealth.text = _player.currentRightArmHealth.ToString() + " / 10";
        _playerCurrentLeftLegHealth.text = _player.currentLeftLegHealth.ToString() + " / 15";
        _playerCurrentRightLegHealth.text = _player.currentRightLegHealth.ToString() + " / 15";


        if (sceneName == "FirstCombat")
        {

            _1stenemyCurrentHeadHealth.text = _enemy.currentHeadHealth.ToString() + " / 8";
            _1stenemyCurrentTorsoHealth.text = _enemy.currentTorsoHealth.ToString() + " / 20";
            _1stenemyCurrentLeftArmHealth.text = _enemy.currentLeftArmHealth.ToString() + " / 10";
            _1stenemyCurrentRightArmHealth.text = _enemy.currentRightArmHealth.ToString() + " / 10";
            _1stenemyCurrentLeftLegHealth.text = _enemy.currentLeftLegHealth.ToString() + " / 15";
            _1stenemyCurrentRightLegHealth.text = _enemy.currentRightLegHealth.ToString() + " / 15";

        }

        if (sceneName == "SecondCombat")
        {

            _2ndenemyCurrentHeadHealth.text = _secondEnemy.currentHeadHealth.ToString() + " / 8";
            _2ndenemyCurrentTorsoHealth.text = _secondEnemy.currentTorsoHealth.ToString() + " / 20";
            _2ndenemyCurrentLeftArmHealth.text = _secondEnemy.currentLeftArmHealth.ToString() + " / 10";
            _2ndenemyCurrentRightArmHealth.text = _secondEnemy.currentRightArmHealth.ToString() + " / 10";
            _2ndenemyCurrentLeftLegHealth.text = _secondEnemy.currentLeftLegHealth.ToString() + " / 15";
            _2ndenemyCurrentRightLegHealth.text = _secondEnemy.currentRightLegHealth.ToString() + " / 15";

        }

        if (sceneName == "ThirdCombat")
        {
            _3rdenemyCurrentHeadHealth.text = _thirdEnemy.currentHeadHealth.ToString() + " / 8";
            _3rdenemyCurrentTorsoHealth.text = _thirdEnemy.currentTorsoHealth.ToString() + " / 20";
            _3rdenemyCurrentLeftArmHealth.text = _thirdEnemy.currentLeftArmHealth.ToString() + " / 10";
            _3rdenemyCurrentRightArmHealth.text = _thirdEnemy.currentRightArmHealth.ToString() + " / 10";
            _3rdenemyCurrentLeftLegHealth.text = _thirdEnemy.currentLeftLegHealth.ToString() + " / 15";
            _3rdenemyCurrentRightLegHealth.text = _thirdEnemy.currentRightLegHealth.ToString() + " / 15";
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

        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "FirstCombat")
        {
            if (rayHit.collider.gameObject.name == "EnemyTorsoHitbox" && PlayerTurn == true && _enemy.currentTorsoHealth > 0)
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

            if (rayHit.collider.gameObject.name == "EnemyHeadHitbox" && PlayerTurn == true && _enemy.currentHeadHealth > 0)
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

            if (rayHit.collider.gameObject.name == "EnemyLeftArmHitbox" && PlayerTurn == true && _enemy.currentLeftArmHealth > 0)
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

            if (rayHit.collider.gameObject.name == "EnemyRightArmHitbox" && PlayerTurn == true && _enemy.currentRightArmHealth > 0)
            {
                _enemy.EnemyTakeRightArmDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyLeftLegHitbox" && PlayerTurn == true && _enemy.currentLeftLegHealth > 0)
            {
                _enemy.EnemyTakeLeftLegDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyRightLegHitbox" && PlayerTurn == true && _enemy.currentRightLegHealth > 0)
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

        if (sceneName == "SecondCombat")
        {
            if (rayHit.collider.gameObject.name == "EnemyTorsoHitbox" && PlayerTurn == true && _secondEnemy.currentTorsoHealth > 0)
            {
                _secondEnemy.EnemyTakeTorsoDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                //yield return new WaitForSeconds(1);
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyHeadHitbox" && PlayerTurn == true && _secondEnemy.currentHeadHealth > 0)
            {
                _secondEnemy.EnemyTakeHeadDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                //yield return new WaitForSeconds(1);
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyLeftArmHitbox" && PlayerTurn == true && _secondEnemy.currentLeftArmHealth > 0)
            {
                _secondEnemy.EnemyTakeLeftArmDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                //yield return new WaitForSeconds(1);
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyRightArmHitbox" && PlayerTurn == true && _secondEnemy.currentRightArmHealth > 0)
            {
                _secondEnemy.EnemyTakeRightArmDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyLeftLegHitbox" && PlayerTurn == true && _secondEnemy.currentLeftLegHealth > 0)
            {
                _secondEnemy.EnemyTakeLeftLegDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyRightLegHitbox" && PlayerTurn == true && _secondEnemy.currentRightLegHealth > 0)
            {
                _secondEnemy.EnemyTakeRightLegDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }
        }

        if (sceneName == "ThirdCombat")
        {
            if (rayHit.collider.gameObject.name == "EnemyTorsoHitbox" && PlayerTurn == true && _thirdEnemy.currentTorsoHealth > 0)
            {
                _thirdEnemy.EnemyTakeTorsoDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                //yield return new WaitForSeconds(1);
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyHeadHitbox" && PlayerTurn == true && _thirdEnemy.currentHeadHealth > 0)
            {
                _thirdEnemy.EnemyTakeHeadDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                //yield return new WaitForSeconds(1);
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyLeftArmHitbox" && PlayerTurn == true && _thirdEnemy.currentLeftArmHealth > 0)
            {
                _thirdEnemy.EnemyTakeLeftArmDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                //yield return new WaitForSeconds(1);
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyRightArmHitbox" && PlayerTurn == true && _thirdEnemy.currentRightArmHealth > 0)
            {
                _thirdEnemy.EnemyTakeRightArmDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyLeftLegHitbox" && PlayerTurn == true && _thirdEnemy.currentLeftLegHealth > 0)
            {
                _thirdEnemy.EnemyTakeLeftLegDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }

            if (rayHit.collider.gameObject.name == "EnemyRightLegHitbox" && PlayerTurn == true && _thirdEnemy.currentRightLegHealth > 0)
            {
                _thirdEnemy.EnemyTakeRightLegDamage(playerWeaponDamage, playerHitChance);
                PlayerTurn = false;
                _turn.text = "Enemy's Turn";
                //_enemy.ShootBack();
                StartCoroutine(WaitForFunction());
                //PlayerTurn = true;
                //_turn.text = "Player's Turn";
            }
        }
    }

}
