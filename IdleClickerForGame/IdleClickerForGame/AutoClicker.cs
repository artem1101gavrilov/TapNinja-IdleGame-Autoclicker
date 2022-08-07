using System.Threading.Tasks;

namespace IdleClickerForGame
{
    public static class AutoClicker
    {
        public static async Task PressSpace()
        {
            await WindowsInput.Simulate.Events()
                    .ManyPressSpace()
                    .Invoke();
        }

        public static async Task BuyAll()
        {
            await WindowsInput.Simulate.Events()
                .BuyBuildings()
                .BuyAbilities()
                .Invoke();
        }

        public static async Task BuyAllStart()
        {
            await WindowsInput.Simulate.Events()
                .BuyBuildingsStart()
                .BuyAbilities()
                .Invoke();
        }

        public static async Task BuyLast()
        {
            await WindowsInput.Simulate.Events()
                .BuyLastBuilding()
                .BuyAbilities()
                .Invoke();
        }

        public static async Task Rebirth()
        {
            await WindowsInput.Simulate.Events()
                .Rebirth()
                .Invoke();
        }
    }
}