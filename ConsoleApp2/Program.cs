// See https://aka.ms/new-console-template for more information
using FactoryMethod;
Console.WriteLine("Hello World!");
INhanvienFactory nhanvienFactory = new NhanvienFactory();

var nv = nhanvienFactory.createNhanvien("LTV");
Console.WriteLine(nv.ToString());

