namespace BillyTamagochi.Objects
{
    class PlayerPurchases
    {
        bool RentUpgrade;
        bool EngineUpgrade;
        bool HealthUpgrade;
        bool HappinessUpgrade;
        bool StaminaUpgrade;
        bool SteroidUpgrade;
        public PlayerPurchases() { }
        public bool GetRentUpgrade()
        {
            return RentUpgrade;
        }
        public bool GetEngineUpgrade()
        {
            return EngineUpgrade;
        }
        public bool GetHealthUpgrade()
        {
            return HealthUpgrade;
        }
        public bool GetHappinessUpgrade()
        {
            return HappinessUpgrade;
        }
        public bool GetStaminaUpgrade()
        {
            return StaminaUpgrade;
        }
        public bool GetSteroidUpgrade()
        {
            return SteroidUpgrade;
        }
        public void SetRentUpgrade(bool RentUpgrade)
        {
            this.RentUpgrade = RentUpgrade;
        }
        public void SetEngineUpgrade(bool EngineUpgrade)
        {
            this.EngineUpgrade = EngineUpgrade;
        }
        public void SetHealthUpgrade(bool HealthUpgrade)
        {
            this.HealthUpgrade = HealthUpgrade;
        }
        public void SetHappinessUpgrade(bool HappinessUpgrade)
        {
            this.HappinessUpgrade = HappinessUpgrade;
        }
        public void SetStaminaUpgrade(bool StaminaUpgrade)
        {
            this.StaminaUpgrade = StaminaUpgrade;
        }
        public void SetSteroidUpgrade(bool SteroidUpgrade)
        {
            this.SteroidUpgrade = SteroidUpgrade;
        }
    }
}
