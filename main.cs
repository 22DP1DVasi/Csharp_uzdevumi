using System;
class Program {
  static void Main() {
    // izveido pirmo objektu
    Spaceship spcship1 = new Spaceship("SpaceX", "Arbiter", 243.52, 565.24, -845.30, true, 11000, 50, 50);
    Spaceship spcship2 = new Spaceship();
    
    // Paradām konsolē info par pirmo objektu
    Console.WriteLine(
        @"#1: Model = {0}, Name = {1},
    X: {2}, Y: {3}, Z: {4},
    Is spaceship flying: {5}, Acceleration = {6}, Passengers = {7}, Percentage of oxygen = {8}",
        spcship1.Model, spcship1.Name, spcship1.CoorX, spcship1.CoorY, spcship1.CoorZ,
        spcship1.IsFlying, spcship1.Acceleration, spcship1.Passengers, spcship1.OxygenPercentage
        );
    Console.WriteLine("");
    
    // Paradām konsolē info par otro objektu
    Console.WriteLine(
        @"#2: Model = {0}, Name = {1},
    X: {2}, Y: {3}, Z: {4},
    Is spaceship flying: {5}, Acceleration = {6}, Passengers = {7}, Percentage of oxygen = {8}",
        spcship2.Model, spcship2.Name, spcship2.CoorX, spcship2.CoorY, spcship2.CoorZ,
        spcship2.IsFlying, spcship2.Acceleration, spcship2.Passengers, spcship2.OxygenPercentage
        );
    Console.WriteLine("");
    
    // Nomainīt otra kosmosa kuģa modeli un vārdu
    spcship2.Model = "Galax";
    spcship2.Name = "Oppy";
    
    // Nomainīt pirma kosmosa kuģa koordināti X par 100 un koordināti Z par -200
    spcship1.WarpAlongCoorX(100);
    spcship1.WarpAlongCoorZ(-200);
    
    // Izvest 20 pasažierus no otra kosmosa kuģa
    spcship1.RemovePassengers(20);
    
    // Pievienot 25% skābekļa pirmam kosmosa kuģim
    spcship1.AddOxygen(25);
    
    // Atņemt no pirma kosmosa kuģa paātrinājuma 1000.55 vienības
    spcship1.ChangeAccelerByValue(-1000.55);
    
    Console.WriteLine("");
    
    // Paradīt, cik objekti bija izveidoti
    Console.WriteLine("Total spaceships: {0}", Spaceship.SpaceshipCount);
    Console.WriteLine("");
    
    // Paradām konsolē info par pirmo objektu
    Console.WriteLine(
        @"#1: Model = {0}, Name = {1},
    X: {2}, Y: {3}, Z: {4},
    Is spaceship flying: {5}, Acceleration = {6}, Passengers = {7}, Percentage of oxygen = {8}",
        spcship1.Model, spcship1.Name, spcship1.CoorX, spcship1.CoorY, spcship1.CoorZ,
        spcship1.IsFlying, spcship1.Acceleration, spcship1.Passengers, spcship1.OxygenPercentage
        );
    Console.WriteLine("");
    
    // Paradām konsolē info par otro objektu
    Console.WriteLine(
        @"#2: Model = {0}, Name = {1},
    X: {2}, Y: {3}, Z: {4},
    Is spaceship flying: {5}, Acceleration = {6}, Passengers = {7}, Percentage of oxygen = {8}",
        spcship2.Model, spcship2.Name, spcship2.CoorX, spcship2.CoorY, spcship2.CoorZ,
        spcship2.IsFlying, spcship2.Acceleration, spcship2.Passengers, spcship2.OxygenPercentage
        );
    Console.WriteLine("");
  }
}
