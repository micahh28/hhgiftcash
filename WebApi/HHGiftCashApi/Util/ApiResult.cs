using System;

namespace HHGiftCashApi.Util
{
    /// <summary>
    /// 统一请求结果返回
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsOk { get; set; }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ApiResult()
        {
        }

        /// <summary>
        /// 成功结果
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public ApiResult Success(object data)
        {
            return new ApiResult()
            {
                Code = 200,
                Message = "OK",
                Data = data
            };
        }

        /// <summary>
        /// 成功结果
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public ApiResult Success(string message, object data = null, int code = 200)
        {
            return new ApiResult()
            {
                Code = code,
                Message = message,
                Data = data
            };
        }

        /// <summary>
        /// 异常错误
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public ApiResult Error(Exception ex)
        {
            return new ApiResult()
            {
                Code = 500,
                Message = ex.Message
            };
        }

        /// <summary>
        /// 设置失败结果
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public ApiResult SetFail(string message, int code = -1)
        {
            return new ApiResult()
            {
                Code = code,
                Message = message
            };
        }
    }
}