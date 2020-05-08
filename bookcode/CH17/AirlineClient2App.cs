using System;
using System.Runtime.InteropServices;
using System.Reflection;
using AIRLINEINFORMATIONLib;

public class AirlineClient2App
{
	public static void Main()
	{
		///////////////////////////////////////////////
		/// QUERY INTERFACE/ RT type Checking
		///////////////////////////////////////////////
		try	
		{
			AirlineInfo objAirlineInfo;
			IAirportFacilitiesInfo objFacilitiesInfo;

			// Create a new AirlineInfo object	
			objAirlineInfo = new AirlineInfo();

			// Invoke the GetAirlineTiming method	
			String strDetails = objAirlineInfo.GetAirlineTiming
												(strAirline);	

			// QI for the IAirportFacilitiesInfo interface		
			objFacilitiesInfo = (IAirportFacilitiesInfo)objAirlineInfo;

			//Invoke a method on the IAirportFacilitiesInfo interface
			Console.WriteLine("{0}",
						objFacilitiesInfo.GetInternetCafeLocations());
		}
		catch(InvalidCastException eCast)
		{	
			Console.WriteLine("We got an InvalidCast Exception " + 
							"- Message is {0}",eCast.Message);   
		}
	}
}

