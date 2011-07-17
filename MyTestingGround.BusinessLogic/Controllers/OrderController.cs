using System.Collections.Generic;
using MyTestingGround.DataAccess.Repository;
using MyTestingGround.DomainObjects;

namespace MyTestingGround.BusinessLogic.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderController
    {
        #region ---------------------- PRIVATE PROPERTIES ----------------------
        private readonly IPurchaseOrderRepository purchaseOrderRepository;
        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------

        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------
        /// <summary>
        /// 
        /// </summary>
        public OrderController()
        {
            purchaseOrderRepository = new PurchaseOrderRepositoryEF();
        }
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------


        /// <summary>
        /// Retrieves the employee purchase order details.
        /// </summary>
        /// <param name="orderHeader">The order header.</param>
        /// <returns></returns>
        public IEnumerable<IPurchaseOrderHeader> PurchaseOrderDetails(IPurchaseOrderHeader orderHeader)
        {

            IEnumerable<IPurchaseOrderHeader> purchaseOrderDetails = purchaseOrderRepository.FindDetails((p) =>
            {
                return (p as PurchaseOrderHeader).PurchaseOrderID == (orderHeader as PurchaseOrderHeader).PurchaseOrderID ? true : false;
            });

            return purchaseOrderDetails;
        }


        /// <summary>
        /// Retrieves the product details
        /// </summary>
        /// <param name="orderHeader">The order header.</param>
        /// <returns></returns>
        public IEnumerable<IProduct> ProductDetails(IProduct product)
        {
            using (ProductRepositoryEF productRepository = new ProductRepositoryEF())
            {
                IEnumerable<IProduct> productDetails = productRepository.FindWhere((p) =>
                {
                    return (p as Product).ProductID == (product as Product).ProductID ? true : false;
                });

                return productDetails;
            }           
        }
        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}
