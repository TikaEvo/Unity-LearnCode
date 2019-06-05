using System.Collections;
using System.Collections.Generic;
using UnityEngine;         //引用API

public class dog
{
    #region 欄位1111111111111111111111111111111111
    public string name;
    public float weight;
    public string type;
    public string sex;
    public string color;
    public int age;
    #endregion

    #region 方法222222222222222222222222222222222222
    /// <summary>
    /// 狗狗亂叫的方法
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + ": 汪汪!!");
    }
    /// <summary>
    /// 轉換狗狗年齡的方法。
    /// </summary>
    /// <returns>狗狗年齡 * 7</returns>
    public int ConverAge()
    {
        return age * 7;
    }

    /// <summary>
    /// 狗狗吃東西的方法。
    /// </summary>
    /// <param name="food">食物</param>
    /// <param name="speed">吃飯速度</param>
    public void Eat(string food. string speed = " 慢")
    {
        Debug.Log(name + ":" + food + "，速度:" + speed);
    }


    #endregion
}