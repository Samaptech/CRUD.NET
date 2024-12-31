using CRUD.NET.Models;
using CRUD.NET.SqlDb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CRUD.NET.Controllers
{
    public class WebController : Controller
    {
        SqlDbContext SqlDbContext;

        public WebController(SqlDbContext sqlDbContext)
        {
           this.SqlDbContext = sqlDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Products products)
        {
            SqlDbContext.tbl_Products.Add(products);
            SqlDbContext.SaveChanges();
            ModelState.Clear();
            ViewBag.success = "Product Successfully Inserted";
            
            return View();
        }

        public IActionResult ProductList()
        {
            return  View(SqlDbContext.tbl_Products.ToList());

        }

        public IActionResult CustomerIndex()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerIndex(Customer cs , string Custumer_Name , string Custumer_Email)
        {
            SqlDbContext.tbl_Customers.Add(cs);
            SqlDbContext.SaveChanges();
            ModelState.Clear();
            ViewBag.success = "Customer Successfully Inserted";

            Users user = new Users
            {
                User_name = Custumer_Name,
                User_Email = Custumer_Email,
                User_Password = "12345",
                User_Role = "Customer"
            };
            SqlDbContext.tbl_Users.Add(user);
            SqlDbContext.SaveChanges();
            return View();
        }


    }
}
