using HH_Utility.DBFramework;

namespace HHGiftCash.Data
{
    public class GiftBookContext : DbHandleBase
    {
        #region 构造函数
        public GiftBookContext() : base() { }

        public GiftBookContext(string connectStr) : base(connectStr) { }
        #endregion
    }
}
