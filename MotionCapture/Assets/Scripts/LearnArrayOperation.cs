using UnityEngine;
using System.Collections.Generic;

public class LearnArrayOperation : MonoBehaviour
{
    public int studentA = 10;
    public int studentB = 20;
    public int studentC = 30;

    // 陣列
    public int[] students = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

    public Color[] colors = { Color.black, Color.red };

    private void Start()
    {
        // 取得陣列資料
        Debug.Log(students[6]);

        // 存入陣列資料
        students[2] = 33;

        // 陣列數量 (長度)
        Debug.Log("學生陣列的長度：" + students.Length);

        // 數學運算子
        Debug.Log(10 + 3);
        Debug.Log(10 - 3);
        Debug.Log(10 * 3);
        Debug.Log(10 / 3);
        Debug.Log(10 % 3);

        // 比較運算子 (結果都是布林值)
        Debug.Log(10 > 3);      // t
        Debug.Log(10 < 3);      // f
        Debug.Log(10 >= 3);     // t
        Debug.Log(10 <= 3);     // f
        Debug.Log(10 == 3);     // f
        Debug.Log(10 != 3);     // t
    }
}
