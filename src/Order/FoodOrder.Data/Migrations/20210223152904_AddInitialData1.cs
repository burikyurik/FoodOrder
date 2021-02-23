using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrder.Data.Migrations
{
    public partial class AddInitialData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "restaurants",
                columns: new[] { "Id", "City", "LogoPath", "Name", "Rank", "Suburb" },
                values: new object[,]
                {
                    { 2380, "Pretoria", "/RestaurantImages/barcelos.png", "Barcelos", 0, "Pretoria" },
                    { 1487, "Cape Town", "/RestaurantImages/knead.png", "Knead", 7, "Palmyra Junction, Claremont" },
                    { 1484, "Cape Town", "/RestaurantImages/knead.png", "Knead", 4, "Gardens" },
                    { 1381, "Cape Town", "/RestaurantImages/knead.png", "Knead", 1, "Panorama" },
                    { 1270, "Cape Town", "/RestaurantImages/knead.png", "Knead", 0, "Sea Point" },
                    { 1269, "Cape Town", "/RestaurantImages/knead.png", "Knead", 9, "Gardens" },
                    { 1524, "Johannesburg", "/RestaurantImages/jimmys-prawns.jpg", "Jimmy's Killer Prawns", 4, "Fordsburg" },
                    { 1491, "Durban", "/RestaurantImages/jimmys-prawns.jpg", "Jimmy's Killer Prawns", 1, "Umhlanga" },
                    { 859, "Cape Town", "/RestaurantImages/jewel-of-india.png", "Jewel of India", 9, "Foreshore" },
                    { 895, "Cape Town", "/RestaurantImages/jamaica-me-crazy.png", "Jamaica Me Crazy", 5, "Woodstock" },
                    { 1874, "Cape Town", "/RestaurantImages/jade-tavern.jpg", "Jade Tavern", 4, "Kenilworth" },
                    { 1200, "Pretoria", "/RestaurantImages/hudsons.png", "Hudsons", 0, "Hazelwood" },
                    { 1031, "Johannesburg", "/RestaurantImages/hudsons.png", "Hudsons", 1, "Parkhurst" },
                    { 1028, "Cape Town", "/RestaurantImages/hudsons.png", "Hudsons", 8, "Claremont" },
                    { 989, "Cape Town", "/RestaurantImages/hudsons.png", "Hudsons", 9, "Gardens" },
                    { 935, "Cape Town", "/RestaurantImages/hudsons.png", "Hudsons", 5, "Green Point" },
                    { 1076, "Pretoria", "/RestaurantImages/hooters.jpg", "Hooters", 6, "Pretoria" },
                    { 830, "Johannesburg", "/RestaurantImages/hooters.jpg", "Hooters", 0, "Fourways" },
                    { 1641, "Cape Town", "/RestaurantImages/hokey-poke.png", "Hokey Poke", 1, "Sea Point" },
                    { 1558, "Cape Town", "/RestaurantImages/hokey-poke.png", "Hokey Poke", 8, "CBD" },
                    { 1029, "Johannesburg", "/RestaurantImages/el-jalapeno.jpg", "El Jalapeno", 9, "Linden" },
                    { 1343, "Johannesburg", "/RestaurantImages/curry-up.jpg", "Curry Up", 3, "Randburg" },
                    { 2438, "Pretoria", "/RestaurantImages/chiapas.png", "CHIAPAS eat mexican", 8, "Brooklyn" },
                    { 1361, "Johannesburg", "/RestaurantImages/chiapas.png", "CHIAPAS eat mexican", 1, "Rosebank" },
                    { 1488, "Cape Town", "/RestaurantImages/knead.png", "Knead", 8, "Golding, Kenilworth" },
                    { 2425, "Cape Town", "/RestaurantImages/knead.png", "Knead", 5, "Constantia" }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Wholesome Vegetarian Meals", 2380 },
                    { 25, "Vegetarian Dishes", 1491 },
                    { 26, "Vegetarian & Banting Meals", 1524 },
                    { 27, "Tacos (Served Day & Night)", 1269 },
                    { 28, "Vegan Light Meals", 1269 },
                    { 29, "Vegetarian Burger (Served Day & Night)", 1269 },
                    { 30, "Tacos (Served Day & Night)", 1270 },
                    { 31, "Vegan Light Meals", 1270 },
                    { 32, "Vegetarian Burger (Served Day & Night)", 1270 },
                    { 24, "Vegetarian Currys", 859 },
                    { 33, "Tacos (Served Day & Night)", 1381 },
                    { 35, "Vegetarian Burger (Served Day & Night)", 1381 },
                    { 36, "Vegan Light Meals", 1484 },
                    { 37, "Vegetarian Burger (Served Day & Night)", 1484 },
                    { 38, "Tacos (Served Day & Night)", 1487 },
                    { 39, "Vegan Light Meals", 1487 },
                    { 40, "Vegetarian Burger (Served Day & Night)", 1487 },
                    { 41, "Tacos (Served Day & Night)", 1488 },
                    { 42, "Vegan Light Meals", 1488 },
                    { 34, "Vegan Light Meals", 1381 },
                    { 23, "Snacks & Starters", 895 },
                    { 22, "Vegetarian Dishes", 1874 },
                    { 21, "Grills", 1200 },
                    { 2, "Mains", 1361 },
                    { 3, "Mains", 2438 },
                    { 4, "Vegetarian Curries", 1343 },
                    { 5, "Grills", 1029 },
                    { 6, "Tacos", 1029 },
                    { 7, "Vegetarian Menu", 1558 },
                    { 8, "Vegetarian Menu", 1641 },
                    { 9, "Appetizers", 830 },
                    { 10, "Salads", 830 },
                    { 11, "Sandwiches & Tacos", 830 },
                    { 12, "Seafood", 830 },
                    { 13, "Appetizers", 1076 },
                    { 14, "Salads", 1076 },
                    { 15, "Sandwiches & Tacos", 1076 },
                    { 16, "Seafood", 1076 },
                    { 17, "Grills", 935 },
                    { 18, "Grills", 989 },
                    { 19, "Grills", 1028 },
                    { 20, "Grills", 1031 }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name", "RestaurantId" },
                values: new object[] { 43, "Vegetarian Burger (Served Day & Night)", 1488 });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name", "RestaurantId" },
                values: new object[] { 44, "Vegetarian Burgers (Served Day & Night)", 2425 });

            migrationBuilder.InsertData(
                table: "menuItems",
                columns: new[] { "Id", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 941580, 1, "Vegetarian Burger", 36.9000m },
                    { 1184610, 26, "Vegetarian Pasta", 95.0000m },
                    { 1184609, 26, "Vegetarian Pizza", 85.0000m },
                    { 1184608, 26, "Vegetable Burger & Chips", 65.0000m },
                    { 1184607, 26, "Vegetable Soup", 50.0000m },
                    { 1184606, 26, "Prawns & Veggies Stir Fry", 130.0000m },
                    { 1184604, 26, "Grilled Lamb Chops", 150.0000m },
                    { 1238155, 25, "Vegetable Platter", 110.0000m },
                    { 1238154, 25, "Vegetable Curry", 99.0000m },
                    { 1238153, 25, "Vegetarian Pasta", 95.0000m },
                    { 1238152, 25, "Vegetable Burger & Chips", 65.0000m },
                    { 1238151, 25, "Vegetable Soup", 50.0000m },
                    { 881403, 25, "Vegetarian Pizza", 85.0000m },
                    { 1020623, 24, "321 Paneer Lababdar", 109.0000m },
                    { 1020615, 24, "320 Vegetable Mohini ", 103.0000m },
                    { 1020566, 24, "314 Allo Gobhi Adraki", 103.0000m },
                    { 1020553, 24, "317 Daal Palak Lasooni", 97.0000m },
                    { 1020552, 24, "316 Daal Tadka", 91.0000m },
                    { 1020543, 24, "312 Veg Jalfrezi", 97.0000m },
                    { 1020538, 24, "309 Vegetable Hyderabadi", 97.0000m },
                    { 1020537, 24, "308 Vegetable Korma", 109.0000m },
                    { 1020535, 24, "307 Punjabi Dum Aloo", 97.0000m },
                    { 1020532, 24, "302 Paneer Makhani", 103.0000m },
                    { 769348, 24, "303 Palak Paneer", 103.0000m },
                    { 207215, 24, "311 Methi Malai Mutter", 103.0000m },
                    { 207209, 24, "305 Aloo Jeera", 91.0000m },
                    { 207208, 24, "304 Aloo Peas-Dry", 91.0000m },
                    { 1362967, 23, "Tacos", 95.0000m },
                    { 1200135, 22, "Stir Fry Chinese Green Vegetables", 87.0000m },
                    { 1200134, 22, "Vegetarian Oyster Sauce", 87.0000m },
                    { 1184611, 26, "Vegetable Curry", 99.0000m },
                    { 1200133, 22, "Vegetarian Foo Yong", 87.0000m },
                    { 1184612, 26, "Vegetable Platter", 110.0000m },
                    { 1332566, 27, "Buttermilk Fried Chicken Taco", 105.0000m },
                    { 1333012, 42, "Vegan Falafel Taco", 99.0000m },
                    { 1333000, 41, "Loaded Nachos", 105.0000m },
                    { 1332999, 41, "Falafel Taco", 99.0000m },
                    { 1332998, 41, "Buttermilk Fried Chicken Taco", 105.0000m },
                    { 1332997, 41, "BBQ Pulled Pork Taco", 105.0000m },
                    { 1327793, 40, "Veggie Burger", 76.0000m },
                    { 1327821, 39, "Vegan Falafel Taco", 99.0000m },
                    { 1327806, 38, "Loaded Nachos", 105.0000m }
                });

            migrationBuilder.InsertData(
                table: "menuItems",
                columns: new[] { "Id", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1327805, 38, "Falafel Taco", 99.0000m },
                    { 1327804, 38, "Buttermilk Fried Chicken Taco", 105.0000m },
                    { 1327803, 38, "BBQ Pulled Pork Taco", 105.0000m },
                    { 1332881, 37, "Veggie Burger", 76.0000m },
                    { 1332904, 36, "Vegan Falafel Taco", 99.0000m },
                    { 1332773, 35, "Veggie Burger", 76.0000m },
                    { 1332796, 34, "Vegan Falafel Taco", 99.0000m },
                    { 1332784, 33, "Loaded Nachos", 105.0000m },
                    { 1332783, 33, "Falafel Taco", 99.0000m },
                    { 1332782, 33, "Buttermilk Fried Chicken Taco", 105.0000m },
                    { 1332781, 33, "BBQ Pulled Pork Taco", 105.0000m },
                    { 1332665, 32, "Veggie Burger", 76.0000m },
                    { 1332688, 31, "Vegan Falafel Taco", 99.0000m },
                    { 1332676, 30, "Loaded Nachos", 105.0000m },
                    { 1332675, 30, "Falafel Taco", 99.0000m },
                    { 1332674, 30, "Buttermilk Fried Chicken Taco", 105.0000m },
                    { 1332673, 30, "BBQ Pulled Pork Taco", 105.0000m },
                    { 1332557, 29, "Veggie Burger", 76.0000m },
                    { 1332580, 28, "Vegan Falafel Taco", 99.0000m },
                    { 1332568, 27, "Loaded Nachos", 105.0000m },
                    { 1332567, 27, "Falafel Taco", 99.0000m },
                    { 1332565, 27, "BBQ Pulled Pork Taco", 105.0000m },
                    { 1332989, 43, "Veggie Burger", 76.0000m },
                    { 1389981, 21, "Free Range Chicken Taco", 113.0000m },
                    { 1390078, 20, "Free Range Chicken Taco", 113.0000m },
                    { 1392554, 7, "Teriyaki Tofu Starter (Vegan)", 40.0000m },
                    { 1263592, 6, "Vegetariano Tacos", 85.0000m },
                    { 1263591, 6, "Pescado Tacos", 87.0000m },
                    { 1263590, 6, "Puerco Tacos", 92.0000m },
                    { 1263589, 6, "Pollo Tacos", 87.0000m },
                    { 1263588, 6, "Carne Tacos", 92.0000m },
                    { 1263596, 5, "Grilled Hard Tacos", 86.0000m },
                    { 1346597, 4, "It hurts so good Vegetable Jalfrezi", 99.9500m },
                    { 1346596, 4, "Chickpea, Veg & Coconut Exotica", 99.9500m },
                    { 1346595, 4, "Our Veg & Paneer Signature Meal", 99.9500m },
                    { 1346594, 4, "Paneer Tikka Masala", 99.9500m },
                    { 1346593, 4, "Gentle Paneer Makhni", 99.9500m },
                    { 1346592, 4, "Paneer Palak", 99.9500m },
                    { 1346591, 4, "The oh so comforting Paneer Korma", 99.9500m },
                    { 1346590, 4, "Paneer & Aloo Makhni", 91.9500m },
                    { 1346589, 4, "Paneer & Aloo Tikka Masala", 99.9500m },
                    { 1346588, 4, "Paneer & Aloo Palak", 91.9500m }
                });

            migrationBuilder.InsertData(
                table: "menuItems",
                columns: new[] { "Id", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1346587, 4, "The Green Velvet Aloo Palak", 78.9500m },
                    { 1346586, 4, "The 'can't get enough of' Aloo Jeera", 69.9500m },
                    { 1346585, 4, "Bombay Potatoes", 74.9500m },
                    { 1346584, 4, "'Howzit Chana' Masala", 73.9500m },
                    { 1346580, 4, "The Powerhouse Dhal Makhni", 79.9500m },
                    { 1346579, 4, "The OMG Dhal & Brinjals", 73.9500m },
                    { 1137092, 3, "Soft Tacos", 70.0000m },
                    { 1137091, 3, "Crispy Tacos", 70.0000m },
                    { 1315808, 2, "Soft Tacos", 80.0000m },
                    { 1315807, 2, "Crispy Tacos", 80.0000m },
                    { 941582, 1, "Vegetarian Schwarma", 41.9000m },
                    { 941581, 1, "Vegetarian Stir Fry & Rice", 42.9000m },
                    { 1392555, 7, "LA Flight Bowl (Gluten-free)", 65.0000m },
                    { 1389980, 21, "Falafel Taco", 106.0000m },
                    { 1392558, 7, "Naughty Girl (Vegan)", 75.0000m },
                    { 1392598, 8, "Teriyaki Tofu Starter (Vegan)", 40.0000m },
                    { 1390077, 20, "Falafel Taco", 106.0000m },
                    { 1389787, 19, "Free Range Chicken Taco", 113.0000m },
                    { 1389786, 19, "Falafel Taco", 106.0000m },
                    { 1288632, 18, "Free Range Chicken Taco", 113.0000m },
                    { 1288551, 18, "Falafel Taco", 106.0000m },
                    { 1389884, 17, "Free Range Chicken Taco", 113.0000m },
                    { 1389883, 17, "Falafel Taco", 106.0000m },
                    { 1266325, 16, "Baja Shrimp Tacos", 123.5000m },
                    { 1266324, 16, "Baja Fish Tacos", 95.5000m },
                    { 1266316, 15, "Baja Shrimp Tacos", 123.5000m },
                    { 1266315, 15, "Baja Fish Tacos", 95.5000m },
                    { 1266314, 15, "Buffalo Chicken Tacos", 90.0000m },
                    { 1266313, 15, "Chicken Speed Way Sandwich", 106.5000m },
                    { 1266312, 15, "Philly Cheese Steak Sandwich", 97.5000m },
                    { 1266311, 15, "Smothered Chicken Sandwich", 101.0000m },
                    { 1266321, 14, "Taco Salad", 112.0000m },
                    { 1266283, 13, "Wise Choice Shrimp Tacos", 120.0000m },
                    { 1266282, 13, "Wise Choice Fish Tacos", 96.5000m },
                    { 1266203, 12, "Baja Shrimp Tacos", 123.5000m },
                    { 1266202, 12, "Baja Fish Tacos", 95.5000m },
                    { 1266194, 11, "Baja Shrimp Tacos", 123.5000m },
                    { 1266193, 11, "Baja Fish Tacos", 95.5000m },
                    { 1266192, 11, "Buffalo Chicken Tacos", 90.0000m },
                    { 1266191, 11, "Chicken Speed Way Sandwich", 106.5000m },
                    { 1266190, 11, "Philly Cheese Steak Sandwich", 97.5000m },
                    { 1266189, 11, "Smothered Chicken Sandwich", 101.0000m }
                });

            migrationBuilder.InsertData(
                table: "menuItems",
                columns: new[] { "Id", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1266199, 10, "Taco Salad", 112.0000m },
                    { 1266161, 9, "Wise Choice Shrimp Tacos", 120.0000m },
                    { 1266160, 9, "Wise Choice Fish Tacos", 96.5000m },
                    { 1392568, 7, "Red Summer (Vegan/Gluten-free)", 75.0000m },
                    { 1384510, 44, "Vegetarian Classic Veggie Burger", 76.0000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 207208);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 207209);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 207215);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 769348);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 881403);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 941580);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 941581);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 941582);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020532);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020535);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020537);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020538);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020543);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020552);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020553);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020566);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020615);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1020623);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1137091);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1137092);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1184604);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1184606);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1184607);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1184608);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1184609);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1184610);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1184611);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1184612);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1200133);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1200134);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1200135);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1238151);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1238152);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1238153);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1238154);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1238155);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1263588);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1263589);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1263590);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1263591);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1263592);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1263596);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266160);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266161);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266189);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266190);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266191);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266192);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266193);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266194);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266199);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266202);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266203);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266282);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266283);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266311);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266312);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266313);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266314);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266315);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266316);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266321);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266324);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1266325);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1288551);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1288632);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1315807);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1315808);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1327793);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1327803);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1327804);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1327805);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1327806);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1327821);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332557);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332565);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332566);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332567);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332568);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332580);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332665);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332673);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332674);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332675);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332676);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332688);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332773);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332781);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332782);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332783);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332784);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332796);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332881);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332904);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332989);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332997);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332998);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1332999);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1333000);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1333012);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346579);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346580);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346584);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346585);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346586);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346587);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346588);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346589);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346590);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346591);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346592);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346593);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346594);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346595);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346596);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1346597);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1362967);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1384510);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1389786);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1389787);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1389883);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1389884);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1389980);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1389981);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1390077);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1390078);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1392554);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1392555);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1392558);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1392568);

            migrationBuilder.DeleteData(
                table: "menuItems",
                keyColumn: "Id",
                keyValue: 1392598);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 2380);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "restaurants",
                keyColumn: "Id",
                keyValue: 2438);
        }
    }
}
