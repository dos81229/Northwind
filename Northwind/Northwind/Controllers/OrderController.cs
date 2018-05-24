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
    public class OrderController : ApiController
    {

        private OrdersDAO _ordersDAO;

        public OrderController()
        {
            //_customersDAO = new CustomersDAO();
            _ordersDAO = new OrdersDAO();
        }

      

        [System.Web.Http.HttpGet, System.Web.Http.Route("customerTable")]
        // GET: api/Order/customerTable
        public HttpResponseMessage Get(int ID)
        {
            HttpResponseMessage resp;
            Customers cus = new Customers();
            cus.CustomerID = "001";
            cus.CompanyName = "";
            cus.ContactName = "";
            cus.ContactTitle = "";
            cus.Address = "";
            cus.City = "";
            cus.Region = "";
            cus.PostalCode = "";
            cus.Country = "";
            cus.Phone = "";
            cus.Fax = "";
            var result = cus;
            resp = Request.CreateResponse(HttpStatusCode.OK, result);
            return resp;
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //try
            //{
            //    var data = _ordersDAO.Get(ID);

            //    if (data == null)
            //        return HttpNotFound(data);

            //    return Ok(data);

            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}

        }

        [System.Web.Http.HttpGet, System.Web.Http.Route("PostCustomerTable")]
        // POST: api/Order/PostCustomerTable
        public HttpResponseMessage PostOrder(Orders order)
        {
            HttpResponseMessage resp;
            Customers cus = new Customers();
            var result = cus;
            resp = Request.CreateResponse(HttpStatusCode.OK, result);
            return resp;
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //try
            //{
            //    var orderId = _ordersDAO.Create(order);
            //    if (orderId > 0)
            //    {
            //        return Created($"/api/Order/{orderId}", orderId);
            //    }
            //    else
            //    {
            //        return BadRequest();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}

        }

        [System.Web.Http.HttpGet, System.Web.Http.Route("PutCustomerTable")]
        // PUT: api/Order/PutCustomerTable
        public HttpResponseMessage PutOrder(int ID, Orders order)
        {
            HttpResponseMessage resp;
            Customers cus = new Customers();
            var result = cus;
            resp = Request.CreateResponse(HttpStatusCode.OK, result);
            return resp;
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (ID != order.OrderID)
            //{
            //    return BadRequest();
            //}

            //try
            //{
            //    _ordersDAO.Update(order);
            //}
            //catch (Exception)
            //{
            //    if (!OrderExists(ID))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return Ok();

        }

        [System.Web.Http.HttpGet, System.Web.Http.Route("DeleteCustomerTable")]
        // DELETE: api/Order/DeleteCustomerTable
        public HttpResponseMessage DeleteOrder(int ID)
        {
            HttpResponseMessage resp;
            Customers cus = new Customers();
            var result = cus;
            resp = Request.CreateResponse(HttpStatusCode.OK, result);
            return resp;
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //try
            //{
            //    var data = _ordersDAO.Get(ID);

            //    if (data == null)
            //        return NotFound(data);

            //    return Ok(_ordersDAO.Delete(ID));

            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}

        }


        private bool OrderExists(int ID)
        {
            return _ordersDAO.IsExists(ID);
        }
    }
}