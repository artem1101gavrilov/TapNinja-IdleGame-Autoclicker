using WindowsInput.Events;

namespace IdleClickerForGame
{
    public static class InputExtension
    {
        public static EventBuilder ManyPressSpace(this EventBuilder eventBuilder)
        {
            for (var i = 0; i <= 3000; i ++)
            {
                eventBuilder.Wait(10)
                    .Click(KeyCode.Space);
            }
            return eventBuilder;
        }

        public static EventBuilder Rebirth(this EventBuilder eventBuilder)
            => eventBuilder.Wait(1000)
                .Click(KeyCode.D3)
                .Wait(100)
                .MoveTo(1400, 250)
                .Click(ButtonCode.Left)
                .Wait(1000)
                .MoveTo(1300, 650)
                .Click(ButtonCode.Left);

        public static EventBuilder BuyAbilities(this EventBuilder eventBuilder)
        {
            eventBuilder.Wait(5000)
                .Click(KeyCode.D2);

            eventBuilder.BuyAbility(250);
            eventBuilder.BuyAbility(250);
            eventBuilder.BuyAbility(250);
            eventBuilder.BuyAbility(250);

            for (var i = 250; i <= 740; i += 40)
            {
                eventBuilder.BuyAbility(i);
            }

            return eventBuilder;
        }

        public static EventBuilder BuyLastBuilding(this EventBuilder eventBuilder)
        {
            return eventBuilder.Wait(2000)
                .Click(KeyCode.D1)
                .Wait(50)
                .BuyBuild(780);
        }

        public static EventBuilder BuyBuildings(this EventBuilder eventBuilder)
        {
            eventBuilder.Wait(5000)
                .Click(KeyCode.D1)
                .Wait(50)
                .BuyBuild(780)
                .BuyBuild(680)
                .BuyBuild(590)
                .BuyBuild(510)
                .BuyBuild(430)
                .BuyBuild(350)
                .BuyBuild(250);

            for (var i = 0; i <= 20; ++i)
            {
                eventBuilder.Wait(100)
                    .Scroll(ButtonCode.VScroll, ButtonScrollDirection.Up)
                    .Click(ButtonCode.Left)
                    .Wait(10)
                    .Click(KeyCode.Space);
            }

            eventBuilder.Wait(100);

            for (int i = 0; i < 30; i++)
            {
                eventBuilder.Scroll(ButtonCode.VScroll, ButtonScrollDirection.Down)
                    .Wait(10)
                    .Click(KeyCode.Space);
            }

            return eventBuilder;
        }

        public static EventBuilder BuyBuildingsStart(this EventBuilder eventBuilder)
        {
            eventBuilder.Wait(300)
                .Click(KeyCode.D1);

            for (int i = 0; i < 10; i++)
            {
                eventBuilder
                    .Wait(500)
                    .MoveTo(1400, 820)
                    .Click(ButtonCode.Left)
                    .Wait(10)
                    .Click(KeyCode.Q)
                    .Wait(10)
                    .Click(KeyCode.W)
                    .Wait(10);
            }

                /*for (int i = 0; i < 10; i++)
                {
                    eventBuilder.Scroll(ButtonCode.VScroll, ButtonScrollDirection.Down)
                        .Wait(10);
                    eventBuilder.Scroll(ButtonCode.VScroll, ButtonScrollDirection.Down)
                        .Wait(10);
                    eventBuilder.Wait(100)
                        .Click(KeyCode.D1)
                        .Wait(50)
                        .BuyBuild(780)
                        .BuyBuild(680)
                        .BuyBuild(590)
                        .BuyBuild(510)
                        .BuyBuild(430)
                        .BuyBuild(350)
                        .BuyBuild(250);
                }

                for (var i = 0; i <= 20; ++i)
                {
                    eventBuilder.Wait(100)
                        .Scroll(ButtonCode.VScroll, ButtonScrollDirection.Up)
                        .Click(ButtonCode.Left)
                        .Wait(10);
                }

                eventBuilder.Wait(100);

                for (int i = 0; i < 30; i++)
                {
                    eventBuilder.Scroll(ButtonCode.VScroll, ButtonScrollDirection.Down)
                        .Wait(10)
                        .Click(KeyCode.Space);
                }*/

            return eventBuilder;
        }

        private static EventBuilder BuyBuild(this EventBuilder eventBuilder, int y)
        {
            return eventBuilder
                .Wait(50)
                .MoveTo(1400, y)
                .Click(ButtonCode.Left)
                .Wait(10)
                .Click(KeyCode.Q)
                .Wait(10)
                .Click(KeyCode.W)
                .Wait(10)
                .Click(KeyCode.Space);
        }

        private static EventBuilder BuyAbility(this EventBuilder eventBuilder, int y)
        {
            return eventBuilder
                .Wait(50)
                .MoveTo(1400, y)
                .Click(ButtonCode.Left)
                .Wait(10)
                .Click(ButtonCode.Left)
                .Wait(10)
                .Click(ButtonCode.Left)
                .Wait(10)
                .Click(KeyCode.Q)
                .Wait(10)
                .Click(KeyCode.W)
                .Wait(10)
                .Click(KeyCode.Space);
        }
    }
}