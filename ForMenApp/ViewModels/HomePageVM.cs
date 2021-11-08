using ForMenApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ForMenApp.ViewModels
{
    public class HomePageVM
    {
        public ObservableCollection<Producto> producto { get; set; }

        public HomePageVM()
        {
            producto = new ObservableCollection<Producto>
            {
                new Producto
                {
                    Title = "Men’s HMLYN D. Parka",
                    Marca = "TNF",
                    Image = "producto1",
                    Price = "40" 
                },

                new Producto
                {
                    Title = "Men’s HMLYN D. Parka",
                    Marca = "TNF",
                    Image = "producto2",
                    Price = "40"
                },

                new Producto
                {
                    Title = "Men’s HMLYN D. Parka",
                    Marca = "TNF",
                    Image = "producto3",
                    Price = "40"
                },

                new Producto
                {
                    Title = "Men’s HMLYN D. Parka",
                    Marca = "TNF",
                    Image = "producto4",
                    Price = "40"
                },

                new Producto
                {
                    Title = "Men’s HMLYN D. Parka",
                    Marca = "TNF",
                    Image = "producto1",
                    Price = "40"
                },

                new Producto
                {
                    Title = "Men’s HMLYN D. Parka",
                    Marca = "TNF",
                    Image = "producto2",
                    Price = "40"
                },

                new Producto
                {
                    Title = "Men’s HMLYN D. Parka",
                    Marca = "TNF",
                    Image = "producto3",
                    Price = "40"
                },

                new Producto
                {
                    Title = "Men’s HMLYN D. Parka",
                    Marca = "TNF",
                    Image = "producto4",
                    Price = "40"
                },
            };
        }
    }
}
