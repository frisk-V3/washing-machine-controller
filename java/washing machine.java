public class WashingMachine {
    // フィールド（属性）
    private String brand;
    private boolean isRunning;

    // コンストラクタ
    public WashingMachine(String brand) {
        this.brand = brand;
        this.isRunning = false;
    }

    // メソッド（動作）：開始
    public void start(String course) {
        if (isRunning) {
            System.out.println("エラー：すでに運転中です。");
        } else {
            isRunning = true;
            System.out.println(brand + "の洗濯機：【" + course + "コース】で運転を開始します。");
        }
    }

    // メソッド（動作）：停止
    public void stop() {
        if (!isRunning) {
            System.out.println("エラー：現在は停止しています。");
        } else {
            isRunning = false;
            System.out.println("運転を停止しました。");
        }
    }

    // メインメソッド（実行用）
    public static void main(String[] args) {
        WashingMachine myWash = new WashingMachine("Panasonic");
        
        myWash.start("標準"); // 運転開始
        myWash.stop();       // 停止
    }
}
