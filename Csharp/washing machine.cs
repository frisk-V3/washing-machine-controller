using System;

public class WashingMachine
{
    // フィールド
    private string brand;
    private bool isRunning;

    // コンストラクタ
    public WashingMachine(string brand)
    {
        this.brand = brand;
        this.isRunning = false;
    }

    // メソッド：開始
    public void Start(string course)
    {
        if (isRunning)
        {
            Console.WriteLine("エラー：すでに運転中です。");
        }
        else
        {
            isRunning = true;
            Console.WriteLine($"{brand}の洗濯機：【{course}コース】で運転を開始します。");
        }
    }

    // メソッド：停止
    public void Stop()
    {
        if (!isRunning)
        {
            Console.WriteLine("エラー：現在は停止しています。");
        }
        else
        {
            isRunning = false;
            Console.WriteLine("運転を停止しました。");
        }
    }

    // 実行用（C#ではMainのMは大文字）
    public static void Main(string[] args)
    {
        WashingMachine myWash = new WashingMachine("Panasonic");
        
        myWash.Start("標準"); // 運転開始
        myWash.Stop();        // 停止
    }
}
