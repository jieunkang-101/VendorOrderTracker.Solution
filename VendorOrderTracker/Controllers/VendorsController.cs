using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.VendorInstances;
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> tracker = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> orderForVendor = selectedVendor.Orders;
      tracker.Add("vendor", selectedVendor);
      tracker.Add("orders", orderForVendor);
      return View(tracker);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, int price, DateTime date)
    {
      Dictionary<string, object> tracker = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOder = new Order(title, description, price, date);
      foundVendor.AddOrder(newOder);
      List<Order> orderForVendor = foundVendor.Orders;
      tracker.Add("orders", orderForVendor);
      tracker.Add("vendor", foundVendor);
      return View("Show", tracker);
    }

    [HttpGet("/vendors/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }

    [HttpPost("/vendors/{id}")]
    public ActionResult Update(int id, string name, string description)
    {
      Vendor foundVendor = Vendor.Find(id);
      foundVendor.Name = name;
      foundVendor.Description = description;
      List<Order> orderForVendor = foundVendor.Orders;
      return RedirectToAction("Index", foundVendor);
    }  

    [HttpPost("/vendors/{id}/delete")]
    public ActionResult Destroy(int id)
    {
      Vendor.Delete(id);
      return RedirectToAction("Index");
    }
  }
} 