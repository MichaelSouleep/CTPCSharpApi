using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using CTPCommon;

namespace CTPMdApi
{
    /// <summary>
    /// CTP行情Api响应类
    /// </summary>
    public class CTPMarektSpi
    {
        /// <summary>
        /// CTP行情Api
        /// </summary>
        protected CTPMarketApi m_api;

        /// <summary>
        /// 构造函数
        /// </summary>
        public CTPMarektSpi()
        {
            //m_api = api;
            //Init();
        }
        //protected void Init()
        //{
        //    m_api.OnRspError += this.OnRspError;
        //    m_api.OnHeartBeatWarning += this.OnHeartBeatWarning;
        //    m_api.OnFrontConnected += this.OnFrontConnected;
        //    m_api.OnFrontDisconnected += this.OnFrontDisconnected;
        //    m_api.OnRspUserLogin += this.OnRspUserLogin;
        //    m_api.OnRspUserLogout += this.OnRspUserLogout;
        //    m_api.OnRspSubMarketData += this.OnRspSubMarketData;
        //    m_api.OnRspUnSubMarketData += this.OnRspUnSubMarketData;
        //    m_api.OnRtnDepthMarketData += this.OnRtnDepthMarketData;
        //}

        //protected void UnInit()
        //{
        //    m_api.OnRspError -= this.OnRspError;
        //    m_api.OnHeartBeatWarning -= this.OnHeartBeatWarning;
        //    m_api.OnFrontConnected -= this.OnFrontConnected;
        //    m_api.OnFrontDisconnected -= this.OnFrontDisconnected;
        //    m_api.OnRspUserLogin -= this.OnRspUserLogin;
        //    m_api.OnRspUserLogout -= this.OnRspUserLogout;
        //    m_api.OnRspSubMarketData -= this.OnRspSubMarketData;
        //    m_api.OnRspUnSubMarketData -= this.OnRspUnSubMarketData;
        //    m_api.OnRtnDepthMarketData -= this.OnRtnDepthMarketData;
        //}
        /// <summary>
        /// 错误消息响应
        /// </summary>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public virtual void OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }
        /// <summary>
        /// 心跳响应(15s)
        /// </summary>
        /// <param name="nTimeLapse"></param>
        public virtual void OnHeartBeatWarning(int nTimeLapse) { }
        /// <summary>
        /// 前置连接响应
        /// </summary>
        public virtual void OnFrontConnected() { }
        /// <summary>
        /// 前置断开响应
        /// </summary>
        /// <param name="nReason"></param>
        public virtual void OnFrontDisconnected(int nReason) { }
        /// <summary>
        /// 登录响应
        /// </summary>
        /// <param name="pRspUserLogin"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public virtual void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }
        /// <summary>
        /// 登出响应
        /// </summary>
        /// <param name="pUserLogout"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public virtual void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }
        /// <summary>
        /// 订阅行情响应
        /// </summary>
        /// <param name="pSpecificInstrument"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public virtual void OnRspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }
        /// <summary>
        /// 退订行情响应
        /// </summary>
        /// <param name="pSpecificInstrument"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public virtual void OnRspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast) { }
        /// <summary>
        /// 行情回报
        /// </summary>
        /// <param name="pDepthMarketData"></param>
        public virtual void OnRtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData) { }
    }
    /// <summary>
    /// 行情接口
    /// </summary>
    public class CTPMarketApi
    {
        const string strDllFile = "ctpcsharpmdapi.dll";

        /// <summary>
        /// MdApi.dll/CTPMdApi.dll/thostmduserapi.dll 放在主程序的执行文件夹中
        /// </summary>
        /// <param name="_FlowPath">流水文件地址</param>
        public CTPMarketApi(string _FlowPath = null)
        {
            //this.FrontAddr = _addr;
            //this.BrokerID = _broker;
            //this.InvestorID = _investor;
            //this.password = _pwd;
            this.FlowPath = _FlowPath;
            CreateFtdcMDApi(_FlowPath);
        }

        /// <summary>
        /// 注册spi
        /// </summary>
        /// <param name="spi"></param>
        public void RegisterSpi(CTPMarektSpi spi)
        {
            OnRspError += spi.OnRspError;
            OnHeartBeatWarning += spi.OnHeartBeatWarning;
            OnFrontConnected += spi.OnFrontConnected;
            OnFrontDisconnected += spi.OnFrontDisconnected;
            OnRspUserLogin += spi.OnRspUserLogin;
            OnRspUserLogout += spi.OnRspUserLogout;
            OnRspSubMarketData += spi.OnRspSubMarketData;
            OnRspUnSubMarketData += spi.OnRspUnSubMarketData;
            OnRtnDepthMarketData += spi.OnRtnDepthMarketData;
        }


        [DllImport(strDllFile, EntryPoint = "CreateApi", CallingConvention = CallingConvention.Cdecl)]
        static extern void CreateFtdcMDApi(string flowPath);

        /// <summary>
        /// 注册前置地址
        /// </summary>
        /// <param name="addr"></param>
        public void RegisterFront(string addr) { registerFront(addr); }
        [DllImport(strDllFile, EntryPoint = "RegisterFront", CallingConvention = CallingConvention.Cdecl)]
        static extern void registerFront(string addr);

        //      /// <summary>
        //      /// 前置地址
        //      /// </summary>
        //      public string FrontAddr { get; set; }
        ///// <summary>
        ///// 经纪公司代码ctp-2030;上期-4030;
        ///// </summary>
        //public string BrokerID { get; set; }
        ///// <summary>
        ///// 投资者代码 351962-申万
        ///// </summary>
        //public string InvestorID { get; set; }
        ///// <summary>
        ///// 密码
        ///// </summary>
        //private string password;
        private string FlowPath;

        /// <summary>
        /// 获取当前交易日:只有登录成功后,才能得到正确的交易日
        /// </summary>
        /// <returns></returns>
        public string GetTradingDay() { return getTradingDay(); }
        [DllImport(strDllFile, EntryPoint = "GetTradingDay", CallingConvention = CallingConvention.Cdecl)]
        static extern string getTradingDay();

        /// <summary>
        /// 连接
        /// </summary>
        public void Init() { init(); }
        [DllImport(strDllFile, EntryPoint = "Init", CallingConvention = CallingConvention.Cdecl)]
        static extern void init();


        /// <summary>
        /// 断开连接
        /// </summary>
        public void DisConnect() { disConnect(); }
        [DllImport(strDllFile, EntryPoint = "DisConnect", CallingConvention = CallingConvention.Cdecl)]
        static extern void disConnect();

        /// <summary>
        /// 登录
        /// </summary>
        public int ReqUserLogin(CThostFtdcReqUserLoginField loginField, int requestID) { return userLogin(loginField.BrokerID, loginField.UserID, loginField.Password); }
        [DllImport(strDllFile, EntryPoint = "ReqUserLogin", CallingConvention = CallingConvention.Cdecl)]
        static extern int userLogin(string BROKER_ID, string INVESTOR_ID, string PASSWORD);

        /// <summary>
        /// 用户注销
        /// </summary>
        public int ReqUserLogout(CThostFtdcUserLogoutField logoutField, int requestID) { return userLogout(logoutField.BrokerID, logoutField.UserID); }
        [DllImport(strDllFile, EntryPoint = "ReqUserLogout", CallingConvention = CallingConvention.Cdecl)]
        static extern int userLogout(string BROKER_ID, string INVESTOR_ID);

        /// <summary>
        /// 订阅行情
        /// </summary>
        /// <param name="instruments">合约代码:可填多个,订阅所有填null</param>
        public int SubscribeMarketData(params string[] instruments) { return subMarketData(instruments, instruments == null ? 0 : instruments.Length); }
        [DllImport(strDllFile, EntryPoint = "SubMarketData", CallingConvention = CallingConvention.Cdecl)]
        static extern int subMarketData(string[] instrumentsID, int nCount);

        /// <summary>
        /// 退订行情
        /// </summary>
        /// <param name="instruments">合约代码:可填多个,退订所有填null</param>
        public int UnSubscribeMarketData(params string[] instruments) {return unSubMarketData(instruments, instruments == null ? 0 : instruments.Length); }
        [DllImport(strDllFile, EntryPoint = "UnSubscribeMarketData", CallingConvention = CallingConvention.Cdecl)]
        static extern int unSubMarketData(string[] ppInstrumentID, int nCount);

        //回调函数 ==================================================================================================================
        #region 错误响应
        [DllImport(strDllFile, EntryPoint = "RegOnRspError", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspError(RspError cb);
        RspError rspError;
        /// <summary>
        /// 
        /// </summary>
        public delegate void RspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 连接响应
        /// </summary>
        public event RspError OnRspError
        {
            add { rspError += value; regOnRspError(rspError); }
            remove { rspError -= value; regOnRspError(rspError); }

        }
        #endregion

        #region 心跳响应
        [DllImport(strDllFile, EntryPoint = "RegOnHeartBeatWarning", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnHeartBeatWarning(HeartBeatWarning cb);
        HeartBeatWarning heartBeatWarning;
        /// <summary>
        /// 
        /// </summary>
        public delegate void HeartBeatWarning(int nTimeLapse);
        /// <summary>
        /// 心跳响应
        /// </summary>
        public event HeartBeatWarning OnHeartBeatWarning
        {
            add { heartBeatWarning += value; regOnHeartBeatWarning(heartBeatWarning); }
            remove { heartBeatWarning -= value; regOnHeartBeatWarning(heartBeatWarning); }

        }
        #endregion

        #region 连接响应
        [DllImport(strDllFile, EntryPoint = "RegOnFrontConnected", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnFrontConnected(FrontConnected cb);
        FrontConnected frontConnected;
        /// <summary>
        /// 
        /// </summary>
        public delegate void FrontConnected();
        /// <summary>
        /// 连接响应
        /// </summary>
        public event FrontConnected OnFrontConnected
        {
            add { frontConnected += value; regOnFrontConnected(frontConnected); }
            remove { frontConnected -= value; regOnFrontConnected(frontConnected); }

        }
        #endregion

        #region 断开应答
        [DllImport(strDllFile, EntryPoint = "RegOnFrontDisconnected", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnFrontDisconnected(FrontDisconnected cb);
        FrontDisconnected frontDisconnected;
        /// <summary>
        /// 
        /// </summary>
        public delegate void FrontDisconnected(int nReason);
        /// <summary>
        /// 断开应答
        /// </summary>
        public event FrontDisconnected OnFrontDisconnected
        {
            add { frontDisconnected += value; regOnFrontDisconnected(frontDisconnected); }
            remove { frontDisconnected -= value; regOnFrontDisconnected(frontDisconnected); }
        }
        #endregion

        #region 登入请求应答
        [DllImport(strDllFile, EntryPoint = "RegOnRspUserLogin", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspUserLogin(RspUserLogin cb);
        RspUserLogin rspUserLogin;
        /// <summary>
        /// 
        /// </summary>
        public delegate void RspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 登入请求应答
        /// </summary>
        public event RspUserLogin OnRspUserLogin
        {
            add { rspUserLogin += value; regOnRspUserLogin(rspUserLogin); }
            remove { rspUserLogin -= value; regOnRspUserLogin(rspUserLogin); }
        }
        #endregion

        #region 登出请求应答
        [DllImport(strDllFile, EntryPoint = "RegOnRspUserLogout", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspUserLogout(RspUserLogout cb);
        RspUserLogout rspUserLogout;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pUserLogout"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public delegate void RspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 登出请求应答
        /// </summary>
        public event RspUserLogout OnRspUserLogout
        {
            add { rspUserLogout += value; regOnRspUserLogout(rspUserLogout); }
            remove { rspUserLogout -= value; regOnRspUserLogout(rspUserLogout); }
        }
        #endregion

        #region 订阅行情应答
        [DllImport(strDllFile, EntryPoint = "RegOnRspSubMarketData", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspSubMarketData(RspSubMarketData cb);
        RspSubMarketData rspSubMarketData;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSpecificInstrument"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public delegate void RspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 订阅行情应答
        /// </summary>
        public event RspSubMarketData OnRspSubMarketData
        {
            add { rspSubMarketData += value; regOnRspSubMarketData(rspSubMarketData); }
            remove { rspSubMarketData -= value; regOnRspSubMarketData(rspSubMarketData); }
        }
        #endregion

        #region 退订请求应答
        [DllImport(strDllFile, EntryPoint = "RegOnRspUnSubMarketData", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRspUnSubMarketData(RspUnSubMarketData cb);
        RspUnSubMarketData rspUnSubMarketData;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSpecificInstrument"></param>
        /// <param name="pRspInfo"></param>
        /// <param name="nRequestID"></param>
        /// <param name="bIsLast"></param>
        public delegate void RspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 退订请求应答
        /// </summary>
        public event RspUnSubMarketData OnRspUnSubMarketData
        {
            add { rspUnSubMarketData += value; regOnRspUnSubMarketData(rspUnSubMarketData); }
            remove { rspUnSubMarketData -= value; regOnRspUnSubMarketData(rspUnSubMarketData); }
        }
        #endregion

        #region 深度行情通知
        [DllImport(strDllFile, EntryPoint = "RegOnRtnDepthMarketData", CallingConvention = CallingConvention.StdCall)]
        static extern void regOnRtnDepthMarketData(RtnDepthMarketData cb);
        RtnDepthMarketData rtnDepthMarketData;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDepthMarketData"></param>
        public delegate void RtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData);
        /// <summary>
        /// 深度行情通知
        /// </summary>
        public event RtnDepthMarketData OnRtnDepthMarketData
        {
            add { rtnDepthMarketData += value; regOnRtnDepthMarketData(rtnDepthMarketData); }
            remove { rtnDepthMarketData -= value; regOnRtnDepthMarketData(rtnDepthMarketData); }
        }
        #endregion
    }
}