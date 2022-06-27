using System.Drawing;

public static class Engine
{
    public static Color BackgroundColor = Color.Gray;

    //Amount of ticks executed last second.
    public static int TPS { get => MainClass.TPS; }

    //Amount of frames executed last second.
    public static int FPS { get=> MainClass.FPS; }

    //Tick count since the engine started
    public static long Ticks {get => MainClass.TickCount;} 

    //The set amount of ticks the program is set to try to process every second
    public static readonly double MaxTPS = 60;

    //The set amount of rendered frames the program is set to try to process every second
    public static readonly double MaxFPS = 180;

    //These are the amount of ticks that are about to be executed very soon to conpensate for a slowdown
    public static int TPSSlowdown = 0;
}