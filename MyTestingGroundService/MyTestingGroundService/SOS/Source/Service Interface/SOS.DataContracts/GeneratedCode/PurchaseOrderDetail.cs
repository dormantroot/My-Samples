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
	/// Data Contract Class - PurchaseOrderDetail
	/// </summary>	
	[WcfSerialization::DataContract(Namespace = "http://MyTestingGroundService.Model/2011/MyTestingGroundService", Name = "PurchaseOrderDetail")]
	public partial class PurchaseOrderDetail 
	{
		private System.DateTime dueDate;
		private int orderQty;
		private decimal unitPrice;
		private decimal lineTotal;
		private decimal receivedQty;
		private int productID;
		
		[WcfSerialization::DataMember(Name = "DueDate", IsRequired = false, Order = 0)]
		public System.DateTime DueDate
		{
		  get { return dueDate; }
		  set { dueDate = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "OrderQty", IsRequired = false, Order = 1)]
		public int OrderQty
		{
		  get { return orderQty; }
		  set { orderQty = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "UnitPrice", IsRequired = false, Order = 2)]
		public decimal UnitPrice
		{
		  get { return unitPrice; }
		  set { unitPrice = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "LineTotal", IsRequired = false, Order = 3)]
		public decimal LineTotal
		{
		  get { return lineTotal; }
		  set { lineTotal = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "ReceivedQty", IsRequired = false, Order = 4)]
		public decimal ReceivedQty
		{
		  get { return receivedQty; }
		  set { receivedQty = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "ProductID", IsRequired = false, Order = 5)]
		public int ProductID
		{
		  get { return productID; }
		  set { productID = value; }
		}				
	}
}

