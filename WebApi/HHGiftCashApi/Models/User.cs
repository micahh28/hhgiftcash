using Dapper.Contrib.Extensions;
using System;

namespace HHGiftCashApi.Models
{
    /// <summary>
    /// 用户
    /// </summary>
    [Table("User")]
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPassword { get; set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public string UserType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 账户有效期
        /// </summary>
        public DateTime? AccountExpire { get; set; }

        /// <summary>
        /// 密码有效期
        /// </summary>
        public DateTime? PasswordExpire { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        public string IdentityCode { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 家庭组Id
        /// </summary>
        public string FamilyId { get; set; }
    }
}
