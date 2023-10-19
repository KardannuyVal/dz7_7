using System;
abstract class ГеографическийОбъект
 {
    public string Название { get; protected set; }
    public ГеографическийОбъект(string название)
    {
        Название = название;
    }
    public abstract void ВывестиИнформацию();
 }
 class Страна : ГеографическийОбъект
 {
    public string Столица { get; set; }
    public string ОфициальныйЯзык { get; set; }
    public double Площадь { get; set; }
    public Страна(string название, string столица, string язык, double площадь)
        : base(название)
    {
        Столица = столица;
        ОфициальныйЯзык = язык;
        Площадь = площадь;
    }
    public override void ВывестиИнформацию()
    {
        Console.WriteLine($"Страна: {Название}");
        Console.WriteLine($"Столица: {Столица}");
        Console.WriteLine($"Официальный язык: {ОфициальныйЯзык}");
        Console.WriteLine($"Площадь: {Площадь} кв. км");
    }
    public double РассчитатьНаселение(double плотность)
    {
        return Площадь * плотность;
    }
 }
 class ProgramProject
 {
    static void MainProject()
    {
        Страна россия = new Страна("Россия", "Москва", "Русский", 17075200.0);
        Страна франция = new Страна("Франция", "Париж", "Французский", 551695.0);
        Console.WriteLine("Информация о странах:");
        россия.ВывестиИнформацию();
        Console.WriteLine();
        франция.ВывестиИнформацию();
        double плотностьРоссии = 8.8; // человек на квадратный километр
        double населениеРоссии = россия.РассчитатьНаселение(плотностьРоссии);
        Console.WriteLine($"Оценка населения России: {населениеРоссии} человек");
        double плотностьФранции = 119.6; // человек на квадратный километр
        double населениеФранции = франция.РассчитатьНаселение(плотностьФранции);
        Console.WriteLine($"Оценка населения Франции: {населениеФранции} человек");
 }
}