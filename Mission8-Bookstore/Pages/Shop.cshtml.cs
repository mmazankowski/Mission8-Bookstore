using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission8_Bookstore.Models;

namespace Mission8_Bookstore.Pages
{
    public class ShopModel : PageModel
    {
        private iBookstoreRepository repo { get; set; }

        public ShopModel (iBookstoreRepository temp)
        {
            repo = temp;
        }

        public Cart cart { get; set; }

        public void OnGet(Cart c)
        {
            cart = c; 
        }

        public IActionResult OnPost(int bookId)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            cart = new Cart(); 

            cart.AddItem(b, 1);

            return RedirectToPage(cart); 
        }

    }
}
