using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;

    private PlayerInventory inventory;

    public int maxTorsoHealth = 20;
    public int currentTorsoHealth;

    public TorsoHealth torsoHealth;

    private void Awake()
    {

        inventory = new PlayerInventory();
        uiInventory.SetInventory(inventory);

    }

    void Start()
    {

        currentTorsoHealth = maxTorsoHealth;
        torsoHealth.SetTorsoStartColor();
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //TakeDamage(2);
        }
        
    }

    /*
    void TakeDamage(int damage)
    {
        currentTorsoHealth -= damage;

        torsoHealth.SetTorsoHealth(currentTorsoHealth, maxTorsoHealth);
    }
    */
}
