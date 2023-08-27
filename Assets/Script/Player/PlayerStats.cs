using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fravio
{
    public class PlayerStats : MonoBehaviour
    {
        public int healthLevel = 10;
        public int maxHealth;
        public int currentHealth;

        public int staminaLevel = 10;
        public int maxStamina;
        public int currentStamina;

        public int magikaLevel = 10;
        public int maxMagika;
        public int currentMagika;

        public HealthBar healthBar;
        public StaminaBar staminaBar;
        public MagikaBar magikaBar;
        AnimatorHandler animatorHandler;

        private void Awake() 
        {
            healthBar = FindObjectOfType<HealthBar>();
            staminaBar = FindObjectOfType<StaminaBar>();
            magikaBar = FindObjectOfType<MagikaBar>();
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
        }
        void Start()
        {
            maxHealth = SetMaxHealthFromHealthLevel();
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
            healthBar.SetCurrentHealth(currentHealth);
            
            maxStamina = SetMaxStaminaFromHealthLevel();
            currentStamina = maxStamina;

            maxMagika = SetMaxMagikaFromHealthLevel();
            currentMagika = maxStamina;
        }

        private int SetMaxHealthFromHealthLevel()
        {
            maxHealth = healthLevel * 10;
            return maxHealth;
        }

        private int SetMaxStaminaFromHealthLevel()
        {
            maxStamina = staminaLevel * 10;
            return maxStamina;
        }

        private int SetMaxMagikaFromHealthLevel()
        {
            maxMagika = magikaLevel * 10;
            return maxMagika;
        }
        
        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth - damage;
            healthBar.SetCurrentHealth(currentHealth);

            animatorHandler.PlayTargetAnimation("Damage_01", true);

            if(currentHealth <= 0)
            {
                currentHealth = 0;
                animatorHandler.PlayTargetAnimation("Dying", true);
            }
        }

        public void TakeStaminaDamage(int damage)
        {
            currentStamina = currentStamina - damage;
            staminaBar.SetCurrentStamina(currentStamina);   
        }

        public void TakeMagikaDamage(int damage)
        {
            currentMagika = currentMagika - damage;
            magikaBar.SetCurrentMagika(currentMagika);   
        }
    }    
}

