using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fravio
{
    [CreateAssetMenu(menuName = "Items/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("Animação parado")]
        public string right_hand_idle;
        public string left_hand_idle;


        [Header("Animação de ataque de uma mão")]
        public string OH_Light_Attack_1;
        public string OH_Light_Attack_2;
        public string OH_Heavy_Attack_1;

        [Header ("Custo de Estamina")]
        public int baseStamina;
        public float lightAttackMultiplier;
        public float heavyAttackMultiplier;
    }
}
