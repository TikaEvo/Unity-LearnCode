using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogManager : MonoBehaviour
{
    #region 欄位
    public dog DogA = new dog();
    public dog DogB = new dog();
    #endregion

    #region 事件
    private void Start()
    {
        DogA.name = "鬼挖";
        DogA.weight = 30.5f;
        DogA.type = "貴賓";
        DogA.sex = "公";
        DogA.color = "咖啡";
        DogA.age = 7;

        DogB.name = "鬼挖";
        DogB.weight = 30.5f;
        DogB.type = "貴賓";
        DogB.sex = "公";
        DogB.color = "咖啡";
        DogB.age = 7;
    }
    #endregion
}