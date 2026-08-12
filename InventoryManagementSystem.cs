using System;
using System.Collections.Generic;

class InventoryManager
{
    static List<string> Products=new List<string>();
    static List<decimal> Prices  =new List<decimal>();
    static List<int> Quantity   =new List<int>();

    static void Main()
    {
        while(true){
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Update Stock");
            Console.WriteLine("3.View Product");
            Console.WriteLine("4.Remove Product");
            Console.WriteLine("5.Exit");
            string Choice=Console.ReadLine();
            switch(Choice){
                case "1":
                AddProduct();
                break;
                case "2":
                UpdateStock();
                break;
                case "3":
                ViewProduct();
                break;
                case "4":
                RemoveProduct();
                break;
                case "5":
                return;
                default:
                Console.WriteLine("INVALID CHOICE");
            }
        }
    }
    static void AddProduct(){
        Console.WriteLine("Enter Product");
        string Product=Console.ReadLine();
        Products.Add(Product);
        Console.WriteLine("Enter The Price Of The Product");
        decimal Price=Convert.ToDecimal(Console.ReadLine());
        Prices.Add(Price);
        Console.WriteLine("Enter The Quantity Of The Product");
        int Quant=int.Parse(Console.ReadLine());
        Quantity.Add(Quant); 
    }
    static void UpdateStock(){
        Console.WriteLine("Enter Product");
        string Product=Console.ReadLine();
        for(int i= 0 ; i < Products.Count ; i++ )
        {
          if(Product==Products[i]){
            Console.WriteLine("1.Increase");
            Console.WriteLine("2.Decrease");
            string Select=Console.ReadLine();
            switch(Select){
                case "1":
                Console.WriteLine("Enter Amount");
                int Quant1=int.Parse(Console.ReadLine());
                Quantity[i]+=Quant1;
                break;
                case "2":
                Console.WriteLine("Enter Amount");
                int Quant2=int.Parse(Console.ReadLine());
                if(Quant2>Quantity[i])
                {
                    Console.WriteLine("Not Enough Stock");
                }else{
                   Quantity[i]-=Quant2;
                   break;
                }
            }
            
          }
        }
    }
    static void ViewProduct(){
        if(Products.Count==0){
            Console.WriteLine("There are not Products");
            return;
        }
         else 
        {
        for (int i=0 ; i < Products.Count ; i++){
            Console.WriteLine("Product: "+Products[i]);
            Console.WriteLine("Price: "+Prices[i]);
            Console.WriteLine("Quantity: "+Quantity[i]);
        }
       }
    }
    static void RemoveProduct(){
        if(Products.Count==0){
            Console.WriteLine("There are not Products");
            return;
        }
        else{
            Console.WriteLine("Enter Product That You Want To Remove");
            string Removeproduct1=Console.ReadLine();
            for( int i=0 ; i< Products.Count ; i++)
            {
                if(Removeproduct1 == Products[i])
                {
                  Products.RemoveAt(i);
                  Prices.RemoveAt(i);
                  Quantity.RemoveAt(i);
                  break;
                }

            }
        }
    }
}