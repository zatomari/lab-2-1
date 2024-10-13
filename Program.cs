﻿public class Program {
    public static async Task Main(string[] args) {

        string fileName = "Dictionary.csv";
        Vocabulary vcb = new Vocabulary();

        await vcb.ReadFromFile(fileName);

        Console.WriteLine("Словарь однокоренных слов");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Введите слово или q для завершения работы");

        new DialogMain(vcb).Run("");

        await vcb.SaveToFile(fileName);
    }
}