using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponSelected : MonoBehaviour
{
    
    public InputHandler InputHandler;

    public TMP_Text _playerCombatLog;

    public enum WeaponTypes
    {
        MachineGun,
        AutoCannon,
        Cannon,
    }

    public void SelectedMachineGun()
    {
        InputHandler.playerWeaponDamage = 2;
        InputHandler.playerHitChance = 45;
        _playerCombatLog.text = "You Have Selected the Machine Gun!";
    }

    public void SelectedAutoCannon()
    {
        InputHandler.playerWeaponDamage = 5;
        InputHandler.playerHitChance = 25;
        _playerCombatLog.text = "You Have Selected the Auto Cannon!";
    }

    public void SelectedBattleCannon()
    {
        InputHandler.playerWeaponDamage = 10;
        InputHandler.playerHitChance = 5;
        _playerCombatLog.text = "You Have Selected the Battle Cannon!";
    }

}
