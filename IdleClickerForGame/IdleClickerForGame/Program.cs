using System;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput.Events;
using WindowsInput.Events.Sources;

namespace IdleClickerForGame
{
    internal class Programa
    {
        private static bool IsWork = true;
        static void Main(string[] args)
        {
            using (var Keyboard = WindowsInput.Capture.Global.KeyboardAsync())
            {
                Keyboard.KeyEvent += Keyboard_KeyEvent;

                Thread.Sleep(2000);
                WorkAutoClickerNinja();
            }
        }

        private static void Keyboard_KeyEvent(object sender, EventSourceEventArgs<KeyboardEvent> e)
        {
            if (e.Data?.KeyDown?.Key == KeyCode.A || e.Data?.KeyUp?.Key == KeyCode.A)
            {
                IsWork = false;
            }
        }

        private static void WorkAutoClickerNinja()
        {
            while (IsWork)
            {
                var dateTime = DateTime.Now;

                while ((DateTime.Now - dateTime).Seconds <= AutoclickerConfiguration.Instance.AllBuySection.Value)
                {
                    var taskSpaces = AutoClicker.PressSpace();
                    var taskBuy = AutoClicker.BuyAllStart();
                    Task.WaitAny(taskBuy);
                }

                while ((DateTime.Now - dateTime).Seconds <= AutoclickerConfiguration.Instance.LastBuySection.Value)
                {
                    var taskSpaces = AutoClicker.PressSpace();
                    var taskBuy = AutoClicker.BuyLast();
                    Task.WaitAny(taskBuy);
                }

                var taskRebirth = AutoClicker.Rebirth();
                Task.WaitAny(taskRebirth);
            }
        }
    }
}