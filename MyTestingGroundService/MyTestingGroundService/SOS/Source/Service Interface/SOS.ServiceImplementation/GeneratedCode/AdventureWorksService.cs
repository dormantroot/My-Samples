//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using WCF = global::System.ServiceModel;

namespace SOS.ServiceImplementation
{	
	/// <summary>
	/// Service Class - AdventureWorksService
	/// </summary>
	[WCF::ServiceBehavior(Name = "AdventureWorksService", 
		Namespace = "http://MyTestingGroundService.Model/2011/MyTestingGroundService", 
		InstanceContextMode = WCF::InstanceContextMode.PerSession, 
		ConcurrencyMode = WCF::ConcurrencyMode.Single )]
	public abstract class AdventureWorksServiceBase : SOS.ServiceContracts.IEmployeeServiceContract
	{
		#region EmployeeServiceContract Members

		public virtual SOS.MessageContracts.EmployeeResponse GetEmployees()
		{
			return null;
		}

		public virtual SOS.MessageContracts.PurchaseOrderDetailsResponse GetPurchaseOrderDetails(SOS.MessageContracts.PurchaseOrderDetailsRequest request)
		{
			return null;
		}

		#endregion		
		
	}
	
	public partial class AdventureWorksService : AdventureWorksServiceBase
	{
	}
	
}

