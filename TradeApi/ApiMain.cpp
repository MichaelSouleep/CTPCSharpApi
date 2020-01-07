
#include "stdafx.h"
#include "TradeApi.h"
#include "ThostFtdcUserApiDataType.h"
#include "ThostFtdcUserApiStruct.h"

// UserApi����
//CTradeApi* pUserApi;


//===============

//// ������
////int volatile iRequestID = 0;
////����
//extern "C" TRADEAPI_API void Connect(char* FRONT_ADDR, char *pszFlowPath)
//{
//	// ��ʼ��UserApi
//	pUserApi = CTradeApi::CreateFtdcTraderApi(pszFlowPath);			// ����UserApi
//	CTraderSpi* pUserSpi = new CTraderSpi();
//	pUserApi->RegisterSpi((CThostFtdcTraderSpi*)pUserSpi);			// ע���¼���
//	pUserApi->SubscribePublicTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// ע�ṫ����
//	pUserApi->SubscribePrivateTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// ע��˽����
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
	//return CTradeApi::CreateFtdcTraderApi(pszFlowPath);			// ����UserApi
}

extern "C" TRADEAPI_API void RegisterFront(CTradeApi* pUserApi, char* FRONT_ADDR)
{

	//CTraderSpi* pUserSpi = new CTraderSpi();
	//api->pUserApi->RegisterSpi((CThostFtdcTraderSpi*)pUserSpi);			// ע���¼���
	pUserApi->pUserApi->SubscribePublicTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// ע�ṫ����
	pUserApi->pUserApi->SubscribePrivateTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// ע��˽����
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
//�Ͽ�
extern "C" TRADEAPI_API void Release(CTradeApi* pUserApi)
{
	delete pUserApi;
	pUserApi = nullptr;
}

//extern "C" TRADEAPI_API int GetRequestID()
//{
//	return iRequestID;
//}

#pragma region ����:��͸ģʽ����û���֤(ʯ��ƽ 2019-06-04)
extern "C" TRADEAPI_API int ReqAuthenticate(CTradeApi* pUserApi, CThostFtdcReqAuthenticateField *req, int requestID)
{
	return pUserApi->pUserApi->ReqAuthenticate(req, requestID);
}
#pragma endregion


//�����û���¼����
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
//���͵ǳ�����
extern "C" TRADEAPI_API int ReqUserLogout(CTradeApi* pUserApi, CThostFtdcUserLogoutField *req, int requestID)
{
	//CThostFtdcUserLogoutField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.UserID, INVESTOR_ID);
	return pUserApi->pUserApi->ReqUserLogout(req, requestID);
}
//�����û�����
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
///�ʽ��˻������������
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
//����¼������
extern "C" TRADEAPI_API int ReqOrderInsert(CTradeApi* pUserApi, CThostFtdcInputOrderField *pOrder, int requestID)
{
	//int siez = sizeof(CThostFtdcInputOrderField);
	//strcpy_s(pOrder->BusinessUnit,"EasyTrader");
	return pUserApi->pUserApi->ReqOrderInsert(pOrder, requestID);
}
//������������
extern "C" TRADEAPI_API int ReqOrderAction(CTradeApi* pUserApi, CThostFtdcInputOrderActionField *pOrder, int requestID)
{
	return pUserApi->pUserApi->ReqOrderAction(pOrder, requestID);
}
///��ѯ��󱨵���������
extern "C" TRADEAPI_API int ReqQueryMaxOrderVolume(CTradeApi* pUserApi, CThostFtdcQueryMaxOrderVolumeField *pMaxOrderVolume, int requestID)
{
	return pUserApi->pUserApi->ReqQueryMaxOrderVolume(pMaxOrderVolume, requestID);
}
//Ͷ���߽�����ȷ��
extern "C" TRADEAPI_API int ReqSettlementInfoConfirm(CTradeApi* pUserApi, CThostFtdcSettlementInfoConfirmField *req, int requestID)
{
	//CThostFtdcSettlementInfoConfirmField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.InvestorID, INVESTOR_ID);
	return pUserApi->pUserApi->ReqSettlementInfoConfirm(req, requestID);
}
///�����ѯ����
extern "C" TRADEAPI_API int ReqQryOrder(CTradeApi* pUserApi, CThostFtdcQryOrderField *pQryOrder, int requestID)
{
	return pUserApi->pUserApi->ReqQryOrder(pQryOrder, requestID);
}
///�����ѯ�ɽ�
extern "C" TRADEAPI_API int ReqQryTrade(CTradeApi* pUserApi, CThostFtdcQryTradeField *pQryTrade, int requestID)
{
	return pUserApi->pUserApi->ReqQryTrade(pQryTrade, requestID);
}
//�����ѯͶ���ֲ߳�
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
//�����ѯ�ʽ��˻�
extern "C" TRADEAPI_API int ReqQryTradingAccount(CTradeApi* pUserApi, CThostFtdcQryTradingAccountField *req, int requestID)
{
	//CThostFtdcQryTradingAccountField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.InvestorID, INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryTradingAccount(req, requestID);
}
///�����ѯͶ����
extern "C" TRADEAPI_API int ReqQryInvestor(CTradeApi* pUserApi, CThostFtdcQryInvestorField *req, int requestID)
{
	//CThostFtdcQryInvestorField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID ,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryInvestor(req, requestID);
}
///�����ѯ���ױ���
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
///�����ѯ��Լ��֤����
extern "C" TRADEAPI_API int ReqQryInstrumentMarginRate(CTradeApi* pUserApi, CThostFtdcQryInstrumentMarginRateField *req, int requestID)
{
	//CThostFtdcQryInstrumentMarginRateField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID ,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID,INSTRUMENT_ID);
	//if(HEDGE_FLAG != NULL)
	//	req->HedgeFlag = HEDGE_FLAG;						//*��*�ܲ���null�������в�ѯ
	return pUserApi->pUserApi->ReqQryInstrumentMarginRate(req, requestID);
}
///�����ѯ��Լ��������
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
///�����ѯ������
extern "C" TRADEAPI_API int ReqQryExchange(CTradeApi* pUserApi, CThostFtdcQryExchangeField  *req, int requestID)
{
	//CThostFtdcQryExchangeField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.ExchangeID,EXCHANGE_ID);
	return pUserApi->pUserApi->ReqQryExchange(req, requestID);
}
//�����ѯ��Լ
extern "C" TRADEAPI_API int ReqQryInstrument(CTradeApi* pUserApi, CThostFtdcQryInstrumentField *req, int requestID)
{
	//CThostFtdcQryInstrumentField req;
	//memset(&req, 0, sizeof(req));
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->pUserApi->ReqQryInstrument(req, requestID);
}
//�����ѯ����
extern "C" TRADEAPI_API int ReqQryDepthMarketData(CTradeApi* pUserApi, CThostFtdcQryDepthMarketDataField *req, int requestID)
{
	//CThostFtdcQryDepthMarketDataField req;
	//memset(&req,0,sizeof(req));
	//if(INSTRUMENT_ID != NULL)
	//	strcpy_s(req.InstrumentID, INSTRUMENT_ID);
	return pUserApi->pUserApi->ReqQryDepthMarketData(req, requestID);
}
///�����ѯͶ���߽�����
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
//��ѯ�ֲ���ϸ
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
///�����ѯ�ͻ�֪ͨ
extern "C" TRADEAPI_API int ReqQryNotice(CTradeApi* pUserApi, CThostFtdcQryNoticeField  *req, int requestID)
{
	//CThostFtdcQryNoticeField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKERID);
	return pUserApi->pUserApi->ReqQryNotice(req, requestID);
}
///�����ѯ������Ϣȷ��
extern "C" TRADEAPI_API int ReqQrySettlementInfoConfirm(CTradeApi* pUserApi, CThostFtdcQrySettlementInfoConfirmField  *req, int requestID)
{
	//CThostFtdcQrySettlementInfoConfirmField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQrySettlementInfoConfirm(req, requestID);
}
///�����ѯ**���**�ֲ���ϸ
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
///�����ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ
extern "C" TRADEAPI_API int ReqQryCFMMCTradingAccountKey(CTradeApi* pUserApi, CThostFtdcQryCFMMCTradingAccountKeyField *req, int requestID)
{
	//CThostFtdcQryCFMMCTradingAccountKeyField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryCFMMCTradingAccountKey(req, requestID);
}
///�����ѯ����֪ͨ
extern "C" TRADEAPI_API int ReqQryTradingNotice(CTradeApi* pUserApi, CThostFtdcQryTradingNoticeField *req, int requestID)
{
	//CThostFtdcQryTradingNoticeField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryTradingNotice(req, requestID);
}
///�����ѯ���͹�˾���ײ���
extern "C" TRADEAPI_API int ReqQryBrokerTradingParams(CTradeApi* pUserApi, CThostFtdcQryBrokerTradingParamsField  *req, int requestID)
{
	//CThostFtdcQryBrokerTradingParamsField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	return pUserApi->pUserApi->ReqQryBrokerTradingParams(req, requestID);
}
///�����ѯ���͹�˾�����㷨
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
///Ԥ��¼������
extern "C" TRADEAPI_API int ReqParkedOrderInsert(CTradeApi* pUserApi, CThostFtdcParkedOrderField *ParkedOrder, int requestID)
{
	return pUserApi->pUserApi->ReqParkedOrderInsert(ParkedOrder, requestID);
}
///Ԥ�񳷵�¼������
extern "C" TRADEAPI_API int ReqParkedOrderAction(CTradeApi* pUserApi, CThostFtdcParkedOrderActionField *ParkedOrderAction, int requestID)
{
	return pUserApi->pUserApi->ReqParkedOrderAction(ParkedOrderAction, requestID);
}
///����ɾ��Ԥ��
extern "C" TRADEAPI_API int ReqRemoveParkedOrder(CTradeApi* pUserApi, CThostFtdcRemoveParkedOrderField  *req, int requestID)
{
	//CThostFtdcRemoveParkedOrderField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//strcpy_s(req.ParkedOrderID,ParkedOrder_ID);
	return pUserApi->pUserApi->ReqRemoveParkedOrder(req, requestID);
}
///����ɾ��Ԥ�񳷵�
extern "C" TRADEAPI_API int ReqRemoveParkedOrderAction(CTradeApi* pUserApi, CThostFtdcRemoveParkedOrderActionField  *req, int requestID)//TThostFtdcBrokerIDType BROKER_ID,TThostFtdcInvestorIDType INVESTOR_ID,TThostFtdcParkedOrderActionIDType ParkedOrderAction_ID)
{
	//CThostFtdcRemoveParkedOrderActionField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.InvestorID,INVESTOR_ID);
	//strcpy_s(req.ParkedOrderActionID,ParkedOrderAction_ID);
	return pUserApi->pUserApi->ReqRemoveParkedOrderAction(req, requestID);
}
///�����ѯת������
extern "C" TRADEAPI_API int ReqQryTransferBank(CTradeApi* pUserApi, CThostFtdcQryTransferBankField  *req, int requestID)//TThostFtdcBankIDType Bank_ID,	TThostFtdcBankBrchIDType BankBrch_ID)
{
	//CThostFtdcQryTransferBankField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BankID,Bank_ID);
	//strcpy_s(req.BankBrchID,BankBrch_ID);
	return pUserApi->pUserApi->ReqQryTransferBank(req, requestID);
}
///�����ѯת����ˮ
extern "C" TRADEAPI_API int ReqQryTransferSerial(CTradeApi* pUserApi, CThostFtdcQryTransferSerialField  *req, int requestID)//TThostFtdcBrokerIDType Broker_ID,TThostFtdcAccountIDType Account_ID,TThostFtdcBankIDType Bank_ID)
{
	//CThostFtdcQryTransferSerialField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID,Broker_ID);
	//strcpy_s(req.AccountID,Account_ID);
	//strcpy_s(req.BankID,Bank_ID);
	return pUserApi->pUserApi->ReqQryTransferSerial(req, requestID);
}
///�����ѯ����ǩԼ��ϵ
extern "C" TRADEAPI_API int ReqQryAccountregister(CTradeApi* pUserApi, CThostFtdcQryAccountregisterField  *req, int requestID)//TThostFtdcBrokerIDType Broker_ID, TThostFtdcAccountIDType Account_ID, TThostFtdcBankIDType Bank_ID)
{
	//CThostFtdcQryAccountregisterField  req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, Broker_ID);
	//strcpy_s(req.AccountID, Account_ID);
	//strcpy_s(req.BankID, Bank_ID);
	return pUserApi->pUserApi->ReqQryAccountregister(req, requestID);
}
///�����ѯǩԼ����
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
///�����ѯԤ��
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
///�����ѯԤ�񳷵�
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
///�ڻ����������ʽ�ת�ڻ�����
extern "C" TRADEAPI_API int ReqFromBankToFutureByFuture(CTradeApi* pUserApi, CThostFtdcReqTransferField *ReqTransfer, int requestID)
{
	return pUserApi->pUserApi->ReqFromBankToFutureByFuture(ReqTransfer, requestID);
}
///�ڻ������ڻ��ʽ�ת��������
extern "C" TRADEAPI_API int ReqFromFutureToBankByFuture(CTradeApi* pUserApi, CThostFtdcReqTransferField *ReqTransfer, int requestID)
{
	return pUserApi->pUserApi->ReqFromFutureToBankByFuture(ReqTransfer, requestID);
}
///�ڻ������ѯ�����������
extern "C" TRADEAPI_API int ReqQueryBankAccountMoneyByFuture(CTradeApi* pUserApi, CThostFtdcReqQueryAccountField *ReqQueryAccountm, int requestID)
{
	return pUserApi->pUserApi->ReqQueryBankAccountMoneyByFuture(ReqQueryAccountm, requestID);
}
//========================================
///==================================== �ص����� =======================================
extern "C" TRADEAPI_API void WINAPI RegOnFrontConnected(CTradeApi* pUserApi, CBOnFrontConnected cb)		///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
{
	pUserApi->pUserSpi->cbOnFrontConnected = cb;
}

extern "C" TRADEAPI_API void WINAPI RegOnFrontDisconnected(CTradeApi* pUserApi, CBOnFrontDisconnected cb)		///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
{
	pUserApi->pUserSpi->cbOnFrontDisconnected = cb;
}

extern "C" TRADEAPI_API void WINAPI RegOnHeartBeatWarning(CTradeApi* pUserApi, CBOnHeartBeatWarning cb)		///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
{
	pUserApi->pUserSpi->cbOnHeartBeatWarning = cb;
}

extern "C" TRADEAPI_API void WINAPI RegRspUserLogin(CTradeApi* pUserApi, CBRspUserLogin cb)	///��¼������Ӧ
{
	pUserApi->pUserSpi->cbRspUserLogin = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspUserLogout(CTradeApi* pUserApi, CBRspUserLogout cb)	///�ǳ�������Ӧ
{
	pUserApi->pUserSpi->cbRspUserLogout = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspUserPasswordUpdate(CTradeApi* pUserApi, CBRspUserPasswordUpdate cb)	///�û��������������Ӧ
{
	pUserApi->pUserSpi->cbRspUserPasswordUpdate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspAuthenticate(CTradeApi* pUserApi, CBRspAuthenticate cb)	///�ͻ�����֤������Ӧ
{
	pUserApi->pUserSpi->cbRspAuthenticate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspTradingAccountPasswordUpdate(CTradeApi* pUserApi, CBRspTradingAccountPasswordUpdate cb)	///�ʽ��˻��������������Ӧ
{
	pUserApi->pUserSpi->cbRspTradingAccountPasswordUpdate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspOrderInsert(CTradeApi* pUserApi, CBRspOrderInsert cb)	///����¼��������Ӧ
{
	pUserApi->pUserSpi->cbRspOrderInsert = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspParkedOrderInsert(CTradeApi* pUserApi, CBRspParkedOrderInsert cb)	///Ԥ��¼��������Ӧ
{
	pUserApi->pUserSpi->cbRspParkedOrderInsert = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspParkedOrderAction(CTradeApi* pUserApi, CBRspParkedOrderAction cb)	///Ԥ�񳷵�¼��������Ӧ
{
	pUserApi->pUserSpi->cbRspParkedOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspOrderAction(CTradeApi* pUserApi, CBRspOrderAction cb)	///��������������Ӧ
{
	pUserApi->pUserSpi->cbRspOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQueryMaxOrderVolume(CTradeApi* pUserApi, CBRspQueryMaxOrderVolume cb)	///��ѯ��󱨵�������Ӧ
{
	pUserApi->pUserSpi->cbRspQueryMaxOrderVolume = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspSettlementInfoConfirm(CTradeApi* pUserApi, CBRspSettlementInfoConfirm cb)	///Ͷ���߽�����ȷ����Ӧ
{
	pUserApi->pUserSpi->cbRspSettlementInfoConfirm = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspRemoveParkedOrder(CTradeApi* pUserApi, CBRspRemoveParkedOrder cb)	///ɾ��Ԥ����Ӧ
{
	pUserApi->pUserSpi->cbRspRemoveParkedOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspRemoveParkedOrderAction(CTradeApi* pUserApi, CBRspRemoveParkedOrderAction cb)	///ɾ��Ԥ�񳷵���Ӧ
{
	pUserApi->pUserSpi->cbRspRemoveParkedOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryOrder(CTradeApi* pUserApi, CBRspQryOrder cb)	///�����ѯ������Ӧ
{
	pUserApi->pUserSpi->cbRspQryOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTrade(CTradeApi* pUserApi, CBRspQryTrade cb)	///�����ѯ�ɽ���Ӧ
{
	pUserApi->pUserSpi->cbRspQryTrade = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInvestorPosition(CTradeApi* pUserApi, CBRspQryInvestorPosition cb)	///�����ѯͶ���ֲ߳���Ӧ
{
	pUserApi->pUserSpi->cbRspQryInvestorPosition = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTradingAccount(CTradeApi* pUserApi, CBRspQryTradingAccount cb)	///�����ѯ�ʽ��˻���Ӧ
{
	pUserApi->pUserSpi->cbRspQryTradingAccount = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryEWarrantOffset(CTradeApi* pUserApi, CBRspQryEWarrantOffset cb)	///�����ѯ�ʽ��˻���Ӧ
{
	pUserApi->pUserSpi->cbRspQryEWarrantOffset = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInvestor(CTradeApi* pUserApi, CBRspQryInvestor cb)	///�����ѯͶ������Ӧ
{
	pUserApi->pUserSpi->cbRspQryInvestor = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTradingCode(CTradeApi* pUserApi, CBRspQryTradingCode cb)	///�����ѯ���ױ�����Ӧ
{
	pUserApi->pUserSpi->cbRspQryTradingCode = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInstrumentMarginRate(CTradeApi* pUserApi, CBRspQryInstrumentMarginRate cb)	///�����ѯ��Լ��֤������Ӧ
{
	pUserApi->pUserSpi->cbRspQryInstrumentMarginRate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInstrumentCommissionRate(CTradeApi* pUserApi, CBRspQryInstrumentCommissionRate cb)	///�����ѯ��Լ����������Ӧ
{
	pUserApi->pUserSpi->cbRspQryInstrumentCommissionRate = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryExchange(CTradeApi* pUserApi, CBRspQryExchange cb)	///�����ѯ��������Ӧ
{
	pUserApi->pUserSpi->cbRspQryExchange = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInstrument(CTradeApi* pUserApi, CBRspQryInstrument cb)	///�����ѯ��Լ��Ӧ
{
	pUserApi->pUserSpi->cbRspQryInstrument = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryDepthMarketData(CTradeApi* pUserApi, CBRspQryDepthMarketData cb)	///�����ѯ������Ӧ
{
	pUserApi->pUserSpi->cbRspQryDepthMarketData = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQrySettlementInfo(CTradeApi* pUserApi, CBRspQrySettlementInfo cb)	///�����ѯͶ���߽�������Ӧ
{
	pUserApi->pUserSpi->cbRspQrySettlementInfo = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTransferBank(CTradeApi* pUserApi, CBRspQryTransferBank cb)	///�����ѯת��������Ӧ
{
	pUserApi->pUserSpi->cbRspQryTransferBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInvestorPositionDetail(CTradeApi* pUserApi, CBRspQryInvestorPositionDetail cb)	///�����ѯͶ���ֲ߳���ϸ��Ӧ
{
	pUserApi->pUserSpi->cbRspQryInvestorPositionDetail = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryNotice(CTradeApi* pUserApi, CBRspQryNotice cb)	///�����ѯ�ͻ�֪ͨ��Ӧ
{
	pUserApi->pUserSpi->cbRspQryNotice = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQrySettlementInfoConfirm(CTradeApi* pUserApi, CBRspQrySettlementInfoConfirm cb)	///�����ѯ������Ϣȷ����Ӧ
{
	pUserApi->pUserSpi->cbRspQrySettlementInfoConfirm = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryInvestorPositionCombineDetail(CTradeApi* pUserApi, CBRspQryInvestorPositionCombineDetail cb)	///�����ѯͶ���ֲ߳���ϸ��Ӧ
{
	pUserApi->pUserSpi->cbRspQryInvestorPositionCombineDetail = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryCFMMCTradingAccountKey(CTradeApi* pUserApi, CBRspQryCFMMCTradingAccountKey cb)	///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
{
	pUserApi->pUserSpi->cbRspQryCFMMCTradingAccountKey = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTransferSerial(CTradeApi* pUserApi, CBRspQryTransferSerial cb)	///�����ѯת����ˮ��Ӧ
{
	pUserApi->pUserSpi->cbRspQryTransferSerial = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryAccountregister(CTradeApi* pUserApi, CBRspQryAccountregister cb)	///�����ѯ����ǩԼ��ϵ��Ӧ
{
	pUserApi->pUserSpi->cbRspQryAccountregister = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspError(CTradeApi* pUserApi, CBRspError cb)	///����Ӧ��
{
	pUserApi->pUserSpi->cbRspError = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnOrder(CTradeApi* pUserApi, CBRtnOrder cb)	///����֪ͨ
{
	pUserApi->pUserSpi->cbRtnOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnTrade(CTradeApi* pUserApi, CBRtnTrade cb)	///�ɽ�֪ͨ
{
	pUserApi->pUserSpi->cbRtnTrade = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnOrderInsert(CTradeApi* pUserApi, CBErrRtnOrderInsert cb)	///����¼�����ر�
{
	pUserApi->pUserSpi->cbErrRtnOrderInsert = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnOrderAction(CTradeApi* pUserApi, CBErrRtnOrderAction cb)	///������������ر�
{
	pUserApi->pUserSpi->cbErrRtnOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnInstrumentStatus(CTradeApi* pUserApi, CBRtnInstrumentStatus cb)	///��Լ����״̬֪ͨ
{
	pUserApi->pUserSpi->cbRtnInstrumentStatus = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnTradingNotice(CTradeApi* pUserApi, CBRtnTradingNotice cb)	///����֪ͨ
{
	pUserApi->pUserSpi->cbRtnTradingNotice = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnErrorConditionalOrder(CTradeApi* pUserApi, CBRtnErrorConditionalOrder cb)	///��ʾ������У�����
{
	pUserApi->pUserSpi->cbRtnErrorConditionalOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryContractBank(CTradeApi* pUserApi, CBRspQryContractBank cb)	///�����ѯǩԼ������Ӧ
{
	pUserApi->pUserSpi->cbRspQryContractBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryParkedOrder(CTradeApi* pUserApi, CBRspQryParkedOrder cb)	///�����ѯԤ����Ӧ
{
	pUserApi->pUserSpi->cbRspQryParkedOrder = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryParkedOrderAction(CTradeApi* pUserApi, CBRspQryParkedOrderAction cb)	///�����ѯԤ�񳷵���Ӧ
{
	pUserApi->pUserSpi->cbRspQryParkedOrderAction = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryTradingNotice(CTradeApi* pUserApi, CBRspQryTradingNotice cb)	///�����ѯ����֪ͨ��Ӧ
{
	pUserApi->pUserSpi->cbRspQryTradingNotice = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryBrokerTradingParams(CTradeApi* pUserApi, CBRspQryBrokerTradingParams cb)	///�����ѯ���͹�˾���ײ�����Ӧ
{
	pUserApi->pUserSpi->cbRspQryBrokerTradingParams = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQryBrokerTradingAlgos(CTradeApi* pUserApi, CBRspQryBrokerTradingAlgos cb)	///�����ѯ���͹�˾�����㷨��Ӧ
{
	pUserApi->pUserSpi->cbRspQryBrokerTradingAlgos = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnFromBankToFutureByBank(CTradeApi* pUserApi, CBRtnFromBankToFutureByBank cb)	///���з��������ʽ�ת�ڻ�֪ͨ
{
	pUserApi->pUserSpi->cbRtnFromBankToFutureByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnFromFutureToBankByBank(CTradeApi* pUserApi, CBRtnFromFutureToBankByBank cb)	///���з����ڻ��ʽ�ת����֪ͨ
{
	pUserApi->pUserSpi->cbRtnFromFutureToBankByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByBank(CTradeApi* pUserApi, CBRtnRepealFromBankToFutureByBank cb)	///���з����������ת�ڻ�֪ͨ
{
	pUserApi->pUserSpi->cbRtnRepealFromBankToFutureByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByBank(CTradeApi* pUserApi, CBRtnRepealFromFutureToBankByBank cb)	///���з�������ڻ�ת����֪ͨ
{
	pUserApi->pUserSpi->cbRtnRepealFromFutureToBankByBank = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnFromBankToFutureByFuture(CTradeApi* pUserApi, CBRtnFromBankToFutureByFuture cb)	///�ڻ����������ʽ�ת�ڻ�֪ͨ
{
	pUserApi->pUserSpi->cbRtnFromBankToFutureByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnFromFutureToBankByFuture(CTradeApi* pUserApi, CBRtnFromFutureToBankByFuture cb)	///�ڻ������ڻ��ʽ�ת����֪ͨ
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
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByFutureManual(CTradeApi* pUserApi, CBRtnRepealFromBankToFutureByFutureManual cb)	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
{
	pUserApi->pUserSpi->cbRtnRepealFromBankToFutureByFutureManual = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByFutureManual(CTradeApi* pUserApi, CBRtnRepealFromFutureToBankByFutureManual cb)	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
{
	pUserApi->pUserSpi->cbRtnRepealFromFutureToBankByFutureManual = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnQueryBankBalanceByFuture(CTradeApi* pUserApi, CBRtnQueryBankBalanceByFuture cb)	///�ڻ������ѯ�������֪ͨ
{
	pUserApi->pUserSpi->cbRtnQueryBankBalanceByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnBankToFutureByFuture(CTradeApi* pUserApi, CBErrRtnBankToFutureByFuture cb)	///�ڻ����������ʽ�ת�ڻ�����ر�
{
	pUserApi->pUserSpi->cbErrRtnBankToFutureByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnFutureToBankByFuture(CTradeApi* pUserApi, CBErrRtnFutureToBankByFuture cb)	///�ڻ������ڻ��ʽ�ת���д���ر�
{
	pUserApi->pUserSpi->cbErrRtnFutureToBankByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnRepealBankToFutureByFutureManual(CTradeApi* pUserApi, CBErrRtnRepealBankToFutureByFutureManual cb)	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
{
	pUserApi->pUserSpi->cbErrRtnRepealBankToFutureByFutureManual = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnRepealFutureToBankByFutureManual(CTradeApi* pUserApi, CBErrRtnRepealFutureToBankByFutureManual cb)	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
{
	pUserApi->pUserSpi->cbErrRtnRepealFutureToBankByFutureManual = cb;
}
extern "C" TRADEAPI_API void WINAPI RegErrRtnQueryBankBalanceByFuture(CTradeApi* pUserApi, CBErrRtnQueryBankBalanceByFuture cb)	///�ڻ������ѯ����������ر�
{
	pUserApi->pUserSpi->cbErrRtnQueryBankBalanceByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromBankToFutureByFuture(CTradeApi* pUserApi, CBRtnRepealFromBankToFutureByFuture cb)	///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
{
	pUserApi->pUserSpi->cbRtnRepealFromBankToFutureByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRtnRepealFromFutureToBankByFuture(CTradeApi* pUserApi, CBRtnRepealFromFutureToBankByFuture cb)	///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
{
	pUserApi->pUserSpi->cbRtnRepealFromFutureToBankByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspFromBankToFutureByFuture(CTradeApi* pUserApi, CBRspFromBankToFutureByFuture cb)	///�ڻ����������ʽ�ת�ڻ�Ӧ��
{
	pUserApi->pUserSpi->cbRspFromBankToFutureByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspFromFutureToBankByFuture(CTradeApi* pUserApi, CBRspFromFutureToBankByFuture cb)	///�ڻ������ڻ��ʽ�ת����Ӧ��
{
	pUserApi->pUserSpi->cbRspFromFutureToBankByFuture = cb;
}
extern "C" TRADEAPI_API void WINAPI RegRspQueryBankAccountMoneyByFuture(CTradeApi* pUserApi, CBRspQueryBankAccountMoneyByFuture cb)	///�ڻ������ѯ�������Ӧ��
{
	pUserApi->pUserSpi->cbRspQueryBankAccountMoneyByFuture = cb;
}
