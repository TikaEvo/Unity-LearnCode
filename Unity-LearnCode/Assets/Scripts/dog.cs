using System.Collections;
using System.Collections.Generic;
using UnityEngine;         //引用API

public class dog
{
    #region 欄位11615616131564864646463613213
    public string name;
    public float weight;
    public string type;
    public string sex;
    public string color;
    public int age;
    #endregion

    #region 方法
    public void Bark()
    {
        Debug.Log(name + ": 汪汪!!");
    }
    #endregion
}