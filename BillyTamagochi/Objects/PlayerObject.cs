namespace BillyTamagochi.Objects
{
    class PlayerObject
    {
        //Base Stats
        public double health = 50;
        public double stamina = 50;
        public double happiness = 50;
        public double muscleBuilt = 0;
        public double wallet = 100000; //REMINDER : Reset from testing value
        public int maxHealth = 100;
        public int maxStamina = 100;
        public int maxHappiness = 100;
        public int rentTimer = 0;
        public int rentLimit = 60;
        public double healthModifier = 0;
        public double staminaModifier = 2;
        public double happinessModifier = -1;
        public double muscleBuildingModifier = 2;
        public double walletModifier = 0;
        public PlayerPurchases Purchases = new PlayerPurchases();

        public PlayerObject()
        {

        }

        public void SetStatModifiers(double happinessMult, double staminaMult, double healthMult, double walletMult)
        {
            healthModifier = healthMult;
            staminaModifier = staminaMult;
            happinessModifier = happinessMult;
            walletModifier = walletMult;
        }

        public double GetPlayerHealth()
        {
            return health;
        }

        public double GetPlayerStamina()
        {
            return stamina;
        }

        public double GetPlayerHappiness()
        {
            return happiness;
        }
        public double GetPlayerWallet()
        {
            return wallet;
        }
        public double GetPlayerMuscle()
        {
            return muscleBuilt;
        }
        public int GetRentLimit()
        {
            return rentLimit;
        }
        public int GetMaxHealth()
        {
            return maxHealth;
        }
        public int GetMaxStamina()
        {
            return maxStamina;
        }
        public int GetMaxHappiness()
        {
            return maxHappiness;
        }
        public void SetMaxHealth(int maxHealth)
        {
            this.maxHealth = maxHealth;
        }
        public void SetMaxStamina(int maxStamina)
        {
            this.maxStamina = maxStamina;
        }
        public void SetMaxHappiness(int maxHappiness)
        {
            this.maxHappiness = maxHappiness;
        }
        public void SetMuscleBuildingModifier(int muscleBuildingModifier)
        {
            this.muscleBuildingModifier = muscleBuildingModifier;
        }
        public void SetMuscleBuilt(int muscleBuilt)
        {
            this.muscleBuilt = muscleBuilt;
        }
        public void SetRentLimit(int rentLimit)
        {
            this.rentLimit = rentLimit;
        }

        public void SetWallet(double wallet)
        {
            this.wallet = wallet;
        }
        public bool PlayerWalletTick()
        {
            wallet += walletModifier;
            rentTimer += 1;
            if (rentTimer == rentLimit)
            {
                rentTimer = 0;
                wallet -= 100;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PlayerHealthTick()
        {
            if (!(health + healthModifier > 100 || health + healthModifier <= 1))
            {
                health += healthModifier;
                return true;
            }
            else
            {
                SetStatModifiers(0, 0, 0, 0);
                return false;
            }
        }

        public bool PlayerStaminaTick()
        {
            if (!(stamina + staminaModifier > 100 || stamina + staminaModifier <= 1))
            {
                stamina += staminaModifier;
                return true;
            }
            else
            {
                SetStatModifiers(0, 0, 0, 0);
                return false;
            }
        }

        public bool PlayerHappinessTick()
        {
            if (!(happiness + happinessModifier > 100 || happiness + happinessModifier <= 1))
            {
                happiness += happinessModifier;
                return true;
            }
            else
            {
                SetStatModifiers(0, 0, 0, 0);
                return false;
            }
        }
    }
}
