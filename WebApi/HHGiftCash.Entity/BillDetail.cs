using Dapper.Contrib.Extensions;
using System;

namespace HHGiftCash.Entity
{
    /// <summary>
    /// 账单详情
    /// </summary>
    [Table("BillDetail")]
    public class BillDetail
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 账单名称
        /// </summary>
        public string BillName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 联系人Id
        /// </summary>
        public int FriendId { get; set; }

        /// <summary>
        /// 礼簿Id
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// 账单类型(0：送礼；1收礼；2：支出；3；收入)
        /// </summary>
        public string BillType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
