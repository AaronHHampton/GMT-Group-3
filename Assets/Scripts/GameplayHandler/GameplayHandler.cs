using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameplayHandler : MonoBehaviour
{

    int randomNumber;

    public InputHandler InputHandler;
    public Player player;
    public Enemy _enemy;

    public TMP_Text _turn;
    public TMP_Text _enemyCombatLog;
    //public TMP_Text _playerCombatLog;

    public bool enemyHasShotThisTurn;
    public bool playerVictory;
    public bool playerDefeat;

    public MainMenuButton mainMenuButton;

    public int enemyWeaponDamage;
    public int enemyHitChance;

    // Start is called before the first frame update
    void Start()
    {
        enemyHasShotThisTurn = false;
        playerVictory = false;
        playerDefeat = false;
        enemyWeaponDamage = 2;
        enemyHitChance = 45;
        _enemyCombatLog.text = "The Enemy Is Using A Machine Gun!";

        /*enemyWeaponDamage = 10;
        enemyHitChance = 5;
        _enemyCombatLog.text = "The Enemy Is Using A Battle Cannon!";*/

        /*enemyWeaponDamage = 5;
        enemyHitChance = 25;
        _enemyCombatLog.text = "The Enemy Is Using An Auto Cannon!";*/
    }

    IEnumerator ReturnToTitle()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Ready to return to title!");
        mainMenuButton.MainMenu();

    }

    // Update is called once per frame
    void Update()
    {

        if (InputHandler.PlayerTurn == false && enemyHasShotThisTurn == false)
        {
            //randomNumber = Random.Range(1, 6);
            //for (int i = 0; i < 1;)
            //{
                randomNumber = Random.Range(1, 6);
                if (randomNumber == 1 && player.partsArray[0].activeInHierarchy == true)
                {
                    player.PlayerTakeHeadDamage(enemyWeaponDamage, enemyHitChance);
                    enemyHasShotThisTurn = true;
                    //Debug.Log("Enemy Has Shot Your Head!");
                //_enemyCombatLog.text = "Enemy Has Shot Your Head!";
                    //i++;
                }
                if (randomNumber == 2 && player.partsArray[1].activeInHierarchy == true)
                {
                    player.PlayerTakeTorsoDamage(enemyWeaponDamage, enemyHitChance);
                    enemyHasShotThisTurn = true;
                //Debug.Log("Enemy Has Shot Your Torso!");
                //_enemyCombatLog.text = "Enemy Has Shot Your Torso!";
                //i++;
            }
                if (randomNumber == 3 && player.partsArray[2].activeInHierarchy == true)
                {
                    player.PlayerTakeLeftArmDamage(enemyWeaponDamage, enemyHitChance);
                    enemyHasShotThisTurn = true;
                //Debug.Log("Enemy Has Shot Your Left Arm!");
                //_enemyCombatLog.text = "Enemy Has Shot Your Left Arm!";
                //i++;
            }
                if (randomNumber == 4 && player.partsArray[3].activeInHierarchy == true)
                {
                    player.PlayerTakeRightArmDamage(enemyWeaponDamage, enemyHitChance);
                    enemyHasShotThisTurn = true;
                //Debug.Log("Enemy Has Shot Your Right Arm!");
                //_enemyCombatLog.text = "Enemy Has Shot Your Right Arm!";
                //i++;
            }
                if (randomNumber == 5 && player.partsArray[4].activeInHierarchy == true)
                {
                    player.PlayerTakeLeftLegDamage(enemyWeaponDamage, enemyHitChance);
                    enemyHasShotThisTurn = true;
                //Debug.Log("Enemy Has Shot Your Left Leg!");
                //_enemyCombatLog.text = "Enemy Has Shot Your Left Leg!";
                //i++;
            }
                if (randomNumber == 6 && player.partsArray[5].activeInHierarchy == true)
                {
                    player.PlayerTakeRightLegDamage(enemyWeaponDamage, enemyHitChance);
                    enemyHasShotThisTurn = true;
                //Debug.Log("Enemy Has Shot Your Right Leg!");
                //_enemyCombatLog.text = "Enemy Has Shot Your Right Leg!";
                //i++;
            }
            //}
        }

        if (_enemy.currentHeadHealth <= 0 || _enemy.currentTorsoHealth <= 0 || _enemy.currentLeftLegHealth <= 0 && _enemy.currentRightLegHealth <= 0)
        {
            playerVictory = true;
            _turn.text = "Victory!";
            Debug.Log("Victory!");
            StartCoroutine(ReturnToTitle());
        }

        if (player.currentHeadHealth <= 0 || player.currentTorsoHealth <= 0 || player.currentLeftLegHealth <= 0 && player.currentRightLegHealth <= 0)
        {
            playerDefeat = true;
            _turn.text = "Defeat!";
            Debug.Log("Defeat!");
            StartCoroutine(ReturnToTitle());
        }
    }
}
