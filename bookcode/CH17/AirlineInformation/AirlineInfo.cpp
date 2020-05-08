// AirlineInfo.cpp : Implementation of CAirlineInfo
#include "stdafx.h"
#include "comdef.h"
#include <time.h>
#include "AirlineInformation.h"
#include "AirlineInfo.h"

/////////////////////////////////////////////
// ERROR CODES
/////////////////////////////////////////////
#define AIRLINE_NOT_FOUND 0x80040002L

/////////////////////////////////////////////////////////////////////////////
// CAirlineInfo

/*
***************************************************************************
** FUNCTION: InterfaceSupportsErrorInfo
** DESCRIPTION: 
** PARAMETERS: 
**  (REFIID)riid
** RETURN VALUES: (STDMETHODIMP)
***************************************************************************
*/
STDMETHODIMP CAirlineInfo::InterfaceSupportsErrorInfo(REFIID riid)
{
	static const IID* arr[] = 
	{
		&IID_IAirlineInfo
	};
	for (int i=0; i < sizeof(arr) / sizeof(arr[0]); i++)
	{
		if (InlineIsEqualGUID(*arr[i],riid))
			return S_OK;
	}
	return S_FALSE;
}

/*
***************************************************************************
** FUNCTION: GetAirlineTiming
** DESCRIPTION: 
** PARAMETERS: 
**  (BSTR)bstrAirline
**  (BSTR)*pBstrTiming
** RETURN VALUES: (STDMETHODIMP)
***************************************************************************
*/
STDMETHODIMP CAirlineInfo::GetAirlineTiming(BSTR bstrAirline, BSTR *pBstrDetails)
{

	_bstr_t bstrQueryAirline(bstrAirline);
	if(NULL == pBstrDetails) return E_POINTER;
	
	// Check to see if this airline was found
	if(_bstr_t("Air Scooby IC 5678") == bstrQueryAirline)
	{
		// Return the timing for this Airline
		*pBstrDetails = _bstr_t(_T("16:45:00 - Will arrive at Terminal 3")).copy();

	}//if
	else
	{
		// Raise an error message 
		// (The Airline was not found)
		return Error(LPCTSTR(_T("Airline Timings not available for this Airline")), 
							  __uuidof(AirlineInfo),AIRLINE_NOT_FOUND);
	}

	return S_OK;
}


/*
***************************************************************************
** FUNCTION: GetInternetCafeLocations
** DESCRIPTION: 
** PARAMETERS: 
**  (BSTR *)pBstrLocationDetails
** RETURN VALUES: (STDMETHODIMP)
***************************************************************************
*/
STDMETHODIMP CAirlineInfo::GetInternetCafeLocations(BSTR * pBstrLocationDetails)
{
	// Check pointer validity
	if(pBstrLocationDetails == NULL) return E_POINTER;

	// Return the nearest location to the caller
	*pBstrLocationDetails = _bstr_t("Your nearest Internet Cafe is at Pavilion 3 in "
		"Terminal 2 - John Doe's Browse & Sip Cafe").copy();

	// Return the status
	return S_OK;


}

/*
***************************************************************************
** FUNCTION: get_LocalTimeAtOrlando
** DESCRIPTION: 
** PARAMETERS: 
**  (BSTR)*pVal
** RETURN VALUES: (STDMETHODIMP)
***************************************************************************
*/
STDMETHODIMP CAirlineInfo::get_LocalTimeAtOrlando(BSTR *pVal)
{
	
	// Local variables
	tm *tmLocalTime;
	time_t timeSys;

	// Get the System time
	time(&timeSys);

	//convert to time_t structure to a tm structure
	tmLocalTime = localtime(&timeSys);

	// Get the string equivalent of the tm structure
	*pVal = _bstr_t(asctime(tmLocalTime)).copy();

	// Return the status to the caller
	return S_OK;


}
