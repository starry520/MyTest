
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIVTest
{
    public class linq
    {
        static List<FeedBackListEntity> feedBackList = new List<FeedBackListEntity>();
        static List<FeedBackListEntity> commHotelWritingComments = new List<FeedBackListEntity>();
        public static void Test()
        {
            feedBackList.Add(new FeedBackListEntity
            {
                Writing = 1,
                IsFeedBack = true
            });
            feedBackList.Add(new FeedBackListEntity
            {
                Writing = 2,
                IsFeedBack = true
            });
            feedBackList.Add(new FeedBackListEntity
            {
                Writing = 3,
                IsFeedBack = true
            });

            feedBackList.Add(new FeedBackListEntity
            {
                Writing =4,
                IsFeedBack = true
            });
            feedBackList.Add(new FeedBackListEntity
            {
                Writing = 5,
                IsFeedBack = true
            });
            feedBackList.Add(new FeedBackListEntity
            {
                Writing = 6,
                IsFeedBack = true
            });

            commHotelWritingComments.Add(new FeedBackListEntity
            {
                Writing = 1,
                IsFeedBack = true
            });
            commHotelWritingComments.Add(new FeedBackListEntity
            {
                Writing = 2,
                IsFeedBack = true
            });
            commHotelWritingComments.Add(new FeedBackListEntity
            {
                Writing = 3,
                IsFeedBack = true
            });

            //查询全部
           var  ff = (from f in feedBackList
                       where f.NickName=="12342"
                       select f
                       ).FirstOrDefault();
                       
        }
    }

    public class FeedBackListEntity
    {
        private int writing;

        public int Writing
        {
            get { return writing; }
            set { writing = value; }
        }

        private DateTime wdate;

        public DateTime Wdate
        {
            get { return wdate; }
            set { wdate = value; }
        }

        private decimal point;
        /// <summary>
        /// 点评分数 
        /// </summary>
        public decimal Point
        {
            get { return point; }
            set { point = value; }
        }

        private String title;
        /// <summary>
        /// 点评主题
        /// </summary>
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        // 去掉了原来的 content 与 huid 。
        // 因为内容与作者不再显示在FeedBackList中了 2012.3.12 

        private Boolean isFeedBack;

        public Boolean IsFeedBack
        {
            get { return isFeedBack; }
            set { isFeedBack = value; }
        }

        private String nickName;

        public String NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

    }
}
