using System;
class Spaceship{
    // lauki
    private string model;
    private string name;
    private double koorX;
    private double koorY;
    private double koorZ;
    private double speed;
    private int passengers;
    private int oxygenPercentage;
    private int createdObjectCounter = 0;
    
    // konstruktors ar parametriem
    public Spaceship(string theModel, string theName, double theKoorX, double theKoorY, double theKoorZ, double theSpeed, int thePassengers, int theOxygenPercentage)
    {
        this.model = theModel;
        this.name = theName;
        this.koorX = theKoorX;
        this.koorY = theKoorY;
        this.koorZ = theKoorZ;
        this.speed = theSpeed;
        this.passengers = thePassengers;
        this.oxygenPercentage = theOxygenPercentage;
        createdObjectCounter++;
    }
    
    // konstruktors pēc noklusējuma
    public Spaceship()
    {
        this.model = "Unknown";
        this.name = "Unknown";
        this.koorX = 0.0;
        this.koorY = 0.0;
        this.koorZ = 0.0;
        this.speed = 0;
        this.passengers = 0;
        this.oxygenPercentage = 100;
    }
}
