// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
// ��ı�׼�������� DLL �е������ļ��������������϶���� TRADEAPI_EXPORTS
// ���ű���ġ���ʹ�ô� DLL ��
// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
// extern "C" TRADEAPI_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
// ������Ϊ�Ǳ������ġ�
#ifdef TRADEAPI_EXPORTS
#define TRADEAPI_API __declspec(dllexport)
#else
#define TRADEAPI_API __declspec(dllimport)
#endif

#include "ThostFtdcTraderApi.h"
#include "ThostFtdcUserApiDataType.h"
#include "ThostFtdcUserApiStruct.h"

///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
typedef int (WINAPI *CBOnFrontConnected)();

///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
typedef int (WINAPI *CBOnFrontDisconnected)(int nReason);

///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
typedef int (WINAPI *CBOnHeartBeatWarning)(int nTimeLapse);
///��¼������Ӧ
typedef int (WINAPI *CBRspUserLogin)(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�ǳ�������Ӧ
typedef int (WINAPI *CBRspUserLogout)(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�û��������������Ӧ
typedef int (WINAPI *CBRspUserPasswordUpdate)(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�ͻ�����֤������Ӧ
typedef int (WINAPI *CBRspAuthenticate)(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�ʽ��˻��������������Ӧ
typedef int (WINAPI *CBRspTradingAccountPasswordUpdate)(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///����¼��������Ӧ
typedef int (WINAPI *CBRspOrderInsert)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///Ԥ��¼��������Ӧ
typedef int (WINAPI *CBRspParkedOrderInsert)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///Ԥ�񳷵�¼��������Ӧ
typedef int (WINAPI *CBRspParkedOrderAction)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///��������������Ӧ
typedef int (WINAPI *CBRspOrderAction)(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///��ѯ��󱨵�������Ӧ
typedef int (WINAPI *CBRspQueryMaxOrderVolume)(CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///Ͷ���߽�����ȷ����Ӧ
typedef int (WINAPI *CBRspSettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///ɾ��Ԥ����Ӧ
typedef int (WINAPI *CBRspRemoveParkedOrder)(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///ɾ��Ԥ�񳷵���Ӧ
typedef int (WINAPI *CBRspRemoveParkedOrderAction)(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ������Ӧ
typedef int (WINAPI *CBRspQryOrder)(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ�ɽ���Ӧ
typedef int (WINAPI *CBRspQryTrade)(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯͶ���ֲ߳���Ӧ
typedef int (WINAPI *CBRspQryInvestorPosition)(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ�ʽ��˻���Ӧ
typedef int (WINAPI *CBRspQryTradingAccount)(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
typedef int (WINAPI *CBRspQryEWarrantOffset)(CThostFtdcEWarrantOffsetField *pEWarrantOffset, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯͶ������Ӧ
typedef int (WINAPI *CBRspQryInvestor)(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ���ױ�����Ӧ
typedef int (WINAPI *CBRspQryTradingCode)(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ��Լ��֤������Ӧ
typedef int (WINAPI *CBRspQryInstrumentMarginRate)(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ��Լ����������Ӧ
typedef int (WINAPI *CBRspQryInstrumentCommissionRate)(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ��������Ӧ
typedef int (WINAPI *CBRspQryExchange)(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ��Լ��Ӧ
typedef int (WINAPI *CBRspQryInstrument)(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ������Ӧ
typedef int (WINAPI *CBRspQryDepthMarketData)(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯͶ���߽�������Ӧ
typedef int (WINAPI *CBRspQrySettlementInfo)(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯת��������Ӧ
typedef int (WINAPI *CBRspQryTransferBank)(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯͶ���ֲ߳���ϸ��Ӧ
typedef int (WINAPI *CBRspQryInvestorPositionDetail)(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ�ͻ�֪ͨ��Ӧ
typedef int (WINAPI *CBRspQryNotice)(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ������Ϣȷ����Ӧ
typedef int (WINAPI *CBRspQrySettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯͶ���ֲ߳���ϸ��Ӧ
typedef int (WINAPI *CBRspQryInvestorPositionCombineDetail)(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
typedef int (WINAPI *CBRspQryCFMMCTradingAccountKey)(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯת����ˮ��Ӧ
typedef int (WINAPI *CBRspQryTransferSerial)(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ����ǩԼ��ϵ��Ӧ
typedef int (WINAPI *CBRspQryAccountregister)(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///����Ӧ��
typedef int (WINAPI *CBRspError)(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///����֪ͨ
typedef int (WINAPI *CBRtnOrder)(CThostFtdcOrderField *pOrder);
///�ɽ�֪ͨ
typedef int (WINAPI *CBRtnTrade)(CThostFtdcTradeField *pTrade);
///����¼�����ر�
typedef int (WINAPI *CBErrRtnOrderInsert)(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo);
///������������ر�
typedef int (WINAPI *CBErrRtnOrderAction)(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo);
///��Լ����״̬֪ͨ
typedef int (WINAPI *CBRtnInstrumentStatus)(CThostFtdcInstrumentStatusField *pInstrumentStatus);
///����֪ͨ
typedef int (WINAPI *CBRtnTradingNotice)(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo);
///��ʾ������У�����
typedef int (WINAPI *CBRtnErrorConditionalOrder)(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder);
///�����ѯǩԼ������Ӧ
typedef int (WINAPI *CBRspQryContractBank)(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯԤ����Ӧ
typedef int (WINAPI *CBRspQryParkedOrder)(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯԤ�񳷵���Ӧ
typedef int (WINAPI *CBRspQryParkedOrderAction)(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ����֪ͨ��Ӧ
typedef int (WINAPI *CBRspQryTradingNotice)(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ���͹�˾���ײ�����Ӧ
typedef int (WINAPI *CBRspQryBrokerTradingParams)(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�����ѯ���͹�˾�����㷨��Ӧ
typedef int (WINAPI *CBRspQryBrokerTradingAlgos)(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///���з��������ʽ�ת�ڻ�֪ͨ
typedef int (WINAPI *CBRtnFromBankToFutureByBank)(CThostFtdcRspTransferField *pRspTransfer);
///���з����ڻ��ʽ�ת����֪ͨ
typedef int (WINAPI *CBRtnFromFutureToBankByBank)(CThostFtdcRspTransferField *pRspTransfer);
///���з����������ת�ڻ�֪ͨ
typedef int (WINAPI *CBRtnRepealFromBankToFutureByBank)(CThostFtdcRspRepealField *pRspRepeal);
///���з�������ڻ�ת����֪ͨ
typedef int (WINAPI *CBRtnRepealFromFutureToBankByBank)(CThostFtdcRspRepealField *pRspRepeal);
///�ڻ����������ʽ�ת�ڻ�֪ͨ
typedef int (WINAPI *CBRtnFromBankToFutureByFuture)(CThostFtdcRspTransferField *pRspTransfer);
///�ڻ������ڻ��ʽ�ת����֪ͨ
typedef int (WINAPI *CBRtnFromFutureToBankByFuture)(CThostFtdcRspTransferField *pRspTransfer);

typedef int (WINAPI *CBRtnCancelAccountByBank)(CThostFtdcCancelAccountField *pCancelAccount);
typedef int (WINAPI *CBRtnChangeAccountByBank)(CThostFtdcChangeAccountField *pChangeAccount);

typedef int (WINAPI *CBRtnOpenAccountByBank)(CThostFtdcOpenAccountField *pOpenAccount);

///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
typedef int (WINAPI *CBRtnRepealFromBankToFutureByFutureManual)(CThostFtdcRspRepealField *pRspRepeal);
///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
typedef int (WINAPI *CBRtnRepealFromFutureToBankByFutureManual)(CThostFtdcRspRepealField *pRspRepeal);
///�ڻ������ѯ�������֪ͨ
typedef int (WINAPI *CBRtnQueryBankBalanceByFuture)(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount);
///�ڻ����������ʽ�ת�ڻ�����ر�
typedef int (WINAPI *CBErrRtnBankToFutureByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo);
///�ڻ������ڻ��ʽ�ת���д���ر�
typedef int (WINAPI *CBErrRtnFutureToBankByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo);
///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
typedef int (WINAPI *CBErrRtnRepealBankToFutureByFutureManual)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo);
///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
typedef int (WINAPI *CBErrRtnRepealFutureToBankByFutureManual)(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo);
///�ڻ������ѯ����������ر�
typedef int (WINAPI *CBErrRtnQueryBankBalanceByFuture)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo);
///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
typedef int (WINAPI *CBRtnRepealFromBankToFutureByFuture)(CThostFtdcRspRepealField *pRspRepeal);
///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
typedef int (WINAPI *CBRtnRepealFromFutureToBankByFuture)(CThostFtdcRspRepealField *pRspRepeal);
///�ڻ����������ʽ�ת�ڻ�Ӧ��
typedef int (WINAPI *CBRspFromBankToFutureByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�ڻ������ڻ��ʽ�ת����Ӧ��
typedef int (WINAPI *CBRspFromFutureToBankByFuture)(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
///�ڻ������ѯ�������Ӧ��
typedef int (WINAPI *CBRspQueryBankAccountMoneyByFuture)(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);



// �����Ǵ� TradeApi.dll ������
class CTraderSpi : public CThostFtdcTraderSpi
{
public:
	//�ص�����
	CBOnFrontConnected cbOnFrontConnected = 0;		///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
	CBOnFrontDisconnected cbOnFrontDisconnected = 0;		///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
	CBOnHeartBeatWarning cbOnHeartBeatWarning = 0;		///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
	CBRspUserLogin cbRspUserLogin = 0;	///��¼������Ӧ
	CBRspUserLogout cbRspUserLogout = 0;	///�ǳ�������Ӧ
	CBRspUserPasswordUpdate cbRspUserPasswordUpdate = 0;	///�û��������������Ӧ
	CBRspAuthenticate cbRspAuthenticate = 0;
	CBRspTradingAccountPasswordUpdate cbRspTradingAccountPasswordUpdate = 0;	///�ʽ��˻��������������Ӧ
	CBRspOrderInsert cbRspOrderInsert = 0;	///����¼��������Ӧ
	CBRspParkedOrderInsert cbRspParkedOrderInsert = 0;	///Ԥ��¼��������Ӧ
	CBRspParkedOrderAction cbRspParkedOrderAction = 0;	///Ԥ�񳷵�¼��������Ӧ
	CBRspOrderAction cbRspOrderAction = 0;	///��������������Ӧ
	CBRspQueryMaxOrderVolume cbRspQueryMaxOrderVolume = 0;	///��ѯ��󱨵�������Ӧ
	CBRspSettlementInfoConfirm cbRspSettlementInfoConfirm = 0;	///Ͷ���߽�����ȷ����Ӧ
	CBRspRemoveParkedOrder cbRspRemoveParkedOrder = 0;	///ɾ��Ԥ����Ӧ
	CBRspRemoveParkedOrderAction cbRspRemoveParkedOrderAction = 0;	///ɾ��Ԥ�񳷵���Ӧ
	CBRspQryOrder cbRspQryOrder = 0;	///�����ѯ������Ӧ
	CBRspQryTrade cbRspQryTrade = 0;	///�����ѯ�ɽ���Ӧ
	CBRspQryInvestorPosition cbRspQryInvestorPosition = 0;	///�����ѯͶ���ֲ߳���Ӧ
	CBRspQryTradingAccount cbRspQryTradingAccount = 0;	///�����ѯ�ʽ��˻���Ӧ
	CBRspQryEWarrantOffset cbRspQryEWarrantOffset = 0;
	CBRspQryInvestor cbRspQryInvestor = 0;	///�����ѯͶ������Ӧ
	CBRspQryTradingCode cbRspQryTradingCode = 0;	///�����ѯ���ױ�����Ӧ
	CBRspQryInstrumentMarginRate cbRspQryInstrumentMarginRate = 0;	///�����ѯ��Լ��֤������Ӧ
	CBRspQryInstrumentCommissionRate cbRspQryInstrumentCommissionRate = 0;	///�����ѯ��Լ����������Ӧ
	CBRspQryExchange cbRspQryExchange = 0;	///�����ѯ��������Ӧ
	CBRspQryInstrument cbRspQryInstrument = 0;	///�����ѯ��Լ��Ӧ
	CBRspQryDepthMarketData cbRspQryDepthMarketData = 0;	///�����ѯ������Ӧ
	CBRspQrySettlementInfo cbRspQrySettlementInfo = 0;	///�����ѯͶ���߽�������Ӧ
	CBRspQryTransferBank cbRspQryTransferBank = 0;	///�����ѯת��������Ӧ
	CBRspQryInvestorPositionDetail cbRspQryInvestorPositionDetail = 0;	///�����ѯͶ���ֲ߳���ϸ��Ӧ
	CBRspQryNotice cbRspQryNotice = 0;	///�����ѯ�ͻ�֪ͨ��Ӧ
	CBRspQrySettlementInfoConfirm cbRspQrySettlementInfoConfirm = 0;	///�����ѯ������Ϣȷ����Ӧ
	CBRspQryInvestorPositionCombineDetail cbRspQryInvestorPositionCombineDetail = 0;	///�����ѯͶ���ֲ߳���ϸ��Ӧ
	CBRspQryCFMMCTradingAccountKey cbRspQryCFMMCTradingAccountKey = 0;	///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
	CBRspQryTransferSerial cbRspQryTransferSerial = 0;	///�����ѯת����ˮ��Ӧ
	CBRspQryAccountregister cbRspQryAccountregister = 0;///�����ѯ����ǩԼ��ϵ��Ӧ
	CBRspError cbRspError = 0;	///����Ӧ��
	CBRtnOrder cbRtnOrder = 0;	///����֪ͨ
	CBRtnTrade cbRtnTrade = 0;	///�ɽ�֪ͨ
	CBErrRtnOrderInsert cbErrRtnOrderInsert = 0;	///����¼�����ر�
	CBErrRtnOrderAction cbErrRtnOrderAction = 0;	///������������ر�
	CBRtnInstrumentStatus cbRtnInstrumentStatus = 0;	///��Լ����״̬֪ͨ
	CBRtnTradingNotice cbRtnTradingNotice = 0;	///����֪ͨ
	CBRtnErrorConditionalOrder cbRtnErrorConditionalOrder = 0;	///��ʾ������У�����
	CBRspQryContractBank cbRspQryContractBank = 0;	///�����ѯǩԼ������Ӧ
	CBRspQryParkedOrder cbRspQryParkedOrder = 0;	///�����ѯԤ����Ӧ
	CBRspQryParkedOrderAction cbRspQryParkedOrderAction = 0;	///�����ѯԤ�񳷵���Ӧ
	CBRspQryTradingNotice cbRspQryTradingNotice = 0;	///�����ѯ����֪ͨ��Ӧ
	CBRspQryBrokerTradingParams cbRspQryBrokerTradingParams = 0;	///�����ѯ���͹�˾���ײ�����Ӧ
	CBRspQryBrokerTradingAlgos cbRspQryBrokerTradingAlgos = 0;	///�����ѯ���͹�˾�����㷨��Ӧ
	CBRtnFromBankToFutureByBank cbRtnFromBankToFutureByBank = 0;	///���з��������ʽ�ת�ڻ�֪ͨ
	CBRtnFromFutureToBankByBank cbRtnFromFutureToBankByBank = 0;	///���з����ڻ��ʽ�ת����֪ͨ
	CBRtnRepealFromBankToFutureByBank cbRtnRepealFromBankToFutureByBank = 0;	///���з����������ת�ڻ�֪ͨ
	CBRtnRepealFromFutureToBankByBank cbRtnRepealFromFutureToBankByBank = 0;	///���з�������ڻ�ת����֪ͨ
	CBRtnFromBankToFutureByFuture cbRtnFromBankToFutureByFuture = 0;	///�ڻ����������ʽ�ת�ڻ�֪ͨ
	CBRtnFromFutureToBankByFuture cbRtnFromFutureToBankByFuture = 0;	///�ڻ������ڻ��ʽ�ת����֪ͨ
	CBRtnCancelAccountByBank cbRtnCancelAccountByBank = 0;
	CBRtnChangeAccountByBank cbRtnChangeAccountByBank = 0;
	CBRtnOpenAccountByBank cbRtnOpenAccountByBank = 0;
	CBRtnRepealFromBankToFutureByFutureManual cbRtnRepealFromBankToFutureByFutureManual = 0;	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
	CBRtnRepealFromFutureToBankByFutureManual cbRtnRepealFromFutureToBankByFutureManual = 0;	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
	CBRtnQueryBankBalanceByFuture cbRtnQueryBankBalanceByFuture = 0;	///�ڻ������ѯ�������֪ͨ
	CBErrRtnBankToFutureByFuture cbErrRtnBankToFutureByFuture = 0;	///�ڻ����������ʽ�ת�ڻ�����ر�
	CBErrRtnFutureToBankByFuture cbErrRtnFutureToBankByFuture = 0;	///�ڻ������ڻ��ʽ�ת���д���ر�
	CBErrRtnRepealBankToFutureByFutureManual cbErrRtnRepealBankToFutureByFutureManual = 0;	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
	CBErrRtnRepealFutureToBankByFutureManual cbErrRtnRepealFutureToBankByFutureManual = 0;	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
	CBErrRtnQueryBankBalanceByFuture cbErrRtnQueryBankBalanceByFuture = 0;	///�ڻ������ѯ����������ر�
	CBRtnRepealFromBankToFutureByFuture cbRtnRepealFromBankToFutureByFuture = 0;	///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
	CBRtnRepealFromFutureToBankByFuture cbRtnRepealFromFutureToBankByFuture = 0;	///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
	CBRspFromBankToFutureByFuture cbRspFromBankToFutureByFuture = 0;	///�ڻ����������ʽ�ת�ڻ�Ӧ��
	CBRspFromFutureToBankByFuture cbRspFromFutureToBankByFuture = 0;	///�ڻ������ڻ��ʽ�ת����Ӧ��
	CBRspQueryBankAccountMoneyByFuture cbRspQueryBankAccountMoneyByFuture = 0;	///�ڻ������ѯ�������Ӧ��
public:
	//���� : ��͸ģʽ����û���֤(ʯ��ƽ 2019 - 06 - 04)
	virtual void OnRspAuthenticate(CThostFtdcRspAuthenticateField *pRspAuthenticateField, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	///���ͻ����뽻�׺�̨������ͨ������ʱ����δ��¼ǰ�����÷��������á�
	virtual void OnFrontConnected();

	///���ͻ����뽻�׺�̨ͨ�����ӶϿ�ʱ���÷��������á���������������API���Զ��������ӣ��ͻ��˿ɲ�������
	virtual void OnFrontDisconnected(int nReason);

	///������ʱ���档����ʱ��δ�յ�����ʱ���÷��������á�
	virtual void OnHeartBeatWarning(int nTimeLapse);
	///��¼������Ӧ
	virtual void OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�ǳ�������Ӧ
	virtual void OnRspUserLogout(CThostFtdcUserLogoutField *pUserLogout, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�û��������������Ӧ
	virtual void OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField *pUserPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�ʽ��˻��������������Ӧ
	virtual void OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField *pTradingAccountPasswordUpdate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///����¼��������Ӧ
	virtual void OnRspOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///Ԥ��¼��������Ӧ
	virtual void OnRspParkedOrderInsert(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///Ԥ�񳷵�¼��������Ӧ
	virtual void OnRspParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///��������������Ӧ
	virtual void OnRspOrderAction(CThostFtdcInputOrderActionField *pInputOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///��ѯ��󱨵�������Ӧ
	virtual void OnRspQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField *pQueryMaxOrderVolume, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///Ͷ���߽�����ȷ����Ӧ
	virtual void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///ɾ��Ԥ����Ӧ
	virtual void OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField *pRemoveParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///ɾ��Ԥ�񳷵���Ӧ
	virtual void OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField *pRemoveParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ������Ӧ
	virtual void OnRspQryOrder(CThostFtdcOrderField *pOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ�ɽ���Ӧ
	virtual void OnRspQryTrade(CThostFtdcTradeField *pTrade, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯͶ���ֲ߳���Ӧ
	virtual void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField *pInvestorPosition, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ�ʽ��˻���Ӧ
	virtual void OnRspQryTradingAccount(CThostFtdcTradingAccountField *pTradingAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯͶ������Ӧ
	virtual void OnRspQryInvestor(CThostFtdcInvestorField *pInvestor, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ���ױ�����Ӧ
	virtual void OnRspQryTradingCode(CThostFtdcTradingCodeField *pTradingCode, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ��Լ��֤������Ӧ
	virtual void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField *pInstrumentMarginRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ��Լ����������Ӧ
	virtual void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField *pInstrumentCommissionRate, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ��������Ӧ
	virtual void OnRspQryExchange(CThostFtdcExchangeField *pExchange, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ��Լ��Ӧ
	virtual void OnRspQryInstrument(CThostFtdcInstrumentField *pInstrument, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ������Ӧ
	virtual void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField *pDepthMarketData, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯͶ���߽�������Ӧ
	virtual void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField *pSettlementInfo, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯת��������Ӧ
	virtual void OnRspQryTransferBank(CThostFtdcTransferBankField *pTransferBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯͶ���ֲ߳���ϸ��Ӧ
	virtual void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField *pInvestorPositionDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ�ͻ�֪ͨ��Ӧ
	virtual void OnRspQryNotice(CThostFtdcNoticeField *pNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ������Ϣȷ����Ӧ
	virtual void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField *pSettlementInfoConfirm, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯͶ���ֲ߳���ϸ��Ӧ
	virtual void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField *pInvestorPositionCombineDetail, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///��ѯ��֤����ϵͳ���͹�˾�ʽ��˻���Կ��Ӧ
	virtual void OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField *pCFMMCTradingAccountKey, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯת����ˮ��Ӧ
	virtual void OnRspQryTransferSerial(CThostFtdcTransferSerialField *pTransferSerial, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ����ǩԼ��ϵ��Ӧ
	virtual void OnRspQryAccountregister(CThostFtdcAccountregisterField *pAccountregister, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///����Ӧ��
	virtual void OnRspError(CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///����֪ͨ
	virtual void OnRtnOrder(CThostFtdcOrderField *pOrder);
	///�ɽ�֪ͨ
	virtual void OnRtnTrade(CThostFtdcTradeField *pTrade);
	///����¼�����ر�
	virtual void OnErrRtnOrderInsert(CThostFtdcInputOrderField *pInputOrder, CThostFtdcRspInfoField *pRspInfo);
	///������������ر�
	virtual void OnErrRtnOrderAction(CThostFtdcOrderActionField *pOrderAction, CThostFtdcRspInfoField *pRspInfo);
	///��Լ����״̬֪ͨ
	virtual void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField *pInstrumentStatus);
	///����֪ͨ
	virtual void OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField *pTradingNoticeInfo);
	///��ʾ������У�����
	virtual void OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField *pErrorConditionalOrder);
	///�����ѯǩԼ������Ӧ
	virtual void OnRspQryContractBank(CThostFtdcContractBankField *pContractBank, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯԤ����Ӧ
	virtual void OnRspQryParkedOrder(CThostFtdcParkedOrderField *pParkedOrder, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯԤ�񳷵���Ӧ
	virtual void OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField *pParkedOrderAction, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ����֪ͨ��Ӧ
	virtual void OnRspQryTradingNotice(CThostFtdcTradingNoticeField *pTradingNotice, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ���͹�˾���ײ�����Ӧ
	virtual void OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField *pBrokerTradingParams, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�����ѯ���͹�˾�����㷨��Ӧ
	virtual void OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField *pBrokerTradingAlgos, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///���з��������ʽ�ת�ڻ�֪ͨ
	virtual void OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField *pRspTransfer);
	///���з����ڻ��ʽ�ת����֪ͨ
	virtual void OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField *pRspTransfer);
	///���з����������ת�ڻ�֪ͨ
	virtual void OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField *pRspRepeal);
	///���з�������ڻ�ת����֪ͨ
	virtual void OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField *pRspRepeal);
	///�ڻ����������ʽ�ת�ڻ�֪ͨ
	virtual void OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField *pRspTransfer);
	///�ڻ������ڻ��ʽ�ת����֪ͨ
	virtual void OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField *pRspTransfer);
	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
	virtual void OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField *pRspRepeal);
	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
	virtual void OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField *pRspRepeal);
	///�ڻ������ѯ�������֪ͨ
	virtual void OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField *pNotifyQueryAccount);
	///�ڻ����������ʽ�ת�ڻ�����ر�
	virtual void OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo);
	///�ڻ������ڻ��ʽ�ת���д���ر�
	virtual void OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo);
	///ϵͳ����ʱ�ڻ����ֹ������������ת�ڻ�����ر�
	virtual void OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo);
	///ϵͳ����ʱ�ڻ����ֹ���������ڻ�ת���д���ر�
	virtual void OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField *pReqRepeal, CThostFtdcRspInfoField *pRspInfo);
	///�ڻ������ѯ����������ر�
	virtual void OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo);
	///�ڻ������������ת�ڻ��������д�����Ϻ��̷��ص�֪ͨ
	virtual void OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField *pRspRepeal);
	///�ڻ���������ڻ�ת�����������д�����Ϻ��̷��ص�֪ͨ
	virtual void OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField *pRspRepeal);
	///�ڻ����������ʽ�ת�ڻ�Ӧ��
	virtual void OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�ڻ������ڻ��ʽ�ת����Ӧ��
	virtual void OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField *pReqTransfer, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
	///�ڻ������ѯ�������Ӧ��
	virtual void OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField *pReqQueryAccount, CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast);

	//====================================
private:
	CThostFtdcRspInfoField* repareInfo(CThostFtdcRspInfoField *pRspInfo);
	// �Ƿ��յ��ɹ�����Ӧ
	bool IsErrorRspInfo(CThostFtdcRspInfoField *pRspInfo);
	// �Ƿ��ҵı����ر�
	bool IsMyOrder(CThostFtdcOrderField *pOrder);
	// �Ƿ����ڽ��׵ı���
	bool IsTradingOrder(CThostFtdcOrderField *pOrder);
};

class CTradeApi
{
public:
	CTradeApi(const char *pszFlowPath = "");

	~CTradeApi();
public:
	CThostFtdcTraderApi* pUserApi;
	CTraderSpi* pUserSpi;
};