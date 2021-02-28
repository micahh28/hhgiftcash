using HH_Utility.DBFramework;

namespace HHGiftCash.Data
{
    public class UserContext : DbHandleBase
    {
        #region 构造函数
        public UserContext() : base() { }

        public UserContext(string connectStr) : base(connectStr) { }
        #endregion
    }
}
