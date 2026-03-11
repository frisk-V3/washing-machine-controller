#include <stdio.h>
#include <unistd.h> // sleep関数（一時停止）を使うため

// 関数のプロトタイプ宣言
void start_washing(char* course);
void supply_water();
void wash();
void rinse();
void spin_dry();

int main() {
    printf("--- 洗濯機プログラム開始 ---\n");

    // 運転開始
    start_washing("標準コース");

    printf("--- すべての工程が完了しました ---\n");
    return 0;
}

// 運転のメイン処理
void start_washing(char* course) {
    printf("設定：%s\n", course);
    
    supply_water(); // 給水
    wash();         // 洗い
    rinse();        // すすぎ
    spin_dry();     // 脱水
}

void supply_water() {
    printf("給水を開始します...\n");
    sleep(1); // 1秒待機
}

void wash() {
    printf("洗っています（左右に回転）...\n");
    sleep(2);
}

void rinse() {
    printf("すすいでいます...\n");
    sleep(2);
}

void spin_dry() {
    printf("脱水しています（高速回転）...\n");
    sleep(2);
}
