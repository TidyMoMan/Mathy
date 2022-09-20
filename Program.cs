while (true)
{
    Console.WriteLine("Input coordinates x1, y2, x2, y2");
    Console.Write("X1: "); double coordX1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y1: "); double coordY1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("X2: "); double coordX2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y2: "); double coordY2 = Convert.ToDouble(Console.ReadLine());

    double run = (coordX2 - coordX1);
    double rise = (coordY2 - coordY1);
    double slope = rise*-1 / run*-1;
    //double angle = Math.Pow(Math.Tan(rise / run), -1);
    double intercept = coordY1 - (slope * coordX1);
    double Xintercept = (coordY1 * slope) + (intercept * slope);
    Console.WriteLine(rise * -1 + " <--rise & run--> " + run * -1 + " between points");
    Console.WriteLine("slope " + slope);
    //Console.WriteLine("angle of line: " + angle);
    Console.WriteLine("Y intercept: " + intercept);
    Console.WriteLine("X intercept: " + Xintercept);
    Console.WriteLine("y = " + slope + "x + " + intercept);
    Console.WriteLine("---------------------------------");
}
/*
float getAbsolute(float input){
  if(input < 0) { input *= -1; return input; }
  else return input;
}
*/