using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; set; }
    public static int CurrentId { get; set; } = 0;
    public static List<Order> OrderInstances { get; } = new List<Order> {};

    public Order(string title, string description, double price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      CurrentId ++;
      Id = CurrentId;
      OrderInstances.Add(this);
    }

    public static void ClearAll()
    {
      OrderInstances.Clear();
      CurrentId = 0;
    }

    public static Order Find(int id)
    {
      for (int i = 0; i < OrderInstances.Count; i++)
      {
        if (OrderInstances[i] is Order)
        {
          if (OrderInstances[i].Id == id)
          {
            return OrderInstances[i];
          }
        }
      }
      return null;
    }

     public static void Delete(int id)
    {
      for (int i = 0; i < OrderInstances.Count; i++)
      {
        if (OrderInstances[i] is Order)
        {
          if (OrderInstances[i].Id == id)
          {
            OrderInstances.RemoveAt(i);
            break;
          }
        }
      }
    }
  }
}  