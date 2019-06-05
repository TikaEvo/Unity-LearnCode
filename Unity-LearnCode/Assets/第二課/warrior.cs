using UnityEngine;
[System.Serializable]//序列化
public class warrior : MonoBehaviour
{
    #region 欄位
    public int exp; //經驗值
    public int lv;  //等級
    #endregion

    #region 方法(以 property屬性   get,set寫)
    /// <summary>
    /// 取得與設定戰士的經驗值
    /// </summary>
    public int Exp
    {
        get
        {
            return lv * 10;
        }
        set
        {
            exp = value;
        }
    }
    #endregion
}
//20190605還有問題