// AirlineInfo.h : Declaration of the CAirlineInfo

#ifndef __AIRLINEINFO_H_
#define __AIRLINEINFO_H_

#include "resource.h"       // main symbols

/////////////////////////////////////////////////////////////////////////////
// CAirlineInfo
class ATL_NO_VTABLE CAirlineInfo : 
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CAirlineInfo, &CLSID_AirlineInfo>,
	public ISupportErrorInfo,
	public IDispatchImpl<IAirlineInfo, &IID_IAirlineInfo, &LIBID_AIRLINEINFORMATIONLib>,
	public IDispatchImpl<IAirportFacilitiesInfo, &IID_IAirportFacilitiesInfo, &LIBID_AIRLINEINFORMATIONLib>
{
public:
	CAirlineInfo()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_AIRLINEINFO)
DECLARE_NOT_AGGREGATABLE(CAirlineInfo)
 
DECLARE_PROTECT_FINAL_CONSTRUCT()

BEGIN_COM_MAP(CAirlineInfo)
	COM_INTERFACE_ENTRY(IAirlineInfo)
	COM_INTERFACE_ENTRY2(IDispatch, IAirlineInfo)
	COM_INTERFACE_ENTRY(ISupportErrorInfo)
	COM_INTERFACE_ENTRY(IAirportFacilitiesInfo)
END_COM_MAP()

// ISupportsErrorInfo
	STDMETHOD(InterfaceSupportsErrorInfo)(REFIID riid);


public:
	// IAirlineInfo
	STDMETHOD(get_LocalTimeAtOrlando)(/*[out, retval]*/ BSTR *pVal);

	STDMETHOD(GetAirlineTiming)(/*[in]*/ BSTR bstrAirline, 
								/*[out,retval]*/ BSTR* pBstrTiming);
		


	// IAirportFacilitiesInfo
	STDMETHOD(GetInternetCafeLocations)(BSTR * pBstrLocationDetails);
	
};

#endif //__AIRLINEINFO_H_
