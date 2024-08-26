﻿using CinemaWebAppRP_PVl321.Models;
using CinemaWebAppRP_PVl321.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebAppRP_PVl321.Pages
{
    public class IndexModel : PageModel
    {
        public string? Message { get; set; }
        public object? Cinema { get; set; }
        public List<Movie> Movies { get; set; } = new();
        //     public IndexModel()
        //     {
        ////Movies = MovieSevice.Movies;
        //Movies = MovieSevice.GetAll();
        //     }

        //GET-request
        //https://localhost:7012/
        //https://localhost:7012/Index

        //parameters get-request: https://localhost:7012/Index?cinema=Ukraine
        //parameters path: https://localhost:7012/Ukraine https://localhost:7012/Index/Ukraine
        public void OnGet(string? cinema)
        {
            Message = "Using property from page model";
            Movies = MovieSevice.GetAll();
           //?? Cinema = RouteData.Values["cinema"];
            //Cinema = Request.Query["cinema"].ToString();
            Cinema = cinema;

        }

        //public void OnGet()
        //{
        //    Movies = MovieSevice.GetAll();
        //}
       // public void OnPost(string? cinema) { }

        //delete
        public IActionResult OnPost(int id) { 
            MovieSevice.Delete(id);
            //return Content("Deleted!"); //contect page
            //return Page(); //   1) current page "Index"
            return RedirectToPage("Index"); // 2) current page
        }

    }
}