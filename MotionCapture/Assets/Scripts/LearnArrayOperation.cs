using UnityEngine;
using System.Collections.Generic;

public class LearnArrayOperation : MonoBehaviour
{
    public int studentA = 10;
    public int studentB = 20;
    public int studentC = 30;

    // 陣列
    public int[] students = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

    private void Start()
    {
        // 取得陣列資料
        Debug.Log(students[6]);

        // 存入陣列資料
        students[2] = 33;

        // 陣列數量 (長度)
        Debug.Log("學生陣列的長度：" + students.Length);
    }
}
