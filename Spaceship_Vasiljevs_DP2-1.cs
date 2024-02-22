using System;
class Spaceship{
    // lauki
    private string model;                       // kosmosa kuģa modelis
    private string name;                        // kosmosa kuģa nosaukums
    private double coorX;                       // kosmosa kuģa koordināta X
    private double coorY;                       // kosmosa kuģa koordināta Y
    private double coorZ;                       // kosmosa kuģa koordināta Z
    private bool isFlying;                      // vai kosmosa kuģis tagad lido
    private double acceleration;                // kosmosa kuģa paātrinājums. Var būt gan pozitīvs (kuģis lido uz priekšu), gan negatīvs (kuģis lido atpakaļ)
    private int passengers;                    // kosmosa kuģa pasažieru skaits (minimums - 0; maksimums - 50). Šis lauks nevar būt negatīvs
    private int oxygenPercentage;              // kosmosa kuģa skābekļa procentuālais daudzums (minimums - 0, maksimums - 100)
    private static int spaceshipCount = 0;      // statiskais izveidoto objektu skaitītājs
    
    // konstruktors ar visiem parametriem
    public Spaceship(string theModel, string theName, double theCoorX, double theCoorY, double theCoorZ, bool theIsFlying, double theAcceleration, int thePassengers, int theOxygenPercentage)
    {
        this.model = theModel;
        this.name = theName;
        this.coorX = theCoorX;
        this.coorY = theCoorY;
        this.coorZ = theCoorZ;
        this.isFlying = theIsFlying;
        this.acceleration = theAcceleration;
        if (thePassengers > 50 || thePassengers < 0)    // maksimālais pasažieru skaits ir 50, minimālais - 0. Ja ievadīta vērtība ir nepareiza, passengers lauks tiek iestatīts uz 0
        {
            Console.WriteLine("Nepareizi ievadīts kosmosa kuģa pasažieru skaits (min = 0, max = 50). Pasažieru skaits uz kosmosa kuģa ir iestatīts uz 0.");
            this.passengers = 0;
        }
        else
        {
            this.passengers = thePassengers;
        }
        
        if (theOxygenPercentage > 100 || theOxygenPercentage < 0)   // maksimālais skābekļa procentuālais daudzums ir 100, minimālais - 0. Ja ievadīta vērtība ir nepareiza, oxygenPercentage lauks tiek iestatīts uz 100
        {
            Console.WriteLine("Nepareizi ievadīts kosmosa kuģa skābekļa procentuālais daudzums (min = 0, max = 100). Kosmosa kuģa skābekļa procentuālais daudzums ir iestatīts uz 100.");
            this.oxygenPercentage = 100;
        }
        else
        {
            this.oxygenPercentage = theOxygenPercentage;
        }
        
        spaceshipCount++;
    }
    
    // konstruktors pēc noklusējuma (bez parametriem)
    public Spaceship()
    {
        this.model = "Unknown";
        this.name = "Unknown";
        this.coorX = 0.0;
        this.coorY = 0.0;
        this.coorZ = 0.0;
        this.isFlying = false;
        this.acceleration = 0;
        this.passengers = 0;
        this.oxygenPercentage = 100;
        spaceshipCount++;
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
    
    public bool IsFlying // isFlying property
    {
        get { return this.isFlying; }
        set { this.isFlying = value; }
    }
    
    public double Acceleration // speed property
    {
        get { return this.acceleration; }
        set { this.acceleration = value; }
    }
    
    public int Passengers // passengers property
    {
        get { return this.passengers; }
        set
        {
            if (value > 50 || value < 0)    // maksimālais pasažieru skaits ir 50, minimālais - 0. Ja vērtība ir nepareiza, passengers lauks paliek ar tādu pašu vērtību
            {
                Console.WriteLine("Nepareizi ievadīts kosmosa kuģa pasažieru skaits (min = 0, max = 50). Pasažieru skaits uz kosmosa kuģa nav izmainīts.");
            }
            else
            {
                this.passengers = value;
            }
        }
    }
    
    public int OxygenPercentage // oxygenPercentage property
    {
        get { return this.oxygenPercentage; }
        set
        {
            if (value > 100 || value < 0)   // maksimālais skābekļa procentuālais daudzums ir 100, minimālais - 0. Ja ievadīta vērtība ir nepareiza, oxygenPercentage lauks paliek ar tādu pašu vērtību
            {
                Console.WriteLine("Nepareizi ievadīts kosmosa kuģa skābekļa procentuālais daudzums (min = 0, max = 100). Kosmosa kuģa skābekļa procentuālais daudzums nav izmainīts.");
            }
            else
            {
                this.oxygenPercentage = value;
            }
        }
    }
    
    public static int SpaceshipCount  // static createdObjectCounter property, read-only
    {
        get {return spaceshipCount; }
    }

    public void WarpAlongCoorX (double distance)    // pārvietot kosmosa kuģi pa X asi par noteiktu vērtību (vērtība pozitīva - uz priekšu; negatīva - atpakaļ)
    {
        this.coorX += distance;
    }
    
    public void WarpAlongCoorY (double distance)    // pārvietot kosmosa kuģi pa Y asi par noteiktu vērtību (vērtība pozitīva - uz priekšu; negatīva - atpakaļ)
    {
        this.coorY += distance;
    }
    
    public void WarpAlongCoorZ (double distance)    // pārvietot kosmosa kuģi pa Z asi par noteiktu vērtību (vērtība pozitīva - uz priekšu; negatīva - atpakaļ)
    {
        this.coorZ += distance;
    }
    
    public void RemovePassengers (int amount)       // izvest no kosmosa kuģa noteiktu skaitu pasažieru
    {   
        if (this.passengers < amount)       // ja norādīta vērtība lielāka par iestādīto vērtību, aizliegt darbību
        {
            Console.WriteLine("Nav iespējams. Norādītais cilvēku skaits ir lielāks nekā pasažieru skaits uz kosmosa kuģa.");
        }
        else if (amount < 0)    // ja norādīta vērtība ir negatīva
        {
            Console.WriteLine("Nav iespējams. Vērtībai jābūt vienādai ar vai lielākai par nulli.");
        }
        else
        {
            this.passengers -= amount;
            Console.WriteLine("Izvest pasažierus: Darbība ir veiksmīga.");
        }
    }
    
    public void AddPassengers (int amount)     // pievienot kosmosa kuģim pasažierus
    {
        if (this.passengers + amount > 50)      // ja kopējā vērtība lielāka par maksimālo vērtību 50, aizliegt darbību
        {
            Console.WriteLine("Nav iespējams. Kopējā vērtība pārsniedz maksimālo iespējamo pasažieru skaitu kosmosa kuģī (50 cilvēki).");
        }
        else if (amount < 0)    // ja norādīta vērtība ir negatīva, aizliegt darbību
        {
            Console.WriteLine("Nav iespējams. Vērtībai jābūt vienādai ar vai lielākai par nulli.");
        }
        else
        {
            this.passengers += amount;
            Console.WriteLine("Pievienot pasažierus: Darbība ir veiksmīga.");
        }
    }
    
    public void AddOxygen (int percents)    // pievienot skābekli procentuāli
    {
        if (this.oxygenPercentage + percents > 100)     // ja kopējā vērtība lielāka par maksimālo vērtību 100, aizliegt darbību
        {
            Console.WriteLine("Nav iespējams. Kopējā vērtība pārsniedz maksimālo iespējamo skābekļa procentuālo daudzumu kosmosa kuģī (100 %)");
        }
        else if (percents < 0)      // ja norādīta vērtība ir negatīva, aizliegt darbību
        {
            Console.WriteLine("Nav iespējams. Vērtībai jābūt vienādai ar vai lielākai par nulli.");
        }
        else
        {
            this.oxygenPercentage += percents;
            Console.WriteLine("Pievienot skābekli procentuāli: Darbība ir veiksmīga.");
        }
    }
    
    public void ChangeAccelerByValue (double val)   // mainīt paātrinājumu uz doto vērtību (val > 0: paaugstināt; val < 0: samazināt)
    {
        this.acceleration += val;
    }
}
