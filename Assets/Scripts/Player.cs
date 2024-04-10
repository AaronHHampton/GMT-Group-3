using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] private UI_Inventory uiInventory;

    //private PlayerInventory inventory;

    public int maxTorsoHealth = 20;
    public int maxHeadHealth = 8;
    public int maxLeftArmHealth = 10;
    public int maxRightArmHealth = 10;
    public int maxLeftLegHealth = 15;
    public int maxRightLegHealth = 15;

    public int currentTorsoHealth;
    public int currentHeadHealth;
    public int currentLeftArmHealth;
    public int currentRightArmHealth;
    public int currentLeftLegHealth;
    public int currentRightLegHealth;

    public TorsoHealth torsoHealth;
    public HeadHealth headHealth;
    public LeftArmHealth leftArmHealth;
    public RightArmHealth rightArmHealth;
    public LeftLegHealth leftLegHealth;
    public RightLegHealth rightLegHealth;

    int randomNumber;

    public TMP_Text _enemyCombatLog;

    [SerializeField]
    public GameObject[] partsArray;

    /*
    private void Awake()
    {

        inventory = new PlayerInventory();
        uiInventory.SetInventory(inventory);

    }
    */

    void Start()
    {

        currentTorsoHealth = maxTorsoHealth;
        torsoHealth.SetTorsoStartColor();

        currentHeadHealth = maxHeadHealth;
        headHealth.SetHeadStartColor();

        currentLeftArmHealth = maxLeftArmHealth;
        leftArmHealth.SetLeftArmStartColor();

        currentRightArmHealth = maxRightArmHealth;
        rightArmHealth.SetRightArmStartColor();

        currentLeftLegHealth = maxLeftLegHealth;
        leftLegHealth.SetLeftLegStartColor();

        currentRightLegHealth = maxRightLegHealth;
        rightLegHealth.SetRightLegStartColor();

    }

    void Update()
    {



    }

    
    public void PlayerTakeTorsoDamage(int damage, int enemyHitChance)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit torso is %45.
        if (randomNumber <= 45 + enemyHitChance)
        {

            currentTorsoHealth -= damage;
            torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);
            Debug.Log("Hit Torso!");
            _enemyCombatLog.text = "Enemy Has Shot Your Torso And Hit!";


        }
        else
        {
            torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);
            Debug.Log("Missed Torso!");
            _enemyCombatLog.text = "Enemy Has Shot Your Torso And Missed!";
        }

        //currentTorsoHealth -= damage;

        //torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);

        if (currentTorsoHealth <= 0)
        {
            DisablePart(1);
        }
    }

    public void PlayerTakeHeadDamage(int damage, int enemyHitChance)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit head is %15.
        if (randomNumber <= 15 + enemyHitChance)
        {

            currentHeadHealth -= damage;
            headHealth.SetHeadHealth(currentHeadHealth, maxHeadHealth);
            Debug.Log("Hit Head!");
            _enemyCombatLog.text = "Enemy Has Shot Your Head And Hit!";

        }
        else
        {
            headHealth.SetHeadHealth(currentHeadHealth, maxHeadHealth);
            Debug.Log("Missed Head!");
            _enemyCombatLog.text = "Enemy Has Shot Your Head And Missed!";
        }

        //currentHeadHealth -= damage;

        //headHealth.SetHeadHealth(currentHeadHealth, maxHeadHealth);

        if (currentHeadHealth <= 0)
        {
            DisablePart(0);
        }
    }

    public void PlayerTakeLeftLegDamage(int damage, int enemyHitChance)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit left leg is %30.
        if (randomNumber <= 30 + enemyHitChance)
        {

            currentLeftLegHealth -= damage;
            leftLegHealth.SetLeftLegHealth(currentLeftLegHealth, maxLeftLegHealth);
            Debug.Log("Hit Left Leg!");
            _enemyCombatLog.text = "Enemy Has Shot Your Left Leg And Hit!";

        }
        else
        {
            leftLegHealth.SetLeftLegHealth(currentLeftLegHealth, maxLeftLegHealth);
            Debug.Log("Missed Left Leg!");
            _enemyCombatLog.text = "Enemy Has Shot Your Left Leg And Missed!";
        }

        //currentLeftLegHealth -= damage;

        //leftLegHealth.SetLeftLegHealth(currentLeftLegHealth, maxLeftLegHealth);

        if (currentLeftLegHealth <= 0)
        {
            DisablePart(4);
        }
    }

    public void PlayerTakeRightLegDamage(int damage, int enemyHitChance)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit right leg is %30.
        if (randomNumber <= 30 + enemyHitChance)
        {

            currentRightLegHealth -= damage;
            rightLegHealth.SetRightLegHealth(currentRightLegHealth, maxRightLegHealth);
            Debug.Log("Hit Right Leg!");
            _enemyCombatLog.text = "Enemy Has Shot Your Right Leg And Hit!";

        }
        else
        {
            rightLegHealth.SetRightLegHealth(currentRightLegHealth, maxRightLegHealth);
            Debug.Log("Missed Right Leg!");
            _enemyCombatLog.text = "Enemy Has Shot Your Right Leg And Missed!";
        }

        //currentRightLegHealth -= damage;

        //rightLegHealth.SetRightLegHealth(currentRightLegHealth, maxRightLegHealth);

        if (currentRightLegHealth <= 0)
        {
            DisablePart(5);
        }
    }

    public void PlayerTakeLeftArmDamage(int damage, int enemyHitChance)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit left arm is %35.
        if (randomNumber <= 35 + enemyHitChance)
        {

            currentLeftArmHealth -= damage;
            leftArmHealth.SetLeftArmHealth(currentLeftArmHealth, maxLeftArmHealth);
            Debug.Log("Hit Left Arm!");
            _enemyCombatLog.text = "Enemy Has Shot Your Left Arm And Hit!";

        }
        else
        {
            leftArmHealth.SetLeftArmHealth(currentLeftArmHealth, maxLeftArmHealth);
            Debug.Log("Missed Left Arm!");
            _enemyCombatLog.text = "Enemy Has Shot Your Left Arm And Missed!";
        }

        //currentLeftArmHealth -= damage;

        //leftArmHealth.SetLeftArmHealth(currentLeftArmHealth, maxLeftArmHealth);

        if (currentLeftArmHealth <= 0)
        {
            DisablePart(2);
        }
    }

    public void PlayerTakeRightArmDamage(int damage, int enemyHitChance)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit left arm is %35.
        if (randomNumber <= 35 + enemyHitChance)
        {

            currentRightArmHealth -= damage;
            rightArmHealth.SetRightArmHealth(currentRightArmHealth, maxRightArmHealth);
            Debug.Log("Hit Right Arm!");
            _enemyCombatLog.text = "Enemy Has Shot Your Right Arm And Hit!";

        }
        else
        {
            rightArmHealth.SetRightArmHealth(currentRightArmHealth, maxRightArmHealth);
            Debug.Log("Missed Right Arm!");
            _enemyCombatLog.text = "Enemy Has Shot Your Right Arm And Missed!";
        }

        //currentRightArmHealth -= damage;

        //rightArmHealth.SetRightArmHealth(currentRightArmHealth, maxRightArmHealth);

        if (currentRightArmHealth <= 0)
        {
            DisablePart(3);
        }
    }

    public void DisablePart(int part)
    {
        partsArray[part].SetActive(false);
        Debug.Log("Disabled");
    }

}
