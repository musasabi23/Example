﻿//3-1
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

if (player1PosX == 2 && player2PosX == 6)
{
    Console.WriteLine("仕掛け解除");
}

//問題3-8

int a_3_8 = 5;
int b_3_8 = 9;

if (a_3_8 == 5 || b_3_8 == 2)
{
    Console.WriteLine("仕掛け解除");
}
//問題3-9
if ((a_3_8 == 5 || b_3_8 == 2) || (a_3_8 == 2 || b_3_8 == 5))

{
    Console.WriteLine("仕掛け解除");
}

//309
int playerPosY = 4;
//プレイヤーが0以上なら走る
//それ以外は泳ぐ
if (playerPosY >= 0)
{
    Console.WriteLine("走る");
}
else
{
    Console.WriteLine("泳ぐ");
}

//問題3-10
int num = 2;
if (num >= 3)
{
    Console.WriteLine("勝ち");
}
else
{
    Console.WriteLine("負け");

}

//S10
int hp = 100;
int mapType = 2;
//地形によってHPの値を増減する
if (mapType == 1)
{
    hp += 10;  //回復
}
else if (mapType == 2)//毒
{
    hp -= 5;
}
else if (mapType == 3)//罠
{
    hp = 0;
}
else //上記以外は通常
{
    Console.WriteLine("HPの変化なし");
}

Console.WriteLine("HP=" + hp);

//3-4繰り返し処理

//処理を5回繰り返す
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("攻撃");
}

//問題3-12
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("逃走！");
}

//list 3-12
//参加者の点呼

for (int i = 1; i < 4; i++)
{
    Console.WriteLine(i + "番！");
}

//問題3-13

for (int i = 2; i < 6; i++)
{
    Console.WriteLine(i);
}

//問題3-14
for (int i = 0; i < 5; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//正解
for (int i = 0; i < 5; i += 2)
{
    Console.WriteLine(i);
}

//list3-13
//for文のカウントダウン
for (int i = 3; i > 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("スタート");

//問題3-15
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

//list3-14a while文の使用例
int playerPosX314 = 5;
int missilePosX314 = 15;
/*プレイヤーとミサイルの位置が等しくなければ
 ミサイルの移動を繰り返す*/
while (playerPosX314 != missilePosX314)
{
    Console.WriteLine("missile at" + missilePosX314);
    missilePosX314--; //missileを左に動かす
}

Console.WriteLine("Hit");

//問題3-16
int i316 = 10000;
int i316_2 = 0;

while (i316 > 100)
{
    i316 = i316 / 2;
    i316_2++;
}
Console.WriteLine(i316_2 + "回");

//list3-14b break文の使用例

int playerPosX314b = 5;
int missilePosX314b = 15;
//常にループ処理
while (true)
{
    //プレイヤーとミサイルが衝突したらwhil文を抜ける
    if (playerPosX314b == missilePosX314b)
    {
        break;
    }

    Console.WriteLine("missile at " + missilePosX314b);
    missilePosX314b--;
}
Console.WriteLine("Hit");

//問題3-17
int a317 = 0;
int b317 = 1;

while (true)
{
    a317 += b317;
    Console.WriteLine(a317);

    if (a317 >= 500)
    {
        break;
    }
    
    b317++;
}

//list3-15 配列の使用例

float[] weights; //配列の変数を宣言
weights 
    = new float[7]; //配列の要素数を決める

//配列の要素に値を代入する
weights[0] = 41.2f;
weights[1] = 42.5f;
weights[2] = 44.9f;
weights[3] = 43.2f;
weights[4] = 45.1f;
weights[5] = 43.2f;
weights[6] = 42.7f;

//配列を全て表示する
for (int i = 0; i < 7; i++)
{
    Console.WriteLine(weights[i]);
}

//list3-16
//配列を初期化する
float[] weights316 = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f,
                       43.2f, 42.7f, 41.5f, 41.4f, 41.9f };
//「変数名.Length」を使って全要素にアクセス
for (int i = 0; i < weights316.Length; i++)
{
    Console.WriteLine(weights316[i]);
}

//list3-17
float[] weights317 = { 41.2f, 42.5f, 44.9f, 43.2f,
                       45.1f, 43.2f, 42.7f };
float sum317 = 0.0f; //一週間の体重の合計を入れる変数
//1週間文の体重の合計
for (int i = 0; i < weights317.Length; i++) 
{
    sum317 += weights317[i];
}
//1週間の体重の平均値
float average317 = sum317 / weights317.Length;
Console.WriteLine("平均値は" + average317 + "です");

//問題3-18
foreach (float w318 in weights317)
{
    float w318ander43 = w318;
    if (w318ander43 <= 43.0f)
    {
        Console.WriteLine(w318ander43);
    }

}

//list3-18
void Shop318()
{
    Console.WriteLine("いらっしゃいませ！");
}

Shop318();

//問題3-19
void Thankyou()
{
    Console.WriteLine("ありがとうございました！");
}

Thankyou();

//list3-19
void Shop319(string itemName)
{
    Console.WriteLine("いらっしゃいませ！");
    if (itemName == "薬草")
    {
        Console.WriteLine(itemName + "は100円です");
    }
    else if (itemName == "棍棒")
    {
        Console.WriteLine(itemName + "1500円です");
    }
    else
    {
        Console.WriteLine("売り切れです");
    }
}

Shop319("薬草");

//問題3-20
void ShowEvenOrOdd (int num320)
{
    if ((num320 % 2) == 0)
    {
        Console.WriteLine("偶数です");
    }
    else
    {
        Console.WriteLine("奇数です");
    }
}

ShowEvenOrOdd(19);

//list3-20
//商品名を引数、戻り値は商品の値段
int Shop320(string itemName320)
{
    Console.WriteLine("いらっしゃいませ！");
    int price320 = 0;
    if (itemName320 == "薬草")
    {
        Console.WriteLine(itemName320 + "は100円です");
        price320 = 100;
    }
    else if (itemName320 == "万能薬")
    {
        Console.WriteLine(itemName320 + "は500円です");
        price320 = 500;
    }
    else if (itemName320 == "棍棒")
    {
        Console.WriteLine(itemName320 + "は1500円です");
        price320 = 1500;
    }
    else
    {
        Console.WriteLine("売り切れです");
        price320 = 0;
    }
    //引数に対応する商品の値段を返す
    return price320;
}

int mony320 = 2500;
Console.WriteLine("所持金は" + mony320 + "円です");
int price320 = Shop320("薬草");
mony320 -= price320;
Console.WriteLine("所持金は" + mony320 + "円です");

//問題3－21
int price321 = Shop320("万能薬");
mony320 -= price321;
Console.WriteLine("所持金は" + mony320 + "円です");

//問題3-22
float CalcAverage(int num3221, int num3222, int num3223)
{
    float answer322 = (num3221 + num3222 + num3223) / 3.0f;
    return answer322;
}

float ave322 = CalcAverage(13, 7, 10);
Console.WriteLine("平均値は" + ave322 + "です");



    