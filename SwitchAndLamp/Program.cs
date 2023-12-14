using SwitchAndLamp;

Light lamp = new Light();
Switch lightSwitch = new Switch();

// 将灯作为观察者注册到开关
lightSwitch.SwitchStateChanged += lampState =>
{
    if (lampState)
    {
        lamp.TurnOn();
    }
    else
    {
        lamp.TurnOff();
    }
};

// 模拟开关操作
lightSwitch.Toggle();
lightSwitch.Toggle();