// MdApi.cpp : ���� DLL Ӧ�ó���ĵ���������
//
#include "stdafx.h"
#include "MdApi.h"
#include <iostream>
//#include <vector>		//��̬����,֧�ָ�ֵ
//using namespace std;

#include "ThostFtdcMdApi.h"

// UserApi����
CThostFtdcMdApi* pUserApi;

// ������
//int iRequestID = 0;

//�ص�����
CBOnRspError cbOnRspError=0;
CBOnHeartBeatWarning cbOnHeartBeatWarning=0;

CBOnFrontConnected cbOnFrontConnected=0;
CBOnFrontDisconnected cbOnFrontDisconnected=0;
CBOnRspUserLogin cbOnRspUserLogin=0;
CBOnRspUserLogout cbOnRspUserLogout=0;
CBOnRspSubMarketData cbOnRspSubMarketData=0;
CBOnRspUnSubMarketData cbOnRspUnSubMarketData=0;
CBOnRtnDepthMarketData cbOnRtnDepthMarketData=0;

/////ע��ǰ�õ�ַ
//extern "C" MDAPI_API void RegisterFront(char *pszFrontAddress)
//{
//	pUserApi->RegisterFront(pszFrontAddress);
//}

extern "C" MDAPI_API void CreateApi(char* pszFlowPath)
{
	pUserApi = CThostFtdcMdApi::CreateFtdcMdApi(pszFlowPath);			// ����UserApi
}

extern "C" MDAPI_API void RegisterFront(char* FRONT_ADDR)
{
	CMdSpi* pUserSpi = new CMdSpi();
	pUserApi->RegisterSpi((CThostFtdcMdSpi*)pUserSpi);			// ע���¼���
	//pUserApi->SubscribePublicTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// ע�ṫ����
	//pUserApi->SubscribePrivateTopic(THOST_TERT_QUICK/*THOST_TERT_RESTART*/);					// ע��˽����
	pUserApi->RegisterFront(FRONT_ADDR);							// connect
}
//����
//extern "C" MDAPI_API void Init(char* FRONT_ADDR, char *pszFlowPath)
//{	
//	pUserApi = CThostFtdcMdApi::CreateFtdcMdApi(pszFlowPath);			// ����UserApi
////pUserApi->RegisterSpi(pUserSpi);						// ע���¼���
//	//pUserApi->RegisterFront(FRONT_ADDR);					// connect
//	CThostFtdcMdSpi* pUserSpi = new CMdSpi();
//	pUserApi->RegisterSpi(pUserSpi);
//	pUserApi->Init();
////	pUserApi->Join();
//}

extern "C" MDAPI_API  void Init()
{
	pUserApi->Init();
	//pUserApi->Join();
}
//
//extern "C" MDAPI_API void RegisterSpi(CThostFtdcMdSpi* pUserSpi)
//{
//	CThostFtdcMdSpi* pUserSpi = new CMdSpi();
//	// ��ʼ��UserApi
//	//pUserApi = CThostFtdcMdApi::CreateFtdcMdApi(pszFlowPath);			// ����UserApi
//	pUserApi->RegisterSpi(pUserSpi);
//}

//extern "C" MDAPI_API void RegisterFront(char* FRONT_ADDR)
//{
//	pUserApi->RegisterFront(FRONT_ADDR);
//}

extern "C" MDAPI_API void DisConnect()
{
	pUserApi->Release();
}
//��¼
extern "C" MDAPI_API void ReqUserLogin(CThostFtdcReqUserLoginField req,int requestID)
{	
	//CThostFtdcReqUserLoginField req;
	//memset(&req, 0, sizeof(req));
	//strcpy_s(req.BrokerID, BROKER_ID);
	//strcpy_s(req.UserID, INVESTOR_ID);
	//strcpy_s(req.Password, PASSWORD);
	pUserApi->ReqUserLogin(&req, requestID);
}

///�ǳ�����
extern "C" MDAPI_API void ReqUserLogout(CThostFtdcUserLogoutField req,int requestID)
{
	//CThostFtdcUserLogoutField req;
	//memset(&req,0,sizeof(req));
	//strcpy_s(req.BrokerID,BROKER_ID);
	//strcpy_s(req.UserID,INVESTOR_ID);
	pUserApi->ReqUserLogout(&req, requestID);
}
//��������
extern "C" MDAPI_API void SubMarketData(char* instrumentsID[],int nCount)
{
	pUserApi->SubscribeMarketData(instrumentsID,nCount);
}
///�˶�����
extern "C" MDAPI_API void UnSubscribeMarketData(char *ppInstrumentID[], int nCount)
{
	pUserApi->UnSubscribeMarketData(ppInstrumentID, nCount);
}
///��ȡ��ǰ������:ֻ�е�¼�ɹ���,���ܵõ���ȷ�Ľ�����
extern "C" MDAPI_API const char *GetTradingDay()
{
	return pUserApi->GetTradingDay();
}

//============================================ �ص� ����ע�� ===========================================
extern "C" MDAPI_API void WINAPI RegOnRspError(CBOnRspError cb)
{
	cbOnRspError= cb;
}
//����
extern "C" MDAPI_API void WINAPI RegOnHeartBeatWarning(CBOnHeartBeatWarning cb)
{
	cbOnHeartBeatWarning = cb;
}

//����Ӧ��
extern "C" MDAPI_API void WINAPI RegOnFrontConnected(CBOnFrontConnected cb)
{
		cbOnFrontConnected=cb;
}
//���ӶϿ�
extern "C" MDAPI_API void WINAPI RegOnFrontDisconnected(CBOnFrontDisconnected cb)
{
		cbOnFrontDisconnected=cb;
}
//��¼����Ӧ��
extern "C" MDAPI_API void WINAPI RegOnRspUserLogin(CBOnRspUserLogin cb)
{
		cbOnRspUserLogin=cb;
}
//�ǳ�����Ӧ��
extern "C" MDAPI_API void WINAPI RegOnRspUserLogout(CBOnRspUserLogout cb)
{
		cbOnRspUserLogout=cb;
}
//��������Ӧ��
extern "C" MDAPI_API void WINAPI RegOnRspSubMarketData(CBOnRspSubMarketData cb)
{
		cbOnRspSubMarketData=cb;
}

//�˶�����Ӧ��
extern "C" MDAPI_API void WINAPI RegOnRspUnSubMarketData(CBOnRspUnSubMarketData cb)
{
		cbOnRspUnSubMarketData=cb;
}
//�������֪ͨ
extern "C" MDAPI_API void WINAPI RegOnRtnDepthMarketData(CBOnRtnDepthMarketData cb)
{
		cbOnRtnDepthMarketData=cb;
}