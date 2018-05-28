using Northwind.DAL;
using Northwind.DAL.Model;
using Northwind.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Northwind.Controllers
{
    [System.Web.Http.RoutePrefix("api/Order")]
    public class OrderController : ApiController
    {
        private OrdersDAO _ordersDAO;

        public OrderController()
        {
            _ordersDAO = new OrdersDAO();
        }


        [System.Web.Http.HttpGet, System.Web.Http.Route("orderTable")]
        // GET: api/Order/orderTable?ID=10248 
        public HttpResponseMessage Get(int ID)
        {
            HttpResponseMessage resp;
            Orders ord = new Orders();

            var data = _ordersDAO.Get(ID);
            ord.CustomerID = data.CustomerID;
            ord.EmployeeID = data.EmployeeID;
            ord.OrderDate = data.OrderDate;
            ord.ShipName = data.ShipName;
            ord.ShipAddress = data.ShipAddress;
            ord.ShipCity = data.ShipCity;
            ord.ShipRegion = data.ShipRegion;
            ord.ShipPostalCode = data.ShipPostalCode;
            ord.ShipCountry = data.ShipCountry;
            var result = ord;
            resp = Request.CreateResponse(HttpStatusCode.OK, result);
            return resp;
        }

        [System.Web.Http.HttpPost, System.Web.Http.Route("PostOrderTable")]
        // POST: api/Order/PostOrderTable
        //PostMan test 
        //{ 
        //"CustomerID":"LILAS",
        //"EmployeeID":2,
        //"OrderDate":"1998-05-04 00:00:00.000",
        //"RequiredDate":"1998-06-01 00:00:00.000",
        //"ShippedDate": "1998-05-06 00:00:00.000",
        //"ShipVia": 2,
        //"Freight": 15.67,
        //"ShipName":"Tortuga Restaurante",
        //"ShipAddress":"Avda. Azteca 123" ,
        //"ShipCity": "México D.F." ,
        //"ShipRegion": "" ,
        //"ShipPostalCode": "05033",
        //"ShipCountry": "Mexico"
        //}
        public HttpResponseMessage PostOrder(Orders order)
        {
            HttpResponseMessage resp;
            Orders ord = new Orders();

            var orderId = _ordersDAO.Create(order);


            var result = ord;
            resp = Request.CreateResponse(HttpStatusCode.OK, result);
            return resp;
        }

        [System.Web.Http.HttpPost, System.Web.Http.Route("PutOrderTable")]
        // PUT: api/Order/PutOrderTable?ID=10248
        public HttpResponseMessage PutOrder(int ID)
        {
            HttpResponseMessage resp;
            Orders ord = new Orders();

            _ordersDAO.Update(ID);

            var result = ord;
            resp = Request.CreateResponse(HttpStatusCode.OK, result);
            return resp;
        }

        [System.Web.Http.HttpPost, System.Web.Http.Route("DeleteOrderTable")]
        // DELETE: api/Order/DeleteOrderTable?ID=11077
        public HttpResponseMessage DeleteOrder(int ID)
        {
            HttpResponseMessage resp;
            Orders ord = new Orders();

            var data = _ordersDAO.Get(ID);

            if (data == null)
            {
                return null;
            }
            _ordersDAO.Delete(ID);

            var result = data;
            resp = Request.CreateResponse(HttpStatusCode.OK, result);
            return resp;
        }


        private bool OrderExists(int ID)
        {
            return _ordersDAO.IsExists(ID);
        }
    }
}