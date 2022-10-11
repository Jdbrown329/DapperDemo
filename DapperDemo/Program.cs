// See https://aka.ms/new-console-template for more information
using DapperDemo;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Transactions;


using System;
using System.IO;
//^^^^MUST HAVE USING DIRECTIVES^^^^

    var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
    string connString = config.GetConnectionString("DefaultConnection");
    IDbConnection conn = new MySqlConnection(connString);
    var repo = new DapperDepartmentRepository(conn);

    Console.WriteLine("Type a new Department Name");

        var newDepartment = Console.ReadLine();
      
        repo.InsertDepartment(newDepartment);

        var departments = repo.GetAllDepartments();

    foreach (var dept in departments)
    {
        Console.WriteLine(dept.Name);
    }
var repoproducts = new DapperProductRepository(conn);

Console.WriteLine("Type a new Product Name");

var products = Console.ReadLine();

repoproducts.CreateProduct(product);

var product = repoproducts.GetAll();

foreach (var Product in products)
{
    Console.WriteLine(product);
}