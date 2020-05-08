using System;
using System.Runtime.InteropServices;
using System.Reflection;
using AIRLINEINFORMATIONLib;

public class AirlineClient1App
{
	public static void Main()
	{
		///////////////////////////////////////////////
		/// EARLY BINDING EXAMPLE
		///////////////////////////////////////////////
		String strAirline = "Air Scooby IC 5678";
		String strFoodJunkieAirline = "Air Jughead TX 1234";
		try
		{
			AirlineInfo objAirlineInfo;

			// Create a new AirlineInfo Object
			objAirlineInfo = new AirlineInfo();	

			// Display the output after calling 
			// the GetAirileTiming method.
			Console.WriteLine("Details for Airline {0} --> {1}",
			strAirline,objAirlineInfo.GetAirlineTiming(strAirline)); 

			// ERROR: The following will result in a thrown exception!
			// Console.WriteLine("Details for Airline {0} --> {1}",
			// strFoodJunkieAirline,objAirlineInfo.GetAirlineTiming
			// (strFoodJunkieAirline)); 
		}
		catch(COMException e)
		{
			Console.WriteLine("Oops- We encountered an error " +
							"for Airline {0}. The Error message " +
							"is : {1}. The  Error code is {2}",	
							strFoodJunkieAirline ,
							e.Message,e.ErrorCode);			  	
		}
	}
}

