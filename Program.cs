Console.WriteLine("LADO A:");
double ladoa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("LADO B:");
double ladob = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("LADO C:");
double ladoc = Convert.ToDouble(Console.ReadLine());

double P = (ladoa + ladob + ladoc) / 2;
double area = Math.Sqrt((P * (P - ladoa) * (P - ladob) * (P - ladoc)));
Console.WriteLine($"SEMIPERIMETRO: {P}");
Console.WriteLine($"ARÉA DO TRIANGULO: {area}");