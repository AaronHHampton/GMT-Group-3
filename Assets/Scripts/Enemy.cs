using System.Collections;
using System.Collections.Generic;
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
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TakeHeadDamage(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TakeTorsoDamage(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TakeLeftArmDamage(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            TakeRightArmDamage(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            TakeLeftLegDamage(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            TakeRightLegDamage(2);
        }
        
    }


    void TakeTorsoDamage(int damage)
    {
        currentTorsoHealth -= damage;

        torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);
    }

    void TakeHeadDamage(int damage)
    {
        currentHeadHealth -= damage;

        headHealth.SetHeadHealth(currentHeadHealth, maxHeadHealth);
    }

    void TakeLeftLegDamage(int damage)
    {
        currentLeftLegHealth -= damage;

        leftLegHealth.SetLeftLegHealth(currentLeftLegHealth, maxLeftLegHealth);
    }

    void TakeRightLegDamage(int damage)
    {
        currentRightLegHealth -= damage;

        rightLegHealth.SetRightLegHealth(currentRightLegHealth, maxRightLegHealth);
    }

    void TakeLeftArmDamage(int damage)
    {
        currentLeftArmHealth -= damage;

        leftArmHealth.SetLeftArmHealth(currentLeftArmHealth, maxLeftArmHealth);
    }

    void TakeRightArmDamage(int damage)
    {
        currentRightArmHealth -= damage;

        rightArmHealth.SetRightArmHealth(currentRightArmHealth, maxRightArmHealth);
    }

}
