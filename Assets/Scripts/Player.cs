using System.Collections;
using System.Collections.Generic;
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

    
    public void PlayerTakeTorsoDamage(int damage)
    {
        currentTorsoHealth -= damage;

        torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);

        if (currentTorsoHealth <= 0)
        {
            DisablePart(1);
        }
    }

    public void PlayerTakeHeadDamage(int damage)
    {
        currentHeadHealth -= damage;

        headHealth.SetHeadHealth(currentHeadHealth, maxHeadHealth);

        if (currentHeadHealth <= 0)
        {
            DisablePart(0);
        }
    }

    public void PlayerTakeLeftLegDamage(int damage)
    {
        currentLeftLegHealth -= damage;

        leftLegHealth.SetLeftLegHealth(currentLeftLegHealth, maxLeftLegHealth);

        if (currentLeftLegHealth <= 0)
        {
            DisablePart(4);
        }
    }

    public void PlayerTakeRightLegDamage(int damage)
    {
        currentRightLegHealth -= damage;

        rightLegHealth.SetRightLegHealth(currentRightLegHealth, maxRightLegHealth);

        if (currentRightLegHealth <= 0)
        {
            DisablePart(5);
        }
    }

    public void PlayerTakeLeftArmDamage(int damage)
    {
        currentLeftArmHealth -= damage;

        leftArmHealth.SetLeftArmHealth(currentLeftArmHealth, maxLeftArmHealth);

        if (currentLeftArmHealth <= 0)
        {
            DisablePart(2);
        }
    }

    public void PlayerTakeRightArmDamage(int damage)
    {
        currentRightArmHealth -= damage;

        rightArmHealth.SetRightArmHealth(currentRightArmHealth, maxRightArmHealth);

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
