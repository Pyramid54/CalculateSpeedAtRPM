class CalculateSpeedAtRPM {
    // detpk = Diesel engine TPK (turns per knots)
    // eetpksurf = Electrical engine TPK while surfaced
    // eetpksub = Electrical engine TPK while submerged
    // If you're wondering how we achieved this TPK value, the formula for it is the (Max engine RPM / Max speed) (Values below are in simplest form)
    static double detpk = 80.0 / 3;
    static double eetpksurf = 300.0 / 11;
    static double eetpksub = 300 / 7.7;

    static double rpm;

    static int engineType;

    public static double CalculateSpeed(double rpm)
    {
        double speed;
        
        switch (engineType)
        {
            // Diesel engine
            case 1:
                speed = rpm / detpk;
                break;

            // Electrical engine surfaced
            case 2:
                speed = rpm / eetpksurf;
                break;

            // Electrical engine submerged
            case 3:
                speed = rpm / eetpksub;
                break;

            default:
                Console.WriteLine("Invalid choice");
                speed = 0;
                break;
        }

        return speed;

        // If you're wondering how we calculated the speed, the formula for it is (RPM / TPK)
    }

    static void Main(string[] args)
    {
        Console.Write("Enter 1 for diesel engine, 2 for electrical engine while surfaced, 3 for electrical engine while submerged: ");
        engineType = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter RPM: ");
        rpm = Convert.ToInt64(Console.ReadLine());

        Console.Write("Speed: " + CalculateSpeed(rpm) + " kts");

        Console.ReadKey();
    }
}