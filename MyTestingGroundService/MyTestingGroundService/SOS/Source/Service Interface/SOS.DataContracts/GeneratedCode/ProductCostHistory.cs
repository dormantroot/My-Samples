//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace SOS.DataContracts
{
	/// <summary>
	/// Data Contract Class - ProductCostHistory
	/// </summary>	
	[WcfSerialization::DataContract(Namespace = "http://MyTestingGroundService.Model/2011/MyTestingGroundService", Name = "ProductCostHistory")]
	public partial class ProductCostHistory 
	{
		private int productID;
		private System.DateTime startDate;
		private System.DateTime endDate;
		private double standardCost;
		private System.DateTime modifiedDate;
		
		[WcfSerialization::DataMember(Name = "ProductID", IsRequired = false, Order = 0)]
		public int ProductID
		{
		  get { return productID; }
		  set { productID = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "StartDate", IsRequired = false, Order = 1)]
		public System.DateTime StartDate
		{
		  get { return startDate; }
		  set { startDate = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "EndDate", IsRequired = false, Order = 2)]
		public System.DateTime EndDate
		{
		  get { return endDate; }
		  set { endDate = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "StandardCost", IsRequired = false, Order = 3)]
		public double StandardCost
		{
		  get { return standardCost; }
		  set { standardCost = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "ModifiedDate", IsRequired = false, Order = 4)]
		public System.DateTime ModifiedDate
		{
		  get { return modifiedDate; }
		  set { modifiedDate = value; }
		}				
	}
}
