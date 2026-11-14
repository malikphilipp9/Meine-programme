
System.Console.WriteLine("Sag mir dein Gewicht: ");
double userGewicht = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("sag mir deine Größe: ");
double userGröße = Convert.ToDouble(Console.ReadLine());

double BerechneBMI(double gewicht, double größe)
{
    double größe2 = größe * größe;
    double bmi = gewicht / größe2;
    return bmi;
}

double bmiFinal = BerechneBMI(userGewicht, userGröße);

Console.WriteLine("Dein BMI ist: " + bmiFinal);