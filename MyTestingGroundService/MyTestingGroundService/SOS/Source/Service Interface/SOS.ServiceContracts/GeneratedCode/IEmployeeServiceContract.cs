//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Net.Security;
using WCF = global::System.ServiceModel;

namespace SOS.ServiceContracts
{
	/// <summary>
	/// Service Contract Class - EmployeeServiceContract
	/// </summary>
	[WCF::ServiceContract(Namespace = "http://MyTestingGroundService.Model/2011/MyTestingGroundService", Name = "EmployeeServiceContract", SessionMode = WCF::SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None )]
	public partial interface IEmployeeServiceContract 
	{
		[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "GetEmployees", ProtectionLevel = ProtectionLevel.None)]
		SOS.MessageContracts.EmployeeResponse GetEmployees();
		
[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "GetPurchaseOrderDetails", ProtectionLevel = ProtectionLevel.None)]
		SOS.MessageContracts.PurchaseOrderDetailsResponse GetPurchaseOrderDetails(SOS.MessageContracts.PurchaseOrderDetailsRequest request);
		
	}
}

