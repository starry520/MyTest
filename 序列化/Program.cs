using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace 序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomTypeEntity roomEntity = new RoomTypeEntity();
            int count = 1000000;
            bool isBuyoutRoom = false;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                RoomTypeEntity tempRoomTypeEntity = roomEntity.CloneRoomTypeEntity();
                if (tempRoomTypeEntity == null)
                {
                    tempRoomTypeEntity = new RoomTypeEntity();
                }
            }

            sw.Stop();

            long sa1 = sw.ElapsedMilliseconds;
            Console.WriteLine("CloneRoomTypeEntity:" + sw.ElapsedMilliseconds);
            sw.Restart();

            for (int i = 0; i < count; i++)
            {
                RoomTypeEntity tempRoomTypeEntity = new RoomTypeEntity();
                tempRoomTypeEntity.IsBuyoutRoom = isBuyoutRoom;
                tempRoomTypeEntity.RoomStatus = roomEntity.RoomStatus;
            }

            sw.Stop();

            Console.WriteLine("NewRoomTypeEntity:" + sw.ElapsedMilliseconds);
        }
    }


    [Serializable]
    public class RoomTypeEntity
    {
        private Int32 hotel;

        public Int32 Hotel
        {
            get { return hotel; }
            set { hotel = value; }
        }
        private String hotelName;
        /// <summary>
        /// 
        /// </summary>
        public String HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private Int32 room;

        public Int32 Room
        {
            get { return room; }
            set { room = value; }
        }

        private Int32 roomClass;

        public Int32 RoomClass
        {
            get { return roomClass; }
            set { roomClass = value; }
        }

        private String roomName;
        /// <summary>
        /// 房型名
        /// </summary>
        public String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        private String roomInternalName;
        /// <summary>
        /// 房型内部名称
        /// </summary>
        public String RoomInternalName
        {
            get { return roomInternalName; }
            set { roomInternalName = value; }
        }

        private String roomEName;
        /// <summary>
        /// 房型名英文
        /// </summary>
        public String RoomEName
        {
            get { return roomEName; }
            set { roomEName = value; }
        }
        private String currency;
        /// <summary>
        /// 货币
        /// </summary>
        public String Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        private Double roomListPrice;
        /// <summary>
        /// 标准价格
        /// </summary>
        public Double RoomListPrice
        {
            get { return roomListPrice; }
            set { roomListPrice = value; }
        }

        private String areaRange;
        /// <summary>
        /// 面积
        /// </summary>
        public String AreaRange
        {
            get { return areaRange; }
            set { areaRange = value; }
        }

        private String floorRange;
        /// <summary>
        /// 楼层
        /// </summary>
        public String FloorRange
        {
            get { return floorRange; }
            set { floorRange = value; }
        }

        private Int32 person;
        /// <summary>
        /// 入住人数
        /// </summary>
        public Int32 Person
        {
            get { return person; }
            set { person = value; }
        }

        private Int32 addBedFee;
        /// <summary>
        /// 加床价-1不可加床，0 免费加床
        /// </summary>
        public Int32 AddBedFee
        {
            get { return addBedFee; }
            set { addBedFee = value; }
        }

        private Int32 roomQuantity;
        /// <summary>
        /// 房间数量
        /// </summary>
        public Int32 RoomQuantity
        {
            get { return roomQuantity; }
            set { roomQuantity = value; }
        }

        private String description;
        /// <summary>
        /// 房型描述
        /// </summary>
        public String Description
        {
            get { return description; }
            set { description = value; }
        }


        private Int32 hasBroadnet;
        /// <summary>
        /// 是否有宽带0,1,2
        /// </summary>
        public Int32 HasBroadnet
        {
            get { return hasBroadnet; }
            set { hasBroadnet = value; }
        }

        private String broadnetFee;
        /// <summary>
        /// 宽带情况
        /// </summary>
        public String BroadnetFee
        {
            get { return broadnetFee; }
            set { broadnetFee = value; }
        }

        private String hasKingBed;
        /// <summary>
        /// 大床
        /// </summary>
        public String HasKingBed
        {
            get { return hasKingBed; }
            set { hasKingBed = value; }
        }

        private String hasTwinBed;
        /// <summary>
        /// 双床
        /// </summary>
        public String HasTwinBed
        {
            get { return hasTwinBed; }
            set { hasTwinBed = value; }
        }
        /// <summary>
        /// 默认推荐级别
        /// </summary>
        public int DefRecommend { get; set; }
        ///// <summary>
        ///// 设置满房类型
        ///// </summary>
        //public string RoomStatus { get; set; }
        /// <summary>
        /// 是否买断房
        /// </summary>
        public bool IsBuyoutRoom { get; set; }
        /// <summary>
        /// 基础房型
        /// </summary>
        public int BasicRoomTypeID { get; set; }
        /// <summary>
        /// 基础房型名称
        /// </summary>
        public string BasicRoomTypeName { get; set; }
        /// <summary>
        /// RateCode
        /// </summary>
        public string RateCodeInternalName { get; set; }
        /// <summary>
        /// 合同保留房
        /// </summary>
        public int ContractRooms { get; set; }
        /// <summary>
        /// 剩余可用保留房
        /// </summary>
        public int AbleRooms { get; set; }
        /// <summary>
        /// 总保留房
        /// </summary>
        public int TotalRooms { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime EffectDate { get; set; }
        /// <summary>
        /// 房态：满房，有房，限量
        /// </summary>
        public string RoomStatus { get; set; }
        /// <summary>
        /// 床态值：KingSizeF,TwinBedF,KingSizeT,TwinBedT
        /// </summary>
        public string BedStatus { get; set; }
        /// <summary>
        /// 日期格式（逗号隔开）：日,月,周X
        /// </summary>
        public string EffectDateFormat { get; set; }
        /// <summary>
        /// 床态属性：HasKingSizeT,HasKingSizeF,HasTwinBedT,HasTwinBedF
        /// </summary>
        public string BedStatusProp { get; set; }

        public RoomTypeEntity CloneRoomTypeEntity()
        {
            RoomTypeEntity result = null;
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Position = 0;
                result = formatter.Deserialize(stream) as RoomTypeEntity;
            }

            return result;
        }
    }
}
