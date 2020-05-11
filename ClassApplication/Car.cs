using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassApplication
{
  public class Car
  {
    //私有欄位 Field，只能在此 Class 存取
    private int speed;

    #region 建構式 Constructor Overload (多載)
    //第一個建構式
    public Car()//初始值
    {
      //speed = 80;
    }
    //第二個建構式
    public Car(int max)//傳入參數
    {
      speed = max;
    }
    #endregion


    #region 屬性 Property
    public int Speed
    {
      get { return speed; }
      set
      {
        //if (value < 60)
        //{
        //  value = 60;
        //}

        //if (value > 100)
        //{
        //  value = 100;
        //}
        speed = value;
      }
    }
    #endregion

    #region 自動屬性
    public string Color { get; set; }
    #endregion

    #region 方法 Overload (多載)
    //第一種加速方法
    public void Accelerate()
    {
      this.Speed++;
    }
    //第二種加速方法
    public void Accelerate(int addSpeed)
    {
      this.Speed += addSpeed;
    }
    //第三種加速方法
    public void Accelerate(string str)
    {
      if (str == "stop") this.Speed = 0;
    }
    #endregion
  }
}