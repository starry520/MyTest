using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommClass;

namespace Linq
{
    //LINQ内链接，外联结
    class Program
    {
       
        static void Main(string[] args)
        {
            double f = 123.523;
            string df = f.ToString();
            int i = (int)f;

            Guid guid = Guid.NewGuid();
            byte[] guidarr = guid.ToByteArray();
            byte[] dstarr = new byte[10];
            Array.Copy(guidarr, dstarr, 10);

            string basestr = Convert.ToBase64String(dstarr);
    

            List<Car> cars = new List<Car>();
            cars.Add(new Car() { Name=  "宝马",Size="10"});
            cars.Add(new Car() { Name = "奔驰", Size = "11" });
            cars.Add(new Car() { Name = "保时捷", Size = "12" });
            cars.Add(new Car() { Name = "宝马", Size = "11" });
          //  cars[0].Test();
            List<Adress> adresslist = new List<Adress>();
            adresslist.Add(new Adress { Name = "宝马", City="伦敦" });
            adresslist.Add(new Adress { Name = "奔驰", City = "上海" });
            adresslist.Add(new Adress { Name = "保时捷", City = "纽约" });

            List<Tel> tellist = new List<Tel>();
            tellist.Add(new Tel { City = "伦敦",Telnum="111111" });
            tellist.Add(new Tel { City = "不知道", Telnum = "22222" });
            tellist.Add(new Tel { City = "纽约", Telnum = "33333" });

            var result = (from ct in cars
                          join a in adresslist on ct.Name equals a.Name
                     
                          into newCityMapTelephones
                          from n in newCityMapTelephones.DefaultIfEmpty()
                          //select new Car()
                          //{
                          //    Name = ct.Name,
                          //    City = n == null ? ct.City : n.City,                            
                          //    Size = ct.Size
                          //}
                          select n
                          ).ToList();

            string ss = result[0].GetType().ToString();// Type.GetType(typeof(result[0]));
            //var result1 = (from ct in result
            //               join c in companys on ct.CompanyName equals c.CompanyName
            //              into newCityMapTelephones
            //               from n in newCityMapTelephones.DefaultIfEmpty()
            //               select new CityMapTelephones()
            //               {
            //                   CityName = ct.CityName,
            //                   ProvinceName = ct.ProvinceName,
            //                   CompanyName = ct.CompanyName,
            //                   Telephone = n == null ? ct.Telephone : n.Telephone
            //               }).ToList();
        }
    }

    public enum EmailTypeEnum
    {
        HotelBookingNotice = 1,//	酒店预订通知
        ChangePriceRequestNotice,//	Ebooking酒店变价申请单待审核通知
        SeasonalInformationAudit,    //3	Ebooking提交时令信息审核
        PriceFaxNotice,   //4	变价传真通知
        PriceChangedNotice,  //5	价格修改通知
        PriceChangedAuditSummary,   //6	变价审核提醒汇总
        HotelOnlineNotice,    //7	酒店上线通知
        HotelPriceLockWarningPP,  //8	酒店卖价锁定预警（预付）
        HotelPriceLockWarningFG,   //9	酒店卖价锁定预警（现付）
        PriceComparisonWarning, //10	马甲房型比价预警
        PaymentMethodChangeWarning    //11	结算方式变更预警
    }
}
