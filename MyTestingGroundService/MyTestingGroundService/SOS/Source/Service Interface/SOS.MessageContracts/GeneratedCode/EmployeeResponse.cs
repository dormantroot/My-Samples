
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

namespace SOS.MessageContracts
{
	/// <summary>
	/// Service Contract Class - EmployeeResponse
	/// </summary>
	[WCF::MessageContract(IsWrapped = false)] 
	public partial class EmployeeResponse
	{
		private SOS.DataContracts.Employees employees;
	 		
		[WCF::MessageBodyMember(Namespace = "http://MyTestingGroundService.Model/2011/MyTestingGroundService", Name = "Employees")]
		public SOS.DataContracts.Employees Employees
		{
			get { return employees; }
			set { employees = value; }
		}
	}
}
