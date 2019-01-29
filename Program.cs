using System;

class Eto
{
    static void Main()
    {
        string[] eto = { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥"};

        Console.Write("西暦をを入力してください---");
        int seireki = int.Parse(Console.ReadLine());
        int num = (8 + seireki) % 12;       //干支の周期を西暦と合わせる

        Console.WriteLine("{0}年の干支は{1}です", seireki, eto[num]);
    }
}