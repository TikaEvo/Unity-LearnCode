using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogManager : MonoBehaviour
{
    #region 欄位
    public dog DogA = new dog("公",7);
    public dog DogB = new dog("母",3);
    #endregion

    #region 事件
    private void Start()
    {
        DogA.name = "鬼挖";
        DogA.weight = 30.5f;
        DogA.type = "貴賓";
        //DogA.sex = "公";
        DogA.color = "咖啡";
        //DogA.age = 7;

        DogB.name = "掐及";
        DogB.weight = 5.8f;
        DogB.type = "及哇哇";
        //DogB.sex = "母";
        DogB.color = "白";
        //DogB.age = 3;

        Debug.Log(DogA.name + "品種:" + DogA.type + "顏色:" + DogA.color);
        Debug.Log(DogB.name + "品種:" + DogB.type + "顏色:" + DogB.color);

        DogA.Bark();
        DogB.Bark();

        Debug.Log(DogA.name + "的實際年齡為:" + DogA.ConverAge());
        Debug.Log(DogB.name + "的實際年齡為:" + DogB.ConverAge());

        DogA.Eat("熱狗");
        DogB.Eat("蛋糕",10);
    }
    #endregion
}