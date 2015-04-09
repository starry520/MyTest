//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel;
//using System.Reflection;
//using System.Data;
//using System.Data.OleDb;
//using System.Collections;
//using System.IO;

//namespace DIVTest
//{
//    class Program
//    {
//        static List<string> list = new List<string>() { };
//        static List<string> list2 = new List<string>() { "2", "4", "3", "6", "7", "12", "23", "33", "42", "52", "63", "73", "82", "3", "2", "3", "2", "3", };
//        static List<int> list3 = new List<int>() { 2, 3 };
//        static void Main(string[] args)
//        {
//            string ssss1 = "哈哈";
//            string ssss2 = "haha";
//            linq.Test();


           
//            string  allNeedGuarantee = string.Empty;
//            string guarantee = string.Empty;
//          var ss = (allNeedGuarantee.Equals("T") || allNeedGuarantee.Equals("B") || guarantee.Equals("G")) ? 1 : 0;

//            //List<string> list3= list2.Skip(2).Take(2222).ToList();
//            //Dictionary<int, int> ssssss = new Dictionary<int, int>();
//            //ssssss[1] = 2;
//            //var ss = (from l in list2
//            //          where l == "12123"
//            //          select l).ToList();
//            //DateTime startDate = DateTime.Now.Date.AddDays(-1);
//            //DateTime endDate = DateTime.Now.Date;
//            //DateTime dt = DateTime.Now;
//            //string ss1 = dt.ToShortDateString();
//            //string ss2 = dt.ToShortTimeString(); 
//            //string ss3 = dt.ToString(); 
//        }
//        static void test()
//        {
//            string ss1 = Guid.NewGuid().ToString();
//          //      Guid GG = Guid.try(ss1)  ;
//            string pathstring = @"d:\Users\zjliu\Desktop\区域维护清单新.xls";
//            DataSet dataSet = ExcelToDS(pathstring);
//            DataTable dt = dataSet.Tables[0];
//            dt.Columns[0].ColumnName = "CityName";
//            dt.Columns[1].ColumnName = "ProvinceName";
//            dt.Columns[2].ColumnName = "CompanyName";
//            dt.Columns.Add("Telephone");
//            int icolumn=dt.Columns.Count;
//            for (int i = 0; i < dt.Rows.Count; i++)
//            {
//                string zone = dt.Rows[i][2].ToString();
//                switch (zone)
//                {
//                    case "北京分公司":
//                        dt.Rows[i][icolumn-1] = "010-64181616";
//                        break;
//                    case "成都分公司":
//                        dt.Rows[i][icolumn-1] = "028-65338899";
//                        break;
//                    case "港澳分公司":
//                        dt.Rows[i][icolumn-1] = "0852-21690911";
//                        break;
//                    case "广州分公司":
//                        dt.Rows[i][icolumn-1] = "020-83936393";
//                        break;
//                    case "桂林办事处":
//                        dt.Rows[i][icolumn-1] = "0773-8983131";
//                        break;
//                    case "杭州分公司":
//                        dt.Rows[i][icolumn-1] = "0571-56196000";
//                        break;
//                    case "宁波办事处":
//                        dt.Rows[i][icolumn - 1] = "0574-81880563";
//                        break;
//                    case "青岛分公司":
//                        dt.Rows[i][icolumn-1] = "0532-85938008";
//                        break;
//                    case "济南办事处":
//                        dt.Rows[i][icolumn-1] = "0531-86117880";
//                        break;
//                    case "昆明办事处":
//                        dt.Rows[i][icolumn-1] = "0871-63108105";
//                        break;
//                    case "南京分公司":
//                        dt.Rows[i][icolumn-1] = "025-66662266";
//                        break;
//                    case "三亚分公司":
//                        dt.Rows[i][icolumn-1] = "0898-88838883";
//                        break;
//                    case "厦门分公司":
//                        dt.Rows[i][icolumn-1] = "0592-5132059";
//                        break;
//                    case "上海区":
//                        dt.Rows[i][icolumn-1] = "021-34064880";
//                        break;
//                    case "深圳分公司":
//                        dt.Rows[i][icolumn-1] = "0755-25981699";
//                        break;
//                    case "沈阳分公司":
//                        dt.Rows[i][icolumn-1] = "024-22522211";
//                        break;
//                    case "苏州办事处":
//                        dt.Rows[i][icolumn-1] = "0512-62373999";
//                        break;
//                    case "天津办事处":
//                        dt.Rows[i][icolumn-1] = "022-87022288";
//                        break;
//                    case "武汉分公司":
//                        dt.Rows[i][icolumn-1] = "027-59536666";
//                        break;
//                    case "西安办事处":
//                        dt.Rows[i][icolumn-1] = "029-82278599";
//                        break;
//                    case "长沙办事处":
//                        dt.Rows[i][icolumn-1] = "0731-85582190";
//                        break;
//                    case "重庆分公司":
//                        dt.Rows[i][icolumn-1] = "023-67766533";
//                        break;
//                    default:
//                        break;
//                }
//            }
//            dt.TableName = "CityMapTelephones";
//            dt.WriteXml(@"d:\Users\zjliu\Desktop\1.xml");
//            //string pathstring = @"d:\Users\zjliu\Desktop\区域维护清单新.xls";
//            //DataSet dataSet= ExcelToDS(pathstring);
//            List<CityMapTelephone> cityMapTelephones = new List<CityMapTelephone>();
//            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
//            {
//                CityMapTelephone cityMapTelephone = new CityMapTelephone();
//                cityMapTelephone.City = dataSet.Tables[0].Rows[i][1].ToString();
//                cityMapTelephone.Province = dataSet.Tables[0].Rows[i][1].ToString();
//                string zone= dataSet.Tables[0].Rows[i][2].ToString();
//                cityMapTelephone.Zone = zone;
//                switch (zone)
//                {
//                    case "北京分公司":
//                        cityMapTelephone.Telephone = "010-64181616";
//                        break;
//                    case "成都分公司":
//                        cityMapTelephone.Telephone = "028-65338899";
//                        break;
//                    case "港澳分公司":
//                        cityMapTelephone.Telephone = "0852-21690911";
//                        break;
//                    case "广州分公司":
//                        cityMapTelephone.Telephone = "020-83936393";
//                        break;
//                    case "桂林办事处":
//                        cityMapTelephone.Telephone = "0773-8983131";
//                        break;
//                    case "杭州分公司":
//                        cityMapTelephone.Telephone = "0571-56196000";
//                        break;
//                    case "宁波办事处":
//                        cityMapTelephone.Telephone = "0574-87115012";
//                        break;
//                    case "青岛分公司":
//                        cityMapTelephone.Telephone = "0532-85938008";
//                        break;
//                    case "济南办事处":
//                        cityMapTelephone.Telephone = "0531-86117880";
//                        break;
//                    case "昆明办事处":
//                        cityMapTelephone.Telephone = "0871-63108105";
//                        break;
//                    case "南京分公司":
//                        cityMapTelephone.Telephone = "025-66662266";
//                        break;
//                    case "三亚分公司":
//                        cityMapTelephone.Telephone = "0898-88838883";
//                        break;
//                    case "厦门分公司":
//                        cityMapTelephone.Telephone = "0592-5132059";
//                        break;
//                    case "上海区":
//                        cityMapTelephone.Telephone = "021-34064880";
//                        break;
//                    case "深圳分公司":
//                        cityMapTelephone.Telephone = "0755-25981699";
//                        break;
//                    case "沈阳分公司":
//                        cityMapTelephone.Telephone = "024-22522211";
//                        break;
//                    case "苏州办事处":
//                        cityMapTelephone.Telephone = "0512-62373999";
//                        break;
//                    case "天津办事处":
//                        cityMapTelephone.Telephone = "022-87022288";
//                        break;
//                    case "武汉分公司":
//                        cityMapTelephone.Telephone = "027-59536666";
//                        break;
//                    case "西安办事处":
//                        cityMapTelephone.Telephone = "029-82278599";
//                        break;
//                    case "长沙办事处":
//                        cityMapTelephone.Telephone = "0731-85582190";
//                        break;
//                    case "重庆分公司":
//                        cityMapTelephone.Telephone = "023-67766533";
//                        break;
//                    default:
//                        break;
//                }
//                cityMapTelephones.Add(cityMapTelephone);

//            }

//             dt = ToDataTable(cityMapTelephones);
//            dt.TableName = "CityMapTelephone";
//            dt.WriteXml(@"d:\Users\zjliu\Desktop\1.xml");
//            string SSS = @"3, 4, 598, 599, 607, 609, 611, 613, 977,
//                                    978, 979, 980, 981, 982, 983, 984, 985,
//                                    986, 987, 988, 989, 990, 991, 992, 993,
//                                    994, 996, 997, 998, 999, 1000, 1001, 1002,
//                                    1003, 1004, 1005, 1006, 1007, 1008, 1010,
//                                    1011, 1012, 1013, 1014, 1015, 1016, 1017,
//                                    1018, 2300, 2301, 2302, 2303, 2304, 2305,
//                                    2306, 2307, 2308, 2309, 2310, 2311, 2312,
//                                    2313, 2314, 2315, 2316, 2317, 2318, 2319,
//                                    2320, 2321, 2322, 2323, 2324, 2325, 2326,
//                                    2327, 2328, 2329, 2607, 2613, 2614, 2619,
//                                    2622, 2623, 2624, 2625, 2626, 2731, 2732,
//                                    2733, 2734, 2735, 2736, 2737, 2738, 2739,
//                                    2740, 2742, 2743, 2744, 2745, 2746, 2747,
//                                    2748, 2749, 2750, 2751, 2752, 2753, 2754,
//                                    2755, 2756, 2757, 2758, 2759, 5336, 5360,
//                                    5623, 5624, 5961, 5965, 5967, 5968, 5969,
//                                    5970, 5971, 5974, 5975, 5976, 5977, 5978,
//                                    5979, 5980, 5982, 5985, 5986, 5988, 5989,
//                                    5992, 5997, 5998, 5999, 6000, 6001, 6002,
//                                    6003, 6004, 6005, 6006, 6007, 6008, 6053,
//                                    6056, 6058, 6060, 6709, 6710, 6711, 6714,
//                                    6715, 6716, 6717, 6719, 6724, 6727, 6729,
//                                    6731, 6733, 6734, 6736, 6737, 6738, 6742,
//                                    6743, 6745, 6748, 6750, 6752, 6755, 6756,
//                                    6759, 6760, 6761, 6763, 6764, 6949, 6950,
//                                    6951, 6952, 7742, 7882, 7923, 8631, 10208,
//                                    10209, 10777, 10778, 10779, 10780, 10781,
//                                    10782, 10783, 10784, 10785, 10786, 10787,
//                                    10788, 10789, 10790, 10791, 10792, 10793,
//                                    10794, 10795, 10796, 10892, 10895, 11085,
//                                    11086, 11096, 11097, 11134, 11135, 11136,
//                                    11147, 11148, 11252, 11295, 11296, 11336,
//                                    11337, 11366, 11367, 11368, 11369, 11370,
//                                    11412, 11413, 11414, 11415, 11416, 11417,
//                                    11418, 11419, 11420, 11421, 11423, 11529,
//                                    11532, 11535, 11536, 11538, 11539, 11540,
//                                    11541, 11545, 11547, 11549, 11550, 11551,
//                                    11554, 11555, 11556, 11560, 11567, 11569,
//                                    11570, 11571, 11572, 11573, 11574, 11575,
//                                    11576, 11577, 11578, 11580, 11581, 11582,
//                                    11583, 11584, 11585, 11590, 11597, 11604,
//                                    11606, 11607, 11608, 11610, 11611, 11612,
//                                    11614, 11615, 11616, 11617, 11618, 11619,
//                                    11745, 11791, 11792, 11803, 11805, 11806,
//                                    11807, 11809, 11824, 11831, 11850, 11851,
//                                    12497, 12498, 12499, 12500, 12955, 12961,
//                                    12963, 12977, 12981, 12984, 12985, 12987,
//                                    12988, 12991, 12993, 14837, 14839, 14840,
//                                    14994, 14996, 15195, 15198, 16274, 16275,
//                                    16281, 16286, 16287, 16290, 16292, 16295,
//                                    16300, 16301, 16302, 16311, 16312, 16313,
//                                    16314, 16316, 16317, 16326, 16328, 16330,
//                                    16337, 16338, 16352, 16357, 16362, 16363,
//                                    16364, 16369, 16378, 16380, 16381, 16390,
//                                    16396, 16397, 16398, 16399, 16400, 16401,
//                                    16402, 16403, 16404, 16405, 16406, 16407,
//                                    16408, 16436, 16437, 16452, 16505, 16506,
//                                    16507, 16508, 16509, 16531, 16532, 16533,
//                                    16544, 16545, 16546, 16547, 16614, 16615,
//                                    16672, 16673, 16691, 16696, 16701, 16703,
//                                    16704, 16706, 16708, 16709, 16710, 16712,
//                                    16718, 16733, 16751, 16752, 16753, 16798,
//                                    16799, 16811, 16817, 16818, 16819, 16822,
//                                    16823, 16842, 16843, 16844, 16845, 16846,
//                                    16847, 16848, 16849, 16850, 16853, 16858,
//                                    16878, 16879, 16883, 16884, 16885, 16886,
//                                    16887, 16897, 16940, 16951, 16958, 16960,
//                                    16971, 16972, 16973, 16974, 16975, 16976,
//                                    16977, 16992, 16993, 16995, 16997, 17014,
//                                    17016, 17017, 17018, 17019, 17020, 17021,
//                                    17022, 17023, 17024, 17025, 17026, 17027,
//                                    17028, 17078, 17079, 17080, 17081, 17082,
//                                    17159, 17160, 17161, 17162, 17163, 17194,
//                                    17205, 17206, 17207, 17208, 17209, 17210,
//                                    17211, 17213, 18124, 18161, 19268, 20024,
//                                    20025, 20026, 20027, 20028, 20029, 20030,
//                                    20031, 20032, 20033, 20034, 20035, 43847 
//";
//            int ddd = 9 / 5;
//            DateTime datetimeLog = DateTime.Now.Date.AddDays(-2);
//            bool flag = true;
//            while (flag)
//            {
//                List<int> logIDList = null;
//                if (logIDList == null || logIDList.Count == 0)
//                {
//                    flag = false;
//                    return;
//                }
//                foreach (int logID in logIDList)
//                {
                   
//                }

//            }
          
//            var v = (from s in list
//                     join s2 in list2
//                    on  s equals s2
//                     select s2).ToList();

//            //Getdata();
//            //string path = @" D:\Work\TFS2010\Hotel\Supplier\Branch-EBooking\dllversion\Product\EbookingMaintain\EbookingMaintainPresentation\target\Ctrip.UI.Business.EbookingMaintain.EbookingMaintainPresentation.dll";
//            //int len = path.Length;
//            //double dd = 123.123;
//            //StringBuilder sb = new StringBuilder();
//            //for (int i = 500; i < 1500; i++)
//            //{
//            //    sb.Append("("+i+"),");
//            //}
//            //string r = sb.ToString();
//            //string ss = "{hello 180}";
//            //string s = "{0:0}";
//            //s = string.Format(s, dd);
//            //int? i = null;
//            //EnumNoBooking fi = (EnumNoBooking)i;
//            // DescriptionAttribute[] arrDesc = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
//            // string ss=EnumService.GetDescription(fi);
//            // return arrDesc[0].Description;
//            Console.ReadKey();
//        }
//        /// <summary>
//        /// 生成XML文件，UTF-8格式，带XSD 
//        /// </summary>
//        /// <param name="descDirectory"></param>
//        /// <param name="fileName"></param>
//        /// <param name="ds"></param>
//        public void Write(string descDirectory, string fileName, DataSet ds)
//        {           
//            ds.WriteXml(descDirectory + @"/" + fileName + ".xml");
//            ds.WriteXmlSchema(descDirectory + @"/" + fileName + ".xsd");
//        }
//        /// <summary>
//        /// 将集合类转换成DataTable
//        /// </summary>
//        /// <param name="list">集合</param>
//        /// <returns></returns>
//        public static DataTable ToDataTable(IList list)
//        {
//            DataTable result = new DataTable();
//            if (list.Count > 0)
//            {
//                PropertyInfo[] propertys = list[0].GetType().GetProperties();
//                foreach (PropertyInfo pi in propertys)
//                {
//                    result.Columns.Add(pi.Name, pi.PropertyType);
//                }

//                for (int i = 0; i < list.Count; i++)
//                {
//                    ArrayList tempList = new ArrayList();
//                    foreach (PropertyInfo pi in propertys)
//                    {
//                        object obj = pi.GetValue(list[i], null);
//                        tempList.Add(obj);
//                    }
//                    object[] array = tempList.ToArray();
//                    result.LoadDataRow(array, true);
//                }
//            }
//            return result;
//        }
//        public static DataSet ExcelToDS(string Path)
//        {
//            //区域维护清单新.xls
//             string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
//            OleDbConnection conn = new OleDbConnection(strConn);
//            conn.Open();
//            string strExcel = "";
//            OleDbDataAdapter myCommand = null;
//            DataSet ds = null;
//            strExcel = "select * from [汇总新$]";
//            myCommand = new OleDbDataAdapter(strExcel, strConn);
//            ds = new DataSet();
//            myCommand.Fill(ds, "table1");
//            return ds;
//        } 


//        private static void Getdata()
//        {
//            var v = (from s in list
//                     where s == "9"
//                     select s).Distinct().ToList();
//            if (v == null)
//            {

//            }
//        }
//        //快速排序
//        static void quick_sort(int[] s, int l, int r)
//        {
//            if (l < r)
//            {
//                //Swap(s[l], s[(l + r) / 2]); //将中间的这个数和第一个数交换 参见注1
//                int i = l, j = r, x = s[l];
//                while (i < j)
//                {
//                    while (i < j && s[j] >= x) // 从右向左找第一个小于x的数
//                        j--;
//                    if (i < j)
//                        s[i++] = s[j];

//                    while (i < j && s[i] < x) // 从左向右找第一个大于等于x的数
//                        i++;
//                    if (i < j)
//                        s[j--] = s[i];
//                }
//                s[i] = x;
//                quick_sort(s, l, i - 1); // 递归调用
//                quick_sort(s, i + 1, r);
//            }
//        }
 
//        static int AdjustArray(int[] s, int l, int r) //返回调整后基准数的位置
//        {
//            int i = l, j = r;
//            int x = s[l]; //s[l]即s[i]就是第一个坑
//            while (i < j)
//            {
//                // 从右向左找小于x的数来填s[i]
//                while (i < j && s[j] >= x)
//                    j--;
//                if (i < j)
//                {
//                    s[i] = s[j]; //将s[j]填到s[i]中，s[j]就形成了一个新的坑
//                    i++;
//                }

//                // 从左向右找大于或等于x的数来填s[j]
//                while (i < j && s[i] < x)
//                    i++;
//                if (i < j)
//                {
//                    s[j] = s[i]; //将s[i]填到s[j]中，s[i]就形成了一个新的坑
//                    j--;
//                }
//            }
//            //退出时，i等于j。将x填到这个坑中。
//            s[i] = x;

//            return i;
//        }
//        static void quick_sort1(int[] s, int l, int r)
//        {
//            if (l < r)
//            {
//                int i = AdjustArray(s, l, r);//先成挖坑填数法调整s[]
//                quick_sort1(s, l, i - 1); // 递归调用
//                quick_sort1(s, i + 1, r);
//            }
//        }
//    }

//    public class EnumService
//    {
//        public static string GetDescription(Enum obj)
//        {
//            string objName = obj.ToString();
//            Type t = obj.GetType();
//            FieldInfo fi = t.GetField(objName);
//            DescriptionAttribute[] arrDesc = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

//            return arrDesc[0].Description;
//        }
//    }

//    public enum EnumNoBooking
//    {
//        /// <summary>
//        /// 1变价
//        /// </summary>
//        [Description("变价")]
//        BinaJia = 1,
//        /// <summary>
//        /// 2停订/停业
//        /// </summary>        
//        [Description("停订/停业")]
//        TingYeTingDing,
//        /// <summary>
//        /// 3价格倒挂/劣势
//        /// </summary>
//        [Description("价格倒挂/劣势")]
//        JiaGeDaoGuaLieShi,
//        /// <summary>
//        /// 4装修
//        /// </summary>
//        [Description("装修")]
//        ZhuangXiul,
//        /// <summary>
//        ///5谈判合作
//        /// </summary>
//        [Description("谈判合作")]
//        TanPan,
//        /// <summary>
//        ///6故障/设备维修
//        /// </summary>
//        [Description("故障/设备维修")]
//        GuZhangWeiXiu,
//        /// <summary>
//        ///7长包
//        /// </summary>
//        [Description("长包")]
//        ChangBao,
//        /// <summary>
//        ///8直连问题
//        /// </summary>
//        [Description("直连问题")]
//        ZhiLian,
//        /// <summary>
//        ///9佣金问题
//        /// </summary>
//        [Description("佣金问题")]
//        YongJin,
//        /// <summary>
//        ///10房型变更/产品下线
//        /// </summary>
//        [Description("房型变更/产品下线")]
//        BianGengXiaXian,
//        /// <summary>
//        ///11政府征用
//        /// </summary>
//        [Description("政府征用")]
//        ZhengFuZHnegYong,
//        /// <summary>
//        ///12不接预订
//        /// </summary>
//        [Description("不接预订")]
//        BuZhiJieYuDing,
//        /// <summary>
//        ///13疑似抢客
//        /// </summary>
//        [Description("疑似抢客")]
//        YiSiQiangKe,
//        /// <summary>
//        ///14自定义
//        /// </summary>
//        [Description("自定义")]
//        Define
//    }
//}
