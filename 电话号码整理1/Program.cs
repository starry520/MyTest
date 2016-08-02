using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Data.OleDb;

namespace 电话号码整理1
{
    class Program
    {

        static string strConn97 = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source={0}";
        static string strConn07 = "Provider=Microsoft.Ace.OleDb.12.0;data source={0} ;Extended Properties='Excel 12.0; HDR=NO; IMEX=1'";
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i < 5000; i++)
            //{ 
            //    int number = rnd.Next(0, 100);
            //    sb.Append(i + "," + number);
            //    sb.Append("\r\n");
            //}

           // string ss = sb.ToString();

            string path = @"E:\Git\HJS_pc\HJS.Web\upload\20160204143229725.xlsx";
            GetExcelFirstTableName(path);
        }

        static void Test()
        {
            DataSet dataSet = GetCityMapTelephone();
            dataSet.WriteXml("原来.xml");
            DataTable datatable = dataSet.Tables[0];
           List<CityMapTelephones> cityMapTelephoness = new List<CityMapTelephones>();
           foreach (DataRow item in datatable.Rows)
           {
               CityMapTelephones cityMapTelephones = new CityMapTelephones();
               cityMapTelephones.CityName = item["CityName"].ToString();
               cityMapTelephones.ProvinceName = item["ProvinceName"].ToString();
               cityMapTelephones.CompanyName = item["CompanyName"].ToString();
               cityMapTelephones.Telephone = item["Telephone"].ToString();
               cityMapTelephoness.Add(cityMapTelephones);
           }

            //分公司对应表.xlsx
          DataSet ds= ExcelToDS("分公司对应表.xls", "电话");
          List<Company> companys = new List<Company>();
          foreach (DataRow item in ds.Tables[0].Rows)
          {
              Company c = new Company();
              c.CompanyName = item[0].ToString();
              c.Telephone = item[1].ToString();
              companys.Add(c);
          }

          ds = ExcelToDS("分公司对应表.xls", "分公司明细");
          List<Adress> AdressList = new List<Adress>();
          foreach (DataRow item in ds.Tables[0].Rows)
          {
              Adress c = new Adress();
              c.CityName = item[4].ToString();
              c.CompanyName = item[5].ToString();
              c.ProvinceName = item[1].ToString();
              AdressList.Add(c);
          }

          var result = (from ct in cityMapTelephoness
                        join a in AdressList on ct.CityName equals a.CityName
                        into newCityMapTelephones
                        from n in newCityMapTelephones.DefaultIfEmpty()
                        select new CityMapTelephones()
                        {
                            CityName = ct.CityName,
                            ProvinceName = n == null ? ct.ProvinceName : n.ProvinceName,
                            CompanyName = n == null ? ct.CompanyName : n.CompanyName,
                            Telephone = ct.Telephone
                        }).ToList();

          var result1 = (from ct in result
                         join c in companys on ct.CompanyName equals c.CompanyName
                        into newCityMapTelephones
                        from n in newCityMapTelephones.DefaultIfEmpty()
                        select new CityMapTelephones()
                        {
                            CityName = ct.CityName,
                            ProvinceName =ct.ProvinceName,
                            CompanyName =ct.CompanyName,
                            Telephone =n==null? ct.Telephone:n.Telephone
                        }).ToList();


          datatable.Rows.Clear();

          for (int i = 0; i < cityMapTelephoness.Count; i++)
          {
              CityMapTelephones cityMapTelephones = cityMapTelephoness[i];
              var cc = (from a in AdressList
                       where a.CityName.Trim().ToUpper() == cityMapTelephones.CityName.Trim().ToUpper()
                        select a).ToList() ;
              if (cc!=null&&cc.Count>0)
              {
                  cityMapTelephones.ProvinceName = cc[0].ProvinceName;
                  cityMapTelephones.CompanyName = cc[0].CompanyName;
              }

              var cp =( from c in companys
                        where c.CompanyName.Trim().ToUpper() == cityMapTelephones.CompanyName.Trim().ToUpper() 
                       select c).ToList();
              if (cp != null && cp.Count > 0)
              {
                  cityMapTelephones.Telephone = cp[0].Telephone;
              }
          }

          foreach (var item in cityMapTelephoness)
          {
              DataRow dr = datatable.NewRow();              
               dr["CityName"] = item.CityName;
               dr["ProvinceName"] = item.ProvinceName;
               dr["CompanyName"] = item.CompanyName;
               dr["Telephone"] = item.Telephone;
               datatable.Rows.Add(dr);
          }

        

          dataSet.WriteXml("11.xml");
        }

        /// <summary>
        /// C#中获取Excel文件的第一个表名 
        /// Excel文件中第一个表名的缺省值是Sheet1$, 但有时也会被改变为其他名字. 如果需要在C#中使用OleDb读写Excel文件, 就需要知道这个名字是什么. 以下代码就是实现这个功能的:
        /// </summary>
        /// <param name="excelFileName"></param>
        /// <returns></returns>
        public static string GetExcelFirstTableName(string excelFileName)
        {
            string tableName = null;
            string connString = string.Empty;
            if (File.Exists(excelFileName))
            {
                if (excelFileName.ToUpper().Trim().EndsWith(".XLSX"))
                {
                    connString = string.Format(strConn07, excelFileName);
                }
                else
                {
                    connString = string.Format(strConn97, excelFileName);
                }

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    tableName = dt.Rows[0][2].ToString().Trim();
                }
            }

            return tableName;
        }

        public static DataSet ExcelToDS(string path,string sheet)
        {         
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            strExcel = "select * from [" + sheet + "$]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            return ds;
        } 

        /// <summary>
        /// 读取分公司和电话
        /// </summary>
        /// <returns></returns>
        public static DataSet GetCityMapTelephone()
        {
           DataSet ds = null;

            try
            {
                 ds = new DataSet();
                ds.ReadXml("CityTelephone.xml");
            
            }
            catch (Exception ex)
            {
               
            }

            return ds;
        }
　　
    }

    public class CityMapTelephones
    {
    //       <CityName>石景山</CityName>
    //<ProvinceName>北京</ProvinceName>
    //<CompanyName>北京分公司</CompanyName>
    //<Telephone>010-64181616</Telephone>

        public string CityName { get; set; }
        public string ProvinceName { get; set; }
        public string CompanyName { get; set; }
        public string Telephone { get; set; }

    }

    public class Company
    {
        public string CompanyName { get; set; }
        public string Telephone { get; set; }

    }

    public class Adress
    {
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string CompanyName { get; set; }
    }

}
