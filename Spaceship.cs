using System;
class Spaceship{
    // lauki
    private string model;
    private string name;
    private double coorX;
    private double coorY;
    private double coorZ;
    private double speed;
    private int passengers;
    private int oxygenPercentage;
    private static int createdObjectCounter = 0;    // ???
    
    // konstruktors ar visiem parametriem
    public Spaceship(string theModel, string theName, double theCoorX, double theCoorY, double theCoorZ, double theSpeed, int thePassengers, int theOxygenPercentage)
    {
        this.model = theModel;
        this.name = theName;
        this.coorX = theCoorX;
        this.coorY = theCoorY;
        this.coorZ = theCoorZ;
        this.speed = theSpeed;
        this.passengers = thePassengers;
        this.oxygenPercentage = theOxygenPercentage;
        createdObjectCounter++;
    }
    
    // konstruktors pēc noklusējuma (nav neviena parametra)
    public Spaceship()
    {
        this.model = "Unknown";
        this.name = "Unknown";
        this.coorX = 0.0;
        this.coorY = 0.0;
        this.coorZ = 0.0;
        this.speed = 0;
        this.passengers = 0;
        this.oxygenPercentage = 100;
        createdObjectCounter++;
    }
    
    public string Model // model property
    {
        get { return this.model; }
        set { this.model = value; }
    }
    
    public string Name // name property
    {
        get { return this.name; }
        set { this.name = value; }
    }
    
    public double CoorX // coorX property
    {
        get { return this.coorX; }
        set { this.coorX = value; }
    }
    
    public double CoorY // coorY property
    {
        get { return this.coorY; }
        set { this.coorY = value; }
    }
    
    public double CoorZ // coorZ property
    {
        get { return this.coorZ; }
        set { this.coorZ = value; }
    }
    
    public double Speed // speed property
    {
        get { return this.speed; }
        set { this.speed = value; }
    }
    
    public int Passengers // passengers property
    {
        get { return this.passengers; }
        set { this.passengers = value; }
    }
    
    public int OxygenPercentage // oxygenPercentage property
    {
        get { return this.oxygenPercentage; }
        set { this.oxygenPercentage = value; }
    }
    
    // public static int GetCreatedObjectCounter()  // createdObjectCounter property, read-only
    // {
    //     return createdObjectCounter;
    // } ???

}
