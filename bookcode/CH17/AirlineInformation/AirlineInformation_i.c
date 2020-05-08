/* this file contains the actual definitions of */
/* the IIDs and CLSIDs */

/* link this file in with the server and any clients */


/* File created by MIDL compiler version 5.01.0164 */
/* at Tue Jan 30 20:08:55 2001
 */
/* Compiler settings for C:\AravindDOTNETSamples\AirlineInformation\AirlineInformation.idl:
    Oicf (OptLev=i2), W1, Zp8, env=Win32, ms_ext, c_ext
    error checks: allocation ref bounds_check enum stub_data 
*/
//@@MIDL_FILE_HEADING(  )
#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

const IID IID_IAirlineInfo = {0xBE246480,0x1FDD,0x4A17,{0xB0,0x7D,0x6A,0x90,0xD4,0x9F,0x21,0x74}};


const IID IID_IAirportFacilitiesInfo = {0x3E918A69,0xA7F8,0x4036,{0x9C,0x21,0x04,0xFB,0x1A,0xAF,0x1C,0x87}};


const IID LIBID_AIRLINEINFORMATIONLib = {0x4A11EAD9,0x6D41,0x4013,{0x81,0xBF,0x19,0x6A,0xFC,0x1E,0xB3,0xF9}};


const CLSID CLSID_AirlineInfo = {0xF29EAEEE,0xD445,0x403B,{0xB8,0x9E,0xC8,0xC5,0x02,0xB1,0x15,0xD8}};


#ifdef __cplusplus
}
#endif

