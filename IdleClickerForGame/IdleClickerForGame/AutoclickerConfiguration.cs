using System.Configuration;

namespace IdleClickerForGame
{
    internal class AutoclickerConfiguration : ConfigurationSection
    {
        public static AutoclickerConfiguration Instance
        {
            get
            {
                return (AutoclickerConfiguration)ConfigurationManager.GetSection(nameof(AutoclickerConfiguration));
            }
        }

        private AutoclickerConfiguration() { }

        [ConfigurationProperty("AllBuy", IsRequired = false)]
        public SecondSection AllBuySection
        {
            get => (SecondSection)this["AllBuy"];
            set => this["AllBuy"] = value;
        }

        [ConfigurationProperty("LastBuy", IsRequired = false)]
        public SecondSection LastBuySection
        {
            get => (SecondSection)this["LastBuy"];
            set => this["LastBuy"] = value;
        }
    }

    public class SecondSection : ConfigurationElement
    {
        private const string SectionValue = "second";
        [ConfigurationProperty(SectionValue, IsRequired = false)]
        public int Value
        {
            get => (int)this[SectionValue];
            set => this[SectionValue] = value;
        }
    }
}