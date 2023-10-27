using System;
using DesafioIt.Domain.Enums;
using DesafioIt.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioIt.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class SeedDishes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Name", "Description", "Price", "ServingSize", "Type", "Photo" },
                values: new DishEntity[] {
                    new DishEntity {Name = "Bruschetta", Description = "Toasted bread topped with a mixture of chopped tomatoes, basil, garlic, and olive oil.", Price = 6, ServingSize = "2 pieces", Type = DishType.Starters, Photo = ""},
                    new DishEntity {Name = "Caprese Salad",  Description = "Fresh mozzarella, tomatoes, and basil drizzled with balsamic reduction.", Price = 9, ServingSize = "1 plate", Type = DishType.Starters, Photo = ""},
                    new DishEntity {Name = "Arancini",  Description = "Deep-fried risotto balls stuffed with cheese and served with marinara sauce.", Price = 8, ServingSize = "3 pieces", Type = DishType.Starters, Photo = ""},
                    new DishEntity {Name = "Spaghetti Carbonara",  Description = "Pasta tossed with pancetta, egg, pecorino cheese, and black pepper.", Price = 14, ServingSize = "1 plate", Type = DishType.MainCourseDishes, Photo = ""},
                    new DishEntity {Name = "Lasagna alla Bolognese",  Description = "Layered pasta sheets with beef ragù, béchamel sauce, and Parmesan cheese.", Price = 16, ServingSize = "1 slice", Type = DishType.MainCourseDishes, Photo = ""},
                    new DishEntity {Name = "Risotto ai Funghi",  Description = "Creamy rice dish cooked with assorted mushrooms and Parmesan cheese.", Price = 15, ServingSize = "1 bowl", Type = DishType.MainCourseDishes, Photo = ""},
                    new DishEntity {Name = "Ossobuco alla Milanese",  Description = "Braised veal shanks cooked with white wine, broth, onions, tomatoes, and garlic, served with gremolata and traditionally accompanied by risotto alla Milanese.", Price = 18, ServingSize = "1 plate", Type = DishType.MainCourseDishes, Photo = ""},
                    new DishEntity {Name = "Gnocchi di Patate",  Description = "Soft potato dumplings served with a choice of tomato basil sauce, creamy gorgonzola sauce, or browned butter and sage.", Price = 15.5,ServingSize =  "1 plate", Type = DishType.MainCourseDishes, Photo = ""},
                    new DishEntity {Name = "Penne all’Arrabbiata",  Description = "Penne pasta served with a spicy tomato sauce made from garlic, tomatoes, and dried red chili peppers.", Price = 13.5,ServingSize =  "1 plate", Type = DishType.MainCourseDishes, Photo = ""},
                    new DishEntity {Name = "Tiramisu",  Description = "Layered dessert made with coffee-soaked ladyfingers, mascarpone cheese, cocoa, and whipped cream.", Price = 8, ServingSize = "1 slice", Type = DishType.Desserts, Photo = ""},
                    new DishEntity {Name = "Panna Cotta",  Description = "Creamy custard-like dessert topped with berry coulis.", Price = 7, ServingSize = "1 cup", Type = DishType.Desserts, Photo = ""},
                    new DishEntity {Name = "Cannoli",  Description = "Crispy pastry tubes filled with sweet ricotta cheese and chocolate chips.", Price = 6, ServingSize = "2 pieces", Type = DishType.Desserts, Photo = ""},
                    new DishEntity {Name = "Espresso",  Description = "Strong Italian coffee served in a small cup.", Price = 3, ServingSize = "1 cup", Type = DishType.Beverages, Photo = ""},
                    new DishEntity {Name = "Limoncello",  Description = "Italian lemon liqueur primarily produced in Southern Italy.", Price = 8, ServingSize = "1 shot", Type = DishType.Beverages, Photo = ""},
                    new DishEntity {Name = "Chianti",  Description = "Red wine from Tuscany, known for its robust flavor.", Price = 10, ServingSize = "1 glass", Type = DishType.Beverages, Photo = ""},
                    new DishEntity {Name = "Aperol Spritz",  Description = "A cocktail made of Prosecco, Aperol, and soda water.", Price = 12, ServingSize = "1 glass", Type = DishType.Beverages, Photo = ""},
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Name",
                keyValues: new object[] {
                    "Bruschetta",
                    "Caprese Salad",
                    "Arancini",
                    "Spaghetti Carbonara",
                    "Lasagna alla Bolognese",
                    "Risotto ai Funghi",
                    "Ossobuco alla Milanese",
                    "Gnocchi di Patate",
                    "Penne all’Arrabbiata",
                    "Tiramisu",
                    "Panna Cotta",
                    "Cannoli",
                    "Espresso",
                    "Limoncello",
                    "Chianti",
                    "Aperol Spritz",
                }
            );
        }
    }
}
