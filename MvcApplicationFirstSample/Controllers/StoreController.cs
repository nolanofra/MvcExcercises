using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcApplicationFirstSample.Models;
using MvcApplicationFirstSample.ViewModels;

namespace MvcApplicationFirstSample.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            var listAlbum = new List<Album>
            {
                new Album
                {
                    Author = "Pink floyd",
                    Title = "the Wall"
                },
                new Album
                {
                    Author = "Genesis",
                    Title = "a trick of the tail"
                }
            };

            var listViewModel = listAlbum.Select(album => new AlbumViewModel
            {
                Title = album.Title, LoggedUser = "francesco"
            }).ToList();

            return this.View(listViewModel);
        }

        public string Details()
        {
            return "Hello from store -details";
        }

        public string Edit(int id)
        {
            return "Hello from store- edit: " + id;
        }

        public string Search(string search)
        {
            return "Hello from store- search: " + search;
        }
    }
}
