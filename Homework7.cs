namespace Homework7;

using System;

class Customer
{
private int cus_id;
public string cus_name;
public int cus_age;
public Customer(int id,string name,int age)
{
cus_id=id;
cus_name=name;
cus_age=age;
}
public void ChangeID(int new_id)
{
cus_id=new_id;
}
public void PrintCusInfo()
{
Console.WriteLine("Customer ID:{0}, Customer Name:{1}, Customer Age:{2}",cus_id,cus_name,cus_age);
}
}
class main {
static void Main() {
Customer c1=new Customer(110,"Alice",28);
Customer c2=new Customer(111,"Bob",30);
c1.PrintCusInfo();
c2.PrintCusInfo();
Console.WriteLine();
c1.ChangeID(220);
c2.ChangeID(221);
c1.PrintCusInfo();
c2.PrintCusInfo();
}
}
       
