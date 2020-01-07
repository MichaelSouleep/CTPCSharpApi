
#include "stdafx.h"
#include "TradeApi.h"
#include "ThostFtdcUserApiDataType.h"
#include "ThostFtdcUserApiStruct.h"

// UserApi对象
//CTradeApi* pUserApi;


//===============

//// 请求编号
////int volatile iRequestID = 0;
////连接
//extern "C" TRADEAPI_API void Connect(char* FRONT_ADDR, char *pszFlowPath)
//{
//	// 初始化UserApi
//	pUserApi = CTradeApi::CreateFtdcTraderApi(pszFlowPath);			// 创建UserApi
//	CTraderSpi* pUserSpi = new CTraderSpi();
//	pUserApi->RegisterSpi((CThostFtdcTraderSpi*)pUserSpi);			// 注册事件类
//	pUserApi->SubscribePublicTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// 注册公有流
//	pUserApi->SubscribePrivateTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// 注册私有流
//	pUserApi->RegisterFront(FRONT_ADDR);							// connect
//	pUserApi->Init();
//	//pUserApi->Join();
//}

CTradeApi::CTradeApi(const char *pszFlowPath):pUserApi(nullptr),pUserSpi(nullptr)
{
	if (pUserApi==NULL)
	{
		pUserApi = CThostFtdcTraderApi::CreateFtdcTraderApi(pszFlowPath);
		pUserSpi = new CTraderSpi;
		pUserApi->RegisterSpi(pUserSpi);
	}
}

CTradeApi::~CTradeApi()
{
	if (pUserApi)
	{
		pUserApi->Release();
	}
	if (pUserSpi)
	{
		delete pUserSpi;
		pUserSpi = nullptr;
	}
}

extern "C" TRADEAPI_API CTradeApi* CreateApi(const char *pszFlowPath = "")
{
	return new CTradeApi(pszFlowPath);
	//return CTradeApi::CreateFtdcTraderApi(pszFlowPath);			// 创建UserApi
}

extern "C" TRADEAPI_API void RegisterFront(CTradeApi* pUserApi, char* FRONT_ADDR)
{

	//CTraderSpi* pUserSpi = new CTraderSpi();
	//api->pUserApi->RegisterSpi((CThostFtdcTraderSpi*)pUserSpi);			// 注册事件类
	pUserApi->pUserApi->SubscribePublicTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// 注册公有流
	pUserApi->pUserApi->SubscribePrivateTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// 注册私有流
	pUserApi->pUserApi->RegisterFront(FRONT_ADDR);							// connect
}

extern "C" TRADEAPI_API void Init(CTradeApi* pUserApi)
{
	pUserApi->pUserApi->Init();
}

extern "C" TRADEAPI_API const char *GetTradingDay(CTradeApi* pUserApi)
{
	return pUserApi->pUserApi->GetTradingDay();
}
//断开
extern "C" TRADEAPI_API void Release(CTradeApi* pUserApi)
{
	delete pUserApi;
	pUserApi = nullptr;
}

//extern "C" TRADEAPI_API int GetRequestID()
//{
//	return iRequestID;
//}

#pragma region 测试:穿透模式添加用户认证(石李平 2019-06-04)
extern "C" TRADEAPI_API int ReqAuthenticate(CTradeApi* pUserApi, CThostFtdcReqAuthenticateField *req, int requestID)
{
	return pUserApi->pUserApi->ReqAuthenticate(req, requestID);
}
#pragma endregion


//发送用户登录请求
extern "C" TRADEAPI_API int ReqUserLogin(CTradeApi* pUserApi, CThostFtdcReqUserLoginField *req, int requestID)
{
	//CThostFtdcReqUserLoginField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.UserID, USER_ID);
	//strcpy_s(req.Password, PASSWORD);
	//strcpy_s(req.UserProductInfo,"EasyTrader");
	return pUserApi->pUserApi->ReqUserLogin(req, requestID);
}
//发送登出请求
extern "C" TRADEAPI_API int ReqUserLogout(CTradeApi* pUserApi, CThostFtdcUserLogoutField *req, int requestID)
{
	//CThostFtdcUserLogoutField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.UserID, INVESTOR_ID);
	return pUserApi->pUserApi->ReqUserLogout(req, requestID);
}
//更新用户口令
extern "C" TRADEAPI_API int ReqUserPasswordUpdate(CTradeApi* pUserApi, CThostFtdcUserPasswordUpdateField *req, int requestID)
{
	//CThostFtdcUserPasswordUpdateField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.UserID, USER_ID);
	//strcpy_s(req.OldPassword,OLD_PASSWORD);
	//strcpy_s(req.NewPassword,NEW_PASSWORD);
	return pUserApi->pUserApi->ReqUserPasswordUpdate(req, requestID);
}
///资金账户口令更新请求
extern "C" TRADEAPI_API int ReqTradingAccountPasswordUpdate(CTradeApi* pUserApi, CThostFtdcTradingAccountPasswordUpdateField *req, int requestID)
{
	//CThostFtdcTradingAccountPasswordUpdateField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.AccountID, ACCOUNT_ID);
	//strcpy_s(req.NewPassword,NEW_PASSWORD);
	//strcpy_s(req.OldPassword,OLD_PASSWORD);
	return pUserApi->pUserApi->ReqTradingAccountPasswordUpdate(req, requestID);
}
//报单录入请求
extern "C" TRADEAPI_API int ReqOrderInsert(CTradeApi* pUserApi, CThostFtdcInputOrderField *pOrder, int requestID)
{
	//int siez = sizeof(CThostFtdcInputOrderField);
	//strcpy_s(pOrder->BusinessUnit,"EasyTrader");
	return pUserApi->pUserApi->ReqOrderInsert(pOrder, requestID);
}
//报单操作请求
extern "C" TRADEAPI_API int ReqOrderAction(CTradeApi* pUserApi, CThostFtdcInputOrderActionField *pOrder, int requestID)
{
	return pUserApi->pUserApi->ReqOrderAction(pOrder, requestID);
}
///查询最大报单数量请求
extern "C" TRADEAPI_API int ReqQueryMaxOrderVolume(CTradeApi* pUserApi, CThostFtdcQueryMaxOrderVolumeField *pMaxOrderVolume, int requestID)
{
	return pUserApi->pUserApi->ReqQueryMaxOrderVolume(pMaxOrderVolume, requestID);
}
//投资者结算结果确认
extern "C" TRADEAPI_API int ReqSettlementInfoConfirm(CTradeApi* pUserApi, CThostFtdcSettlementInfoConfirmField *req, int requestID)
{
	//CThostFtdcSettlementInfoConfirmField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.InvestorID, INVESTOR_ID);
	return pUserApi->pUserApi->ReqSettlementInfoConfirm(req, requestID);
}
///请求查询报单
extern "C" TRADEAPI_API int ReqQryOrder(CTradeApi* pUserApi, CThostFtdcQryOrderField *pQryOrder, int requestID)
{
	return pUserApi->pUserApi->ReqQryOrder(pQryOrder, requestID);
}
///请求查询成交
extern "C" TRADEAPI_API int ReqQryTrade(CTradeApi* pUserApi, CThostFtdcQryTradeField *pQryTrade, int requestID)
{
	return pUserApi->pUserApi->ReqQryTrade(pQryTrade, requestID);
}
//请求查询投资者持仓
extern "C" TRADEAPI_API int ReqQryInvestorPosition(CTradeApi* pUserApi, CThostFtdcQryInvestorPositionField *req, int requestID)
{
	//CThostFtdcQryInvestorPositionField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.InvestorID, INVESTOR_ID);
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->pUserApi->ReqQryInvestorPosition(req, requestID);
}
//请求查询资金账户
extern "C" TRADEAPI_API int ReqQryTradingAccount(CTradeApi* pUserApi, CThostFtdcQryTradingAccountField *req, int requestID)
{
	//CThostFtdcQryTradingAccountField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.InvestorID, INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryTradingAccount(req, requestID);
}
///请求查询投资者
extern "C" TRADEAPI_API int ReqQryInvestor(CTradeApi* pUserApi, CThostFtdcQryInvestorField *req, int requestID)
{
	//CThostFtdcQryInvestorField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID ,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryInvestor(req, requestID);
}
///请求查询交易编码
extern "C" TRADEAPI_API int ReqQryTradingCode(CTradeApi* pUserApi, CThostFtdcQryTradingCodeField *req, int requestID)
{
	//CThostFtdcQryTradingCodeField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID ,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//if(CLIENT_ID != NULL)
	//	strcpy_s(req.ClientID,CLIENT_ID);
	//if(EXCHANGE_ID != NULL)
	//	strcpy_s(req.ExchangeID,EXCHANGE_ID);
	return pUserApi->pUserApi->ReqQryTradingCode(req, requestID);
}
///请求查询合约保证金率
extern "C" TRADEAPI_API int ReqQryInstrumentMarginRate(CTradeApi* pUserApi, CThostFtdcQryInstrumentMarginRateField *req, int requestID)
{
	//CThostFtdcQryInstrumentMarginRateField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID ,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID,INSTRUMENT_ID);
	//if(HEDGE_FLAG != NULL)
	//	req->HedgeFlag = HEDGE_FLAG;						//*不*能采用null进行所有查询
	return pUserApi->pUserApi->ReqQryInstrumentMarginRate(req, requestID);
}
///请求查询合约手续费率
extern "C" TRADEAPI_API int ReqQryInstrumentCommissionRate(CTradeApi* pUserApi, CThostFtdcQryInstrumentCommissionRateField  *req, int requestID)
{
	//CThostFtdcQryInstrumentCommissionRateField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID ,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);	
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID,INSTRUMENT_ID);
	return pUserApi->pUserApi->ReqQryInstrumentCommissionRate(req, requestID);
}
///请求查询交易所
extern "C" TRADEAPI_API int ReqQryExchange(CTradeApi* pUserApi, CThostFtdcQryExchangeField  *req, int requestID)
{
	//CThostFtdcQryExchangeField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.ExchangeID,EXCHANGE_ID);
	return pUserApi->pUserApi->ReqQryExchange(req, requestID);
}
//请求查询合约
extern "C" TRADEAPI_API int ReqQryInstrument(CTradeApi* pUserApi, CThostFtdcQryInstrumentField *req, int requestID)
{
	//CThostFtdcQryInstrumentField req;
	//memset(&req, 0, sizeof(req));
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->pUserApi->ReqQryInstrument(req, requestID);
}
//请求查询行情
extern "C" TRADEAPI_API int ReqQryDepthMarketData(CTradeApi* pUserApi, CThostFtdcQryDepthMarketDataField *req, int requestID)
{
	//CThostFtdcQryDepthMarketDataField req;
	//memset(&req,0,sizeof(req));
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->pUserApi->ReqQryDepthMarketData(req, requestID);
}
///请求查询投资者结算结果
extern "C" TRADEAPI_API int ReqQrySettlementInfo(CTradeApi* pUserApi, CThostFtdcQrySettlementInfoField *req, int requestID)
{
	//CThostFtdcQrySettlementInfoField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID ,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);	
	//if(TRADING_DAY != NULL)
	//	strcpy_s(req.TradingDay, TRADING_DAY);
	return pUserApi->pUserApi->ReqQrySettlementInfo(req, requestID);
}
//查询持仓明细
extern "C" TRADEAPI_API int ReqQryInvestorPositionDetail(CTradeApi* pUserApi, CThostFtdcQryInvestorPositionDetailField *req, int requestID)
{
	//CThostFtdcQryInvestorPositionDetailField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->pUserApi->ReqQryInvestorPositionDetail(req, requestID);
}
///请求查询客户通知
extern "C" TRADEAPI_API int ReqQryNotice(CTradeApi* pUserApi, CThostFtdcQryNoticeField  *req, int requestID)
{
	//CThostFtdcQryNoticeField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKERID);
	return pUserApi->pUserApi->ReqQryNotice(req, requestID);
}
///请求查询结算信息确认
extern "C" TRADEAPI_API int ReqQrySettlementInfoConfirm(CTradeApi* pUserApi, CThostFtdcQrySettlementInfoConfirmField  *req, int requestID)
{
	//CThostFtdcQrySettlementInfoConfirmField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQrySettlementInfoConfirm(req, requestID);
}
///请求查询**组合**持仓明细
extern "C" TRADEAPI_API int ReqQryInvestorPositionCombineDetail(CTradeApi* pUserApi, CThostFtdcQryInvestorPositionCombineDetailField *req, int requestID)
{
	//CThostFtdcQryInvestorPositionCombineDetailField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.CombInstrumentID, INSTRUMENT_ID);
	return pUserApi->pUserApi->ReqQryInvestorPositionCombineDetail(req, requestID);
}
///请求查询保证金监管系统经纪公司资金账户密钥
extern "C" TRADEAPI_API int ReqQryCFMMCTradingAccountKey(CTradeApi* pUserApi, CThostFtdcQryCFMMCTradingAccountKeyField *req, int requestID)
{
	//CThostFtdcQryCFMMCTradingAccountKeyField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryCFMMCTradingAccountKey(req, requestID);
}
///请求查询交易通知
extern "C" TRADEAPI_API int ReqQryTradingNotice(CTradeApi* pUserApi, CThostFtdcQryTradingNoticeField *req, int requestID)
{
	//CThostFtdcQryTradingNoticeField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryTradingNotice(req, requestID);
}
///请求查询经纪公司交易参数
extern "C" TRADEAPI_API int ReqQryBrokerTradingParams(CTradeApi* pUserApi, CThostFtdcQryBrokerTradingParamsField  *req, int requestID)
{
	//CThostFtdcQryBrokerTradingParamsField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryBrokerTradingParams(req, requestID);
}
///请求查询经纪公司交易算法
extern "C" TRADEAPI_API int ReqQryBrokerTradingAlgos(CTradeApi* pUserApi, CThostFtdcQryBrokerTradingAlgosField  *req, int requestID)
{
	//CThostFtdcQryBrokerTradingAlgosField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//if(EXCHANGE_ID != NULL)
	//	strcpy_s(req.ExchangeID, EXCHANGE_ID);
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID, INSTRUMENT_ID);

	return pUserApi->pUserApi->ReqQryBrokerTradingAlgos(req, requestID);
}
///预埋单录入请求
extern "C" TRADEAPI_API int ReqParkedOrderInsert(CTradeApi* pUserApi, CThostFtdcParkedOrderField *ParkedOrder, int requestID)
{
	return pUserApi->pUserApi->ReqParkedOrderInsert(ParkedOrder, requestID);
}
///预埋撤单录入请求
extern "C" TRADEAPI_API int ReqParkedOrderAction(CTradeApi* pUserApi, CThostFtdcParkedOrderActionField *ParkedOrderAction, int requestID)
{
	return pUserApi->pUserApi->ReqParkedOrderAction(ParkedOrderAction, requestID);
}
///请求删除预埋单
extern "C" TRADEAPI_API int ReqRemoveParkedOrder(CTradeApi* pUserApi, CThostFtdcRemoveParkedOrderField  *req, int requestID)
{
	//CThostFtdcRemoveParkedOrderField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//strcpy_s(req.ParkedOrderID,ParkedOrder_ID);
	return pUserApi->pUserApi->ReqRemoveParkedOrder(req, requestID);
}
///请求删除预埋撤单
extern "C" TRADEAPI_API int ReqRemoveParkedOrderAction(CTradeApi* pUserApi, CThostFtdcRemoveParkedOrderActionField  *req, int requestID)//TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcParkedOrderActionIDType ParkedOrderAction_ID)
{
	//CThostFtdcRemoveParkedOrderActionField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//strcpy_s(req.ParkedOrderActionID,ParkedOrderAction_ID);
	return pUserApi->pUserApi->ReqRemoveParkedOrderAction(req, requestID);
}
///请求查询转帐银行
extern "C" TRADEAPI_API int ReqQryTransferBank(CTradeApi* pUserApi, CThostFtdcQryTransferBankField  *req, int requestID)//TThostFtdcBankIDType Bank_ID,	TThostFtdcBankBrchIDType BankBrch_ID)
{
	//CThostFtdcQryTransferBankField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BankID,Bank_ID);
	//strcpy_s(req.BankBrchID,BankBrch_ID);
	return pUserApi->pUserApi->ReqQryTransferBank(req, requestID);
}
///请求查询转帐流水
extern "C" TRADEAPI_API int ReqQryTransferSerial(CTradeApi* pUserApi, CThostFtdcQryTransferSerialField  *req, int requestID)//TThostFtdcBrokerIDType Broker_ID,TThostFtdcAccountIDType Account_ID,TThostFtdcBankIDType Bank_ID)
{
	//CThostFtdcQryTransferSerialField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,Broker_ID);
	//strcpy_s(req.AccountID,Account_ID);
	//strcpy_s(req.BankID,Bank_ID);
	return pUserApi->pUserApi->ReqQryTransferSerial(req, requestID);
}
///请求查询银期签约关系
extern "C" TRADEAPI_API int ReqQryAccountregister(CTradeApi* pUserApi, CThostFtdcQryAccountregisterField  *req, int requestID)//TThostFtdcBrokerIDType Broker_ID, TThostFtdcAccountIDType Account_ID, TThostFtdcBankIDType Bank_ID)
{
	//CThostFtdcQryAccountregisterField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, Broker_ID);
	//strcpy_s(req.AccountID, Account_ID);
	//strcpy_s(req.BankID, Bank_ID);
	return pUserApi->pUserApi->ReqQryAccountregister(req, requestID);
}
///请求查询签约银行
extern "C" TRADEAPI_API int ReqQryContractBank(CTradeApi* pUserApi, CThostFtdcQryContractBankField  *req, int requestID)//TThostFtdcBrokerIDType Broker_ID,TThostFtdcBankIDType Bank_ID,	TThostFtdcBankBrchIDType BankBrch_ID)
{
	//CThostFtdcQryContractBankField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,Broker_ID);
	//if(Bank_ID != NULL)
	//	strcpy_s(req.BankID,Bank_ID);
	//if(BankBrch_ID !=NULL)
	//	strcpy_s(req.BankBrchID,BankBrch_ID);
	return pUserApi->pUserApi->ReqQryContractBank(req, requestID);
}
///请求查询预埋单
extern "C" TRADEAPI_API int ReqQryParkedOrder(CTradeApi* pUserApi, CThostFtdcQryParkedOrderField  *req, int requestID)//TThostFtdcBrokerIDType BrokerID,TThostFtdcInvestorIDType InvestorID,TThostFtdcInstrumentIDType InstrumentID,TThostFtdcExchangeIDType ExchangeID)
{
	//CThostFtdcQryParkedOrderField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BrokerID);
	//strcpy_s(req.InvestorID,InvestorID);
	//if(InstrumentID != NULL)
	//	strcpy_s(req.InstrumentID,InstrumentID);
	//if(ExchangeID != NULL)
	//	strcpy_s(req.ExchangeID,ExchangeID);
	return pUserApi->pUserApi->ReqQryParkedOrder(req, requestID);
}
///请求查询预埋撤单
extern "C" TRADEAPI_API int ReqQryParkedOrderAction(CTradeApi* pUserApi, CThostFtdcQryParkedOrderActionField  *req, int requestID)//TThostFtdcBrokerIDType BrokerID,TThostFtdcInvestorIDType InvestorID,TThostFtdcInstrumentIDType InstrumentID,TThostFtdcExchangeIDType ExchangeID)
{
	//CThostFtdcQryParkedOrderActionField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BrokerID);
	//strcpy_s(req.InvestorID,InvestorID);
	//if(InstrumentID != NULL)
	//	strcpy_s(req.InstrumentID,InstrumentID);
	//if(ExchangeID != NULL)
	//	strcpy_s(req.ExchangeID,ExchangeID);
	return pUserApi->pUserApi->ReqQryParkedOrderAction(req, requestID);
}
///期货发起银行资金转期货请求
extern "C" TRADEAPI_API int ReqFromBankToFutureByFuture(CTradeApi* pUserApi, CThostFtdcReqTransferField *ReqTransfer, int requestID)
{
	return pUserApi->pUserApi->ReqFromBankToFutureByFuture(ReqTransfer, requestID);
}
///期货发起期货资金转银行请求
extern "C" TRADEAPI_API int ReqFromFutureToBankByFuture(CTradeApi* pUserApi, CThostFtdcReqTransferField *ReqTransfer, int requestID)
{
	return pUserApi->pUserApi->ReqFromFutureToBankByFuture(ReqTransfer, requestID);
}
///期货发起查询银行余额请求
extern "C" TRADEAPI_API int ReqQueryBankAccountMoneyByFuture(CTradeApi* pUserApi, CThostFtdcReqQueryAccountField *ReqQueryAccountm, int requestID)
{
	return pUserApi->pUserApi->ReqQueryBankAccountMoneyByFuture(ReqQueryAccountm, requestID);
}
//========================================
///==================================== 回调函数 =======================================
extern "C" TRADEAPI_API void WINAPI RegOnFrontConnected(CTradeApi* pUserApi, CBOnFrontConnected cb)		///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
{
	pUserApi->pUserSpi->cbOnFrontConnected = cb;
}

extern "C" TRADEAPI_API void WINAPI RegOnFrontDisconnected(CTradeApi* pUserApi, CBOnFrontDisconnected cb)		///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
{
	pUserApi->pUserSpi->cbOnFrontDisconnected = cb;
}

extern "C" TRADEAPI_API void WINAPI RegOnHeartBeatWarning(CTradeApi* pUserApi, CBOnHeartBeatWarning cb)		///心跳超时警告。当长时间未收到报文时，该方法被调用。
{
	pUserApi->pUserSpi->cbOnHeartBeatWarning = cb;
}

extern "C" TRADEAPI_API void WINAPI RegRspUserLogin(CTradeApi* pUserApi, CBRspUserLogin cb)	///登录请求响应
{
	pUserApi->pUserSpi->cbRspUserLogin = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspUserLogout(CTradeApi* pUserApi, CBRspUserLogout cb)	///登出请求响应
{
	pUserApi->pUserSpi->cbRspUserLogout = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspUserPasswordUpdate(CTradeApi* pUserApi, CBRspUserPasswordUpdate cb)	///用户口令更新请求响应
{
	pUserApi->pUserSpi->cbRspUserPasswordUpdate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspAuthenticate(CTradeApi* pUserApi, CBRspAuthenticate cb)	///客户端认证请求响应
{
	pUserApi->pUserSpi->cbRspAuthenticate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspTradingAccountPasswordUpdate(CTradeApi* pUserApi, CBRspTradingAccountPasswordUpdate cb)	///资金账户口令更新请求响应
{
	pUserApi->pUserSpi->cbRspTradingAccountPasswordUpdate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspOrderInsert(CTradeApi* pUserApi, CBRspOrderInsert cb)	///报单录入请求响应
{
	pUserApi->pUserSpi->cbRspOrderInsert = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspParkedOrderInsert(CTradeApi* pUserApi, CBRspParkedOrderInsert cb)	///预埋单录入请求响应
{
	pUserApi->pUserSpi->cbRspParkedOrderInsert = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspParkedOrderAction(CTradeApi* pUserApi, CBRspParkedOrderAction cb)	///预埋撤单录入请求响应
{
	pUserApi->pUserSpi->cbRspParkedOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspOrderAction(CTradeApi* pUserApi, CBRspOrderAction cb)	///报单操作请求响应
{
	pUserApi->pUserSpi->cbRspOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQueryMaxOrderVolume(CTradeApi* pUserApi, CBRspQueryMaxOrderVolume cb)	///查询最大报单数量响应
{
	pUserApi->pUserSpi->cbRspQueryMaxOrderVolume = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspSettlementInfoConfirm(CTradeApi* pUserApi, CBRspSettlementInfoConfirm cb)	///投资者结算结果确认响应
{
	pUserApi->pUserSpi->cbRspSettlementInfoConfirm = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspRemoveParkedOrder(CTradeApi* pUserApi, CBRspRemoveParkedOrder cb)	///删除预埋单响应
{
	pUserApi->pUserSpi->cbRspRemoveParkedOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspRemoveParkedOrderAction(CTradeApi* pUserApi, CBRspRemoveParkedOrderAction cb)	///删除预埋撤单响应
{
	pUserApi->pUserSpi->cbRspRemoveParkedOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryOrder(CTradeApi* pUserApi, CBRspQryOrder cb)	///请求查询报单响应
{
	pUserApi->pUserSpi->cbRspQryOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTrade(CTradeApi* pUserApi, CBRspQryTrade cb)	///请求查询成交响应
{
	pUserApi->pUserSpi->cbRspQryTrade = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInvestorPosition(CTradeApi* pUserApi, CBRspQryInvestorPosition cb)	///请求查询投资者持仓响应
{
	pUserApi->pUserSpi->cbRspQryInvestorPosition = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTradingAccount(CTradeApi* pUserApi, CBRspQryTradingAccount cb)	///请求查询资金账户响应
{
	pUserApi->pUserSpi->cbRspQryTradingAccount = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryEWarrantOffset(CTradeApi* pUserApi, CBRspQryEWarrantOffset cb)	///请求查询资金账户响应
{
	pUserApi->pUserSpi->cbRspQryEWarrantOffset = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInvestor(CTradeApi* pUserApi, CBRspQryInvestor cb)	///请求查询投资者响应
{
	pUserApi->pUserSpi->cbRspQryInvestor = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTradingCode(CTradeApi* pUserApi, CBRspQryTradingCode cb)	///请求查询交易编码响应
{
	pUserApi->pUserSpi->cbRspQryTradingCode = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInstrumentMarginRate(CTradeApi* pUserApi, CBRspQryInstrumentMarginRate cb)	///请求查询合约保证金率响应
{
	pUserApi->pUserSpi->cbRspQryInstrumentMarginRate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInstrumentCommissionRate(CTradeApi* pUserApi, CBRspQryInstrumentCommissionRate cb)	///请求查询合约手续费率响应
{
	pUserApi->pUserSpi->cbRspQryInstrumentCommissionRate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryExchange(CTradeApi* pUserApi, CBRspQryExchange cb)	///请求查询交易所响应
{
	pUserApi->pUserSpi->cbRspQryExchange = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInstrument(CTradeApi* pUserApi, CBRspQryInstrument cb)	///请求查询合约响应
{
	pUserApi->pUserSpi->cbRspQryInstrument = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryDepthMarketData(CTradeApi* pUserApi, CBRspQryDepthMarketData cb)	///请求查询行情响应
{
	pUserApi->pUserSpi->cbRspQryDepthMarketData = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQrySettlementInfo(CTradeApi* pUserApi, CBRspQrySettlementInfo cb)	///请求查询投资者结算结果响应
{
	pUserApi->pUserSpi->cbRspQrySettlementInfo = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTransferBank(CTradeApi* pUserApi, CBRspQryTransferBank cb)	///请求查询转帐银行响应
{
	pUserApi->pUserSpi->cbRspQryTransferBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInvestorPositionDetail(CTradeApi* pUserApi, CBRspQryInvestorPositionDetail cb)	///请求查询投资者持仓明细响应
{
	pUserApi->pUserSpi->cbRspQryInvestorPositionDetail = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryNotice(CTradeApi* pUserApi, CBRspQryNotice cb)	///请求查询客户通知响应
{
	pUserApi->pUserSpi->cbRspQryNotice = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQrySettlementInfoConfirm(CTradeApi* pUserApi, CBRspQrySettlementInfoConfirm cb)	///请求查询结算信息确认响应
{
	pUserApi->pUserSpi->cbRspQrySettlementInfoConfirm = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInvestorPositionCombineDetail(CTradeApi* pUserApi, CBRspQryInvestorPositionCombineDetail cb)	///请求查询投资者持仓明细响应
{
	pUserApi->pUserSpi->cbRspQryInvestorPositionCombineDetail = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryCFMMCTradingAccountKey(CTradeApi* pUserApi, CBRspQryCFMMCTradingAccountKey cb)	///查询保证金监管系统经纪公司资金账户密钥响应
{
	pUserApi->pUserSpi->cbRspQryCFMMCTradingAccountKey = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTransferSerial(CTradeApi* pUserApi, CBRspQryTransferSerial cb)	///请求查询转帐流水响应
{
	pUserApi->pUserSpi->cbRspQryTransferSerial = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryAccountregister(CTradeApi* pUserApi, CBRspQryAccountregister cb)	///请求查询银期签约关系响应
{
	pUserApi->pUserSpi->cbRspQryAccountregister = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspError(CTradeApi* pUserApi, CBRspError cb)	///错误应答
{
	pUserApi->pUserSpi->cbRspError = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnOrder(CTradeApi* pUserApi, CBRtnOrder cb)	///报单通知
{
	pUserApi->pUserSpi->cbRtnOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnTrade(CTradeApi* pUserApi, CBRtnTrade cb)	///成交通知
{
	pUserApi->pUserSpi->cbRtnTrade = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnOrderInsert(CTradeApi* pUserApi, CBErrRtnOrderInsert cb)	///报单录入错误回报
{
	pUserApi->pUserSpi->cbErrRtnOrderInsert = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnOrderAction(CTradeApi* pUserApi, CBErrRtnOrderAction cb)	///报单操作错误回报
{
	pUserApi->pUserSpi->cbErrRtnOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnInstrumentStatus(CTradeApi* pUserApi, CBRtnInstrumentStatus cb)	///合约交易状态通知
{
	pUserApi->pUserSpi->cbRtnInstrumentStatus = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnTradingNotice(CTradeApi* pUserApi, CBRtnTradingNotice cb)	///交易通知
{
	pUserApi->pUserSpi->cbRtnTradingNotice = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnErrorConditionalOrder(CTradeApi* pUserApi, CBRtnErrorConditionalOrder cb)	///提示条件单校验错误
{
	pUserApi->pUserSpi->cbRtnErrorConditionalOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryContractBank(CTradeApi* pUserApi, CBRspQryContractBank cb)	///请求查询签约银行响应
{
	pUserApi->pUserSpi->cbRspQryContractBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryParkedOrder(CTradeApi* pUserApi, CBRspQryParkedOrder cb)	///请求查询预埋单响应
{
	pUserApi->pUserSpi->cbRspQryParkedOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryParkedOrderAction(CTradeApi* pUserApi, CBRspQryParkedOrderAction cb)	///请求查询预埋撤单响应
{
	pUserApi->pUserSpi->cbRspQryParkedOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTradingNotice(CTradeApi* pUserApi, CBRspQryTradingNotice cb)	///请求查询交易通知响应
{
	pUserApi->pUserSpi->cbRspQryTradingNotice = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryBrokerTradingParams(CTradeApi* pUserApi, CBRspQryBrokerTradingParams cb)	///请求查询经纪公司交易参数响应
{
	pUserApi->pUserSpi->cbRspQryBrokerTradingParams = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryBrokerTradingAlgos(CTradeApi* pUserApi, CBRspQryBrokerTradingAlgos cb)	///请求查询经纪公司交易算法响应
{
	pUserApi->pUserSpi->cbRspQryBrokerTradingAlgos = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnFromBankToFutureByBank(CTradeApi* pUserApi, CBRtnFromBankToFutureByBank cb)	///银行发起银行资金转期货通知
{
	pUserApi->pUserSpi->cbRtnFromBankToFutureByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnFromFutureToBankByBank(CTradeApi* pUserApi, CBRtnFromFutureToBankByBank cb)	///银行发起期货资金转银行通知
{
	pUserApi->pUserSpi->cbRtnFromFutureToBankByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByBank(CTradeApi* pUserApi, CBRtnRepealFromBankToFutureByBank cb)	///银行发起冲正银行转期货通知
{
	pUserApi->pUserSpi->cbRtnRepealFromBankToFutureByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByBank(CTradeApi* pUserApi, CBRtnRepealFromFutureToBankByBank cb)	///银行发起冲正期货转银行通知
{
	pUserApi->pUserSpi->cbRtnRepealFromFutureToBankByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnFromBankToFutureByFuture(CTradeApi* pUserApi, CBRtnFromBankToFutureByFuture cb)	///期货发起银行资金转期货通知
{
	pUserApi->pUserSpi->cbRtnFromBankToFutureByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnFromFutureToBankByFuture(CTradeApi* pUserApi, CBRtnFromFutureToBankByFuture cb)	///期货发起期货资金转银行通知
{
	pUserApi->pUserSpi->cbRtnFromFutureToBankByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnCancelAccountByBank(CTradeApi* pUserApi, CBRtnCancelAccountByBank cb)
{
	pUserApi->pUserSpi->cbRtnCancelAccountByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnChangeAccountByBank(CTradeApi* pUserApi, CBRtnChangeAccountByBank cb)
{
	pUserApi->pUserSpi->cbRtnChangeAccountByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnOpenAccountByBank(CTradeApi* pUserApi, CBRtnOpenAccountByBank cb)
{
	pUserApi->pUserSpi->cbRtnOpenAccountByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByFutureManual(CTradeApi* pUserApi, CBRtnRepealFromBankToFutureByFutureManual cb)	///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
{
	pUserApi->pUserSpi->cbRtnRepealFromBankToFutureByFutureManual = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByFutureManual(CTradeApi* pUserApi, CBRtnRepealFromFutureToBankByFutureManual cb)	///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
{
	pUserApi->pUserSpi->cbRtnRepealFromFutureToBankByFutureManual = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnQueryBankBalanceByFuture(CTradeApi* pUserApi, CBRtnQueryBankBalanceByFuture cb)	///期货发起查询银行余额通知
{
	pUserApi->pUserSpi->cbRtnQueryBankBalanceByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnBankToFutureByFuture(CTradeApi* pUserApi, CBErrRtnBankToFutureByFuture cb)	///期货发起银行资金转期货错误回报
{
	pUserApi->pUserSpi->cbErrRtnBankToFutureByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnFutureToBankByFuture(CTradeApi* pUserApi, CBErrRtnFutureToBankByFuture cb)	///期货发起期货资金转银行错误回报
{
	pUserApi->pUserSpi->cbErrRtnFutureToBankByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnRepealBankToFutureByFutureManual(CTradeApi* pUserApi, CBErrRtnRepealBankToFutureByFutureManual cb)	///系统运行时期货端手工发起冲正银行转期货错误回报
{
	pUserApi->pUserSpi->cbErrRtnRepealBankToFutureByFutureManual = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnRepealFutureToBankByFutureManual(CTradeApi* pUserApi, CBErrRtnRepealFutureToBankByFutureManual cb)	///系统运行时期货端手工发起冲正期货转银行错误回报
{
	pUserApi->pUserSpi->cbErrRtnRepealFutureToBankByFutureManual = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnQueryBankBalanceByFuture(CTradeApi* pUserApi, CBErrRtnQueryBankBalanceByFuture cb)	///期货发起查询银行余额错误回报
{
	pUserApi->pUserSpi->cbErrRtnQueryBankBalanceByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByFuture(CTradeApi* pUserApi, CBRtnRepealFromBankToFutureByFuture cb)	///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
{
	pUserApi->pUserSpi->cbRtnRepealFromBankToFutureByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByFuture(CTradeApi* pUserApi, CBRtnRepealFromFutureToBankByFuture cb)	///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
{
	pUserApi->pUserSpi->cbRtnRepealFromFutureToBankByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspFromBankToFutureByFuture(CTradeApi* pUserApi, CBRspFromBankToFutureByFuture cb)	///期货发起银行资金转期货应答
{
	pUserApi->pUserSpi->cbRspFromBankToFutureByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspFromFutureToBankByFuture(CTradeApi* pUserApi, CBRspFromFutureToBankByFuture cb)	///期货发起期货资金转银行应答
{
	pUserApi->pUserSpi->cbRspFromFutureToBankByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQueryBankAccountMoneyByFuture(CTradeApi* pUserApi, CBRspQueryBankAccountMoneyByFuture cb)	///期货发起查询银行余额应答
{
	pUserApi->pUserSpi->cbRspQueryBankAccountMoneyByFuture = cb;
}
