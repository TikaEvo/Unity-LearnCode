using UnityEngine;


public class gameManager : MonoBehaviour
{
    #region 欄位
    public soldier SoldierA = new soldier();

    public warrior WarriorA = new warrior();
    #endregion

    #region 事件
    private void Start()
    {
        //以欄位寫法
        SoldierA.lv = 30;
        Debug.Log("士兵經驗值 - 取得" + SoldierA.GetExp());

        SoldierA.SetExp(100);
        Debug.Log("士兵經驗值 -  設定" + SoldierA.exp);

        //以property屬性寫法
        //20190605還有問題
        WarriorA.lv = 50;
        Debug.Log("戰士經驗值 - 取得" + WarriorA.Exp);

        WarriorA.Exp =777;
        Debug.Log("戰士經驗值 -  設定" + WarriorA.Exp);
    }
    #endregion
}
