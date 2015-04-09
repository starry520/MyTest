using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace JsonTest
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  //[
          //  //{"RoomPriceXLable":"['2011/3','2011/4','2011/5','2011/6','2011/7','2011/8','2011/9','2011/10']"},
          //  //{"RoomListSeries":"[
          //  //{name：'商务间_new3', data: [0.0,775.0,769.0,208.6,132.9,150.0,518.0,440.1]},
          //  //{name：'商务间_new1', data: [0.0,280.0,1167.9,124.0,80.0,138.0,158.0,318.0]}]"}
          //  //]

          //  Dictionary<string, List<double>> data = new Dictionary<string, List<double>>();
          //  List<double> fl = new List<double>() { 0.0, 775.0, 769.0, 208.6, 132.9, 150.0, 518.0, 440.1 };
          //  data.Add("商务间_new3", fl);
          //  List<double> f2 = new List<double>() { 0.0, 280.0, 1167.9, 124.0, 80.0, 138.0, 158.0, 318.0 };
          //  data.Add("双人间_new3", f2);
          //  SeriesEntity seriesEntity = new SeriesEntity();
          //  seriesEntity.Name = "商务间_new3";
          //  seriesEntity.Data = f2;
          //  List<SeriesEntity> list = new List<SeriesEntity>();
          //  list.Add(seriesEntity);
          //  list.Add(seriesEntity);
          //string s2=  ObjectToJSON(data);
          //string s1 = ObjectToJSON(seriesEntity);
          //string s3 = ObjectToJSON(list);

         
        }

         public static string ObjectToJSON(object obj)
    {
        JavaScriptSerializer jss =new JavaScriptSerializer();
        try
        {
            return jss.Serialize(obj);
        }
        catch(Exception ex)
        {

            throw new Exception("JSONHelper.ObjectToJSON(): "+ ex.Message);
        }
    }

         public class SeriesEntity
         {
             
             public string Name;
            [XmlElement(ElementName = "data")]
             public List<double> Data;
         }
    }
}
