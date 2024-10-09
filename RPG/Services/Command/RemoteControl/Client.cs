using RPG.Services.Command.RemoteControl.Commands;
using RPG.Services.Command.RemoteControl.Receivers;

namespace RPG.Services.Command.RemoteControl;

public static class Client
{
    public static void RemoteControlTest()
    {
        Light livingRoomLight = new("Living Room");
        Light kitchenLight = new("Kitchen");
        CeilingFan ceilingFan = new("Living Room");
        GarageDoor garageDoor = new("Garage");
        Stereo stereo = new("Living Room");

        LightOnCommand livingRoomLightOn = new(livingRoomLight);
        LightOffCommand livingRoomLightOff = new(livingRoomLight);
        LightOnCommand kitchenLightOn = new(kitchenLight);
        LightOffCommand kitchenLightOff = new(kitchenLight);
        CeilingFanOnCommand livingRoomCeilingFanOn = new(ceilingFan);
        CeilingFanOffCommand livingRoomCeilingFanOff = new(ceilingFan);
        GarageDoorUpCommand garageDoorUp = new(garageDoor);
        GarageDoorDownCommand garageDoorDown = new(garageDoor);
        StereoOnWithCDCommand stereoOnWithCD = new(stereo);
        StereoOffCommand stereoOff = new(stereo);

        var remote = new Invokers.RemoteControl();
        remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remote.SetCommand(2, livingRoomCeilingFanOn, livingRoomCeilingFanOff);
        remote.SetCommand(3, garageDoorUp, garageDoorDown);
        remote.SetCommand(4, stereoOnWithCD, stereoOff);

        Console.WriteLine(remote.ToString());

        remote.OnButtonWasPressed(0);
        remote.OffButtonWasPressed(0);
        remote.OnButtonWasPressed(1);
        remote.OffButtonWasPressed(1);
        remote.OnButtonWasPressed(2);
        remote.OffButtonWasPressed(2);
        remote.OnButtonWasPressed(3);
        remote.OffButtonWasPressed(3);
        remote.OnButtonWasPressed(4);
        remote.OffButtonWasPressed(4);
    }
}
