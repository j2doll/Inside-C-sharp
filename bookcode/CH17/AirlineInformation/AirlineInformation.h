/* this ALWAYS GENERATED file contains the definitions for the interfaces */


/* File created by MIDL compiler version 5.01.0164 */
/* at Tue Jan 30 20:08:55 2001
 */
/* Compiler settings for C:\AravindDOTNETSamples\AirlineInformation\AirlineInformation.idl:
    Oicf (OptLev=i2), W1, Zp8, env=Win32, ms_ext, c_ext
    error checks: allocation ref bounds_check enum stub_data 
*/
//@@MIDL_FILE_HEADING(  )


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 440
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __AirlineInformation_h__
#define __AirlineInformation_h__

#ifdef __cplusplus
extern "C"{
#endif 

/* Forward Declarations */ 

#ifndef __IAirlineInfo_FWD_DEFINED__
#define __IAirlineInfo_FWD_DEFINED__
typedef interface IAirlineInfo IAirlineInfo;
#endif 	/* __IAirlineInfo_FWD_DEFINED__ */


#ifndef __IAirportFacilitiesInfo_FWD_DEFINED__
#define __IAirportFacilitiesInfo_FWD_DEFINED__
typedef interface IAirportFacilitiesInfo IAirportFacilitiesInfo;
#endif 	/* __IAirportFacilitiesInfo_FWD_DEFINED__ */


#ifndef __IAirportFacilitiesInfo_FWD_DEFINED__
#define __IAirportFacilitiesInfo_FWD_DEFINED__
typedef interface IAirportFacilitiesInfo IAirportFacilitiesInfo;
#endif 	/* __IAirportFacilitiesInfo_FWD_DEFINED__ */


#ifndef __AirlineInfo_FWD_DEFINED__
#define __AirlineInfo_FWD_DEFINED__

#ifdef __cplusplus
typedef class AirlineInfo AirlineInfo;
#else
typedef struct AirlineInfo AirlineInfo;
#endif /* __cplusplus */

#endif 	/* __AirlineInfo_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

void __RPC_FAR * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void __RPC_FAR * ); 

#ifndef __IAirlineInfo_INTERFACE_DEFINED__
#define __IAirlineInfo_INTERFACE_DEFINED__

/* interface IAirlineInfo */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_IAirlineInfo;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("BE246480-1FDD-4A17-B07D-6A90D49F2174")
    IAirlineInfo : public IDispatch
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetAirlineTiming( 
            /* [in] */ BSTR bstrAirline,
            /* [retval][out] */ BSTR __RPC_FAR *pBstrDetails) = 0;
        
        virtual /* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE get_LocalTimeAtOrlando( 
            /* [retval][out] */ BSTR __RPC_FAR *pVal) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IAirlineInfoVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            IAirlineInfo __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            IAirlineInfo __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            IAirlineInfo __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            IAirlineInfo __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            IAirlineInfo __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            IAirlineInfo __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            IAirlineInfo __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetAirlineTiming )( 
            IAirlineInfo __RPC_FAR * This,
            /* [in] */ BSTR bstrAirline,
            /* [retval][out] */ BSTR __RPC_FAR *pBstrDetails);
        
        /* [helpstring][id][propget] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *get_LocalTimeAtOrlando )( 
            IAirlineInfo __RPC_FAR * This,
            /* [retval][out] */ BSTR __RPC_FAR *pVal);
        
        END_INTERFACE
    } IAirlineInfoVtbl;

    interface IAirlineInfo
    {
        CONST_VTBL struct IAirlineInfoVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IAirlineInfo_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IAirlineInfo_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IAirlineInfo_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IAirlineInfo_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define IAirlineInfo_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define IAirlineInfo_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define IAirlineInfo_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define IAirlineInfo_GetAirlineTiming(This,bstrAirline,pBstrDetails)	\
    (This)->lpVtbl -> GetAirlineTiming(This,bstrAirline,pBstrDetails)

#define IAirlineInfo_get_LocalTimeAtOrlando(This,pVal)	\
    (This)->lpVtbl -> get_LocalTimeAtOrlando(This,pVal)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IAirlineInfo_GetAirlineTiming_Proxy( 
    IAirlineInfo __RPC_FAR * This,
    /* [in] */ BSTR bstrAirline,
    /* [retval][out] */ BSTR __RPC_FAR *pBstrDetails);


void __RPC_STUB IAirlineInfo_GetAirlineTiming_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


/* [helpstring][id][propget] */ HRESULT STDMETHODCALLTYPE IAirlineInfo_get_LocalTimeAtOrlando_Proxy( 
    IAirlineInfo __RPC_FAR * This,
    /* [retval][out] */ BSTR __RPC_FAR *pVal);


void __RPC_STUB IAirlineInfo_get_LocalTimeAtOrlando_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IAirlineInfo_INTERFACE_DEFINED__ */


#ifndef __IAirportFacilitiesInfo_INTERFACE_DEFINED__
#define __IAirportFacilitiesInfo_INTERFACE_DEFINED__

/* interface IAirportFacilitiesInfo */
/* [unique][helpstring][dual][uuid][object] */ 


EXTERN_C const IID IID_IAirportFacilitiesInfo;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("3E918A69-A7F8-4036-9C21-04FB1AAF1C87")
    IAirportFacilitiesInfo : public IDispatch
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetInternetCafeLocations( 
            /* [retval][out] */ BSTR __RPC_FAR *pBstrLocationDetails) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IAirportFacilitiesInfoVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            IAirportFacilitiesInfo __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            IAirportFacilitiesInfo __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            IAirportFacilitiesInfo __RPC_FAR * This);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfoCount )( 
            IAirportFacilitiesInfo __RPC_FAR * This,
            /* [out] */ UINT __RPC_FAR *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetTypeInfo )( 
            IAirportFacilitiesInfo __RPC_FAR * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo __RPC_FAR *__RPC_FAR *ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetIDsOfNames )( 
            IAirportFacilitiesInfo __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR __RPC_FAR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID __RPC_FAR *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *Invoke )( 
            IAirportFacilitiesInfo __RPC_FAR * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS __RPC_FAR *pDispParams,
            /* [out] */ VARIANT __RPC_FAR *pVarResult,
            /* [out] */ EXCEPINFO __RPC_FAR *pExcepInfo,
            /* [out] */ UINT __RPC_FAR *puArgErr);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE __RPC_FAR *GetInternetCafeLocations )( 
            IAirportFacilitiesInfo __RPC_FAR * This,
            /* [retval][out] */ BSTR __RPC_FAR *pBstrLocationDetails);
        
        END_INTERFACE
    } IAirportFacilitiesInfoVtbl;

    interface IAirportFacilitiesInfo
    {
        CONST_VTBL struct IAirportFacilitiesInfoVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IAirportFacilitiesInfo_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IAirportFacilitiesInfo_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IAirportFacilitiesInfo_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IAirportFacilitiesInfo_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define IAirportFacilitiesInfo_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define IAirportFacilitiesInfo_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define IAirportFacilitiesInfo_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define IAirportFacilitiesInfo_GetInternetCafeLocations(This,pBstrLocationDetails)	\
    (This)->lpVtbl -> GetInternetCafeLocations(This,pBstrLocationDetails)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IAirportFacilitiesInfo_GetInternetCafeLocations_Proxy( 
    IAirportFacilitiesInfo __RPC_FAR * This,
    /* [retval][out] */ BSTR __RPC_FAR *pBstrLocationDetails);


void __RPC_STUB IAirportFacilitiesInfo_GetInternetCafeLocations_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IAirportFacilitiesInfo_INTERFACE_DEFINED__ */



#ifndef __AIRLINEINFORMATIONLib_LIBRARY_DEFINED__
#define __AIRLINEINFORMATIONLib_LIBRARY_DEFINED__

/* library AIRLINEINFORMATIONLib */
/* [helpstring][version][uuid] */ 



EXTERN_C const IID LIBID_AIRLINEINFORMATIONLib;

EXTERN_C const CLSID CLSID_AirlineInfo;

#ifdef __cplusplus

class DECLSPEC_UUID("F29EAEEE-D445-403B-B89E-C8C502B115D8")
AirlineInfo;
#endif
#endif /* __AIRLINEINFORMATIONLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

unsigned long             __RPC_USER  BSTR_UserSize(     unsigned long __RPC_FAR *, unsigned long            , BSTR __RPC_FAR * ); 
unsigned char __RPC_FAR * __RPC_USER  BSTR_UserMarshal(  unsigned long __RPC_FAR *, unsigned char __RPC_FAR *, BSTR __RPC_FAR * ); 
unsigned char __RPC_FAR * __RPC_USER  BSTR_UserUnmarshal(unsigned long __RPC_FAR *, unsigned char __RPC_FAR *, BSTR __RPC_FAR * ); 
void                      __RPC_USER  BSTR_UserFree(     unsigned long __RPC_FAR *, BSTR __RPC_FAR * ); 

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif
