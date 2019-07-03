﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;         //引用API

[System.Serializable]//序列化屬性之類別可組織在面板上
public class dog
{
    #region 欄位
    public string name;
    public float weight;
    public string type;
    public string color;

    private string sex;
    private int age;
    #endregion

    #region 建構函式
    // 建構函式可以多載
    public dog()
    {

    }

    public dog(string sex,int age)
    {
        this.sex = sex;
        this.age = age;
    }
    #endregion

    #region 方法
    /// <summary>
    /// 狗狗亂叫的方法
    /// </summary>
    public void Bark()
    {
        Debug.Log(age + ": 汪汪!!"+sex);
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
    public void Eat(string food, string speed = " 慢")
    {
        Debug.Log(name + ":" + food + "，速度:" + speed);
    }
    /// <summary>
    ///  狗狗吃東西的方法。
    /// </summary>
    /// <param name="food">食物</param>
    /// <param name="count">份量</param>
    public void Eat(string food, int count)
    {
        Debug.Log(name + ":" + food + " ，份量:" + count);
    }
    #endregion
}