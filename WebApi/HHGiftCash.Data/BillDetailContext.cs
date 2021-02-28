using HH_Utility.DBFramework;

namespace HHGiftCash.Data
{
    public class BillDetailContext : DbHandleBase
    {
        #region 构造函数
        public BillDetailContext() : base() { }

        public BillDetailContext(string connectStr) : base(connectStr) { }
        #endregion
    }
}
