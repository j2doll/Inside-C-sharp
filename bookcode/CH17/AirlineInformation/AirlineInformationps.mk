
AirlineInformationps.dll: dlldata.obj AirlineInformation_p.obj AirlineInformation_i.obj
	link /dll /out:AirlineInformationps.dll /def:AirlineInformationps.def /entry:DllMain dlldata.obj AirlineInformation_p.obj AirlineInformation_i.obj \
		kernel32.lib rpcndr.lib rpcns4.lib rpcrt4.lib oleaut32.lib uuid.lib \

.c.obj:
	cl /c /Ox /DWIN32 /D_WIN32_WINNT=0x0400 /DREGISTER_PROXY_DLL \
		$<

clean:
	@del AirlineInformationps.dll
	@del AirlineInformationps.lib
	@del AirlineInformationps.exp
	@del dlldata.obj
	@del AirlineInformation_p.obj
	@del AirlineInformation_i.obj
