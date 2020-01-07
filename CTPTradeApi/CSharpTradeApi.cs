using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using CTPCommon;

namespace CTPTradeApi
{
    /// <summary>
    /// CTP交易Api响应类
    /// </summary>
    public class CTPTradeSpi
    {
        /// <summary>
        /// CTP交易api
        /// </summary>
        protected CTPTradeApi m_api;

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释

        public virtual void OnRtnChangeAccountByBank(ref CThostFtdcChangeAccountField pChangeAccount)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryTransferBank(ref CThostFtdcTransferBankField pTransferBank,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryNotice(ref CThostFtdcNoticeField pNotice,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryCFMMCTradingAccountKey(ref CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryEWarrantOffset(ref CThostFtdcEWarrantOffsetField pEWarrantOffset,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspAuthenticate(ref CThostFtdcRspAuthenticateField pRspAuthenticateField,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryTransferSerial(ref CThostFtdcTransferSerialField pTransferSerial,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryAccountregister(ref CThostFtdcAccountregisterField pAccountregister,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRtnRepealFromBankToFutureByFutureManual(ref CThostFtdcRspRepealField pRspRepeal)
        {
            //Todo:Impl
        }

        public virtual void OnRtnRepealFromFutureToBankByFutureManual(ref CThostFtdcRspRepealField pRspRepeal)
        {
            //Todo:Impl
        }

        public virtual void OnRtnQueryBankBalanceByFuture(ref CThostFtdcNotifyQueryAccountField pNotifyQueryAccount)
        {
            //Todo:Impl
        }

        public virtual void OnErrRtnBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo)
        {
            //Todo:Impl
        }

        public virtual void OnErrRtnFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo)
        {
            //Todo:Impl
        }

        public virtual void OnErrRtnRepealBankToFutureByFutureManual(ref CThostFtdcReqRepealField pReqRepeal,ref CThostFtdcRspInfoField pRspInfo)
        {
            //Todo:Impl
        }

        public virtual void OnErrRtnRepealFutureToBankByFutureManual(ref CThostFtdcReqRepealField pReqRepeal,ref CThostFtdcRspInfoField pRspInfo)
        {
            //Todo:Impl
        }

        public virtual void OnErrRtnQueryBankBalanceByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,ref CThostFtdcRspInfoField pRspInfo)
        {
            //Todo:Impl
        }

        public virtual void OnRtnRepealFromBankToFutureByFuture(ref CThostFtdcRspRepealField pRspRepeal)
        {
            //Todo:Impl
        }

        public virtual void OnRtnRepealFromFutureToBankByFuture(ref CThostFtdcRspRepealField pRspRepeal)
        {
            //Todo:Impl
        }

        public virtual void OnRspFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRtnOpenAccountByBank(ref CThostFtdcOpenAccountField pOpenAccount)
        {
            //Todo:Impl
        }

        public virtual void OnRtnCancelAccountByBank(ref CThostFtdcCancelAccountField pCancelAccount)
        {
            //Todo:Impl
        }

        public virtual void OnRtnFromFutureToBankByFuture(ref CThostFtdcRspTransferField pRspTransfer)
        {
            //Todo:Impl
        }

        public virtual void OnRtnFromBankToFutureByFuture(ref CThostFtdcRspTransferField pRspTransfer)
        {
            //Todo:Impl
        }

        public virtual void OnRtnRepealFromFutureToBankByBank(ref CThostFtdcRspRepealField pRspRepeal)
        {
            //Todo:Impl
        }

        public virtual void OnRtnRepealFromBankToFutureByBank(ref CThostFtdcRspRepealField pRspRepeal)
        {
            //Todo:Impl
        }

        public virtual void OnRtnTradingNotice(ref CThostFtdcTradingNoticeInfoField pTradingNoticeInfo)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryContractBank(ref CThostFtdcContractBankField pContractBank,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryParkedOrder(ref CThostFtdcParkedOrderField pParkedOrder,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryTradingNotice(ref CThostFtdcTradingNoticeField pTradingNotice,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryBrokerTradingAlgos(ref CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRtnFromBankToFutureByBank(ref CThostFtdcRspTransferField pRspTransfer)
        {
            //Todo:Impl
        }

        public virtual void OnRtnFromFutureToBankByBank(ref CThostFtdcRspTransferField pRspTransfer)
        {
            //Todo:Impl
        }

        public virtual void OnRtnErrorConditionalOrder(ref CThostFtdcErrorConditionalOrderField pErrorConditionalOrder)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryBrokerTradingParams(ref CThostFtdcBrokerTradingParamsField pBrokerTradingParams,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnFrontConnected()
        {
            //CThostFtdcReqUserLoginField loginField = new CThostFtdcReqUserLoginField();
            //loginField.UserID = "035510";
            //loginField.Password = "123456";
            //loginField.BrokerID = "9999";
            //m_api.ReqUserLogin(loginField, 0);
            ////Todo:Impl
        }

        public virtual void OnFrontDisconnected(int nReason)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryInvestor(ref CThostFtdcInvestorField pInvestor,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryTradingCode(ref CThostFtdcTradingCodeField pTradingCode,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryInstrumentMarginRate(ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryInstrumentCommissionRate(ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryExchange(ref CThostFtdcExchangeField pExchange,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryInstrument(ref CThostFtdcInstrumentField pInstrument,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryInvestorPositionDetail(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQrySettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryInvestorPositionCombineDetail(ref CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryInvestorPosition(ref CThostFtdcInvestorPositionField pInvestorPosition,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryTrade(ref CThostFtdcTradeField pTrade,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnHeartBeatWarning(int nTimeLapse)
        {
            //Todo:Impl
        }

        public virtual void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQryOrder(ref CThostFtdcOrderField pOrder,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspQueryMaxOrderVolume(ref CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            //Todo:Impl
        }

        public virtual void OnRtnOrder(ref CThostFtdcOrderField pOrder)
        {
            //Todo:Impl
        }

        public virtual void OnRtnTrade(ref CThostFtdcTradeField pTrade)
        {
            //Todo:Impl
        }

        public virtual void OnErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo)
        {
            //Todo:Impl
        }

        public virtual void OnErrRtnOrderAction(ref CThostFtdcOrderActionField pOrderAction,ref CThostFtdcRspInfoField pRspInfo)
        {
            //Todo:Impl
        }

        public virtual void OnRtnInstrumentStatus(ref CThostFtdcInstrumentStatusField pInstrumentStatus)
        {
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name + pInstrumentStatus.InstrumentID);
        }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }

    /// <summary>
    /// 交易接口
    /// </summary>
    public class CTPTradeApi
	{
        private IntPtr api;
        /// <summary>
        /// 中继模式下获取SystemInfo
        /// </summary>
        /// <returns></returns>
        public static int GetSystemInfo(string pSystemInfo, int nLen) { return CTP_GetSystemInfo(pSystemInfo, nLen); }
		const string dllName = "ctpcsharptdapi.dll";
        const string dataCollectDllName = "WinDataCollect.dll";

		/// <summary>
		/// TradeApi.dll/CTPTradeApi.dll/thosttraderapi.dll 放在主程序的执行文件夹中
		/// </summary>
		public CTPTradeApi( string _FlowPath ="")
		{
			//this.FrontAddr = _addr;
			//this.BrokerID = _broker;
			//this.InvestorID = _investor;
			//this.passWord = _pwd;
            this.FlowPath = _FlowPath;
            api=CreateFtdcTraderApi(_FlowPath);
		}

        /// <summary>
        /// 注册spi
        /// </summary>
        /// <param name="spi"></param>
        public void RegisterSpi(CTPTradeSpi spi)
        {
            OnRtnFromFutureToBankByBank += spi.OnRtnFromFutureToBankByBank;
            OnRtnFromBankToFutureByBank += spi.OnRtnFromBankToFutureByBank;
            OnRspQryBrokerTradingAlgos += spi.OnRspQryBrokerTradingAlgos;
            OnRspQryBrokerTradingParams += spi.OnRspQryBrokerTradingParams;
            OnRspQryTradingNotice += spi.OnRspQryTradingNotice;
            OnRspQryParkedOrderAction += spi.OnRspQryParkedOrderAction;
            OnRspQryParkedOrder += spi.OnRspQryParkedOrder;
            OnRspQryContractBank += spi.OnRspQryContractBank;
            OnRtnErrorConditionalOrder += spi.OnRtnErrorConditionalOrder;
            OnRtnTradingNotice += spi.OnRtnTradingNotice;
            OnRtnInstrumentStatus += spi.OnRtnInstrumentStatus;
            OnErrRtnOrderAction += spi.OnErrRtnOrderAction;
            OnErrRtnOrderInsert += spi.OnErrRtnOrderInsert;
            OnRtnTrade += spi.OnRtnTrade;
            OnRtnRepealFromBankToFutureByBank += spi.OnRtnRepealFromBankToFutureByBank;
            OnRtnRepealFromFutureToBankByBank += spi.OnRtnRepealFromFutureToBankByBank;
            OnRtnFromBankToFutureByFuture += spi.OnRtnFromBankToFutureByFuture;
            OnRtnFromFutureToBankByFuture += spi.OnRtnFromFutureToBankByFuture;
            OnRtnCancelAccountByBank += spi.OnRtnCancelAccountByBank;
            OnRtnOpenAccountByBank += spi.OnRtnOpenAccountByBank;
            OnRspQueryBankAccountMoneyByFuture += spi.OnRspQueryBankAccountMoneyByFuture;
            OnRspFromFutureToBankByFuture += spi.OnRspFromFutureToBankByFuture;
            OnRspFromBankToFutureByFuture += spi.OnRspFromBankToFutureByFuture;
            OnRtnRepealFromFutureToBankByFuture += spi.OnRtnRepealFromFutureToBankByFuture;
            OnRtnRepealFromBankToFutureByFuture += spi.OnRtnRepealFromBankToFutureByFuture;
            OnErrRtnQueryBankBalanceByFuture += spi.OnErrRtnQueryBankBalanceByFuture;
            OnErrRtnRepealFutureToBankByFutureManual += spi.OnErrRtnRepealFutureToBankByFutureManual;
            OnErrRtnRepealBankToFutureByFutureManual += spi.OnErrRtnRepealBankToFutureByFutureManual;
            OnErrRtnFutureToBankByFuture += spi.OnErrRtnFutureToBankByFuture;
            OnErrRtnBankToFutureByFuture += spi.OnErrRtnBankToFutureByFuture;
            OnRtnQueryBankBalanceByFuture += spi.OnRtnQueryBankBalanceByFuture;
            OnRtnRepealFromFutureToBankByFutureManual += spi.OnRtnRepealFromFutureToBankByFutureManual;
            OnRtnRepealFromBankToFutureByFutureManual += spi.OnRtnRepealFromBankToFutureByFutureManual;
            OnRtnOrder += spi.OnRtnOrder;
            OnRspError += spi.OnRspError;
            OnRspQryAccountregister += spi.OnRspQryAccountregister;
            OnRspQryTransferSerial += spi.OnRspQryTransferSerial;
            OnRspRemoveParkedOrderAction += spi.OnRspRemoveParkedOrderAction;
            OnRspRemoveParkedOrder += spi.OnRspRemoveParkedOrder;
            OnRspSettlementInfoConfirm += spi.OnRspSettlementInfoConfirm;
            OnRspQueryMaxOrderVolume += spi.OnRspQueryMaxOrderVolume;
            OnRspOrderAction += spi.OnRspOrderAction;
            OnRspParkedOrderAction += spi.OnRspParkedOrderAction;
            OnRspQryOrder += spi.OnRspQryOrder;
            OnRspParkedOrderInsert += spi.OnRspParkedOrderInsert;
            OnRspTradingAccountPasswordUpdate += spi.OnRspTradingAccountPasswordUpdate;
            OnRspUserPasswordUpdate += spi.OnRspUserPasswordUpdate;
            OnRspAuthenticate += spi.OnRspAuthenticate;
            OnRspUserLogout += spi.OnRspUserLogout;
            OnRspUserLogin += spi.OnRspUserLogin;
            OnHeartBeatWarning += spi.OnHeartBeatWarning;
            OnRspOrderInsert += spi.OnRspOrderInsert;
            OnRspQryTrade += spi.OnRspQryTrade;
            OnRspQryInvestorPosition += spi.OnRspQryInvestorPosition;
            OnRspQryTradingAccount += spi.OnRspQryTradingAccount;
            OnRspQryEWarrantOffset += spi.OnRspQryEWarrantOffset;
            OnRspQryCFMMCTradingAccountKey += spi.OnRspQryCFMMCTradingAccountKey;
            OnRspQryInvestorPositionCombineDetail += spi.OnRspQryInvestorPositionCombineDetail;
            OnRspQrySettlementInfoConfirm += spi.OnRspQrySettlementInfoConfirm;
            OnRspQryNotice += spi.OnRspQryNotice;
            OnRspQryInvestorPositionDetail += spi.OnRspQryInvestorPositionDetail;
            OnRspQryTransferBank += spi.OnRspQryTransferBank;
            OnRspQrySettlementInfo += spi.OnRspQrySettlementInfo;
            OnRspQryDepthMarketData += spi.OnRspQryDepthMarketData;
            OnRspQryInstrument += spi.OnRspQryInstrument;
            OnRspQryExchange += spi.OnRspQryExchange;
            OnRspQryInstrumentCommissionRate += spi.OnRspQryInstrumentCommissionRate;
            OnRspQryInstrumentMarginRate += spi.OnRspQryInstrumentMarginRate;
            OnRspQryTradingCode += spi.OnRspQryTradingCode;
            OnRspQryInvestor += spi.OnRspQryInvestor;
            OnRtnChangeAccountByBank += spi.OnRtnChangeAccountByBank;
            OnFrontDisConnected += spi.OnFrontDisconnected;
            OnFrontConnected += spi.OnFrontConnected;
        }

		///// <summary>
		///// 前置地址
		///// </summary>
		//public string FrontAddr { get; set; }

		///// <summary>
		///// 经纪公司代码ctp-2030;上期-4030;
		///// </summary>
		//public string BrokerID { get; set; }

		///// <summary>
		///// 投资者代码
		///// </summary>
		//public string InvestorID { get; set; }

		/// <summary>
		/// 前置编号
		/// </summary>
		public int FrontID { get; set; }

		/// <summary>
		/// 会话编号
		/// </summary>
		public int SessionID { get; set; }

		/// <summary>
		/// 最大报单引用
		/// </summary>
		public int MaxOrderRef { get; set; }

		//private string passWord;
        private string FlowPath;

        ///// <summary>
        ///// 登录
        ///// </summary>
        //      public void Connect() { connect(this.FrontAddr, this.FlowPath); }
        //      [DllImport(dllName, EntryPoint = "Connect", CallingConvention = CallingConvention.Cdecl)]
        //      static extern void connect(string FrontAddr, string FlowPath);


        #region 测试:穿透模式添加用户认证(石李平 2019-06-04)
        [DllImport(dataCollectDllName, EntryPoint = "CTP_GetSystemInfo", CallingConvention = CallingConvention.Cdecl)]
        static extern int CTP_GetSystemInfo(string pSystemInfo, int nLen);

        /// <summary>
        /// 请求用户认证
        /// </summary>
        /// <returns></returns>
        public int ReqAuthenticate(CThostFtdcReqAuthenticateField reqField, int requestID)
        { return reqAuthenticate(api,ref reqField,requestID); }
        [DllImport(dllName, EntryPoint = "ReqAuthenticate", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqAuthenticate(IntPtr api,ref CThostFtdcReqAuthenticateField reqField,int requestID);
        #endregion

        /// <summary>
        /// 断开
        /// </summary>
        public void Release() { release(api); }
		[DllImport(dllName, EntryPoint = "Release", CallingConvention = CallingConvention.Cdecl)]
		static extern void release(IntPtr api);

        [DllImport(dllName, EntryPoint = "CreateApi", CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr CreateFtdcTraderApi(string flowPath);
        /// <summary>
        /// 获取交易日
        /// </summary>
        /// <returns></returns>
        public string GetTradingDay()
		{ return Marshal.PtrToStringAnsi(getTradingDay(api));}
		[DllImport(dllName, EntryPoint = "GetTradingDay", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr getTradingDay(IntPtr api);

        /// <summary>
        /// 开始连接
        /// </summary>
        public void Init() { init(api); }
        [DllImport(dllName, EntryPoint = "Init", CallingConvention = CallingConvention.Cdecl)]
        static extern void init(IntPtr api);

        /// <summary>
        /// 注册前置
        /// </summary>
        /// <param name="addr"></param>
        public void RegisterFront(string addr) { registerFront(api,addr); }
        [DllImport(dllName, EntryPoint = "RegisterFront", CallingConvention = CallingConvention.Cdecl)]
        static extern void registerFront(IntPtr api, string addr);
        ///// <summary>
        ///// 获取RequestID
        ///// </summary>
        ///// <returns></returns>
        //public int GetRequestID()
        //{ return getRequestID(); }
        //[DllImport(dllName, EntryPoint = "GetRequestID", CallingConvention = CallingConvention.Cdecl)]
        //static extern int getRequestID();

        /// <summary>
        /// 登入请求
        /// </summary>
        public int ReqUserLogin(CThostFtdcReqUserLoginField reqField,int requestID) { return reqUserLogin(api,ref reqField,requestID); }
		[DllImport(dllName, EntryPoint = "ReqUserLogin", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqUserLogin(IntPtr api, ref CThostFtdcReqUserLoginField reqField,int requestID);

		/// <summary>
		/// 发送登出请求
		/// </summary>
		public int ReqUserLogout(CThostFtdcUserLogoutField reqField,int requestID) { return reqUserLogout(api,ref  reqField, requestID); }
		[DllImport(dllName, EntryPoint = "ReqUserLogout", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqUserLogout(IntPtr api, ref CThostFtdcUserLogoutField reqField, int requestID);

        /// <summary>
        /// 更新用户口令
        /// </summary>
        /// <param name="pUserPasswordUpdate"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqUserPasswordupdate(CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID)
		{ return reqUserPasswordUpdate(api,ref pUserPasswordUpdate, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqUserPasswordUpdate", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqUserPasswordUpdate(IntPtr api, ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID);

        /// <summary>
        /// 资金账户口令更新请求
        /// </summary>
        /// <param name="pTradingAccountPasswordUpdate"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID)
		{ return reqTradingAccountPasswordUpdate(api,ref pTradingAccountPasswordUpdate, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqTradingAccountPasswordUpdate", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqTradingAccountPasswordUpdate(IntPtr api, ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID);

        ///// <summary>
        ///// 下单:录入报单
        ///// </summary>
        ///// <param name="order">输入的报单</param>
        //public int OrderInsert(IntPtr api,ref CThostFtdcInputOrderField order) { return reqOrderInsert(ref order); }

        /// <summary>
        /// 开平仓:限价单
        /// </summary>
        /// <param name="reqField"></param>
        /// <param name="requestID"></param>
        /// <returns></returns>
        public int ReqOrderInsert(CThostFtdcInputOrderField reqField,int requestID)
		{
            //CThostFtdcInputOrderField tmp = new CThostFtdcInputOrderField();
            //tmp.BrokerID = this.BrokerID;
            //tmp.BusinessUnit = null;
            //tmp.ContingentCondition = TThostFtdcContingentConditionType.Immediately;
            //tmp.ForceCloseReason = TThostFtdcForceCloseReasonType.NotForceClose;
            //tmp.InvestorID = this.InvestorID;
            //tmp.IsAutoSuspend = (int)TThostFtdcBoolType.No;
            //tmp.MinVolume = 1;
            //tmp.OrderPriceType = TThostFtdcOrderPriceTypeType.LimitPrice;
            //tmp.OrderRef = (++this.MaxOrderRef).ToString();
            //tmp.TimeCondition = TThostFtdcTimeConditionType.GFD;	//当日有效
            //tmp.UserForceClose = (int)TThostFtdcBoolType.No;
            //tmp.UserID = this.InvestorID;
            //tmp.VolumeCondition = TThostFtdcVolumeConditionType.AV;
            //tmp.CombHedgeFlag_0 = TThostFtdcHedgeFlagType.Speculation;

            //tmp.InstrumentID = InstrumentID;
            //tmp.CombOffsetFlag_0 = OffsetFlag;
            //tmp.Direction = Direction;
            //tmp.LimitPrice = Price;
            //tmp.VolumeTotalOriginal = Volume;
            return reqOrderInsert(api,ref reqField,requestID);
        }
		///// <summary>
		///// 开平仓:市价单
		///// </summary>
		///// <param name="InstrumentID"></param>
		///// <param name="OffsetFlag">平仓:仅上期所平今时使用CloseToday/其它情况均使用Close</param>
		///// <param name="Direction"></param>
		///// <param name="Volume"></param>
  //      public int OrderInsert(string InstrumentID, TThostFtdcOffsetFlagType OffsetFlag, TThostFtdcDirectionType Direction, int Volume)
		//{
		//	CThostFtdcInputOrderField tmp = new CThostFtdcInputOrderField();
		//	tmp.BrokerID = this.BrokerID;
		//	tmp.BusinessUnit = null;
		//	tmp.ContingentCondition = TThostFtdcContingentConditionType.Immediately;
		//	tmp.ForceCloseReason = TThostFtdcForceCloseReasonType.NotForceClose;
		//	tmp.InvestorID = this.InvestorID;
		//	tmp.IsAutoSuspend = (int)TThostFtdcBoolType.No;
		//	tmp.MinVolume = 1;
		//	tmp.OrderPriceType = TThostFtdcOrderPriceTypeType.AnyPrice;
		//	tmp.OrderRef = (++this.MaxOrderRef).ToString();
		//	tmp.TimeCondition = TThostFtdcTimeConditionType.IOC;	//立即完成,否则撤单
		//	tmp.UserForceClose = (int)TThostFtdcBoolType.No;
		//	tmp.UserID = this.InvestorID;
		//	tmp.VolumeCondition = TThostFtdcVolumeConditionType.AV;
		//	tmp.CombHedgeFlag_0 = TThostFtdcHedgeFlagType.Speculation;

		//	tmp.InstrumentID = InstrumentID;
		//	tmp.CombOffsetFlag_0 = OffsetFlag;
		//	tmp.Direction = Direction;
		//	tmp.LimitPrice = 0;
		//	tmp.VolumeTotalOriginal = Volume;
		//	return reqOrderInsert(ref tmp);
		//}
		///// <summary>
		///// 开平仓:触发单
		///// </summary>
		///// <param name="InstrumentID"></param>
		///// <param name="ConditionType">触发单类型</param>
		///// <param name="ConditionPrice">触发价格</param>
		///// <param name="OffsetFlag">平仓:仅上期所平今时使用CloseToday/其它情况均使用Close</param>
		///// <param name="Direction"></param>
		///// <param name="PriceType">下单类型</param>
		///// <param name="Price">下单价格:仅当下单类型为LimitPrice时有效</param>
		///// <param name="Volume"></param>
		//public int OrderInsert(string InstrumentID, TThostFtdcContingentConditionType ConditionType
		//	, double ConditionPrice, TThostFtdcOffsetFlagType OffsetFlag, TThostFtdcDirectionType Direction, TThostFtdcOrderPriceTypeType PriceType, double Price, int Volume)
		//{
		//	CThostFtdcInputOrderField tmp = new CThostFtdcInputOrderField();
		//	tmp.BrokerID = this.BrokerID;
		//	tmp.BusinessUnit = null;
		//	tmp.ForceCloseReason = TThostFtdcForceCloseReasonType.NotForceClose;
		//	tmp.InvestorID = this.InvestorID;
		//	tmp.IsAutoSuspend = (int)TThostFtdcBoolType.No;
		//	tmp.MinVolume = 1;
		//	tmp.OrderRef = (++this.MaxOrderRef).ToString();
		//	tmp.TimeCondition = TThostFtdcTimeConditionType.GFD;
		//	tmp.UserForceClose = (int)TThostFtdcBoolType.No;
		//	tmp.UserID = this.InvestorID;
		//	tmp.VolumeCondition = TThostFtdcVolumeConditionType.AV;
		//	tmp.CombHedgeFlag_0 = TThostFtdcHedgeFlagType.Speculation;

		//	tmp.InstrumentID = InstrumentID;
		//	tmp.CombOffsetFlag_0 = OffsetFlag;
		//	tmp.Direction = Direction;
		//	tmp.ContingentCondition = ConditionType;	//触发类型
		//	tmp.StopPrice = Price;						//触发价格
		//	tmp.OrderPriceType = PriceType;				//下单类型
		//	tmp.LimitPrice = Price;						//下单价格:Price = LimitPrice 时有效
		//	tmp.VolumeTotalOriginal = Volume;
		//	return reqOrderInsert(ref tmp);
		//}
		[DllImport(dllName, EntryPoint = "ReqOrderInsert", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqOrderInsert(IntPtr api, ref CThostFtdcInputOrderField req,int requestID);

        /// <summary>
        /// 撤单
        /// </summary>
        /// <param name="reqField"></param>
        /// <param name="requestID"></param>
        /// <returns></returns>
        public int ReqOrderAction(CThostFtdcInputOrderActionField reqField,int requestID)
        {
            return reqOrderAction(api,ref reqField,requestID);
        }
		///// <summary>
		///// 撤单
		///// </summary>
		///// <param name="InstrumentID"></param>
		///// <param name="FrontID"></param>
		///// <param name="SessionID"></param>
		///// <param name="OrderRef"></param>
		///// <param name="ExchangeID"></param>
		///// <param name="OrderSysID"></param>
		//public int OrderAction(string InstrumentID, int FrontID = 0, int SessionID = 0, string OrderRef = "0", string ExchangeID = null, string OrderSysID = null)
		//{
		//	CThostFtdcInputOrderActionField tmp = new CThostFtdcInputOrderActionField();
		//	tmp.ActionFlag = TThostFtdcActionFlagType.Delete;
		//	tmp.BrokerID = this.BrokerID;
		//	tmp.InvestorID = this.InvestorID;
		//	//tmp.UserID = this.InvestorID;
		//	tmp.InstrumentID = InstrumentID;
		//	//tmp.VolumeChange = int.Parse(lvi.SubItems["VolumeTotalOriginal"].Text);
		//	if (FrontID != 0)
		//		tmp.FrontID = FrontID;
		//	if (SessionID != 0)
		//		tmp.SessionID = SessionID;
		//	if (OrderRef != "0")
		//		tmp.OrderRef = OrderRef;
		//	tmp.ExchangeID = ExchangeID;
		//	if (OrderSysID != null)
		//		tmp.OrderSysID = new string('\0', 21 - OrderSysID.Length) + OrderSysID;	//OrderSysID右对齐
		//	return reqOrderAction(ref tmp);
		//}
        /// <summary>
        /// 请求撤单
        /// </summary>
        /// <param name="pOrder"></param>
        /// <param name="requestID"></param>
        /// <returns></returns>
		[DllImport(dllName, EntryPoint = "ReqOrderAction", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqOrderAction(IntPtr api, ref CThostFtdcInputOrderActionField pOrder,int requestID);

        /// <summary>
        /// 查询最大允许报单数量请求
        /// </summary>
        /// <param name="pMaxOrderVolume"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int QueryMaxOrderVolume(IntPtr api,ref CThostFtdcQueryMaxOrderVolumeField pMaxOrderVolume, int nRequestID)
		{ return reqQueryMaxOrderVolume(api, ref pMaxOrderVolume, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQueryMaxOrderVolume", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQueryMaxOrderVolume(IntPtr api, ref CThostFtdcQueryMaxOrderVolumeField pMaxOrderVolume, int nRequestID);

		/// <summary>
		/// 确认结算结果
		/// </summary>
		/// <s></s>
		public int ReqSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField reqField,int requestID) { return reqSettlementInfoConfirm(api, ref reqField,requestID); }
		[DllImport(dllName, EntryPoint = "ReqSettlementInfoConfirm", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqSettlementInfoConfirm(IntPtr api, ref CThostFtdcSettlementInfoConfirmField reqField, int requestID);

        /// <summary>
        /// 请求查询报单:不填-查所有
        /// </summary>
        /// <param name="qryField"></param>
        /// <param name="requestID"></param>
        /// <returns></returns>
        public int QryOrder(CThostFtdcQryOrderField qryField,int requestID)
		{
			//CThostFtdcQryOrderField tmp = new CThostFtdcQryOrderField();
			//tmp.BrokerID = this.BrokerID;
			//tmp.InvestorID = this.InvestorID;
			//tmp.ExchangeID = _exchangeID;
			//tmp.InsertTimeStart = _timeStart;
			//tmp.InsertTimeEnd = _timeEnd;
			//tmp.InstrumentID = _instrumentID;
			//tmp.OrderSysID = _orderSysID;
			return reqQryOrder(api, ref qryField,requestID);
		}
		[DllImport(dllName, EntryPoint = "ReqQryOrder", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryOrder(IntPtr api,ref CThostFtdcQryOrderField pQryOrder,int requestID);

        /// <summary>
        /// 请求查询成交:不填-查所有
        /// </summary>
        /// <param name="qryField"></param>
        /// <param name="requestID"></param>
        /// <returns></returns>
        public int QryTrade(CThostFtdcQryTradeField qryField, int requestID)
		{
			//CThostFtdcQryTradeField tmp = new CThostFtdcQryTradeField();
			//tmp.BrokerID = this.BrokerID;
			//tmp.InvestorID = this.InvestorID;
			//tmp.ExchangeID = _exchangeID;
			//tmp.TradeTimeStart = _timeStart == null ? null : _timeStart.Value.ToString("HH:mm:ss");
			//tmp.TradeTimeEnd = _timeEnd == null ? null : _timeEnd.Value.ToString("HH:mm:ss");
			//tmp.InstrumentID = _instrumentID;
			//tmp.TradeID = _tradeID;
			return reqQryTrade(api, ref qryField, requestID);
		}
        ///// <summary>
        /////  请求查询成交:不填-查所有
        ///// </summary>
        ///// <param name="_exchangeID"></param>
        ///// <param name="_timeStart"></param>
        ///// <param name="_timeEnd"></param>
        ///// <param name="_instrumentID"></param>
        ///// <param name="_tradeID"></param>
        //public int QryTrade(string _timeStart = null, string _timeEnd = null
        //    , string _instrumentID = null, string _exchangeID = null, string _tradeID = null)
        //{
        //    CThostFtdcQryTradeField tmp = new CThostFtdcQryTradeField();
        //    tmp.BrokerID = this.BrokerID;
        //    tmp.InvestorID = this.InvestorID;
        //    tmp.ExchangeID = _exchangeID;
        //    tmp.TradeTimeStart = _timeStart;
        //    tmp.TradeTimeEnd = _timeEnd ;
        //    tmp.InstrumentID = _instrumentID;
        //    tmp.TradeID = _tradeID;
        //    return reqQryTrade(ref tmp);
        //}
		[DllImport(dllName, EntryPoint = "ReqQryTrade", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryTrade(IntPtr api,ref CThostFtdcQryTradeField pQryTrade,int requestID);

        /// <summary>
        /// 查询投资者持仓
        /// </summary>
        /// <param name="pQryInvestorPosition"></param>
        /// <param name="requestID"></param>
        /// <returns></returns>
        public int ReqQryInvestorPosition(CThostFtdcQryInvestorPositionField pQryInvestorPosition,int requestID)
		{ return reqQryInvestorPosition(api, ref pQryInvestorPosition,requestID); }
		[DllImport(dllName, EntryPoint = "ReqQryInvestorPosition", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryInvestorPosition(IntPtr api,ref CThostFtdcQryInvestorPositionField pQryInvestorPosition, int requestID);

		/// <summary>
		/// 查询帐户资金请求
		/// </summary>
		public int ReqQryTradingAccount(CThostFtdcQryTradingAccountField qryField,int requestID) { return reqQryTradingAccount(api, ref qryField,requestID); }
		[DllImport(dllName, EntryPoint = "ReqQryTradingAccount", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryTradingAccount(IntPtr api,ref CThostFtdcQryTradingAccountField qryField, int requestID);

		/// <summary>
		/// 请求查询投资者
		/// </summary>
		public int QryInvestor(CThostFtdcQryInvestorField pQryInvestor, int nRequestID) { return reqQryInvestor(api, ref pQryInvestor,nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryInvestor", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryInvestor(IntPtr api,ref CThostFtdcQryInvestorField pQryInvestor, int nRequestID);

        /// <summary>
        /// 请求查询交易编码:参数不填-查所有
        /// </summary>
        /// <param name="pQryTradingCode"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int QryTradingCode(CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID)
		{ return reqQryTradingCode(api, ref pQryTradingCode, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryTradingCode", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryTradingCode(IntPtr api,ref CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID);

        /// <summary>
        /// 请求查询合约保证金率:能为null;每次只能查一个合约
        /// </summary>
        /// <param name="pQryInstrumentMarginRate"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int QryInstrumentMarginRate(CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID)
		{ 
			return reqQryInstrumentMarginRate(api, ref pQryInstrumentMarginRate, nRequestID); 
		}
		[DllImport(dllName, EntryPoint = "ReqQryInstrumentMarginRate", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryInstrumentMarginRate(IntPtr api,ref CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID);

        /// <summary>
        /// 请求查询合约手续费率
        /// </summary>
        /// <param name="pQryInstrumentCommissionRate"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int QryInstrumentCommissionRate(CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID)
		{ return reqQryInstrumentCommissionRate(api, ref pQryInstrumentCommissionRate,nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryInstrumentCommissionRate", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryInstrumentCommissionRate(IntPtr api,ref CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID);

        /// <summary>
        /// 请求查询交易所
        /// </summary>
        /// <param name="pQryExchange"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int QryExchange(CThostFtdcQryExchangeField pQryExchange, int nRequestID) { return reqQryExchange(api, ref pQryExchange, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryExchange", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryExchange(IntPtr api,ref CThostFtdcQryExchangeField pQryExchange, int nRequestID);

        /// <summary>
        /// 查询合约
        /// </summary>
        /// <param name="pQryInstrument"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQryInstrument(CThostFtdcQryInstrumentField pQryInstrument, int nRequestID) { return reqQryInstrument(api, ref pQryInstrument, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryInstrument", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryInstrument(IntPtr api,ref CThostFtdcQryInstrumentField pQryInstrument, int nRequestID);

        /// <summary>
        /// 查询行情
        /// </summary>
        /// <param name="pQryDepthMarketData"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int QryDepthMarketData(CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID) { return reqQryDepthMarketData(api, ref pQryDepthMarketData, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryDepthMarketData", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryDepthMarketData(IntPtr api,ref CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID);

		/// <summary>
		/// 请求查询投资者结算结果
		/// </summary>
		public int QrySettlementInfo(CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID)
		{ return reqQrySettlementInfo(api, ref pQrySettlementInfo,nRequestID); }// tradingDay.ToString("yyyyMMdd")); }
		[DllImport(dllName, EntryPoint = "ReqQrySettlementInfo", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQrySettlementInfo(IntPtr api,ref CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID);

        /// <summary>
        /// 查询投资者持仓明细
        /// </summary>
        /// <param name="pQryInvestorPositionDetail"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int QryInvestorPositionDetail(CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID)
		{ return reqQryInvestorPositionDetail(api, ref pQryInvestorPositionDetail, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryInvestorPositionDetail", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryInvestorPositionDetail(IntPtr api,ref CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID);

		/// <summary>
		/// 请求查询客户通知
		/// </summary>
		public int QryNotice(CThostFtdcQryNoticeField pQryNotice, int nRequestID) { return reqQryNotice(api, ref pQryNotice, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryNotice", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryNotice(IntPtr api,ref CThostFtdcQryNoticeField pQryNotice, int nRequestID);

		/// <summary>
		/// 请求查询结算信息确认
		/// </summary>
		public int ReqQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField reqField, int nRequestID)
		{ return reqQrySettlementInfoConfirm(api, ref reqField, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQrySettlementInfoConfirm", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQrySettlementInfoConfirm(IntPtr api,ref CThostFtdcSettlementInfoConfirmField reqField, int nRequestID);

        /// <summary>
        /// 请求查询**组合**持仓明细
        /// </summary>
        /// <param name="pQryInvestorPositionCombineDetail"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQryInvestorPositionCombineDetail(CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID)
		{ return reqQryInvestorPositionCombineDetail(api, ref pQryInvestorPositionCombineDetail, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryInvestorPositionCombineDetail", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryInvestorPositionCombineDetail(IntPtr api,ref CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID);

		/// <summary>
		/// 请求查询保证金监管系统经纪公司资金账户密钥
		/// </summary>
		public int QryCFMMCTradingAccountKey(CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID)
		{ return reqQryCFMMCTradingAccountKey(api, ref pQryCFMMCTradingAccountKey, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryCFMMCTradingAccountKey", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryCFMMCTradingAccountKey(IntPtr api,ref CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID);

		/// <summary>
		/// 请求查询交易通知
		/// </summary>
		public int QryTradingNotice(CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID)
		{ return reqQryTradingNotice(api, ref pQryTradingNotice, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryTradingNotice", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryTradingNotice(IntPtr api,ref CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID);

		/// <summary>
		/// 请求查询经纪公司交易参数
		/// </summary>
		public int QryBrokerTradingParams(CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID)
		{ return reqQryBrokerTradingParams(api, ref pQryBrokerTradingParams, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryBrokerTradingParams", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryBrokerTradingParams(IntPtr api,ref CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID);

        /// <summary>
        /// 请求查询经纪公司交易算法
        /// </summary>
        /// <param name="pQryBrokerTradingAlgos"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int QryBrokerTradingAlgos(CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID)
		{ return reqQryBrokerTradingAlgos(api, ref pQryBrokerTradingAlgos, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryBrokerTradingAlgos", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryBrokerTradingAlgos(IntPtr api,ref CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID);

		/// <summary>
		/// 预埋单录入请求
		/// </summary>
		/// <param name="field"></param>
		public int ParkedOrderInsert(IntPtr api,ref CThostFtdcParkedOrderField field,int requestID)
		{ return reqParkedOrderInsert(api, ref field,requestID); }
		///// <summary>
		///// 预埋单录入请求
		///// </summary>
		///// <param name="InstrumentID"></param>
		///// <param name="OffsetFlag"></param>
		///// <param name="Direction"></param>
		///// <param name="Price"></param>
		///// <param name="Volume"></param>
		//public int ParkedOrderInsert(string InstrumentID, TThostFtdcOffsetFlagType OffsetFlag, TThostFtdcDirectionType Direction, double Price, int Volume)
		//{
		//	CThostFtdcParkedOrderField tmp = new CThostFtdcParkedOrderField();
		//	tmp.BrokerID = this.BrokerID;
		//	tmp.BusinessUnit = null;
		//	tmp.ContingentCondition = TThostFtdcContingentConditionType.ParkedOrder;
		//	tmp.ForceCloseReason = TThostFtdcForceCloseReasonType.NotForceClose;
		//	tmp.InvestorID = this.InvestorID;
		//	tmp.IsAutoSuspend = (int)TThostFtdcBoolType.No;
		//	tmp.MinVolume = 1;
		//	tmp.OrderPriceType = TThostFtdcOrderPriceTypeType.LimitPrice;
		//	tmp.OrderRef = (++this.MaxOrderRef).ToString();
		//	tmp.TimeCondition = TThostFtdcTimeConditionType.GFD;
		//	tmp.UserForceClose = (int)TThostFtdcBoolType.No;
		//	tmp.UserID = this.InvestorID;
		//	tmp.VolumeCondition = TThostFtdcVolumeConditionType.AV;
		//	tmp.CombHedgeFlag_0 = TThostFtdcHedgeFlagType.Speculation;

		//	tmp.InstrumentID = InstrumentID;
		//	tmp.CombOffsetFlag_0 = OffsetFlag;
		//	tmp.Direction = Direction;
		//	tmp.LimitPrice = Price;
		//	tmp.VolumeTotalOriginal = Volume;
		//	return reqParkedOrderInsert(ref tmp);
		//}

        [DllImport(dllName, EntryPoint = "ReqParkedOrderInsert", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqParkedOrderInsert(IntPtr api,ref CThostFtdcParkedOrderField pField,int requestID);

        /// <summary>
        /// 预埋撤单录入请求
        /// </summary>
        /// <param name="field"></param>
        /// <param name="requestID"></param>
        /// <returns></returns>
        public int ReqParkedOrderAction(IntPtr api,ref CThostFtdcParkedOrderActionField field,int requestID)
		{ return reqParkedOrderAction(api, ref field,requestID); }
  //      /// <summary>
  //      /// 预埋撤单录入请求
  //      /// </summary>
  //      /// <param name="InstrumentID"></param>
  //      /// <param name="FrontID"></param>
  //      /// <param name="SessionID"></param>
  //      /// <param name="OrderRef"></param>
  //      /// <param name="ExchangeID"></param>
  //      /// <param name="OrderSysID"></param>
  //      /// <returns></returns>
		//public int ReqParkedOrderAction(string InstrumentID, int FrontID, int SessionID, string OrderRef, string ExchangeID = null, string OrderSysID = null)
		//{
		//	CThostFtdcParkedOrderActionField tmp = new CThostFtdcParkedOrderActionField();
		//	tmp.ActionFlag = TThostFtdcActionFlagType.Delete;
		//	tmp.BrokerID = this.BrokerID;
		//	tmp.InvestorID = this.InvestorID;
		//	//tmp.UserID = this.InvestorID;
		//	tmp.InstrumentID = InstrumentID;
		//	//tmp.VolumeChange = int.Parse(lvi.SubItems["VolumeTotalOriginal"].Text);

		//	tmp.FrontID = FrontID;
		//	tmp.SessionID = SessionID;
		//	tmp.OrderRef = OrderRef;
		//	tmp.ExchangeID = ExchangeID;
		//	if (OrderSysID != null)
		//		tmp.OrderSysID = new string('\0', 21 - OrderSysID.Length) + OrderSysID;	//OrderSysID右对齐
		//	return reqParkedOrderAction(ref tmp);
		//}
		[DllImport(dllName, EntryPoint = "ReqParkedOrderAction", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqParkedOrderAction(IntPtr api,ref CThostFtdcParkedOrderActionField pField,int requestID);

        /// <summary>
        /// 请求删除预埋单
        /// </summary>
        /// <param name="pRemoveParkedOrder"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqRemoveParkedOrder(CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID)
		{ return reqRemoveParkedOrder(api, ref pRemoveParkedOrder, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqRemoveParkedOrder", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqRemoveParkedOrder(IntPtr api,ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID);

        /// <summary>
        /// 请求删除预埋撤单
        /// </summary>
        /// <param name="pRemoveParkedOrderAction"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID)
		{ return reqRemoveParkedOrderAction(api, ref pRemoveParkedOrderAction, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqRemoveParkedOrderAction", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqRemoveParkedOrderAction(IntPtr api,ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID);

        /// <summary>
        /// 请求查询转帐银行
        /// </summary>
        /// <param name="pQryTransferBank"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQryTransferBank(CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID)
		{ return reqQryTransferBank(api, ref pQryTransferBank, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryTransferBank", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryTransferBank(IntPtr api,ref CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID);

        /// <summary>
        /// 请求查询转帐流水
        /// </summary>
        /// <param name="pQryTransferSerial"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQryTransferSerial(CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID)
		{ return reqQryTransferSerial(api, ref pQryTransferSerial, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryTransferSerial", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryTransferSerial(IntPtr api,ref CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID);


        /// <summary>
        /// 请求查询银期签约关系
        /// </summary>
        /// <param name="pQryAccountregister"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQryAccountregister(CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID)
        { return reqQryAccountregister(api, ref pQryAccountregister, nRequestID); }
        [DllImport(dllName, EntryPoint = "ReqQryAccountregister", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqQryAccountregister(IntPtr api,ref CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID);

        /// <summary>
        /// 请求查询签约银行
        /// </summary>
        /// <param name="reqField"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQryContractBank(CThostFtdcQryContractBankField reqField,int nRequestID)
		{ return reqQryContractBank(api, ref reqField, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryContractBank", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryContractBank(IntPtr api,ref CThostFtdcQryContractBankField reqField, int nRequestID);

        /// <summary>
        /// 请求查询预埋单
        /// </summary>
        /// <param name="reqField"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQryParkedOrder(CThostFtdcQryParkedOrderField reqField, int nRequestID)
		{ return reqQryParkedOrder(api, ref reqField,  nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryParkedOrder", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryParkedOrder(IntPtr api,ref CThostFtdcQryParkedOrderField reqField, int nRequestID);

        /// <summary>
        /// 请求查询预埋撤单
        /// </summary>
        /// <param name="reqField"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQryParkedOrderAction(CThostFtdcQryParkedOrderActionField reqField,int nRequestID)
		{ return reqQryParkedOrderAction(api, ref reqField,nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQryParkedOrderAction", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQryParkedOrderAction(IntPtr api,ref CThostFtdcQryParkedOrderActionField reqField, int nRequestID);

        /// <summary>
        /// 期货发起银行资金转期货请求
        /// </summary>
        /// <param name="field"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqFromBankToFutureByFuture(IntPtr api,ref CThostFtdcReqTransferField field,int nRequestID)
		{ return reqFromBankToFutureByFuture(api, ref field,nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqFromBankToFutureByFuture", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqFromBankToFutureByFuture(IntPtr api,ref CThostFtdcReqTransferField pField,int nRequestID);

        /// <summary>
        /// 期货发起期货资金转银行请求
        /// </summary>
        /// <param name="field"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqFromFutureToBankByFuture(IntPtr api,ref CThostFtdcReqTransferField field, int nRequestID)
        { return reqFromFutureToBankByFuture(api, ref field, nRequestID); }
        [DllImport(dllName, EntryPoint = "ReqFromFutureToBankByFuture", CallingConvention = CallingConvention.Cdecl)]
        static extern int reqFromFutureToBankByFuture(IntPtr api,ref CThostFtdcReqTransferField pField, int nRequestID);

        /// <summary>
        /// 期货发起查询银行余额请求
        /// </summary>
        /// <param name="field"></param>
        /// <param name="nRequestID"></param>
        /// <returns></returns>
        public int ReqQueryBankAccountMoneyByFuture(IntPtr api,ref CThostFtdcReqQueryAccountField field, int nRequestID)
		{ return reqQueryBankAccountMoneyByFuture(api, ref field, nRequestID); }
		[DllImport(dllName, EntryPoint = "ReqQueryBankAccountMoneyByFuture", CallingConvention = CallingConvention.Cdecl)]
		static extern int reqQueryBankAccountMoneyByFuture(IntPtr api,ref CThostFtdcReqQueryAccountField pField, int nRequestID);


        [DllImport(dllName, EntryPoint = "RegOnFrontConnected", CallingConvention = CallingConvention.StdCall)]
		static extern void regOnFrontConnected(IntPtr api, FrontConnect fc);
		FrontConnect frontConnect;
		/// <summary>
		/// 
		/// </summary>
		public delegate void FrontConnect();
		/// <summary>
		/// 当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
		/// </summary>
		public event FrontConnect OnFrontConnected
        {
			add { frontConnect += value; regOnFrontConnected(api,frontConnect); }
			remove { frontConnect -= value; regOnFrontConnected(api,frontConnect); }
		}

		[DllImport(dllName, EntryPoint = "RegOnFrontDisconnected", CallingConvention = CallingConvention.StdCall)]
		static extern void regOnDisConnected(IntPtr api, DisConnected dc);
		DisConnected disConnected;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="reason"></param>
		public delegate void DisConnected(int reason);
		/// <summary>
		/// 当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
		/// </summary>
		public event DisConnected OnFrontDisConnected
		{
			add { disConnected += value; regOnDisConnected(api,disConnected); }
			remove { disConnected -= value; regOnDisConnected(api,disConnected); }
		}

		[DllImport(dllName, EntryPoint = "RegOnHeartBeatWarning", CallingConvention = CallingConvention.StdCall)]
		static extern void regOnHeartBeatWarning(IntPtr api, HeartBeatWarning hbw);
		HeartBeatWarning heartBeatWarning;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pTimeLapes"></param>
		public delegate void HeartBeatWarning(int pTimeLapes);
		/// <summary>
		/// 心跳超时警告。当长时间未收到报文时，该方法被调用。
		/// </summary>
		public event HeartBeatWarning OnHeartBeatWarning
		{
			add { heartBeatWarning += value; regOnHeartBeatWarning(api,heartBeatWarning); }
			remove { heartBeatWarning -= value; regOnHeartBeatWarning(api,heartBeatWarning); }
		}

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释

        ///期货发起银行资金转期货错误回报
        [DllImport(dllName, EntryPoint = "RegErrRtnBankToFutureByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regErrRtnBankToFutureByFuture(IntPtr api, ErrRtnBankToFutureByFuture cb);
		ErrRtnBankToFutureByFuture errRtnBankToFutureByFuture;
        public delegate void ErrRtnBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo);
                              /// <summary>
                              /// 期货发起银行资金转期货错误回报
                              /// </summary>
        public event ErrRtnBankToFutureByFuture OnErrRtnBankToFutureByFuture
		{
			add { errRtnBankToFutureByFuture += value; regErrRtnBankToFutureByFuture(api,errRtnBankToFutureByFuture); }
			remove { errRtnBankToFutureByFuture -= value; regErrRtnBankToFutureByFuture(api,errRtnBankToFutureByFuture); }
		}

		///期货发起期货资金转银行错误回报
		[DllImport(dllName, EntryPoint = "RegErrRtnFutureToBankByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regErrRtnFutureToBankByFuture(IntPtr api, ErrRtnFutureToBankByFuture cb);
		ErrRtnFutureToBankByFuture errRtnFutureToBankByFuture;
		public delegate void ErrRtnFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo);
		/// <summary>
		/// 期货发起期货资金转银行错误回报
		/// </summary>
		public event ErrRtnFutureToBankByFuture OnErrRtnFutureToBankByFuture
		{
			add { errRtnFutureToBankByFuture += value; regErrRtnFutureToBankByFuture(api,errRtnFutureToBankByFuture); }
			remove { errRtnFutureToBankByFuture -= value; regErrRtnFutureToBankByFuture(api,errRtnFutureToBankByFuture); }
		}

		///报单操作错误回报
		[DllImport(dllName, EntryPoint = "RegErrRtnOrderAction", CallingConvention = CallingConvention.StdCall)]
		static extern void regErrRtnOrderAction(IntPtr api, ErrRtnOrderAction cb);
		ErrRtnOrderAction errRtnOrderAction;
		public delegate void ErrRtnOrderAction(ref CThostFtdcOrderActionField pOrderAction, ref CThostFtdcRspInfoField pRspInfo);
		/// <summary>
		/// 报单操作错误回报
		/// </summary>
		public event ErrRtnOrderAction OnErrRtnOrderAction
		{
			add { errRtnOrderAction += value; regErrRtnOrderAction(api,errRtnOrderAction); }
			remove { errRtnOrderAction -= value; regErrRtnOrderAction(api,errRtnOrderAction); }
		}

		///报单录入错误回报
		[DllImport(dllName, EntryPoint = "RegErrRtnOrderInsert", CallingConvention = CallingConvention.StdCall)]
		static extern void regErrRtnOrderInsert(IntPtr api, ErrRtnOrderInsert cb);
		ErrRtnOrderInsert errRtnOrderInsert;
		public delegate void ErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo);
		/// <summary>
		/// 报单录入错误回报
		/// </summary>
		public event ErrRtnOrderInsert OnErrRtnOrderInsert
		{
			add { errRtnOrderInsert += value; regErrRtnOrderInsert(api,errRtnOrderInsert); }
			remove { errRtnOrderInsert -= value; regErrRtnOrderInsert(api,errRtnOrderInsert); }
		}

		///期货发起查询银行余额错误回报
		[DllImport(dllName, EntryPoint = "RegErrRtnQueryBankBalanceByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regErrRtnQueryBankBalanceByFuture(IntPtr api, ErrRtnQueryBankBalanceByFuture cb);
		ErrRtnQueryBankBalanceByFuture errRtnQueryBankBalanceByFuture;
		public delegate void ErrRtnQueryBankBalanceByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount, ref CThostFtdcRspInfoField pRspInfo);
		/// <summary>
		/// 期货发起查询银行余额错误回报
		/// </summary>
		public event ErrRtnQueryBankBalanceByFuture OnErrRtnQueryBankBalanceByFuture
		{
			add { errRtnQueryBankBalanceByFuture += value; regErrRtnQueryBankBalanceByFuture(api, errRtnQueryBankBalanceByFuture); }
			remove { errRtnQueryBankBalanceByFuture -= value; regErrRtnQueryBankBalanceByFuture(api, errRtnQueryBankBalanceByFuture); }
		}

		///系统运行时期货端手工发起冲正银行转期货错误回报
		[DllImport(dllName, EntryPoint = "RegErrRtnRepealBankToFutureByFutureManual", CallingConvention = CallingConvention.StdCall)]
		static extern void regErrRtnRepealBankToFutureByFutureManual(IntPtr api, ErrRtnRepealBankToFutureByFutureManual cb);
		ErrRtnRepealBankToFutureByFutureManual errRtnRepealBankToFutureByFutureManual;
		public delegate void ErrRtnRepealBankToFutureByFutureManual(ref CThostFtdcReqRepealField pReqRepeal, ref CThostFtdcRspInfoField pRspInfo);
		/// <summary>
		/// 系统运行时期货端手工发起冲正银行转期货错误回报
		/// </summary>
		public event ErrRtnRepealBankToFutureByFutureManual OnErrRtnRepealBankToFutureByFutureManual
		{
			add { errRtnRepealBankToFutureByFutureManual += value; regErrRtnRepealBankToFutureByFutureManual(api, errRtnRepealBankToFutureByFutureManual); }
			remove { errRtnRepealBankToFutureByFutureManual -= value; regErrRtnRepealBankToFutureByFutureManual(api, errRtnRepealBankToFutureByFutureManual); }
		}

		///系统运行时期货端手工发起冲正期货转银行错误回报
		[DllImport(dllName, EntryPoint = "RegErrRtnRepealFutureToBankByFutureManual", CallingConvention = CallingConvention.StdCall)]
		static extern void regErrRtnRepealFutureToBankByFutureManual(IntPtr api, ErrRtnRepealFutureToBankByFutureManual cb);
		ErrRtnRepealFutureToBankByFutureManual errRtnRepealFutureToBankByFutureManual;
		public delegate void ErrRtnRepealFutureToBankByFutureManual(ref CThostFtdcReqRepealField pReqRepeal, ref CThostFtdcRspInfoField pRspInfo);
		/// <summary>
		/// 系统运行时期货端手工发起冲正期货转银行错误回报
		/// </summary>
		public event ErrRtnRepealFutureToBankByFutureManual OnErrRtnRepealFutureToBankByFutureManual
		{
			add { errRtnRepealFutureToBankByFutureManual += value; regErrRtnRepealFutureToBankByFutureManual( api, errRtnRepealFutureToBankByFutureManual); }
			remove { errRtnRepealFutureToBankByFutureManual -= value; regErrRtnRepealFutureToBankByFutureManual( api, errRtnRepealFutureToBankByFutureManual); }
		}

		///错误应答
		[DllImport(dllName, EntryPoint = "RegRspError", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspError(IntPtr api, RspError cb);
		RspError rspError;
		public delegate void RspError(ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 错误应答
		/// </summary>
		public event RspError OnRspError
		{
			add { rspError += value; regRspError( api, rspError); }
			remove { rspError -= value; regRspError( api, rspError); }
		}

		///期货发起银行资金转期货应答
		[DllImport(dllName, EntryPoint = "RegRspFromBankToFutureByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspFromBankToFutureByFuture(IntPtr api, RspFromBankToFutureByFuture cb);
		RspFromBankToFutureByFuture rspFromBankToFutureByFuture;
		public delegate void RspFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 期货发起银行资金转期货应答
		/// </summary>
		public event RspFromBankToFutureByFuture OnRspFromBankToFutureByFuture
		{
			add { rspFromBankToFutureByFuture += value; regRspFromBankToFutureByFuture( api, rspFromBankToFutureByFuture); }
			remove { rspFromBankToFutureByFuture -= value; regRspFromBankToFutureByFuture( api, rspFromBankToFutureByFuture); }
		}

		///期货发起期货资金转银行应答
		[DllImport(dllName, EntryPoint = "RegRspFromFutureToBankByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspFromFutureToBankByFuture(IntPtr api, RspFromFutureToBankByFuture cb);
		RspFromFutureToBankByFuture rspFromFutureToBankByFuture;
		public delegate void RspFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 期货发起期货资金转银行应答
		/// </summary>
		public event RspFromFutureToBankByFuture OnRspFromFutureToBankByFuture
		{
			add { rspFromFutureToBankByFuture += value; regRspFromFutureToBankByFuture( api, rspFromFutureToBankByFuture); }
			remove { rspFromFutureToBankByFuture -= value; regRspFromFutureToBankByFuture( api, rspFromFutureToBankByFuture); }
		}

		///报单操作请求响应
		[DllImport(dllName, EntryPoint = "RegRspOrderAction", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspOrderAction(IntPtr api, RspOrderAction cb);
		RspOrderAction rspOrderAction;
		public delegate void RspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 报单操作请求响应
		/// </summary>
		public event RspOrderAction OnRspOrderAction
		{
			add { rspOrderAction += value; regRspOrderAction(api, rspOrderAction); }
			remove { rspOrderAction -= value; regRspOrderAction(api, rspOrderAction); }
		}

		///报单录入请求响应
		[DllImport(dllName, EntryPoint = "RegRspOrderInsert", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspOrderInsert(IntPtr api, RspOrderInsert cb);
		RspOrderInsert rspOrderInsert;
		public delegate void RspOrderInsert(ref CThostFtdcInputOrderField pInputOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 报单录入请求响应
		/// </summary>
		public event RspOrderInsert OnRspOrderInsert
		{
			add { rspOrderInsert += value; regRspOrderInsert(api, rspOrderInsert); }
			remove { rspOrderInsert -= value; regRspOrderInsert(api, rspOrderInsert); }
		}

		///预埋撤单录入请求响应
		[DllImport(dllName, EntryPoint = "RegRspParkedOrderAction", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspParkedOrderAction(IntPtr api, RspParkedOrderAction cb);
		RspParkedOrderAction rspParkedOrderAction;
		public delegate void RspParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 预埋撤单录入请求响应
		/// </summary>
		public event RspParkedOrderAction OnRspParkedOrderAction
		{
			add { rspParkedOrderAction += value; regRspParkedOrderAction(api, rspParkedOrderAction); }
			remove { rspParkedOrderAction -= value; regRspParkedOrderAction(api, rspParkedOrderAction); }
		}

		///预埋单录入请求响应
		[DllImport(dllName, EntryPoint = "RegRspParkedOrderInsert", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspParkedOrderInsert(IntPtr api, RspParkedOrderInsert cb);
		RspParkedOrderInsert rspParkedOrderInsert;
		public delegate void RspParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 预埋单录入请求响应
		/// </summary>
		public event RspParkedOrderInsert OnRspParkedOrderInsert
		{
			add { rspParkedOrderInsert += value; regRspParkedOrderInsert(api, rspParkedOrderInsert); }
			remove { rspParkedOrderInsert -= value; regRspParkedOrderInsert(api, rspParkedOrderInsert); }
		}

		///请求查询经纪公司交易算法响应
		[DllImport(dllName, EntryPoint = "RegRspQryBrokerTradingAlgos", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryBrokerTradingAlgos(IntPtr api, RspQryBrokerTradingAlgos cb);
		RspQryBrokerTradingAlgos rspQryBrokerTradingAlgos;
		public delegate void RspQryBrokerTradingAlgos(ref CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询经纪公司交易算法响应
		/// </summary>
		public event RspQryBrokerTradingAlgos OnRspQryBrokerTradingAlgos
		{
			add { rspQryBrokerTradingAlgos += value; regRspQryBrokerTradingAlgos(api, rspQryBrokerTradingAlgos); }
			remove { rspQryBrokerTradingAlgos -= value; regRspQryBrokerTradingAlgos(api, rspQryBrokerTradingAlgos); }
		}

		///请求查询经纪公司交易参数响应
		[DllImport(dllName, EntryPoint = "RegRspQryBrokerTradingParams", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryBrokerTradingParams(IntPtr api, RspQryBrokerTradingParams cb);
		RspQryBrokerTradingParams rspQryBrokerTradingParams;
		public delegate void RspQryBrokerTradingParams(ref CThostFtdcBrokerTradingParamsField pBrokerTradingParams, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询经纪公司交易参数响应
		/// </summary>
		public event RspQryBrokerTradingParams OnRspQryBrokerTradingParams
		{
			add { rspQryBrokerTradingParams += value; regRspQryBrokerTradingParams(api, rspQryBrokerTradingParams); }
			remove { rspQryBrokerTradingParams -= value; regRspQryBrokerTradingParams(api, rspQryBrokerTradingParams); }
		}

		///查询保证金监管系统经纪公司资金账户密钥响应
		[DllImport(dllName, EntryPoint = "RegRspQryCFMMCTradingAccountKey", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryCFMMCTradingAccountKey(IntPtr api, RspQryCFMMCTradingAccountKey cb);
		RspQryCFMMCTradingAccountKey rspQryCFMMCTradingAccountKey;
		public delegate void RspQryCFMMCTradingAccountKey(ref CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 查询保证金监管系统经纪公司资金账户密钥响应
		/// </summary>
		public event RspQryCFMMCTradingAccountKey OnRspQryCFMMCTradingAccountKey
		{
			add { rspQryCFMMCTradingAccountKey += value; regRspQryCFMMCTradingAccountKey(api, rspQryCFMMCTradingAccountKey); }
			remove { rspQryCFMMCTradingAccountKey -= value; regRspQryCFMMCTradingAccountKey(api, rspQryCFMMCTradingAccountKey); }
		}

		///请求查询签约银行响应
		[DllImport(dllName, EntryPoint = "RegRspQryContractBank", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryContractBank(IntPtr api, RspQryContractBank cb);
		RspQryContractBank rspQryContractBank;
		public delegate void RspQryContractBank(ref CThostFtdcContractBankField pContractBank, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询签约银行响应
		/// </summary>
		public event RspQryContractBank OnRspQryContractBank
		{
			add { rspQryContractBank += value; regRspQryContractBank(api, rspQryContractBank); }
			remove { rspQryContractBank -= value; regRspQryContractBank(api, rspQryContractBank); }
		}

		///请求查询行情响应
		[DllImport(dllName, EntryPoint = "RegRspQryDepthMarketData", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryDepthMarketData(IntPtr api, RspQryDepthMarketData cb);
		RspQryDepthMarketData rspQryDepthMarketData;
		public delegate void RspQryDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询行情响应
		/// </summary>
		public event RspQryDepthMarketData OnRspQryDepthMarketData
		{
			add { rspQryDepthMarketData += value; regRspQryDepthMarketData( api, rspQryDepthMarketData); }
			remove { rspQryDepthMarketData -= value; regRspQryDepthMarketData( api, rspQryDepthMarketData); }
		}

		///请求查询交易所响应
		[DllImport(dllName, EntryPoint = "RegRspQryExchange", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryExchange(IntPtr api, RspQryExchange cb);
		RspQryExchange rspQryExchange;
		public delegate void RspQryExchange(ref CThostFtdcExchangeField pExchange, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询交易所响应
		/// </summary>
		public event RspQryExchange OnRspQryExchange
		{
			add { rspQryExchange += value; regRspQryExchange(api, rspQryExchange); }
			remove { rspQryExchange -= value; regRspQryExchange(api, rspQryExchange); }
		}

		///请求查询合约响应
		[DllImport(dllName, EntryPoint = "RegRspQryInstrument", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryInstrument(IntPtr api, RspQryInstrument cb);
		RspQryInstrument rspQryInstrument;
		public delegate void RspQryInstrument(ref CThostFtdcInstrumentField pInstrument, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询合约响应
		/// </summary>
		public event RspQryInstrument OnRspQryInstrument
		{
			add { rspQryInstrument += value; regRspQryInstrument(api, rspQryInstrument); }
			remove { rspQryInstrument -= value; regRspQryInstrument(api, rspQryInstrument); }
		}

		///请求查询合约手续费率响应
		[DllImport(dllName, EntryPoint = "RegRspQryInstrumentCommissionRate", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryInstrumentCommissionRate(IntPtr api, RspQryInstrumentCommissionRate cb);
		RspQryInstrumentCommissionRate rspQryInstrumentCommissionRate;
		public delegate void RspQryInstrumentCommissionRate(ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询合约手续费率响应
		/// </summary>
		public event RspQryInstrumentCommissionRate OnRspQryInstrumentCommissionRate
		{
			add { rspQryInstrumentCommissionRate += value; regRspQryInstrumentCommissionRate(api, rspQryInstrumentCommissionRate); }
			remove { rspQryInstrumentCommissionRate -= value; regRspQryInstrumentCommissionRate(api, rspQryInstrumentCommissionRate); }
		}

		///请求查询合约保证金率响应
		[DllImport(dllName, EntryPoint = "RegRspQryInstrumentMarginRate", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryInstrumentMarginRate(IntPtr api, RspQryInstrumentMarginRate cb);
		RspQryInstrumentMarginRate rspQryInstrumentMarginRate;
		public delegate void RspQryInstrumentMarginRate(ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询合约保证金率响应
		/// </summary>
		public event RspQryInstrumentMarginRate OnRspQryInstrumentMarginRate
		{
			add { rspQryInstrumentMarginRate += value; regRspQryInstrumentMarginRate(api, rspQryInstrumentMarginRate); }
			remove { rspQryInstrumentMarginRate -= value; regRspQryInstrumentMarginRate(api, rspQryInstrumentMarginRate); }
		}

		///请求查询投资者响应
		[DllImport(dllName, EntryPoint = "RegRspQryInvestor", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryInvestor(IntPtr api, RspQryInvestor cb);
		RspQryInvestor rspQryInvestor;
		public delegate void RspQryInvestor(ref CThostFtdcInvestorField pInvestor, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询投资者响应
		/// </summary>
		public event RspQryInvestor OnRspQryInvestor
		{
			add { rspQryInvestor += value; regRspQryInvestor(api, rspQryInvestor); }
			remove { rspQryInvestor -= value; regRspQryInvestor(api, rspQryInvestor); }
		}

		///请求查询投资者持仓响应
		[DllImport(dllName, EntryPoint = "RegRspQryInvestorPosition", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryInvestorPosition(IntPtr api, RspQryInvestorPosition cb);
		RspQryInvestorPosition rspQryInvestorPosition;
		public delegate void RspQryInvestorPosition(ref CThostFtdcInvestorPositionField pInvestorPosition, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询投资者持仓响应
		/// </summary>
		public event RspQryInvestorPosition OnRspQryInvestorPosition
		{
			add { rspQryInvestorPosition += value; regRspQryInvestorPosition(api, rspQryInvestorPosition); }
			remove { rspQryInvestorPosition -= value; regRspQryInvestorPosition(api, rspQryInvestorPosition); }
		}

		///请求查询投资者持仓明细响应
		[DllImport(dllName, EntryPoint = "RegRspQryInvestorPositionCombineDetail", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryInvestorPositionCombineDetail(IntPtr api, RspQryInvestorPositionCombineDetail cb);
		RspQryInvestorPositionCombineDetail rspQryInvestorPositionCombineDetail;
		public delegate void RspQryInvestorPositionCombineDetail(ref CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询投资者持仓明细响应
		/// </summary>
		public event RspQryInvestorPositionCombineDetail OnRspQryInvestorPositionCombineDetail
		{
			add { rspQryInvestorPositionCombineDetail += value; regRspQryInvestorPositionCombineDetail(api, rspQryInvestorPositionCombineDetail); }
			remove { rspQryInvestorPositionCombineDetail -= value; regRspQryInvestorPositionCombineDetail(api, rspQryInvestorPositionCombineDetail); }
		}

		///请求查询投资者持仓明细响应
		[DllImport(dllName, EntryPoint = "RegRspQryInvestorPositionDetail", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryInvestorPositionDetail(IntPtr api, RspQryInvestorPositionDetail cb);
		RspQryInvestorPositionDetail rspQryInvestorPositionDetail;
		public delegate void RspQryInvestorPositionDetail(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询投资者持仓明细响应
		/// </summary>
		public event RspQryInvestorPositionDetail OnRspQryInvestorPositionDetail
		{
			add { rspQryInvestorPositionDetail += value; regRspQryInvestorPositionDetail(api, rspQryInvestorPositionDetail); }
			remove { rspQryInvestorPositionDetail -= value; regRspQryInvestorPositionDetail(api, rspQryInvestorPositionDetail); }
		}

		///请求查询客户通知响应
		[DllImport(dllName, EntryPoint = "RegRspQryNotice", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryNotice(IntPtr api, RspQryNotice cb);
		RspQryNotice rspQryNotice;
		public delegate void RspQryNotice(ref CThostFtdcNoticeField pNotice, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询客户通知响应
		/// </summary>
		public event RspQryNotice OnRspQryNotice
		{
			add { rspQryNotice += value; regRspQryNotice(api, rspQryNotice); }
			remove { rspQryNotice -= value; regRspQryNotice(api, rspQryNotice); }
		}

		///请求查询报单响应
		[DllImport(dllName, EntryPoint = "RegRspQryOrder", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryOrder(IntPtr api, RspQryOrder cb);
		RspQryOrder rspQryOrder;
		public delegate void RspQryOrder(ref CThostFtdcOrderField pOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询报单响应
		/// </summary>
		public event RspQryOrder OnRspQryOrder
		{
			add { rspQryOrder += value; regRspQryOrder(api, rspQryOrder); }
			remove { rspQryOrder -= value; regRspQryOrder(api, rspQryOrder); }
		}

		///请求查询预埋单响应
		[DllImport(dllName, EntryPoint = "RegRspQryParkedOrder", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryParkedOrder(IntPtr api, RspQryParkedOrder cb);
		RspQryParkedOrder rspQryParkedOrder;
		public delegate void RspQryParkedOrder(ref CThostFtdcParkedOrderField pParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询预埋单响应
		/// </summary>
		public event RspQryParkedOrder OnRspQryParkedOrder
		{
			add { rspQryParkedOrder += value; regRspQryParkedOrder( api, rspQryParkedOrder); }
			remove { rspQryParkedOrder -= value; regRspQryParkedOrder( api, rspQryParkedOrder); }
		}

		///请求查询预埋撤单响应
		[DllImport(dllName, EntryPoint = "RegRspQryParkedOrderAction", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryParkedOrderAction(IntPtr api, RspQryParkedOrderAction cb);
		RspQryParkedOrderAction rspQryParkedOrderAction;
		public delegate void RspQryParkedOrderAction( ref CThostFtdcParkedOrderActionField pParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询预埋撤单响应
		/// </summary>
		public event RspQryParkedOrderAction OnRspQryParkedOrderAction
		{
			add { rspQryParkedOrderAction += value; regRspQryParkedOrderAction( api, rspQryParkedOrderAction); }
			remove { rspQryParkedOrderAction -= value; regRspQryParkedOrderAction( api, rspQryParkedOrderAction); }
		}

		///请求查询投资者结算结果响应
		[DllImport(dllName, EntryPoint = "RegRspQrySettlementInfo", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQrySettlementInfo(IntPtr api, RspQrySettlementInfo cb);
		RspQrySettlementInfo rspQrySettlementInfo;
		public delegate void RspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询投资者结算结果响应
		/// </summary>
		public event RspQrySettlementInfo OnRspQrySettlementInfo
		{
			add { rspQrySettlementInfo += value; regRspQrySettlementInfo(api, rspQrySettlementInfo); }
			remove { rspQrySettlementInfo -= value; regRspQrySettlementInfo(api, rspQrySettlementInfo); }
		}

		///请求查询结算信息确认响应
		[DllImport(dllName, EntryPoint = "RegRspQrySettlementInfoConfirm", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQrySettlementInfoConfirm(IntPtr api, RspQrySettlementInfoConfirm cb);
		RspQrySettlementInfoConfirm rspQrySettlementInfoConfirm;
		public delegate void RspQrySettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询结算信息确认响应
		/// </summary>
		public event RspQrySettlementInfoConfirm OnRspQrySettlementInfoConfirm
		{
			add { rspQrySettlementInfoConfirm += value; regRspQrySettlementInfoConfirm(api, rspQrySettlementInfoConfirm); }
			remove { rspQrySettlementInfoConfirm -= value; regRspQrySettlementInfoConfirm(api, rspQrySettlementInfoConfirm); }
		}

		///请求查询成交响应
		[DllImport(dllName, EntryPoint = "RegRspQryTrade", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryTrade(IntPtr api, RspQryTrade cb);
		RspQryTrade rspQryTrade;
		public delegate void RspQryTrade(ref CThostFtdcTradeField pTrade, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询成交响应
		/// </summary>
		public event RspQryTrade OnRspQryTrade
		{
			add { rspQryTrade += value; regRspQryTrade(api, rspQryTrade); }
			remove { rspQryTrade -= value; regRspQryTrade(api, rspQryTrade); }
		}

		///请求查询资金账户响应
		[DllImport(dllName, EntryPoint = "RegRspQryTradingAccount", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryTradingAccount(IntPtr api, RspQryTradingAccount cb);
		RspQryTradingAccount rspQryTradingAccount;
		public delegate void RspQryTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询资金账户响应
		/// </summary>
		public event RspQryTradingAccount OnRspQryTradingAccount
		{
			add { rspQryTradingAccount += value; regRspQryTradingAccount(api, rspQryTradingAccount); }
			remove { rspQryTradingAccount -= value; regRspQryTradingAccount(api, rspQryTradingAccount); }
		}


        ///请求查询资金账户响应
        [DllImport(dllName, EntryPoint = "RegRspQryEWarrantOffset", CallingConvention = CallingConvention.StdCall)]
        static extern void regRspQryEWarrantOffset(IntPtr api, RspQryEWarrantOffset cb);
        RspQryEWarrantOffset rspQryEWarrantOffset;
        public delegate void RspQryEWarrantOffset(ref CThostFtdcEWarrantOffsetField pEWarrantOffset, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 请求查询资金账户响应
        /// </summary>
        public event RspQryEWarrantOffset OnRspQryEWarrantOffset
        {
            add { rspQryEWarrantOffset += value; regRspQryEWarrantOffset(api, rspQryEWarrantOffset); }
            remove { rspQryEWarrantOffset -= value; regRspQryEWarrantOffset(api, rspQryEWarrantOffset); }
        }


        ///请求查询交易编码响应
        [DllImport(dllName, EntryPoint = "RegRspQryTradingCode", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryTradingCode(IntPtr api, RspQryTradingCode cb);
		RspQryTradingCode rspQryTradingCode;
		public delegate void RspQryTradingCode(ref CThostFtdcTradingCodeField pTradingCode, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询交易编码响应
		/// </summary>
		public event RspQryTradingCode OnRspQryTradingCode
		{
			add { rspQryTradingCode += value; regRspQryTradingCode(api, rspQryTradingCode); }
			remove { rspQryTradingCode -= value; regRspQryTradingCode(api, rspQryTradingCode); }
		}

		///请求查询交易通知响应
		[DllImport(dllName, EntryPoint = "RegRspQryTradingNotice", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryTradingNotice(IntPtr api, RspQryTradingNotice cb);
		RspQryTradingNotice rspQryTradingNotice;
		public delegate void RspQryTradingNotice(ref CThostFtdcTradingNoticeField pTradingNotice, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询交易通知响应
		/// </summary>
		public event RspQryTradingNotice OnRspQryTradingNotice
		{
			add { rspQryTradingNotice += value; regRspQryTradingNotice(api, rspQryTradingNotice); }
			remove { rspQryTradingNotice -= value; regRspQryTradingNotice(api, rspQryTradingNotice); }
		}

		///请求查询转帐银行响应
		[DllImport(dllName, EntryPoint = "RegRspQryTransferBank", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryTransferBank(IntPtr api, RspQryTransferBank cb);
		RspQryTransferBank rspQryTransferBank;
		public delegate void RspQryTransferBank(ref CThostFtdcTransferBankField pTransferBank, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询转帐银行响应
		/// </summary>
		public event RspQryTransferBank OnRspQryTransferBank
		{
			add { rspQryTransferBank += value; regRspQryTransferBank(api, rspQryTransferBank); }
			remove { rspQryTransferBank -= value; regRspQryTransferBank(api, rspQryTransferBank); }
		}

		///请求查询转帐流水响应
		[DllImport(dllName, EntryPoint = "RegRspQryTransferSerial", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQryTransferSerial(IntPtr api, RspQryTransferSerial cb);
		RspQryTransferSerial rspQryTransferSerial;
		public delegate void RspQryTransferSerial(ref CThostFtdcTransferSerialField pTransferSerial, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 请求查询转帐流水响应
		/// </summary>
		public event RspQryTransferSerial OnRspQryTransferSerial
		{
			add { rspQryTransferSerial += value; regRspQryTransferSerial(api, rspQryTransferSerial); }
			remove { rspQryTransferSerial -= value; regRspQryTransferSerial(api, rspQryTransferSerial); }
		}

        ///请求查询银期签约关系响应
        [DllImport(dllName, EntryPoint = "RegRspQryAccountregister", CallingConvention = CallingConvention.StdCall)]
        static extern void regRspQryAccountregister(IntPtr api, RspQryAccountregister cb);
        RspQryAccountregister rspQryAccountregister;
        public delegate void RspQryAccountregister(ref CThostFtdcAccountregisterField pAccountregister, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 请求查询转帐流水响应
        /// </summary>
        public event RspQryAccountregister OnRspQryAccountregister
        {
            add { rspQryAccountregister += value; regRspQryAccountregister(api, rspQryAccountregister); }
            remove { rspQryAccountregister -= value; regRspQryAccountregister(api, rspQryAccountregister); }
        }


		///期货发起查询银行余额应答
		[DllImport(dllName, EntryPoint = "RegRspQueryBankAccountMoneyByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQueryBankAccountMoneyByFuture(IntPtr api, RspQueryBankAccountMoneyByFuture cb);
		RspQueryBankAccountMoneyByFuture rspQueryBankAccountMoneyByFuture;
		public delegate void RspQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 期货发起查询银行余额应答
		/// </summary>
		public event RspQueryBankAccountMoneyByFuture OnRspQueryBankAccountMoneyByFuture
		{
			add { rspQueryBankAccountMoneyByFuture += value; regRspQueryBankAccountMoneyByFuture(api, rspQueryBankAccountMoneyByFuture); }
			remove { rspQueryBankAccountMoneyByFuture -= value; regRspQueryBankAccountMoneyByFuture(api, rspQueryBankAccountMoneyByFuture); }
		}

		///查询最大报单数量响应
		[DllImport(dllName, EntryPoint = "RegRspQueryMaxOrderVolume", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspQueryMaxOrderVolume(IntPtr api, RspQueryMaxOrderVolume cb);
		RspQueryMaxOrderVolume rspQueryMaxOrderVolume;
		public delegate void RspQueryMaxOrderVolume(ref CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 查询最大报单数量响应
		/// </summary>
		public event RspQueryMaxOrderVolume OnRspQueryMaxOrderVolume
		{
			add { rspQueryMaxOrderVolume += value; regRspQueryMaxOrderVolume(api, rspQueryMaxOrderVolume); }
			remove { rspQueryMaxOrderVolume -= value; regRspQueryMaxOrderVolume(api, rspQueryMaxOrderVolume); }
		}

		///删除预埋单响应
		[DllImport(dllName, EntryPoint = "RegRspRemoveParkedOrder", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspRemoveParkedOrder(IntPtr api, RspRemoveParkedOrder cb);
		RspRemoveParkedOrder rspRemoveParkedOrder;
		public delegate void RspRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 删除预埋单响应
		/// </summary>
		public event RspRemoveParkedOrder OnRspRemoveParkedOrder
		{
			add { rspRemoveParkedOrder += value; regRspRemoveParkedOrder(api, rspRemoveParkedOrder); }
			remove { rspRemoveParkedOrder -= value; regRspRemoveParkedOrder(api, rspRemoveParkedOrder); }
		}

		///删除预埋撤单响应
		[DllImport(dllName, EntryPoint = "RegRspRemoveParkedOrderAction", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspRemoveParkedOrderAction(IntPtr api, RspRemoveParkedOrderAction cb);
		RspRemoveParkedOrderAction rspRemoveParkedOrderAction;
		public delegate void RspRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 删除预埋撤单响应
		/// </summary>
		public event RspRemoveParkedOrderAction OnRspRemoveParkedOrderAction
		{
			add { rspRemoveParkedOrderAction += value; regRspRemoveParkedOrderAction(api, rspRemoveParkedOrderAction); }
			remove { rspRemoveParkedOrderAction -= value; regRspRemoveParkedOrderAction(api, rspRemoveParkedOrderAction); }
		}

		///投资者结算结果确认响应
		[DllImport(dllName, EntryPoint = "RegRspSettlementInfoConfirm", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspSettlementInfoConfirm(IntPtr api, RspSettlementInfoConfirm cb);
		RspSettlementInfoConfirm rspSettlementInfoConfirm;
		public delegate void RspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 投资者结算结果确认响应
		/// </summary>
		public event RspSettlementInfoConfirm OnRspSettlementInfoConfirm
		{
			add { rspSettlementInfoConfirm += value; regRspSettlementInfoConfirm(api, rspSettlementInfoConfirm); }
			remove { rspSettlementInfoConfirm -= value; regRspSettlementInfoConfirm(api, rspSettlementInfoConfirm); }
		}

		///资金账户口令更新请求响应
		[DllImport(dllName, EntryPoint = "RegRspTradingAccountPasswordUpdate", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspTradingAccountPasswordUpdate(IntPtr api, RspTradingAccountPasswordUpdate cb);
		RspTradingAccountPasswordUpdate rspTradingAccountPasswordUpdate;
		public delegate void RspTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 资金账户口令更新请求响应
		/// </summary>
		public event RspTradingAccountPasswordUpdate OnRspTradingAccountPasswordUpdate
		{
			add { rspTradingAccountPasswordUpdate += value; regRspTradingAccountPasswordUpdate(api, rspTradingAccountPasswordUpdate); }
			remove { rspTradingAccountPasswordUpdate -= value; regRspTradingAccountPasswordUpdate(api, rspTradingAccountPasswordUpdate); }
		}

		///登录请求响应
		[DllImport(dllName, EntryPoint = "RegRspUserLogin", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspUserLogin(IntPtr api, RspUserLogin cb);
		RspUserLogin rspUserLogin;
		public delegate void RspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 登录请求响应
		/// </summary>
		public event RspUserLogin OnRspUserLogin
		{
			add { rspUserLogin += value; regRspUserLogin(api, rspUserLogin); }
			remove { rspUserLogin -= value; regRspUserLogin(api, rspUserLogin); }
		}

		///登出请求响应
		[DllImport(dllName, EntryPoint = "RegRspUserLogout", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspUserLogout(IntPtr api, RspUserLogout cb);
		RspUserLogout rspUserLogout;
		public delegate void RspUserLogout(ref CThostFtdcUserLogoutField pUserLogout, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 登出请求响应
		/// </summary>
		public event RspUserLogout OnRspUserLogout
		{
			add { rspUserLogout += value; regRspUserLogout(api, rspUserLogout); }
			remove { rspUserLogout -= value; regRspUserLogout(api, rspUserLogout); }
		}

		///用户口令更新请求响应
		[DllImport(dllName, EntryPoint = "RegRspUserPasswordUpdate", CallingConvention = CallingConvention.StdCall)]
		static extern void regRspUserPasswordUpdate(IntPtr api, RspUserPasswordUpdate cb);
		RspUserPasswordUpdate rspUserPasswordUpdate;
		public delegate void RspUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
		/// <summary>
		/// 用户口令更新请求响应
		/// </summary>
		public event RspUserPasswordUpdate OnRspUserPasswordUpdate
		{
			add { rspUserPasswordUpdate += value; regRspUserPasswordUpdate(api, rspUserPasswordUpdate); }
			remove { rspUserPasswordUpdate -= value; regRspUserPasswordUpdate(api, rspUserPasswordUpdate); }
		}

        ///用户口令更新请求响应
        [DllImport(dllName, EntryPoint = "RegRspAuthenticate", CallingConvention = CallingConvention.StdCall)]
        static extern void regRspAuthenticate(IntPtr api, RspAuthenticate cb);
        RspAuthenticate rspAuthenticate;
        public delegate void RspAuthenticate(ref CThostFtdcRspAuthenticateField pAuthenticate, ref CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        /// <summary>
        /// 用户口令更新请求响应
        /// </summary>
        public event RspAuthenticate OnRspAuthenticate
        {
            add { rspAuthenticate += value; regRspAuthenticate( api, rspAuthenticate); }
            remove { rspAuthenticate -= value; regRspAuthenticate( api, rspAuthenticate); }
        }
        

        ///提示条件单校验错误
        [DllImport(dllName, EntryPoint = "RegRtnErrorConditionalOrder", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnErrorConditionalOrder(IntPtr api, RtnErrorConditionalOrder cb);
		RtnErrorConditionalOrder rtnErrorConditionalOrder;
		public delegate void RtnErrorConditionalOrder(ref CThostFtdcErrorConditionalOrderField pErrorConditionalOrder);
		/// <summary>
		/// 提示条件单校验错误
		/// </summary>
		public event RtnErrorConditionalOrder OnRtnErrorConditionalOrder
		{
			add { rtnErrorConditionalOrder += value; regRtnErrorConditionalOrder( api, rtnErrorConditionalOrder); }
			remove { rtnErrorConditionalOrder -= value; regRtnErrorConditionalOrder( api, rtnErrorConditionalOrder); }
		}

		///银行发起银行资金转期货通知
		[DllImport(dllName, EntryPoint = "RegRtnFromBankToFutureByBank", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnFromBankToFutureByBank(IntPtr api, RtnFromBankToFutureByBank cb);
		RtnFromBankToFutureByBank rtnFromBankToFutureByBank;
		public delegate void RtnFromBankToFutureByBank(ref CThostFtdcRspTransferField pRspTransfer);
		/// <summary>
		/// 银行发起银行资金转期货通知
		/// </summary>
		public event RtnFromBankToFutureByBank OnRtnFromBankToFutureByBank
		{
			add { rtnFromBankToFutureByBank += value; regRtnFromBankToFutureByBank(api, rtnFromBankToFutureByBank); }
			remove { rtnFromBankToFutureByBank -= value; regRtnFromBankToFutureByBank(api, rtnFromBankToFutureByBank); }
		}

		///期货发起银行资金转期货通知
		[DllImport(dllName, EntryPoint = "RegRtnFromBankToFutureByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnFromBankToFutureByFuture(IntPtr api, RtnFromBankToFutureByFuture cb);
		RtnFromBankToFutureByFuture rtnFromBankToFutureByFuture;
		public delegate void RtnFromBankToFutureByFuture( ref CThostFtdcRspTransferField pRspTransfer);
		/// <summary>
		/// 期货发起银行资金转期货通知
		/// </summary>
		public event RtnFromBankToFutureByFuture OnRtnFromBankToFutureByFuture
		{
			add { rtnFromBankToFutureByFuture += value; regRtnFromBankToFutureByFuture(api, rtnFromBankToFutureByFuture); }
			remove { rtnFromBankToFutureByFuture -= value; regRtnFromBankToFutureByFuture(api, rtnFromBankToFutureByFuture); }
		}

		///银行发起期货资金转银行通知
		[DllImport(dllName, EntryPoint = "RegRtnFromFutureToBankByBank", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnFromFutureToBankByBank(IntPtr api, RtnFromFutureToBankByBank cb);
		RtnFromFutureToBankByBank rtnFromFutureToBankByBank;
		public delegate void RtnFromFutureToBankByBank(ref CThostFtdcRspTransferField pRspTransfer);
		/// <summary>
		/// 银行发起期货资金转银行通知
		/// </summary>
		public event RtnFromFutureToBankByBank OnRtnFromFutureToBankByBank
		{
			add { rtnFromFutureToBankByBank += value; regRtnFromFutureToBankByBank(api, rtnFromFutureToBankByBank); }
			remove { rtnFromFutureToBankByBank -= value; regRtnFromFutureToBankByBank(api, rtnFromFutureToBankByBank); }
		}

		///期货发起期货资金转银行通知
		[DllImport(dllName, EntryPoint = "RegRtnFromFutureToBankByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnFromFutureToBankByFuture(IntPtr api, RtnFromFutureToBankByFuture cb);
		RtnFromFutureToBankByFuture rtnFromFutureToBankByFuture;
		public delegate void RtnFromFutureToBankByFuture(ref CThostFtdcRspTransferField pRspTransfer);
		/// <summary>
		/// 期货发起期货资金转银行通知
		/// </summary>
		public event RtnFromFutureToBankByFuture OnRtnFromFutureToBankByFuture
		{
			add { rtnFromFutureToBankByFuture += value; regRtnFromFutureToBankByFuture(api, rtnFromFutureToBankByFuture); }
			remove { rtnFromFutureToBankByFuture -= value; regRtnFromFutureToBankByFuture(api, rtnFromFutureToBankByFuture); }
		}

        [DllImport(dllName, EntryPoint = "RegRtnCancelAccountByBank", CallingConvention = CallingConvention.StdCall)]
        static extern void regRtnCancelAccountByBank(IntPtr api, RtnCancelAccountByBank cb);
        public delegate void RtnCancelAccountByBank(ref CThostFtdcCancelAccountField pCancelAccount);
        RtnCancelAccountByBank rtnCancelAccountByBank;
        public event RtnCancelAccountByBank OnRtnCancelAccountByBank
        {
            add { rtnCancelAccountByBank += value;regRtnCancelAccountByBank(api, rtnCancelAccountByBank); }
            remove { rtnCancelAccountByBank -= value; regRtnCancelAccountByBank(api, rtnCancelAccountByBank); }
        }

        [DllImport(dllName, EntryPoint = "RegRtnChangeAccountByBank", CallingConvention = CallingConvention.StdCall)]
        static extern void regRtnChangeAccountByBank(IntPtr api, RtnChangeAccountByBank cb);
        public delegate void RtnChangeAccountByBank(ref CThostFtdcChangeAccountField pCancelAccount);
        RtnChangeAccountByBank rtnChangeAccountByBank;
        public event RtnChangeAccountByBank OnRtnChangeAccountByBank
        {
            add { rtnChangeAccountByBank += value; regRtnChangeAccountByBank(api, rtnChangeAccountByBank); }
            remove { rtnChangeAccountByBank -= value; regRtnChangeAccountByBank(api, rtnChangeAccountByBank); }
        }


        [DllImport(dllName, EntryPoint = "RegRtnOpenAccountByBank", CallingConvention = CallingConvention.StdCall)]
        static extern void regRtnOpenAccountByBank(IntPtr api,RtnOpenAccountByBank cb);
        public delegate void RtnOpenAccountByBank(ref CThostFtdcOpenAccountField pCancelAccount);
        RtnOpenAccountByBank rtnOpenAccountByBank;
        public event RtnOpenAccountByBank OnRtnOpenAccountByBank
        {
            add { rtnOpenAccountByBank += value; regRtnOpenAccountByBank(api, rtnOpenAccountByBank); }
            remove { rtnOpenAccountByBank -= value; regRtnOpenAccountByBank(api, rtnOpenAccountByBank); }
        }

        

        ///合约交易状态通知
        [DllImport(dllName, EntryPoint = "RegRtnInstrumentStatus", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnInstrumentStatus(IntPtr api, RtnInstrumentStatus cb);
		RtnInstrumentStatus rtnInstrumentStatus;
		public delegate void RtnInstrumentStatus(ref CThostFtdcInstrumentStatusField pInstrumentStatus);
		/// <summary>
		/// 合约交易状态通知
		/// </summary>
		public event RtnInstrumentStatus OnRtnInstrumentStatus
		{
			add { rtnInstrumentStatus += value; regRtnInstrumentStatus(api, rtnInstrumentStatus); }
			remove { rtnInstrumentStatus -= value; regRtnInstrumentStatus(api, rtnInstrumentStatus); }
		}

		///报单通知
		[DllImport(dllName, EntryPoint = "RegRtnOrder", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnOrder(IntPtr api, RtnOrder cb);
		RtnOrder rtnOrder;
		public delegate void RtnOrder(ref CThostFtdcOrderField pOrder);
		/// <summary>
		/// 报单通知
		/// </summary>
		public event RtnOrder OnRtnOrder
		{
			add { rtnOrder += value; regRtnOrder(api, rtnOrder); }
			remove { rtnOrder -= value; regRtnOrder(api, rtnOrder); }
		}

		///期货发起查询银行余额通知
		[DllImport(dllName, EntryPoint = "RegRtnQueryBankBalanceByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnQueryBankBalanceByFuture(IntPtr api, RtnQueryBankBalanceByFuture cb);
		RtnQueryBankBalanceByFuture rtnQueryBankBalanceByFuture;
		public delegate void RtnQueryBankBalanceByFuture(ref CThostFtdcNotifyQueryAccountField pNotifyQueryAccount);
		/// <summary>
		/// 期货发起查询银行余额通知
		/// </summary>
		public event RtnQueryBankBalanceByFuture OnRtnQueryBankBalanceByFuture
		{
			add { rtnQueryBankBalanceByFuture += value; regRtnQueryBankBalanceByFuture(api, rtnQueryBankBalanceByFuture); }
			remove { rtnQueryBankBalanceByFuture -= value; regRtnQueryBankBalanceByFuture(api, rtnQueryBankBalanceByFuture); }
		}

		///银行发起冲正银行转期货通知
		[DllImport(dllName, EntryPoint = "RegRtnRepealFromBankToFutureByBank", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnRepealFromBankToFutureByBank(IntPtr api, RtnRepealFromBankToFutureByBank cb);
		RtnRepealFromBankToFutureByBank rtnRepealFromBankToFutureByBank;
		public delegate void RtnRepealFromBankToFutureByBank(ref CThostFtdcRspRepealField pRspRepeal);
		/// <summary>
		/// 银行发起冲正银行转期货通知
		/// </summary>
		public event RtnRepealFromBankToFutureByBank OnRtnRepealFromBankToFutureByBank
		{
			add { rtnRepealFromBankToFutureByBank += value; regRtnRepealFromBankToFutureByBank(api, rtnRepealFromBankToFutureByBank); }
			remove { rtnRepealFromBankToFutureByBank -= value; regRtnRepealFromBankToFutureByBank(api, rtnRepealFromBankToFutureByBank); }
		}

		///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
		[DllImport(dllName, EntryPoint = "RegRtnRepealFromBankToFutureByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnRepealFromBankToFutureByFuture(IntPtr api, RtnRepealFromBankToFutureByFuture cb);
		RtnRepealFromBankToFutureByFuture rtnRepealFromBankToFutureByFuture;
		public delegate void RtnRepealFromBankToFutureByFuture(ref CThostFtdcRspRepealField pRspRepeal);
		/// <summary>
		/// 期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
		/// </summary>
		public event RtnRepealFromBankToFutureByFuture OnRtnRepealFromBankToFutureByFuture
		{
			add { rtnRepealFromBankToFutureByFuture += value; regRtnRepealFromBankToFutureByFuture(api, rtnRepealFromBankToFutureByFuture); }
			remove { rtnRepealFromBankToFutureByFuture -= value; regRtnRepealFromBankToFutureByFuture(api, rtnRepealFromBankToFutureByFuture); }
		}

		///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
		[DllImport(dllName, EntryPoint = "RegRtnRepealFromBankToFutureByFutureManual", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnRepealFromBankToFutureByFutureManual(IntPtr api, RtnRepealFromBankToFutureByFutureManual cb);
		RtnRepealFromBankToFutureByFutureManual rtnRepealFromBankToFutureByFutureManual;
		public delegate void RtnRepealFromBankToFutureByFutureManual(ref CThostFtdcRspRepealField pRspRepeal);
		/// <summary>
		/// 系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
		/// </summary>
		public event RtnRepealFromBankToFutureByFutureManual OnRtnRepealFromBankToFutureByFutureManual
		{
			add { rtnRepealFromBankToFutureByFutureManual += value; regRtnRepealFromBankToFutureByFutureManual(api, rtnRepealFromBankToFutureByFutureManual); }
			remove { rtnRepealFromBankToFutureByFutureManual -= value; regRtnRepealFromBankToFutureByFutureManual(api, rtnRepealFromBankToFutureByFutureManual); }
		}

		///银行发起冲正期货转银行通知
		[DllImport(dllName, EntryPoint = "RegRtnRepealFromFutureToBankByBank", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnRepealFromFutureToBankByBank(IntPtr api, RtnRepealFromFutureToBankByBank cb);
		RtnRepealFromFutureToBankByBank rtnRepealFromFutureToBankByBank;
		public delegate void RtnRepealFromFutureToBankByBank(ref CThostFtdcRspRepealField pRspRepeal);
		/// <summary>
		/// 银行发起冲正期货转银行通知
		/// </summary>
		public event RtnRepealFromFutureToBankByBank OnRtnRepealFromFutureToBankByBank
		{
			add { rtnRepealFromFutureToBankByBank += value; regRtnRepealFromFutureToBankByBank(api, rtnRepealFromFutureToBankByBank); }
			remove { rtnRepealFromFutureToBankByBank -= value; regRtnRepealFromFutureToBankByBank(api, rtnRepealFromFutureToBankByBank); }
		}

		///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
		[DllImport(dllName, EntryPoint = "RegRtnRepealFromFutureToBankByFuture", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnRepealFromFutureToBankByFuture(IntPtr api, RtnRepealFromFutureToBankByFuture cb);
		RtnRepealFromFutureToBankByFuture rtnRepealFromFutureToBankByFuture;
		public delegate void RtnRepealFromFutureToBankByFuture(ref CThostFtdcRspRepealField pRspRepeal);
		/// <summary>
		/// 期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
		/// </summary>
		public event RtnRepealFromFutureToBankByFuture OnRtnRepealFromFutureToBankByFuture
		{
			add { rtnRepealFromFutureToBankByFuture += value; regRtnRepealFromFutureToBankByFuture(api, rtnRepealFromFutureToBankByFuture); }
			remove { rtnRepealFromFutureToBankByFuture -= value; regRtnRepealFromFutureToBankByFuture(api, rtnRepealFromFutureToBankByFuture); }
		}

		///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
		[DllImport(dllName, EntryPoint = "RegRtnRepealFromFutureToBankByFutureManual", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnRepealFromFutureToBankByFutureManual(IntPtr api, RtnRepealFromFutureToBankByFutureManual cb);
		RtnRepealFromFutureToBankByFutureManual rtnRepealFromFutureToBankByFutureManual;
		public delegate void RtnRepealFromFutureToBankByFutureManual(ref CThostFtdcRspRepealField pRspRepeal);
		/// <summary>
		/// 系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
		/// </summary>
		public event RtnRepealFromFutureToBankByFutureManual OnRtnRepealFromFutureToBankByFutureManual
		{
			add { rtnRepealFromFutureToBankByFutureManual += value; regRtnRepealFromFutureToBankByFutureManual(api, rtnRepealFromFutureToBankByFutureManual); }
			remove { rtnRepealFromFutureToBankByFutureManual -= value; regRtnRepealFromFutureToBankByFutureManual(api, rtnRepealFromFutureToBankByFutureManual); }
		}

		///成交通知
		[DllImport(dllName, EntryPoint = "RegRtnTrade", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnTrade(IntPtr api, RtnTrade cb);
		RtnTrade rtnTrade;
		public delegate void RtnTrade(ref CThostFtdcTradeField pTrade);
		/// <summary>
		/// 成交通知
		/// </summary>
		public event RtnTrade OnRtnTrade
		{
			add { rtnTrade += value; regRtnTrade(api, rtnTrade); }
			remove { rtnTrade -= value; regRtnTrade(api, rtnTrade); }
		}

		///交易通知
		[DllImport(dllName, EntryPoint = "RegRtnTradingNotice", CallingConvention = CallingConvention.StdCall)]
		static extern void regRtnTradingNotice(IntPtr api, RtnTradingNotice cb);
		RtnTradingNotice rtnTradingNotice;
		public delegate void RtnTradingNotice(ref CThostFtdcTradingNoticeInfoField pTradingNoticeInfo);
		/// <summary>
		/// 交易通知
		/// </summary>
		public event RtnTradingNotice OnRtnTradingNotice
		{
			add { rtnTradingNotice += value; regRtnTradingNotice(api, rtnTradingNotice); }
			remove { rtnTradingNotice -= value; regRtnTradingNotice(api, rtnTradingNotice); }
		}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
