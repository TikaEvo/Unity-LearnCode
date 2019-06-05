using UnityEngine;


public class gameManager : MonoBehaviour
{
    #region 欄位
    public soldier SoldierA = new soldier();
    #endregion

    #region 事件
    private void Start()
    {
        SoldierA.lv = 30;
        Debug.Log("士兵經驗值 - 取得" + SoldierA.GetExp());

        SoldierA.SetExp(100);
        Debug.Log("士兵經驗值 -  設定" + SoldierA.exp);
    }
    #endregion
}
