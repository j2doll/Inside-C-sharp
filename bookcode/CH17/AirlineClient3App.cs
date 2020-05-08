using System;
using System.Runtime.InteropServices;
using System.Reflection;
using AIRLINEINFORMATIONLib;

public class AirlineClient3App
{
	public static void Main()
	{
		///////////////////////////////////////////////
		/// LATE BINDING
		///////////////////////////////////////////////
		try
		{
			object objAirlineLateBound;
			Type objTypeAirline;

			object[] arrayInputParams= { "Air Scooby IC 5678" };

			objTypeAirline = Type.GetTypeFromProgID
								("AirlineInformation.AirlineInfo");

			objAirlineLateBound = Activator.CreateInstance
								(objTypeAirline);

			String str = (String)objTypeAirline.InvokeMember
						("GetAirlineTiming",
						 BindingFlags.Default |	
						 BindingFlags.InvokeMethod,
						 null, objAirlineLateBound,
						 arrayInputParams);

			Console.WriteLine("{0}",str);

			String strTime = (String)objTypeAirline.InvokeMember
									("LocalTimeAtOrlando",
									 BindingFlags.Default | 
									 BindingFlags.GetProperty, 
									 null, objAirlineLateBound,
									 new object [] {});

			Console.WriteLine ("Hi there !. The Local Time in " +
 						 "Orlando,Florida is: {0}", strTime);
		}
		catch(COMException e)
		{
			Console.WriteLine("Oops- We encountered an error " + 
							"for Airline {0}. The Error message " +
							"is : {1}. The Error code is {2}",
							strFoodJunkieAirline,
							e.Message,e.ErrorCode);			  	
		}
	}
}

