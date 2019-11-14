using UnityEngine;

public class Lady : MonoBehaviour
{
    private Animator ani;               // 動畫元件

    [Header("動畫控制器：參數名稱")]
    public string parRun = "跑步開關";
    public string parAtk = "攻擊觸發";
    public string parDam = "受傷觸發";
    public string parJump = "跳躍開關";
    public string parDead = "死亡開關";

    private void Start()
    {
        ani = GetComponent<Animator>(); // 動畫元件欄位 =  取得元件<泛型>();
    }

    private void Update()
    {
        Walk();
    }

    // 定義方法
    // 修飾詞 傳回類型 方法名稱 (參數) { 敘述 }
    // void 無回傳

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        // 動畫：跑步 - 按下前後時 true
        ani.SetBool(parRun, Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0);
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
