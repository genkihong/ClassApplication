using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassApplication
{
  public partial class Index : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      Car bmw = new Car();//初始值
      Car benz = new Car(200);//傳入參數

      BMWLiteral.Text = bmw.Speed.ToString();
      BenzLiteral.Text = benz.Speed.ToString();

      #region 屬性
      if (!string.IsNullOrEmpty(TextBoxBMW.Text))
      {
        bmw.Speed = Convert.ToInt32(TextBoxBMW.Text);
        BMWLiteral1.Text = bmw.Speed.ToString();
      }

      if (!string.IsNullOrEmpty(TextBoxBenz.Text))
      {
        benz.Speed = Convert.ToInt32(TextBoxBenz.Text);
        BenzLiteral1.Text = benz.Speed.ToString();
      }
      #endregion

      #region 方法
      //Car audi = new Car();//初始值
      //audi.Speed = 70;
      //audi.Accelerate();
      //AudiLiteral1.Text = audi.Speed.ToString();

      //audi.Accelerate(100);
      //AudiLiteral2.Text = audi.Speed.ToString();

      //audi.Accelerate("stop");
      //AudiLiteral3.Text = audi.Speed.ToString();
      #endregion

      #region 自動屬性
      //bmw.Color = "藍色";
      //benz.Color = "綠色";
      //audi.Color = "紅色";

      //Literal1.Text = bmw.Color;
      //Literal2.Text = benz.Color;
      //Literal3.Text = audi.Color;
      #endregion
    }
  }
}