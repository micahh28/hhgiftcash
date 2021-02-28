using Dapper.Contrib.Extensions;
using System;

namespace HHGiftCash.Entity
{
    [Table("GiftBook")]
    public class GiftBook
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 礼簿名称
        /// </summary>
        public string BookName { get; set; }
        
        /// <summary>
        /// 礼簿类型
        /// </summary>
        public string BookType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
