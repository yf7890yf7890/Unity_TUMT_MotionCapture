using UnityEngine;

public class Lady : MonoBehaviour
{
    [Header("跑步速度")]
    [Range(1, 10)]
    public int speed;
    private Animator ani;               // 動畫元件
    private Rigidbody rig;

    [Header("動畫控制器：參數名稱")]
    public string parRun = "跑步開關";
    public string parAtk = "攻擊觸發";
    public string parDam = "受傷觸發";
    public string parJump = "跳躍觸發";
    public string parDead = "死亡開關";
    
    


    private void Start()
    {
        ani = GetComponent<Animator>(); // 動畫元件欄位 =  取得元件<泛型>();
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Walk();
        Attack();
        Jump();
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
        rig.AddForce(transform.forward * Input.GetAxis("Vertical")*speed);
    }

    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            ani.SetTrigger(parAtk);
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetTrigger(parJump);
            Debug.Log("12");
        }
            
    }

    /// <summary>
    /// 受傷
    /// </summary>
    private void Hurt()
    {
        ani.SetTrigger(parDam);
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        ani.SetBool(parDead, true);
    }
}
