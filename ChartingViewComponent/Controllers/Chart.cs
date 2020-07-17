using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartingViewComponent.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChartingViewComponent.Controllers
{
    public class Chart : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private Random rnd = new Random();
        public IActionResult Bar()
        {
            //list of department
            var lstModel = new List<SimpleReportViewModel>();
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Technology",
                Quantity = rnd.Next(10)
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Sales",
                Quantity = rnd.Next(10)
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Marketing",
                Quantity = rnd.Next(10)
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Human Resource",
                Quantity = rnd.Next(10)
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Research and Development",
                Quantity = rnd.Next(10)


            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Acconting",
                Quantity = rnd.Next(10)
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Support",
                Quantity = rnd.Next(10)
            });
            lstModel.Add(new SimpleReportViewModel
            {
                DimensionOne = "Logistics",
                Quantity = rnd.Next(10)
            });
            return View(lstModel);
        }
    }
}
