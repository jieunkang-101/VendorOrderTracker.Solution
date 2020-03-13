using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> tracker = new Dictionary<string, object>();
      tracker.Add("order", order);
      tracker.Add("vendor", vendor);
      return View(tracker);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}/delete}")]
    public ActionResult Destroy(int id)
    {
      Order.Delete(id);
      return View();
    }
  }
} 