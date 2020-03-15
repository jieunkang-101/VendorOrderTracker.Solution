using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    public static int CurrentId { get; set; } = 0;
    public List<Order> Orders { get; set; }
    public static List<Vendor> VendorInstances { get; } = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      CurrentId ++;
      Id = CurrentId;
      Orders = new List<Order> {};
      VendorInstances.Add(this);
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static void ClearAll()
    {
      VendorInstances.Clear();
      CurrentId = 0;
    }

    public static Vendor Find(int id)
    {
      for (int i = 0; i < VendorInstances.Count; i++)
      {
        if (VendorInstances[i] is Vendor)
        {
          if (VendorInstances[i].Id == id)
          {
            return VendorInstances[i];
          }
        }
      }
      return null;
    }

     public static void Delete(int id)
    {
      for (int i = 0; i < VendorInstances.Count; i++)
      {
        if (VendorInstances[i] is Vendor)
        {
          if (VendorInstances[i].Id == id)
          {
            VendorInstances.RemoveAt(i);
            //break;
          }
        }
      }
    }

    public void DeleteOrder(int id)
    {
      for (int i = 0; i < Orders.Count; i++)
      {
        if (Orders[i] is Order)
        {
          if (Orders[i].Id == id)
          {
            Orders.RemoveAt(i);
            break;
          }
        }
      }
    }
  }
}  