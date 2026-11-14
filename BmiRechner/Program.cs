using System.Runtime.Intrinsics.X86;

System.Console.WriteLine("Sag mir dein Gewicht: ");
double user_gewicht = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("sag mir deine Größe");
double user_größe = Convert.ToDouble(Console.ReadLine());

double BerechneBMI(double gewicht, double größe)
{
    double größe2 = größe * größe;
    double bmi = gewicht / größe2;
    return bmi;
}

double bmi_final = BerechneBMI(user_gewicht, user_größe);

Console.WriteLine("Dein BMI ist: " + bmi_final);