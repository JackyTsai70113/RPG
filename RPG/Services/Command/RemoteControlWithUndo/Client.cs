using RPG.Services.Command.RemoteControlWithUndo.Commands;
using RPG.Services.Command.RemoteControlWithUndo.Receivers;

namespace RPG.Services.Command.RemoteControlWithUndo;

public static class Client
{
    public static void RemoteControlTest()
    {
        Light livingRoomLight = new("Living Room");
        CeilingFan ceilingFan = new("Living Room");

        LightOnCommand livingRoomLightOn = new(livingRoomLight);
        LightOffCommand livingRoomLightOff = new(livingRoomLight);
        CeilingFanHighCommand livingRoomCeilingFanHigh = new(ceilingFan);
        CeilingFanMediumCommand livingRoomCeilingFanMedium = new(ceilingFan);
        CeilingFanOffCommand livingRoomCeilingFanOff = new(ceilingFan);

        var remote = new Invokers.RemoteControl();
        remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

        remote.OnButtonWasPressed(0);
        remote.OffButtonWasPressed(0);
        Console.WriteLine(remote);
        remote.UndoButtonWasPressed();
        remote.OffButtonWasPressed(0);
        remote.OnButtonWasPressed(0);
        Console.WriteLine(remote);
        remote.UndoButtonWasPressed();

        Console.WriteLine("-----");

        remote.SetCommand(0, livingRoomCeilingFanMedium, livingRoomCeilingFanOff);
        remote.SetCommand(1, livingRoomCeilingFanHigh, livingRoomCeilingFanOff);

        remote.OnButtonWasPressed(0);
        remote.OffButtonWasPressed(0);
        Console.WriteLine(remote);
        remote.UndoButtonWasPressed();
        remote.OnButtonWasPressed(1);
        Console.WriteLine(remote);
        remote.UndoButtonWasPressed();
    }

    public static void PartyTest()
    {
        Light light = new("Living Room");
        CeilingFan ceilingFan = new("Living Room");
        Stereo stereo = new("Living Room");
        Hottub hottub = new();

        LightOnCommand lightOn = new(light);
        LightOffCommand lightOff = new(light);
        StereoOnWithCDCommand stereoOn = new(stereo);
        StereoOffCommand stereoOff = new(stereo);
        CeilingFanHighCommand ceilingFanHigh = new(ceilingFan);
        CeilingFanOffCommand ceilingFanOff = new(ceilingFan);
        HottubOnCommand hottubOn = new(hottub);
        HottubOffCommand hottubOff = new(hottub);

        ICommand[] partyOn = { lightOn, stereoOn, ceilingFanHigh, hottubOn };
        ICommand[] partyOff = { lightOff, stereoOff, ceilingFanOff, hottubOff };

        MacroCommand partyOnMacro = new(partyOn);
        MacroCommand partyOffMacro = new(partyOff);

        Invokers.RemoteControl remote = new();
        remote.SetCommand(0, partyOnMacro, partyOffMacro);

        Console.WriteLine(remote);
        Console.WriteLine("--- Pushing Macro On ---");
        remote.OnButtonWasPressed(0);
        Console.WriteLine("--- Pushing Macro Off ---");
        remote.OffButtonWasPressed(0);
    }
}
