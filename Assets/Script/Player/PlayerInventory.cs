using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fravio
{
    public class PlayerInventory : MonoBehaviour
    {
        WeaponSlotManager weaponSlotManager;

        public WeaponItem rightWeapon;
        public WeaponItem leftWeapon;

        public WeaponItem unarmedWeapon;

        public WeaponItem[] weaponsInRightHandSlots = new WeaponItem[1];
        public WeaponItem[] weaponsInLeftHandSlots = new WeaponItem[1];

        public int currentRightWeaponIndex = -1;
        public int currentLeftWeaponIndex = -1;

        public List<WeaponItem> weaponsInventory;


        private void Awake()
        {
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        }

        void Start()
        {
            rightWeapon = unarmedWeapon;
            leftWeapon = unarmedWeapon;
        }

        public void ChangeRightWeapon()
        {
            /*currentRightWeaponIndex = currentRightWeaponIndex + 1;

            if(currentRightWeaponIndex == 0 && weaponsInRightHandSlots[0] != null)
            {
                rightWeapon = weaponsInRightHandSlots[currentRightWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInRightHandSlots[currentRightWeaponIndex], false);
            }
            else if(currentRightWeaponIndex == 0 && weaponsInRightHandSlots[0] == null) 
            {
                currentRightWeaponIndex = currentRightWeaponIndex +1;
            } 
            else if(currentRightWeaponIndex == 1 && weaponsInRightHandSlots[1] == null)
            {
                rightWeapon = weaponsInRightHandSlots[currentRightWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInRightHandSlots[currentRightWeaponIndex], false);
            }
            else if(currentRightWeaponIndex == 1 && weaponsInRightHandSlots[1] == null)
            {
                currentRightWeaponIndex = currentRightWeaponIndex + 1;
            }

            else if (currentRightWeaponIndex > weaponsInRightHandSlots.Length -1)
            {
                currentRightWeaponIndex = -1;
                rightWeapon = unarmedWeapon;
                weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, false);
            }*/

                WeaponItem weapon = null;
            while(currentRightWeaponIndex < weaponsInRightHandSlots.Length-1 && weapon == null)
            {
                currentRightWeaponIndex += 1;
                weapon = weaponsInRightHandSlots[currentRightWeaponIndex];
            }
            if(weapon != null)
            {
                rightWeapon = weapon;
                weaponSlotManager.LoadWeaponOnSlot(weapon, false);
            }
            else
            {
                currentRightWeaponIndex = -1;
                rightWeapon = unarmedWeapon;
                weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, false);
            }
        }

        public void ChangeLeftWeapon()
        {
            /*currentLeftWeaponIndex = currentLeftWeaponIndex + 1;

            if(currentLeftWeaponIndex == 0 && weaponsInLeftHandSlots[0] != null)
            {
                leftWeapon = weaponsInLeftHandSlots[currentLeftWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInLeftHandSlots[currentLeftWeaponIndex], false);
            }
            else if(currentLeftWeaponIndex == 0 && weaponsInLeftHandSlots[0] == null) 
            {
                currentLeftWeaponIndex = currentLeftWeaponIndex +1;
            } 
            else if(currentLeftWeaponIndex == 1 && weaponsInLeftHandSlots[1] == null)
            {
                leftWeapon = weaponsInLeftHandSlots[currentLeftWeaponIndex];
                weaponSlotManager.LoadWeaponOnSlot(weaponsInLeftHandSlots[currentLeftWeaponIndex], false);
            }
            else if(currentLeftWeaponIndex == 1 && weaponsInLeftHandSlots[1] == null)
            {
                currentLeftWeaponIndex = currentLeftWeaponIndex + 1;
            }

            else if (currentLeftWeaponIndex > weaponsInLeftHandSlots.Length -1)
            {
                currentLeftWeaponIndex = -1;
                leftWeapon = unarmedWeapon;
                weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, false);
            }*/

            WeaponItem weapon = null;
            while(currentLeftWeaponIndex < weaponsInLeftHandSlots.Length-1 && weapon == null)
            {
                currentLeftWeaponIndex += 1;
                weapon = weaponsInLeftHandSlots[currentLeftWeaponIndex];
            }
            if(weapon != null)
            {
                leftWeapon = weapon;
                weaponSlotManager.LoadWeaponOnSlot(weapon, false);
            }
            else
            {
                currentLeftWeaponIndex = -1;
                leftWeapon = unarmedWeapon;
                weaponSlotManager.LoadWeaponOnSlot(unarmedWeapon, false);
            }
        }
    }    
}
