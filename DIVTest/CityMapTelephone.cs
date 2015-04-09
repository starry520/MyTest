using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIVTest
{
    [Serializable]
     public  class CityMapTelephone
    {
         /// <summary>
         /// 城市
         /// </summary>
        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
         /// <summary>
         /// 省份
         /// </summary>
        private string _province;

        public string Province
        {
            get { return _province; }
            set { _province = value; }
        }
         /// <summary>
         /// 地区
         /// </summary>
        private string _zone;

        public string Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }
         /// <summary>
         /// 电话
         /// </summary>
        private string _telephone;

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
    }
}
