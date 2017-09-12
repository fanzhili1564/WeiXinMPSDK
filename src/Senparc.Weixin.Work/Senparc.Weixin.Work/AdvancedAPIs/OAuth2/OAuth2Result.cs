﻿/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc
    
    文件名：OAuth2Result.cs
    文件功能描述：获取成员信息返回结果
    http://work.weixin.qq.com/api/doc#10028
    
    创建标识：Senparc - 20150313
    
    修改标识：Senparc - 20150313
    修改描述：整理接口
 
    修改标识：Senparc - 20150316
    修改描述：添加DeviceId字段
 
    修改标识：Senparc - 20150316
    修改描述：GetUserIdResult变更为GetUserInfoResult，增加OpenId字段

    修改标识：Senparc - 20170909
    修改描述：修改注释

----------------------------------------------------------------*/

using Senparc.Weixin.Entities;

namespace Senparc.Weixin.Work.AdvancedAPIs.OAuth2
{
    /// <summary>
    /// 获取成员信息返回结果
    /// </summary>
    public class GetUserInfoResult : WorkJsonResult
    {
        /* 
           a) 当用户为企业成员时返回示例如下：

{
   "errcode": 0,
   "errmsg": "ok",
   "UserId":"USERID",
   "DeviceId":"DEVICEID",
   "user_ticket": "USER_TICKET"，
   "expires_in":7200
}

            b) 非企业成员授权时返回示例如下：

{
   "errcode": 0,
   "errmsg": "ok",
   "OpenId":"OPENID",
   "DeviceId":"DEVICEID"
}

    */


        /// <summary>
        /// 员工UserID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 非企业成员的OpenId
        /// （此属性在Work最新文档中没有）
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 手机设备号(由微信在安装时随机生成) 
        /// （此属性在Work最新文档中没有）
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 成员票据，最大为512字节。
        /// scope为snsapi_userinfo或snsapi_privateinfo，且用户在应用可见范围之内时返回此参数。
        /// 后续利用该参数可以获取用户信息或敏感信息。
        /// </summary>
        public string user_ticket { get; set; }

        /// <summary>
        /// user_token的有效时间（秒），随user_ticket一起返回
        /// </summary>
        public int expires_in { get; set; }

    }


    /// <summary>
    /// "使用user_ticket获取成员详情"接口返回结果
    /// </summary>
    public class GetUserDetailResult : WorkJsonResult
    {
        /*
         {
   "userid":"lisi",
   "name":"李四",
   "department":[3],
   "position": "后台工程师",
   "mobile":"15050495892",
   "gender":1,
   "email":"xxx@xx.com",
   "avatar":"http://shp.qpic.cn/bizmp/xxxxxxxxxxx/0"
        }
        */

        public string userid { get; set; }
        public string name { get; set; }
        public int[] department { get; set; }
        public string position { get; set; }
        public string mobile { get; set; }
        public int gender { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
    }
}
