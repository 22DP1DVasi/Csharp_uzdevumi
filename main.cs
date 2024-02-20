using System;
class Program {
  static void Main() {
    // izveido pirmo objektu
    Spaceship spcship1 = new Spaceship("SpaceX", "Arbiter", 243.52, 565.24, -845.30, 11000.0, 52, 100);
    Spaceship spcship2 = new Spaceship();
    
    // Paradām konsolē info par pirmo objektu
    Console.WriteLine(
        @"#1: Model = {0}, Name = {1},
    X: {2}, Y: {3}, Z: {4},
    Speed = {5}, Passengers = {6}, Percentage of oxygen = {7}",
        spcship1.Model, spcship1.Name, spcship1.CoorX, spcship1.CoorY, spcship1.CoorZ,
        spcship1.Speed, spcship1.Passengers, spcship1.OxygenPercentage
        );
    Console.WriteLine("");
    
    // Paradām konsolē info par otro objektu
    Console.WriteLine(
        @"#2: Model = {0}, Name = {1},
    X: {2}, Y: {3}, Z: {4},
    Speed = {5}, Passengers = {6}, Percentage of oxygen = {7}",
        spcship2.Model, spcship2.Name, spcship2.CoorX, spcship2.CoorY, spcship2.CoorZ,
        spcship2.Speed, spcship2.Passengers, spcship2.OxygenPercentage
        );
  }
}