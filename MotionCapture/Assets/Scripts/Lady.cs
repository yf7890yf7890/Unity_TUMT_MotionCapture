using UnityEngine;

public class Lady : MonoBehaviour
{
    private Animator ani;               // 動畫元件

    private void Start()
    {
        ani = GetComponent<Animator>(); // 動畫元件欄位 =  取得元件<泛型>();
    }

    // 定義方法
    // 修飾詞 傳回類型 方法名稱 (參數) { 敘述 }
    // void 無回傳

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {

    }

    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {

    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 受傷
    /// </summary>
    private void Hurt()
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }
}
