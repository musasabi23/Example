//3-1
// 変数の変化
int moneyNow; //所持金を代入する変数
string name; //名前を代入する変数

//変数に名前を代入する
moneyNow = 5000;
name = "きたむら";

Console.WriteLine(moneyNow); //所持金を表示
Console.WriteLine(name); //名前を表示

string kokoko = "いける？";
Console.WriteLine(kokoko); //名前を表示

kokoko = "ぶぶ";
Console.WriteLine(kokoko);


//3-2
//プログラム計算

int answer; //計算結果

//加算
answer = 3 + 4;
Console.WriteLine(answer);

//減算
answer = 12 - 18;
Console.WriteLine(answer);

//乗算
answer = 2 * 7;
Console.WriteLine(answer);

//除算
answer = 18 / 3;
Console.WriteLine(answer);

//剰算
answer = 21 % 5;
Console.WriteLine(answer);

//問題3-1
answer = 1 + 2 + 3 + 4 + 5;
Console.WriteLine(answer);
//問題3-2
answer = 30 % 7;
Console.WriteLine(answer);

//3-3
//変数同士の計算

//変数の初期化
int money = 15000; //所持金
int salary = 1000; //時給
int hour = 5; //働いた時間

//現在の所持金の合計を計算して表示
int sum = money + salary * hour;
Console.WriteLine(sum);

//問題3-3
int sum2 = money + (salary + 150) * hour;
Console.WriteLine(sum2);
//問題3-4
int money3 = 5000; //所持金
int salary3 = 800; //時給
int hour3 = 2; //働いた時間

int sum3 = money3 + salary3 * hour3;
Console.WriteLine(sum3);


//平均値
int math = 80;
int english = 66;
int history = 95;
//平均値を計算して表示
float average = (math + english + history) / 3.0f;
Console.WriteLine("平均値は" + average + "点");

//問題3-5
int test3_5_1 = 24;
int test3_5_2 = 9;
float answer3_5;
// int型の変数を2つ用意 + 浮動小数点の結果を代入する変数を用意

// int型の値に小数点を掛けて計算する場合
// (整数同士の計算は必ず整数となる為、小数点は自動切り捨てされてしまう)
answer3_5 = test3_5_1 * 1.0f / test3_5_2;//☝より、後ろに* 1.0したら結果が狂う
Console.WriteLine(answer3_5);

// 暗黙のキャストでint型をfloat型にして計算する場合
float c = test3_5_1;
answer3_5 = c / test3_5_2;
Console.WriteLine(answer3_5);

// 明示的なキャストでint型をfloat型にして計算する場合
answer3_5 = (float)test3_5_1 / test3_5_2;
Console.WriteLine(answer3_5);


//変数の値を増やす
int life = 1;
//ライフを3だけ増やす
life = life + 3;
Console.WriteLine(life);
//簡略化
life = 1;
life += 3;
Console.WriteLine(life);
//1だけ増やしたい
life = 1;
life++;
Console.WriteLine(life);

//問題3-6
int a3_6 = 10;
a3_6--;
a3_6--;
Console.WriteLine(a3_6);
a3_6 /= 4;
Console.WriteLine(a3_6);

//if文
int playerPosX = 5; // プレイヤの位置は「X=5」
int enemyPosX = 5; // 敵の位置は「X=10」

// プレイヤと敵の位置が等しい場合は敵と遭遇
if (playerPosX == enemyPosX)
{
    Console.WriteLine("敵と遭遇");
}

//問題3-7
int a3_7 = 4;
if (a3_7 >= 3)
{
    Console.WriteLine("勝利");
}

//2つの条件のif文
int player1PosX = 2;
int player2PosX = 6;

if (player1PosX == 2)
{
    if (player2PosX == 6)
    {
        Console.WriteLine("仕掛け解除");
    }
}


Console.WriteLine("テストコミット１");

Console.WriteLine("テストコミット２");