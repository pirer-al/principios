namespace DesignPatterns.Behavioral.Command
{
    public class RemoteControl
    {
        // Invoker
        private Light _light;

        public RemoteControl(Light light)
        {
            this._light = light;
        }

        public void PressButton(bool turnOn)
        {
            if (turnOn)
            {
                _light.TurnOff();
            }
            else
            {
                _light.TurnOn();
            }
        }

    }
}