using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
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

    public TMP_Text _playerCombatLog;

    [SerializeField]
    private GameObject[] partsArray;
    //private GameObject[] healthDisplayArray;

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


    public void EnemyTakeTorsoDamage(int damage, int gunChanceToHit)
    {
        randomNumber = Random.Range(1, 100);

        //Default chance to hit torso is %45.
        if (randomNumber <= 45 + gunChanceToHit) 
        {
            
            currentTorsoHealth -= damage;
            torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);
            Debug.Log("Hit Torso!");
            _playerCombatLog.text = "You Have Hit The Enemy's Torso!";


        }
        else
        {
            torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);
            Debug.Log("Missed Torso!");
            _playerCombatLog.text = "You Have Missed The Enemy's Torso!";
        }

        //currentTorsoHealth -= damage;

        //torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);

        if (currentTorsoHealth <= 0)
        {
            //Disable Visual Enemy Torso art.
            DisablePart(13);
        }
    }

    public void EnemyTakeHeadDamage(int damage, int gunChanceToHit)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit head is %15.
        if (randomNumber <= 15 + gunChanceToHit)
        {

            currentHeadHealth -= damage;
            headHealth.SetHeadHealth(currentHeadHealth, maxHeadHealth);
            Debug.Log("Hit Head!");
            _playerCombatLog.text = "You Have Hit The Enemy's Head!";

        }
        else
        {
            headHealth.SetHeadHealth(currentHeadHealth, maxHeadHealth);
            Debug.Log("Missed Head!");
            _playerCombatLog.text = "You Have Missed The Enemy's Head!";
        }

        //currentHeadHealth -= damage;

        //headHealth.SetHeadHealth(currentHeadHealth, maxHeadHealth);

        if (currentHeadHealth <= 0)
        {
            //Disable Visual Enemy Head art.
            DisablePart(12);
        }
    }

    public void EnemyTakeLeftLegDamage(int damage, int gunChanceToHit)
    {
        randomNumber = Random.Range(1, 100);

        //Default chance to hit left leg is %30.
        if (randomNumber <= 30 + gunChanceToHit)
        {

            currentLeftLegHealth -= damage;
            leftLegHealth.SetLeftLegHealth(currentLeftLegHealth, maxLeftLegHealth);
            Debug.Log("Hit Left Leg!");
            _playerCombatLog.text = "You Have Hit The Enemy's Left Leg!";

        }
        else
        {
            leftLegHealth.SetLeftLegHealth(currentLeftLegHealth, maxLeftLegHealth);
            Debug.Log("Missed Left Leg!");
            _playerCombatLog.text = "You Have Missed The Enemy's Left Leg!";
        }

        //currentLeftLegHealth -= damage;

        //leftLegHealth.SetLeftLegHealth(currentLeftLegHealth, maxLeftLegHealth);

        if (currentLeftLegHealth <= 0)
        {
            //Disable Visual Enemy Left Leg art.
            DisablePart(16);
        }
    }

    public void EnemyTakeRightLegDamage(int damage, int gunChanceToHit)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit right leg is %30.
        if (randomNumber <= 30 + gunChanceToHit)
        {

            currentRightLegHealth -= damage;
            rightLegHealth.SetRightLegHealth(currentRightLegHealth, maxRightLegHealth);
            Debug.Log("Hit Right Leg!");
            _playerCombatLog.text = "You Have Hit The Enemy's Right Leg!";

        }
        else
        {
            rightLegHealth.SetRightLegHealth(currentRightLegHealth, maxRightLegHealth);
            Debug.Log("Missed Right Leg!");
            _playerCombatLog.text = "You Have Missed The Enemy's Right Leg!";
        }

        //currentRightLegHealth -= damage;

        //rightLegHealth.SetRightLegHealth(currentRightLegHealth, maxRightLegHealth);

        if (currentRightLegHealth <= 0)
        {
            //Disable Visual Enemy Right Leg art.
            DisablePart(17);
        }
    }

    public void EnemyTakeLeftArmDamage(int damage, int gunChanceToHit)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit left arm is %35.
        if (randomNumber <= 35 + gunChanceToHit)
        {

            currentLeftArmHealth -= damage;
            leftArmHealth.SetLeftArmHealth(currentLeftArmHealth, maxLeftArmHealth);
            Debug.Log("Hit Left Arm!");
            _playerCombatLog.text = "You Have Hit The Enemy's Left Arm!";

        }
        else
        {
            leftArmHealth.SetLeftArmHealth(currentLeftArmHealth, maxLeftArmHealth);
            Debug.Log("Missed Left Arm!");
            _playerCombatLog.text = "You Have Missed The Enemy's Left Arm!";
        }

        //currentLeftArmHealth -= damage;

        //leftArmHealth.SetLeftArmHealth(currentLeftArmHealth, maxLeftArmHealth);

        if (currentLeftArmHealth <= 0)
        {
            //Disable Visual Enemy Left Arm art.
            DisablePart(14);
        }
    }

    public void EnemyTakeRightArmDamage(int damage, int gunChanceToHit)
    {

        randomNumber = Random.Range(1, 100);

        //Default chance to hit left arm is %35.
        if (randomNumber <= 35 + gunChanceToHit)
        {

            currentRightArmHealth -= damage;
            rightArmHealth.SetRightArmHealth(currentRightArmHealth, maxRightArmHealth);
            Debug.Log("Hit Right Arm!");
            _playerCombatLog.text = "You Have Hit The Enemy's Right Arm!";

        }
        else
        {
            rightArmHealth.SetRightArmHealth(currentRightArmHealth, maxRightArmHealth);
            Debug.Log("Missed Right Arm!");
            _playerCombatLog.text = "You Have Missed The Enemy's Right Arm!";
        }

        //currentRightArmHealth -= damage;

        //rightArmHealth.SetRightArmHealth(currentRightArmHealth, maxRightArmHealth);

        if (currentRightArmHealth <= 0)
        {
            //Disable Visual Enemy Right Arm art.
            DisablePart(15);
        }
    }

    public void DisablePart(int part)
    {
        partsArray[part].SetActive(false);
        //Debug.Log($"Disabled {part}");
    }

    public void EnablePart(int part)
    {
        partsArray[part].SetActive(true);
        Debug.Log($"Enabled {part}");
    }

}
