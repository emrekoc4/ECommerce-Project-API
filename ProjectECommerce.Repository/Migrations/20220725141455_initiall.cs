using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectECommerce.Repository.Migrations
{
    public partial class initiall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderDetailsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDetailsId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 11, 3, 12, 885, DateTimeKind.Local).AddTicks(6212), "Generic Concrete Shoes", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 12, 17, 326, DateTimeKind.Local).AddTicks(3623), "Incredible Plastic Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 16, 46, 47, 507, DateTimeKind.Local).AddTicks(2735), "Incredible Rubber Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 13, 46, 36, 311, DateTimeKind.Local).AddTicks(359), "Licensed Granite Cheese", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 17, 22, 32, 998, DateTimeKind.Local).AddTicks(3446), "Awesome Cotton Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 11, 5, 9, 531, DateTimeKind.Local).AddTicks(6302), "Fantastic Frozen Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 21, 44, 13, 255, DateTimeKind.Local).AddTicks(8750), "Handcrafted Cotton Sausages", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 6, 55, 27, 479, DateTimeKind.Local).AddTicks(6691), "Fantastic Rubber Hat", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 4, 33, 27, 723, DateTimeKind.Local).AddTicks(3855), "Handmade Metal Keyboard", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 10, 29, 43, 612, DateTimeKind.Local).AddTicks(8261), "Small Soft Pizza", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 5, 39, 55, 860, DateTimeKind.Local).AddTicks(6332), "Handcrafted Fresh Sausages", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 17, 59, 42, 139, DateTimeKind.Local).AddTicks(2200), "Gorgeous Soft Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 32, 27, 7, DateTimeKind.Local).AddTicks(7060), "Sleek Rubber Table", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 19, 5, 49, 786, DateTimeKind.Local).AddTicks(6109), "Handmade Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 19, 29, 49, 251, DateTimeKind.Local).AddTicks(2135), "Refined Cotton Salad", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 4, 56, 1, 564, DateTimeKind.Local).AddTicks(9115), "Sleek Metal Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 6, 31, 55, 705, DateTimeKind.Local).AddTicks(5323), "Sleek Plastic Computer", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 5, 19, 22, 212, DateTimeKind.Local).AddTicks(5594), "Rustic Rubber Keyboard", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 13, 26, 32, 688, DateTimeKind.Local).AddTicks(3817), "Refined Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 13, 59, 30, 445, DateTimeKind.Local).AddTicks(595), "Unbranded Frozen Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 0, 7, 27, 648, DateTimeKind.Local).AddTicks(443), "Practical Wooden Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 1, 53, 37, 212, DateTimeKind.Local).AddTicks(8951), "Small Concrete Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 23, 53, 24, 144, DateTimeKind.Local).AddTicks(2917), "Fantastic Frozen Cheese", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 10, 38, 15, 215, DateTimeKind.Local).AddTicks(7750), "Small Wooden Pizza", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 18, 48, 39, 73, DateTimeKind.Local).AddTicks(1741), "Handmade Granite Car", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 39, 32, 668, DateTimeKind.Local).AddTicks(4870), "Generic Wooden Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 0, 23, 26, 837, DateTimeKind.Local).AddTicks(1105), "Intelligent Concrete Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 2, 42, 38, 457, DateTimeKind.Local).AddTicks(7639), "Gorgeous Concrete Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 16, 9, 35, 173, DateTimeKind.Local).AddTicks(3824), "Practical Fresh Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 21, 52, 10, 29, DateTimeKind.Local).AddTicks(963), "Generic Frozen Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 2, 0, 41, 91, DateTimeKind.Local).AddTicks(3503), "Sleek Steel Cheese", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 9, 0, 59, 303, DateTimeKind.Local).AddTicks(4525), "Handcrafted Granite Car", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 17, 47, 37, 967, DateTimeKind.Local).AddTicks(8331), "Rustic Cotton Fish", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 11, 27, 40, 721, DateTimeKind.Local).AddTicks(6185), "Ergonomic Fresh Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 17, 2, 56, 178, DateTimeKind.Local).AddTicks(7656), "Fantastic Frozen Computer", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 9, 50, 49, 610, DateTimeKind.Local).AddTicks(3172), "Sleek Metal Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 15, 4, 0, 372, DateTimeKind.Local).AddTicks(6930), "Incredible Cotton Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 22, 27, 42, 170, DateTimeKind.Local).AddTicks(8016), "Fantastic Frozen Bacon", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 1, 26, 35, 344, DateTimeKind.Local).AddTicks(43), "Gorgeous Granite Shoes", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 2, 7, 41, 327, DateTimeKind.Local).AddTicks(986), "Refined Concrete Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 19, 58, 45, 422, DateTimeKind.Local).AddTicks(7827), "Rustic Granite Shoes", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 19, 22, 34, 689, DateTimeKind.Local).AddTicks(2936), "Refined Metal Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 17, 47, 45, 849, DateTimeKind.Local).AddTicks(7251), "Awesome Plastic Soap", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 14, 0, 2, 137, DateTimeKind.Local).AddTicks(9113), "Intelligent Metal Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 2, 48, 7, 266, DateTimeKind.Local).AddTicks(1521), "Licensed Frozen Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 8, 2, 46, 924, DateTimeKind.Local).AddTicks(6580), "Generic Fresh Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 11, 10, 51, 134, DateTimeKind.Local).AddTicks(9252), "Refined Plastic Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 12, 21, 12, 400, DateTimeKind.Local).AddTicks(484), "Gorgeous Soft Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 8, 45, 21, 994, DateTimeKind.Local).AddTicks(2700), "Ergonomic Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 16, 11, 25, 634, DateTimeKind.Local).AddTicks(1472), "Practical Metal Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 17, 23, 46, 68, DateTimeKind.Local).AddTicks(5552), "Gorgeous Rubber Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 5, 28, 853, DateTimeKind.Local).AddTicks(326), "Refined Cotton Cheese", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 5, 6, 40, 296, DateTimeKind.Local).AddTicks(8840), "Generic Rubber Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 12, 58, 33, 512, DateTimeKind.Local).AddTicks(4658), "Licensed Granite Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 0, 40, 52, 297, DateTimeKind.Local).AddTicks(1032), "Handmade Soft Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 2, 18, 39, 115, DateTimeKind.Local).AddTicks(4211), "Handcrafted Concrete Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 3, 30, 42, 628, DateTimeKind.Local).AddTicks(8499), "Unbranded Wooden Bacon", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 19, 33, 41, 187, DateTimeKind.Local).AddTicks(377), "Unbranded Granite Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 10, 7, 1, 257, DateTimeKind.Local).AddTicks(8307), "Handcrafted Frozen Car", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 20, 53, 24, 779, DateTimeKind.Local).AddTicks(3565), "Tasty Steel Ball", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 3, 55, 0, 668, DateTimeKind.Local).AddTicks(4530), "Incredible Metal Salad", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 2, 11, 38, 35, DateTimeKind.Local).AddTicks(1211), "Fantastic Concrete Table", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 22, 41, 42, 737, DateTimeKind.Local).AddTicks(5065), "Small Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 0, 25, 20, 463, DateTimeKind.Local).AddTicks(8893), "Generic Concrete Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 0, 49, 34, 111, DateTimeKind.Local).AddTicks(5225), "Gorgeous Wooden Chicken", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 1, 44, 980, DateTimeKind.Local).AddTicks(7641), "Gorgeous Soft Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 7, 35, 32, 654, DateTimeKind.Local).AddTicks(6371), "Unbranded Rubber Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 19, 38, 16, 595, DateTimeKind.Local).AddTicks(6046), "Licensed Frozen Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 13, 6, 47, 509, DateTimeKind.Local).AddTicks(6360), "Handcrafted Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 6, 12, 10, 706, DateTimeKind.Local).AddTicks(6403), "Licensed Granite Fish", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 4, 18, 43, 631, DateTimeKind.Local).AddTicks(3148), "Practical Steel Ball", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 22, 0, 17, 270, DateTimeKind.Local).AddTicks(4097), "Ergonomic Concrete Hat", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 15, 32, 36, 937, DateTimeKind.Local).AddTicks(2407), "Gorgeous Granite Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 22, 33, 44, 322, DateTimeKind.Local).AddTicks(841), "Incredible Wooden Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 1, 0, 15, 675, DateTimeKind.Local).AddTicks(6802), "Licensed Wooden Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 15, 7, 12, 89, DateTimeKind.Local).AddTicks(133), "Licensed Plastic Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 4, 40, 33, 367, DateTimeKind.Local).AddTicks(3523), "Generic Granite Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 22, 45, 18, 188, DateTimeKind.Local).AddTicks(8851), "Intelligent Soft Bike", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 11, 3, 25, 221, DateTimeKind.Local).AddTicks(3780), "Refined Rubber Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 1, 7, 47, 324, DateTimeKind.Local).AddTicks(2658), "Rustic Frozen Keyboard", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 18, 33, 49, 99, DateTimeKind.Local).AddTicks(5798), "Practical Metal Table", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 23, 47, 8, 417, DateTimeKind.Local).AddTicks(9519), "Tasty Wooden Bike", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 1, 36, 39, 214, DateTimeKind.Local).AddTicks(3494), "Unbranded Plastic Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 21, 59, 57, 58, DateTimeKind.Local).AddTicks(9466), "Incredible Wooden Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 11, 41, 9, 985, DateTimeKind.Local).AddTicks(4120), "Handmade Cotton Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 2, 38, 15, 558, DateTimeKind.Local).AddTicks(8152), "Ergonomic Soft Car", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 22, 53, 16, 744, DateTimeKind.Local).AddTicks(1411), "Intelligent Plastic Soap", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 20, 13, 32, 867, DateTimeKind.Local).AddTicks(6193), "Handmade Fresh Pants", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 17, 40, 33, 729, DateTimeKind.Local).AddTicks(1614), "Refined Metal Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 8, 28, 829, DateTimeKind.Local).AddTicks(7874), "Handmade Rubber Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 19, 0, 16, 61, DateTimeKind.Local).AddTicks(8559), "Generic Steel Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 21, 8, 7, 772, DateTimeKind.Local).AddTicks(4846), "Handmade Fresh Fish", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 0, 0, 16, 172, DateTimeKind.Local).AddTicks(1741), "Sleek Concrete Shoes", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 17, 52, 6, 495, DateTimeKind.Local).AddTicks(3355), "Generic Fresh Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 9, 4, 24, 359, DateTimeKind.Local).AddTicks(3457), "Ergonomic Metal Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 14, 48, 35, 98, DateTimeKind.Local).AddTicks(2232), "Fantastic Wooden Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 19, 52, 56, 695, DateTimeKind.Local).AddTicks(6305), "Intelligent Granite Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 19, 0, 50, 149, DateTimeKind.Local).AddTicks(9109), "Intelligent Granite Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 18, 35, 15, 922, DateTimeKind.Local).AddTicks(5178), "Handmade Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 6, 2, 14, 505, DateTimeKind.Local).AddTicks(98), "Handcrafted Concrete Cheese", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 23, 56, 36, 182, DateTimeKind.Local).AddTicks(2098), "Fantastic Concrete Car", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 2, 53, 50, 306, DateTimeKind.Local).AddTicks(4334), "Awesome Frozen Bacon", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 20, 24, 48, 767, DateTimeKind.Local).AddTicks(1499), "Intelligent Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 5, 3, 24, 190, DateTimeKind.Local).AddTicks(1501), "Practical Fresh Gloves", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 11, 10, 10, 102, DateTimeKind.Local).AddTicks(7329), "Sleek Metal Shoes", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 5, 24, 50, 635, DateTimeKind.Local).AddTicks(8285), "Handmade Steel Chair", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 9, 8, 30, 401, DateTimeKind.Local).AddTicks(7094), "Refined Soft Chair", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 0, 53, 50, 631, DateTimeKind.Local).AddTicks(2664), "Practical Frozen Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 20, 25, 51, 809, DateTimeKind.Local).AddTicks(7815), "Handcrafted Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 21, 59, 11, 116, DateTimeKind.Local).AddTicks(4087), "Incredible Metal Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 9, 14, 56, 824, DateTimeKind.Local).AddTicks(7472), "Sleek Metal Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 14, 50, 2, 571, DateTimeKind.Local).AddTicks(3920), "Ergonomic Cotton Pizza", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 22, 3, 15, 970, DateTimeKind.Local).AddTicks(5613), "Awesome Metal Tuna", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 9, 12, 0, 94, DateTimeKind.Local).AddTicks(1596), "Sleek Soft Bacon", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 18, 54, 45, 248, DateTimeKind.Local).AddTicks(5548), "Handmade Rubber Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 21, 49, 37, 100, DateTimeKind.Local).AddTicks(4982), "Tasty Cotton Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 9, 18, 9, 215, DateTimeKind.Local).AddTicks(2946), "Sleek Cotton Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 21, 45, 29, 699, DateTimeKind.Local).AddTicks(7363), "Rustic Cotton Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 20, 25, 8, 291, DateTimeKind.Local).AddTicks(3856), "Unbranded Steel Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 14, 54, 31, 433, DateTimeKind.Local).AddTicks(698), "Gorgeous Wooden Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 21, 47, 11, 484, DateTimeKind.Local).AddTicks(7519), "Small Rubber Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 14, 46, 18, 367, DateTimeKind.Local).AddTicks(3227), "Ergonomic Granite Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 13, 17, 41, 704, DateTimeKind.Local).AddTicks(483), "Unbranded Wooden Hat", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 10, 14, 8, 168, DateTimeKind.Local).AddTicks(6117), "Gorgeous Granite Pizza", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 19, 42, 57, 13, DateTimeKind.Local).AddTicks(347), "Handmade Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 16, 5, 33, 416, DateTimeKind.Local).AddTicks(9154), "Awesome Rubber Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 10, 12, 12, 973, DateTimeKind.Local).AddTicks(4595), "Licensed Steel Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 10, 7, 23, 276, DateTimeKind.Local).AddTicks(5124), "Gorgeous Soft Gloves", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 21, 50, 26, 421, DateTimeKind.Local).AddTicks(4728), "Fantastic Cotton Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 11, 6, 14, 270, DateTimeKind.Local).AddTicks(6523), "Unbranded Fresh Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 5, 13, 26, 270, DateTimeKind.Local).AddTicks(58), "Generic Steel Fish", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 4, 45, 17, 290, DateTimeKind.Local).AddTicks(7259), "Incredible Concrete Soap", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 16, 58, 31, 756, DateTimeKind.Local).AddTicks(9523), "Handmade Plastic Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 16, 14, 22, 830, DateTimeKind.Local).AddTicks(9174), "Handmade Steel Sausages", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 0, 33, 17, 973, DateTimeKind.Local).AddTicks(58), "Sleek Granite Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 14, 2, 32, 572, DateTimeKind.Local).AddTicks(3638), "Rustic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 19, 20, 23, 604, DateTimeKind.Local).AddTicks(2793), "Practical Frozen Pizza", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 13, 48, 5, 635, DateTimeKind.Local).AddTicks(2266), "Handmade Frozen Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 5, 59, 55, 200, DateTimeKind.Local).AddTicks(8275), "Handmade Wooden Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 14, 26, 9, 153, DateTimeKind.Local).AddTicks(1790), "Gorgeous Wooden Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 16, 51, 23, 955, DateTimeKind.Local).AddTicks(6772), "Fantastic Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 16, 25, 44, 516, DateTimeKind.Local).AddTicks(7611), "Sleek Frozen Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 7, 40, 1, 593, DateTimeKind.Local).AddTicks(6605), "Fantastic Cotton Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 18, 51, 4, 461, DateTimeKind.Local).AddTicks(8780), "Practical Cotton Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 19, 59, 34, 199, DateTimeKind.Local).AddTicks(5307), "Sleek Plastic Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 7, 25, 3, 29, 3, 184, DateTimeKind.Local).AddTicks(8664), "Refined Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 1, 14, 44, 104, DateTimeKind.Local).AddTicks(2260), "Practical Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 21, 5, 39, 358, DateTimeKind.Local).AddTicks(1566), "Awesome Cotton Shoes", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 14, 55, 21, 306, DateTimeKind.Local).AddTicks(802), "Handmade Cotton Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 2, 39, 44, 397, DateTimeKind.Local).AddTicks(6831), "Fantastic Granite Salad", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 12, 21, 1, 194, DateTimeKind.Local).AddTicks(5366), "Practical Metal Table", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 3, 38, 50, 838, DateTimeKind.Local).AddTicks(5969), "Refined Rubber Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 20, 50, 477, DateTimeKind.Local).AddTicks(6989), "Ergonomic Frozen Car", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 9, 56, 7, 844, DateTimeKind.Local).AddTicks(2722), "Rustic Steel Tuna", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 20, 12, 7, 594, DateTimeKind.Local).AddTicks(1070), "Small Fresh Soap", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 0, 11, 26, 915, DateTimeKind.Local).AddTicks(3494), "Ergonomic Metal Bike", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 15, 40, 11, 803, DateTimeKind.Local).AddTicks(7706), "Gorgeous Soft Tuna", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 13, 43, 47, 643, DateTimeKind.Local).AddTicks(259), "Refined Metal Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 1, 46, 30, 116, DateTimeKind.Local).AddTicks(9229), "Refined Frozen Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 12, 22, 33, 808, DateTimeKind.Local).AddTicks(6915), "Intelligent Steel Pants", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 22, 43, 18, 470, DateTimeKind.Local).AddTicks(125), "Ergonomic Metal Shirt", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 21, 13, 13, 311, DateTimeKind.Local).AddTicks(7681), "Incredible Rubber Chips", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 15, 4, 21, 580, DateTimeKind.Local).AddTicks(937), "Ergonomic Frozen Computer", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 1, 47, 25, 630, DateTimeKind.Local).AddTicks(2400), "Tasty Wooden Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 12, 39, 34, 69, DateTimeKind.Local).AddTicks(6016), "Gorgeous Metal Fish", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 14, 59, 12, 67, DateTimeKind.Local).AddTicks(6827), "Unbranded Granite Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 18, 10, 0, 868, DateTimeKind.Local).AddTicks(4800), "Unbranded Granite Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 0, 35, 7, 845, DateTimeKind.Local).AddTicks(7542), "Sleek Cotton Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 19, 17, 12, 200, DateTimeKind.Local).AddTicks(7646), "Awesome Concrete Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 0, 38, 8, 738, DateTimeKind.Local).AddTicks(3938), "Generic Wooden Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 3, 13, 52, 523, DateTimeKind.Local).AddTicks(5545), "Handcrafted Rubber Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 13, 28, 52, 910, DateTimeKind.Local).AddTicks(7393), "Incredible Fresh Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 22, 29, 16, 952, DateTimeKind.Local).AddTicks(1941), "Intelligent Wooden Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 4, 54, 0, 86, DateTimeKind.Local).AddTicks(5771), "Unbranded Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 14, 18, 59, 935, DateTimeKind.Local).AddTicks(398), "Small Steel Mouse", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 8, 8, 3, 426, DateTimeKind.Local).AddTicks(7497), "Intelligent Frozen Sausages", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 9, 35, 51, 943, DateTimeKind.Local).AddTicks(6018), "Tasty Concrete Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 4, 49, 6, 666, DateTimeKind.Local).AddTicks(3388), "Handmade Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 16, 38, 52, 748, DateTimeKind.Local).AddTicks(4214), "Gorgeous Granite Car", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 14, 18, 50, 883, DateTimeKind.Local).AddTicks(1642), "Rustic Metal Shirt", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 20, 10, 22, 37, DateTimeKind.Local).AddTicks(2274), "Tasty Plastic Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 9, 29, 47, 836, DateTimeKind.Local).AddTicks(8600), "Intelligent Steel Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 14, 25, 45, 602, DateTimeKind.Local).AddTicks(7042), "Gorgeous Granite Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 5, 17, 32, 356, DateTimeKind.Local).AddTicks(9558), "Practical Metal Pizza", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 2, 54, 24, 925, DateTimeKind.Local).AddTicks(9906), "Small Rubber Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 17, 48, 39, 119, DateTimeKind.Local).AddTicks(7990), "Rustic Frozen Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 3, 27, 51, 875, DateTimeKind.Local).AddTicks(6305), "Ergonomic Frozen Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 20, 0, 56, 708, DateTimeKind.Local).AddTicks(134), "Tasty Frozen Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 19, 33, 53, 402, DateTimeKind.Local).AddTicks(6113), "Incredible Plastic Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 20, 12, 53, 326, DateTimeKind.Local).AddTicks(1274), "Handmade Granite Pants", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 3, 33, 28, 331, DateTimeKind.Local).AddTicks(493), "Gorgeous Soft Soap", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 44, 25, 55, DateTimeKind.Local).AddTicks(1457), "Handmade Metal Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 3, 1, 2, 910, DateTimeKind.Local).AddTicks(8499), "Refined Plastic Sausages", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 15, 21, 55, 74, DateTimeKind.Local).AddTicks(6579), "Gorgeous Concrete Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 7, 27, 46, 149, DateTimeKind.Local).AddTicks(7498), "Gorgeous Steel Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 15, 40, 18, 619, DateTimeKind.Local).AddTicks(145), "Refined Rubber Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 21, 28, 2, 769, DateTimeKind.Local).AddTicks(2327), "Handcrafted Wooden Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 23, 56, 5, 387, DateTimeKind.Local).AddTicks(1656), "Fantastic Soft Salad", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 12, 0, 36, 577, DateTimeKind.Local).AddTicks(7190), "Practical Wooden Tuna", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 9, 52, 24, 785, DateTimeKind.Local).AddTicks(4587), "Fantastic Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 11, 29, 48, 50, DateTimeKind.Local).AddTicks(1919), "Incredible Plastic Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 20, 11, 21, 146, DateTimeKind.Local).AddTicks(175), "Small Cotton Soap", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 15, 41, 4, 203, DateTimeKind.Local).AddTicks(587), "Licensed Soft Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 7, 43, 7, 543, DateTimeKind.Local).AddTicks(7032), "Gorgeous Concrete Car", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 11, 25, 47, 474, DateTimeKind.Local).AddTicks(5364), "Licensed Granite Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 2, 16, 53, 129, DateTimeKind.Local).AddTicks(4412), "Fantastic Concrete Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 10, 20, 16, 39, DateTimeKind.Local).AddTicks(3347), "Fantastic Fresh Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 34, 32, 890, DateTimeKind.Local).AddTicks(7074), "Incredible Metal Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 11, 4, 168, DateTimeKind.Local).AddTicks(8946), "Handmade Concrete Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 5, 57, 50, 980, DateTimeKind.Local).AddTicks(9219), "Incredible Cotton Towels", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 17, 3, 787, DateTimeKind.Local).AddTicks(9770), "Gorgeous Metal Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 22, 23, 20, 207, DateTimeKind.Local).AddTicks(3844), "Licensed Concrete Hat", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 8, 10, 48, 826, DateTimeKind.Local).AddTicks(7835), "Rustic Cotton Cheese", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 0, 39, 47, 573, DateTimeKind.Local).AddTicks(2218), "Generic Steel Cheese", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 22, 19, 19, 460, DateTimeKind.Local).AddTicks(9682), "Handmade Granite Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 1, 23, 36, 663, DateTimeKind.Local).AddTicks(6911), "Incredible Soft Pants", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 20, 46, 34, 258, DateTimeKind.Local).AddTicks(6346), "Handmade Plastic Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 11, 24, 3, 221, DateTimeKind.Local).AddTicks(2112), "Intelligent Fresh Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 19, 13, 31, 813, DateTimeKind.Local).AddTicks(5001), "Intelligent Concrete Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 16, 35, 24, 300, DateTimeKind.Local).AddTicks(2682), "Awesome Concrete Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 23, 45, 20, 428, DateTimeKind.Local).AddTicks(4899), "Ergonomic Soft Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 23, 0, 24, 490, DateTimeKind.Local).AddTicks(4804), "Unbranded Soft Car", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 2, 40, 27, 310, DateTimeKind.Local).AddTicks(4860), "Unbranded Fresh Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 13, 51, 13, 203, DateTimeKind.Local).AddTicks(1511), "Licensed Rubber Chips", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 3, 52, 28, 965, DateTimeKind.Local).AddTicks(39), "Small Rubber Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 16, 42, 25, 735, DateTimeKind.Local).AddTicks(6981), "Awesome Frozen Chair", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 10, 26, 41, 421, DateTimeKind.Local).AddTicks(4482), "Fantastic Frozen Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 16, 9, 15, 366, DateTimeKind.Local).AddTicks(5163), "Handcrafted Fresh Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 8, 45, 6, 411, DateTimeKind.Local).AddTicks(9982), "Rustic Rubber Shoes", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 22, 13, 27, 332, DateTimeKind.Local).AddTicks(6980), "Generic Cotton Sausages", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 23, 44, 14, 411, DateTimeKind.Local).AddTicks(6064), "Ergonomic Rubber Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 9, 55, 767, DateTimeKind.Local).AddTicks(4510), "Tasty Granite Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 8, 43, 19, 410, DateTimeKind.Local).AddTicks(6363), "Tasty Steel Chicken", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 2, 46, 34, 692, DateTimeKind.Local).AddTicks(4804), "Generic Granite Sausages", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 9, 29, 27, 991, DateTimeKind.Local).AddTicks(4057), "Refined Concrete Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 1, 30, 46, 676, DateTimeKind.Local).AddTicks(5384), "Intelligent Metal Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 11, 20, 0, 885, DateTimeKind.Local).AddTicks(7728), "Incredible Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 15, 17, 43, 937, DateTimeKind.Local).AddTicks(7014), "Handcrafted Cotton Tuna", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 12, 29, 57, 992, DateTimeKind.Local).AddTicks(5545), "Handcrafted Cotton Fish", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 22, 50, 16, 206, DateTimeKind.Local).AddTicks(8340), "Licensed Steel Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 10, 5, 163, DateTimeKind.Local).AddTicks(8222), "Unbranded Soft Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 17, 10, 49, 512, DateTimeKind.Local).AddTicks(7352), "Awesome Concrete Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 3, 24, 27, 357, DateTimeKind.Local).AddTicks(3781), "Rustic Concrete Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 12, 54, 52, 215, DateTimeKind.Local).AddTicks(9920), "Generic Granite Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 7, 15, 11, 965, DateTimeKind.Local).AddTicks(7025), "Incredible Steel Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 21, 30, 9, 370, DateTimeKind.Local).AddTicks(638), "Small Concrete Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 19, 51, 0, 498, DateTimeKind.Local).AddTicks(608), "Generic Cotton Pizza", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 10, 59, 6, 33, DateTimeKind.Local).AddTicks(6357), "Ergonomic Frozen Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 11, 24, 59, 355, DateTimeKind.Local).AddTicks(3600), "Sleek Cotton Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 4, 32, 14, 987, DateTimeKind.Local).AddTicks(538), "Generic Frozen Chips", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 1, 17, 11, 489, DateTimeKind.Local).AddTicks(5047), "Small Metal Bacon", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 22, 22, 24, 341, DateTimeKind.Local).AddTicks(4810), "Unbranded Soft Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 6, 44, 56, 179, DateTimeKind.Local).AddTicks(8622), "Refined Granite Bike", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 43, 11, 50, DateTimeKind.Local).AddTicks(3205), "Small Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 16, 40, 19, 346, DateTimeKind.Local).AddTicks(8357), "Awesome Plastic Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 18, 59, 30, 636, DateTimeKind.Local).AddTicks(9871), "Generic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 12, 7, 19, 732, DateTimeKind.Local).AddTicks(9638), "Rustic Fresh Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 16, 44, 15, 280, DateTimeKind.Local).AddTicks(1781), "Rustic Plastic Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 12, 7, 8, 659, DateTimeKind.Local).AddTicks(8853), "Refined Wooden Fish", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 1, 50, 35, 326, DateTimeKind.Local).AddTicks(6178), "Sleek Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 5, 19, 32, 368, DateTimeKind.Local).AddTicks(4596), "Unbranded Frozen Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 11, 22, 21, 31, DateTimeKind.Local).AddTicks(6416), "Practical Fresh Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 6, 22, 24, 944, DateTimeKind.Local).AddTicks(5499), "Handmade Concrete Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 15, 20, 58, 373, DateTimeKind.Local).AddTicks(3717), "Ergonomic Soft Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 15, 30, 5, 906, DateTimeKind.Local).AddTicks(7831), "Practical Soft Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 19, 21, 7, 600, DateTimeKind.Local).AddTicks(6544), "Unbranded Soft Car", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 11, 53, 17, 633, DateTimeKind.Local).AddTicks(7562), "Unbranded Soft Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 22, 48, 14, 817, DateTimeKind.Local).AddTicks(5214), "Fantastic Steel Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 20, 19, 3, 529, DateTimeKind.Local).AddTicks(5120), "Sleek Rubber Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 34, 31, 666, DateTimeKind.Local).AddTicks(2782), "Unbranded Granite Salad", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 5, 58, 4, 232, DateTimeKind.Local).AddTicks(4049), "Incredible Rubber Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 4, 32, 12, 741, DateTimeKind.Local).AddTicks(7498), "Generic Plastic Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 6, 6, 28, 831, DateTimeKind.Local).AddTicks(3321), "Handmade Concrete Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 18, 4, 12, 414, DateTimeKind.Local).AddTicks(1608), "Refined Granite Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 6, 10, 17, 260, DateTimeKind.Local).AddTicks(3490), "Refined Metal Keyboard", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 13, 26, 54, 158, DateTimeKind.Local).AddTicks(2352), "Licensed Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 3, 56, 11, 86, DateTimeKind.Local).AddTicks(3401), "Sleek Frozen Mouse", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 14, 15, 59, 395, DateTimeKind.Local).AddTicks(7628), "Awesome Concrete Chips", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 2, 50, 52, 763, DateTimeKind.Local).AddTicks(4697), "Licensed Fresh Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 12, 8, 18, 220, DateTimeKind.Local).AddTicks(8780), "Awesome Metal Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 1, 52, 44, 326, DateTimeKind.Local).AddTicks(7949), "Awesome Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 20, 36, 55, 755, DateTimeKind.Local).AddTicks(3611), "Handmade Concrete Salad", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 22, 6, 39, 565, DateTimeKind.Local).AddTicks(3201), "Refined Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 7, 28, 25, 207, DateTimeKind.Local).AddTicks(9660), "Handmade Rubber Car", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 9, 28, 56, 649, DateTimeKind.Local).AddTicks(9924), "Gorgeous Frozen Pizza", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 19, 6, 58, 89, DateTimeKind.Local).AddTicks(9691), "Gorgeous Plastic Cheese", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 5, 33, 8, 720, DateTimeKind.Local).AddTicks(387), "Handmade Wooden Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 12, 2, 42, 46, DateTimeKind.Local).AddTicks(220), "Fantastic Frozen Gloves", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 1, 5, 31, 676, DateTimeKind.Local).AddTicks(4687), "Intelligent Steel Sausages", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 15, 41, 43, 705, DateTimeKind.Local).AddTicks(891), "Intelligent Steel Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 8, 11, 20, 312, DateTimeKind.Local).AddTicks(7325), "Awesome Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 4, 53, 4, 137, DateTimeKind.Local).AddTicks(2073), "Licensed Plastic Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 21, 15, 10, 478, DateTimeKind.Local).AddTicks(6436), "Tasty Fresh Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 15, 29, 28, 596, DateTimeKind.Local).AddTicks(6439), "Intelligent Granite Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 19, 37, 45, 395, DateTimeKind.Local).AddTicks(9270), "Fantastic Cotton Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 3, 43, 42, 446, DateTimeKind.Local).AddTicks(8753), "Sleek Soft Shoes", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 3, 55, 33, 959, DateTimeKind.Local).AddTicks(8740), "Refined Steel Keyboard", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 20, 53, 4, 774, DateTimeKind.Local).AddTicks(3930), "Licensed Frozen Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 16, 39, 20, 460, DateTimeKind.Local).AddTicks(3748), "Ergonomic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 10, 46, 0, 5, DateTimeKind.Local).AddTicks(6272), "Generic Fresh Bike", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 5, 57, 53, 53, DateTimeKind.Local).AddTicks(6240), "Intelligent Concrete Ball", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 21, 30, 41, 118, DateTimeKind.Local).AddTicks(1910), "Refined Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 17, 11, 0, 872, DateTimeKind.Local).AddTicks(1680), "Fantastic Granite Bike", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 5, 28, 57, 231, DateTimeKind.Local).AddTicks(6493), "Generic Cotton Ball", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 14, 39, 23, 847, DateTimeKind.Local).AddTicks(3820), "Gorgeous Steel Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 4, 27, 43, 356, DateTimeKind.Local).AddTicks(6401), "Handcrafted Soft Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 3, 27, 14, 851, DateTimeKind.Local).AddTicks(2830), "Handmade Cotton Chips", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 12, 50, 27, 113, DateTimeKind.Local).AddTicks(622), "Ergonomic Granite Car", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 15, 5, 44, 293, DateTimeKind.Local).AddTicks(3486), "Handmade Wooden Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 23, 58, 51, 382, DateTimeKind.Local).AddTicks(4371), "Handmade Frozen Gloves", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 15, 9, 13, 877, DateTimeKind.Local).AddTicks(847), "Rustic Wooden Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 16, 45, 30, 350, DateTimeKind.Local).AddTicks(769), "Unbranded Frozen Bike", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 15, 16, 8, 356, DateTimeKind.Local).AddTicks(6731), "Ergonomic Metal Fish", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 5, 44, 0, 876, DateTimeKind.Local).AddTicks(1637), "Tasty Fresh Gloves", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 9, 19, 4, 997, DateTimeKind.Local).AddTicks(3214), "Sleek Metal Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 7, 14, 32, 724, DateTimeKind.Local).AddTicks(7015), "Small Concrete Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 18, 39, 10, 804, DateTimeKind.Local).AddTicks(9143), "Rustic Granite Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 2, 31, 5, 235, DateTimeKind.Local).AddTicks(8741), "Practical Cotton Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 0, 3, 44, 234, DateTimeKind.Local).AddTicks(7369), "Gorgeous Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 2, 12, 20, 397, DateTimeKind.Local).AddTicks(9343), "Small Soft Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 7, 11, 35, 959, DateTimeKind.Local).AddTicks(698), "Awesome Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 7, 1, 37, 405, DateTimeKind.Local).AddTicks(1105), "Unbranded Fresh Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 18, 48, 10, 212, DateTimeKind.Local).AddTicks(1530), "Practical Concrete Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 10, 43, 13, 521, DateTimeKind.Local).AddTicks(8612), "Licensed Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 19, 23, 19, 385, DateTimeKind.Local).AddTicks(4381), "Practical Plastic Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 3, 34, 28, 774, DateTimeKind.Local).AddTicks(7036), "Refined Plastic Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 8, 6, 7, 205, DateTimeKind.Local).AddTicks(9226), "Handcrafted Plastic Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 8, 58, 27, 671, DateTimeKind.Local).AddTicks(4988), "Handmade Fresh Pizza", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 1, 53, 1, 430, DateTimeKind.Local).AddTicks(7392), "Handcrafted Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 23, 5, 37, 569, DateTimeKind.Local).AddTicks(5594), "Refined Rubber Bike", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 15, 51, 55, 421, DateTimeKind.Local).AddTicks(7794), "Gorgeous Frozen Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 7, 8, 19, 725, DateTimeKind.Local).AddTicks(7161), "Intelligent Concrete Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 15, 43, 15, 300, DateTimeKind.Local).AddTicks(9975), "Licensed Frozen Bacon", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 15, 20, 44, 344, DateTimeKind.Local).AddTicks(9306), "Tasty Cotton Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 17, 17, 24, 607, DateTimeKind.Local).AddTicks(3251), "Awesome Granite Towels", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 9, 7, 23, 262, DateTimeKind.Local).AddTicks(3018), "Incredible Cotton Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 21, 55, 29, 996, DateTimeKind.Local).AddTicks(6919), "Handmade Soft Bike", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 1, 45, 7, 669, DateTimeKind.Local).AddTicks(1398), "Practical Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 7, 43, 32, 336, DateTimeKind.Local).AddTicks(6741), "Rustic Cotton Bacon", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 4, 7, 56, 399, DateTimeKind.Local).AddTicks(6710), "Awesome Plastic Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 20, 29, 34, 982, DateTimeKind.Local).AddTicks(1041), "Awesome Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 11, 19, 25, 486, DateTimeKind.Local).AddTicks(5102), "Sleek Metal Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 5, 22, 29, 74, DateTimeKind.Local).AddTicks(4499), "Tasty Steel Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 20, 17, 59, 116, DateTimeKind.Local).AddTicks(8554), "Tasty Concrete Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 22, 45, 12, 961, DateTimeKind.Local).AddTicks(7290), "Gorgeous Wooden Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 21, 37, 50, 271, DateTimeKind.Local).AddTicks(7552), "Rustic Rubber Chips", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 5, 45, 38, 896, DateTimeKind.Local).AddTicks(8035), "Refined Cotton Soap", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 3, 19, 7, 677, DateTimeKind.Local).AddTicks(1404), "Gorgeous Concrete Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 4, 8, 13, 712, DateTimeKind.Local).AddTicks(9972), "Small Wooden Fish", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 3, 3, 23, 671, DateTimeKind.Local).AddTicks(8374), "Licensed Metal Car", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 22, 21, 18, 910, DateTimeKind.Local).AddTicks(9980), "Rustic Steel Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 6, 7, 19, 703, DateTimeKind.Local).AddTicks(2908), "Fantastic Soft Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 20, 11, 4, 719, DateTimeKind.Local).AddTicks(4576), "Incredible Concrete Pants", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 43, 55, 282, DateTimeKind.Local).AddTicks(8147), "Fantastic Rubber Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 17, 38, 30, 238, DateTimeKind.Local).AddTicks(8691), "Fantastic Fresh Ball", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 13, 6, 21, 661, DateTimeKind.Local).AddTicks(3734), "Licensed Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 1, 24, 5, 50, DateTimeKind.Local).AddTicks(2039), "Unbranded Fresh Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 0, 16, 31, 361, DateTimeKind.Local).AddTicks(3732), "Generic Soft Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 4, 50, 1, 616, DateTimeKind.Local).AddTicks(9712), "Intelligent Soft Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 2, 8, 17, 709, DateTimeKind.Local).AddTicks(153), "Gorgeous Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 20, 14, 29, 390, DateTimeKind.Local).AddTicks(5633), "Ergonomic Steel Ball", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 23, 31, 30, 305, DateTimeKind.Local).AddTicks(6646), "Small Soft Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 23, 50, 23, 419, DateTimeKind.Local).AddTicks(1986), "Small Steel Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 7, 18, 14, 53, DateTimeKind.Local).AddTicks(9571), "Licensed Rubber Pants", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 0, 11, 35, 883, DateTimeKind.Local).AddTicks(9017), "Handmade Wooden Bike", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 13, 7, 13, 519, DateTimeKind.Local).AddTicks(7897), "Generic Frozen Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 12, 12, 25, 435, DateTimeKind.Local).AddTicks(7913), "Awesome Wooden Pants", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 14, 20, 35, 278, DateTimeKind.Local).AddTicks(9391), "Refined Plastic Chair", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 5, 18, 13, 584, DateTimeKind.Local).AddTicks(4832), "Small Granite Shoes", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 7, 42, 37, 625, DateTimeKind.Local).AddTicks(8506), "Refined Wooden Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 9, 34, 45, 759, DateTimeKind.Local).AddTicks(1238), "Ergonomic Metal Soap", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 5, 48, 1, 256, DateTimeKind.Local).AddTicks(4890), "Rustic Plastic Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 2, 25, 39, 447, DateTimeKind.Local).AddTicks(6492), "Rustic Steel Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 23, 15, 32, 727, DateTimeKind.Local).AddTicks(7377), "Ergonomic Fresh Chips", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 2, 7, 45, 709, DateTimeKind.Local).AddTicks(78), "Practical Frozen Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 8, 4, 2, 228, DateTimeKind.Local).AddTicks(358), "Ergonomic Rubber Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 6, 12, 16, 723, DateTimeKind.Local).AddTicks(2113), "Incredible Soft Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 14, 30, 20, 251, DateTimeKind.Local).AddTicks(8929), "Licensed Wooden Keyboard", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 15, 52, 469, DateTimeKind.Local).AddTicks(2787), "Handmade Plastic Soap", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 0, 48, 34, 735, DateTimeKind.Local).AddTicks(7379), "Gorgeous Frozen Ball", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 11, 24, 10, 385, DateTimeKind.Local).AddTicks(9658), "Awesome Steel Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 0, 23, 45, 526, DateTimeKind.Local).AddTicks(6563), "Unbranded Metal Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 9, 5, 0, 22, DateTimeKind.Local).AddTicks(6902), "Intelligent Soft Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 5, 37, 11, 87, DateTimeKind.Local).AddTicks(5805), "Handcrafted Concrete Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 23, 40, 7, 953, DateTimeKind.Local).AddTicks(5208), "Handmade Fresh Shoes", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 10, 26, 49, 772, DateTimeKind.Local).AddTicks(6719), "Ergonomic Frozen Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 0, 19, 25, 603, DateTimeKind.Local).AddTicks(2505), "Sleek Wooden Fish", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 0, 38, 19, 990, DateTimeKind.Local).AddTicks(7282), "Refined Steel Gloves", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 9, 32, 20, 164, DateTimeKind.Local).AddTicks(4569), "Unbranded Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 17, 34, 1, 876, DateTimeKind.Local).AddTicks(1918), "Practical Fresh Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 14, 29, 40, 173, DateTimeKind.Local).AddTicks(1502), "Ergonomic Frozen Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 11, 14, 26, 931, DateTimeKind.Local).AddTicks(7656), "Licensed Rubber Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 17, 20, 10, 750, DateTimeKind.Local).AddTicks(231), "Generic Rubber Computer", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 12, 17, 45, 810, DateTimeKind.Local).AddTicks(724), "Unbranded Metal Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 17, 23, 34, 158, DateTimeKind.Local).AddTicks(7904), "Generic Frozen Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 23, 44, 57, 486, DateTimeKind.Local).AddTicks(4427), "Incredible Metal Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 9, 21, 40, 470, DateTimeKind.Local).AddTicks(4769), "Awesome Wooden Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 19, 58, 18, 871, DateTimeKind.Local).AddTicks(1524), "Small Soft Fish", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 1, 14, 52, 179, DateTimeKind.Local).AddTicks(2905), "Refined Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 13, 52, 29, 26, DateTimeKind.Local).AddTicks(8888), "Ergonomic Rubber Pizza", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 13, 44, 25, 612, DateTimeKind.Local).AddTicks(456), "Rustic Soft Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 17, 17, 40, 392, DateTimeKind.Local).AddTicks(133), "Refined Steel Salad", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 1, 11, 54, 584, DateTimeKind.Local).AddTicks(2589), "Incredible Metal Salad", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 8, 4, 37, 44, DateTimeKind.Local).AddTicks(8511), "Generic Cotton Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 5, 6, 12, 951, DateTimeKind.Local).AddTicks(2169), "Sleek Granite Cheese", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 10, 54, 16, 675, DateTimeKind.Local).AddTicks(5796), "Rustic Concrete Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 14, 11, 57, 437, DateTimeKind.Local).AddTicks(2052), "Unbranded Plastic Pants", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 4, 11, 39, 381, DateTimeKind.Local).AddTicks(6774), "Sleek Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 1, 42, 38, 772, DateTimeKind.Local).AddTicks(7451), "Refined Rubber Fish", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 21, 5, 37, 526, DateTimeKind.Local).AddTicks(4124), "Awesome Wooden Table", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 8, 48, 46, 239, DateTimeKind.Local).AddTicks(4588), "Handmade Plastic Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 18, 32, 10, 754, DateTimeKind.Local).AddTicks(8648), "Small Plastic Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 2, 40, 24, 919, DateTimeKind.Local).AddTicks(2758), "Generic Steel Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 8, 1, 52, 906, DateTimeKind.Local).AddTicks(9531), "Sleek Soft Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 22, 25, 18, 465, DateTimeKind.Local).AddTicks(7186), "Licensed Cotton Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 10, 30, 42, 888, DateTimeKind.Local).AddTicks(649), "Rustic Concrete Cheese", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 11, 33, 43, 216, DateTimeKind.Local).AddTicks(5613), "Rustic Rubber Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 11, 28, 18, 725, DateTimeKind.Local).AddTicks(7520), "Ergonomic Soft Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 1, 28, 38, 359, DateTimeKind.Local).AddTicks(2070), "Rustic Plastic Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 5, 47, 9, 897, DateTimeKind.Local).AddTicks(7535), "Rustic Rubber Chips", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 0, 44, 4, 283, DateTimeKind.Local).AddTicks(4406), "Generic Steel Ball", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 0, 8, 3, 506, DateTimeKind.Local).AddTicks(2685), "Handmade Granite Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 6, 17, 55, 848, DateTimeKind.Local).AddTicks(8671), "Awesome Metal Tuna", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 23, 18, 42, 237, DateTimeKind.Local).AddTicks(2596), "Handcrafted Fresh Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 10, 18, 53, 467, DateTimeKind.Local).AddTicks(7709), "Unbranded Wooden Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 11, 57, 6, 495, DateTimeKind.Local).AddTicks(972), "Practical Wooden Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 22, 53, 1, 851, DateTimeKind.Local).AddTicks(9739), "Incredible Wooden Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 3, 12, 7, 951, DateTimeKind.Local).AddTicks(789), "Small Granite Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 18, 52, 30, 592, DateTimeKind.Local).AddTicks(2814), "Intelligent Concrete Shoes", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 1, 25, 54, 926, DateTimeKind.Local).AddTicks(463), "Refined Rubber Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 15, 14, 27, 685, DateTimeKind.Local).AddTicks(9545), "Intelligent Rubber Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 21, 52, 25, 313, DateTimeKind.Local).AddTicks(7542), "Ergonomic Concrete Fish", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 3, 52, 13, 720, DateTimeKind.Local).AddTicks(2679), "Gorgeous Soft Table", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 18, 51, 1, 2, DateTimeKind.Local).AddTicks(1196), "Awesome Fresh Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 7, 27, 0, 957, DateTimeKind.Local).AddTicks(7115), "Ergonomic Frozen Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 7, 44, 26, 615, DateTimeKind.Local).AddTicks(2208), "Small Cotton Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 8, 45, 20, 987, DateTimeKind.Local).AddTicks(8563), "Licensed Cotton Tuna", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 9, 31, 54, 550, DateTimeKind.Local).AddTicks(8593), "Small Wooden Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 10, 10, 53, 954, DateTimeKind.Local).AddTicks(6419), "Refined Cotton Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 8, 18, 22, 637, DateTimeKind.Local).AddTicks(2726), "Incredible Rubber Table", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 27, 23, 877, DateTimeKind.Local).AddTicks(4385), "Small Wooden Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 21, 9, 22, 362, DateTimeKind.Local).AddTicks(652), "Licensed Rubber Shoes", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 0, 19, 58, 218, DateTimeKind.Local).AddTicks(4139), "Incredible Concrete Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 9, 52, 58, 911, DateTimeKind.Local).AddTicks(3240), "Intelligent Plastic Sausages", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 16, 15, 5, 520, DateTimeKind.Local).AddTicks(3569), "Practical Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 1, 34, 23, 654, DateTimeKind.Local).AddTicks(9366), "Practical Concrete Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 18, 2, 51, 677, DateTimeKind.Local).AddTicks(4458), "Small Cotton Gloves", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 12, 35, 48, 32, DateTimeKind.Local).AddTicks(992), "Practical Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 18, 51, 28, 782, DateTimeKind.Local).AddTicks(259), "Licensed Concrete Car", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 5, 44, 20, 622, DateTimeKind.Local).AddTicks(3806), "Refined Soft Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 3, 3, 19, 180, DateTimeKind.Local).AddTicks(6029), "Handcrafted Steel Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 7, 44, 46, 660, DateTimeKind.Local).AddTicks(8230), "Licensed Granite Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 8, 16, 41, 353, DateTimeKind.Local).AddTicks(9021), "Tasty Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 8, 44, 25, 382, DateTimeKind.Local).AddTicks(3988), "Unbranded Steel Gloves", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 7, 1, 12, 343, DateTimeKind.Local).AddTicks(9613), "Incredible Frozen Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 7, 38, 16, 210, DateTimeKind.Local).AddTicks(2658), "Awesome Metal Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 2, 16, 19, 516, DateTimeKind.Local).AddTicks(3791), "Awesome Granite Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 16, 37, 51, 44, DateTimeKind.Local).AddTicks(9079), "Refined Rubber Shoes", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 15, 10, 30, 36, DateTimeKind.Local).AddTicks(3531), "Tasty Granite Soap", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 15, 11, 11, 258, DateTimeKind.Local).AddTicks(7496), "Sleek Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 1, 4, 15, 184, DateTimeKind.Local).AddTicks(900), "Intelligent Wooden Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 11, 26, 33, 308, DateTimeKind.Local).AddTicks(6071), "Awesome Granite Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 18, 26, 38, 289, DateTimeKind.Local).AddTicks(1400), "Ergonomic Frozen Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 1, 18, 32, 926, DateTimeKind.Local).AddTicks(6721), "Fantastic Rubber Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 7, 52, 52, 4, DateTimeKind.Local).AddTicks(3436), "Intelligent Metal Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 20, 18, 1, 87, DateTimeKind.Local).AddTicks(5800), "Unbranded Metal Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 13, 19, 3, 299, DateTimeKind.Local).AddTicks(318), "Sleek Frozen Gloves", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 15, 48, 31, 667, DateTimeKind.Local).AddTicks(1587), "Practical Steel Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 15, 57, 6, 714, DateTimeKind.Local).AddTicks(6219), "Awesome Fresh Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 1, 22, 57, 394, DateTimeKind.Local).AddTicks(5376), "Sleek Concrete Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 18, 46, 21, 477, DateTimeKind.Local).AddTicks(2269), "Practical Granite Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 16, 4, 7, 457, DateTimeKind.Local).AddTicks(7058), "Practical Fresh Ball", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 23, 58, 32, 833, DateTimeKind.Local).AddTicks(3519), "Gorgeous Frozen Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 2, 46, 55, 110, DateTimeKind.Local).AddTicks(6354), "Ergonomic Cotton Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 20, 38, 33, 743, DateTimeKind.Local).AddTicks(3647), "Intelligent Steel Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 16, 1, 54, 863, DateTimeKind.Local).AddTicks(7563), "Sleek Cotton Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 22, 13, 38, 443, DateTimeKind.Local).AddTicks(8832), "Refined Granite Sausages", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 8, 26, 2, 195, DateTimeKind.Local).AddTicks(2997), "Ergonomic Concrete Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 15, 32, 51, 788, DateTimeKind.Local).AddTicks(8883), "Sleek Rubber Table", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 16, 12, 59, 615, DateTimeKind.Local).AddTicks(6053), "Awesome Soft Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 14, 46, 48, 241, DateTimeKind.Local).AddTicks(2884), "Small Wooden Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 9, 44, 39, 962, DateTimeKind.Local).AddTicks(1630), "Refined Cotton Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 16, 42, 44, 154, DateTimeKind.Local).AddTicks(9789), "Tasty Cotton Keyboard", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 4, 19, 10, 26, DateTimeKind.Local).AddTicks(1563), "Licensed Frozen Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 13, 58, 8, 781, DateTimeKind.Local).AddTicks(4133), "Practical Cotton Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 13, 25, 36, 632, DateTimeKind.Local).AddTicks(4649), "Awesome Fresh Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 13, 4, 59, 645, DateTimeKind.Local).AddTicks(77), "Handmade Soft Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 13, 11, 17, 913, DateTimeKind.Local).AddTicks(3519), "Fantastic Plastic Towels", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 23, 42, 23, 943, DateTimeKind.Local).AddTicks(2114), "Ergonomic Granite Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 3, 5, 1, 455, DateTimeKind.Local).AddTicks(7363), "Rustic Concrete Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 6, 24, 30, 566, DateTimeKind.Local).AddTicks(692), "Licensed Granite Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 6, 57, 26, 866, DateTimeKind.Local).AddTicks(1656), "Handcrafted Granite Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 19, 13, 51, 135, DateTimeKind.Local).AddTicks(7221), "Sleek Steel Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 5, 2, 31, 600, DateTimeKind.Local).AddTicks(9088), "Fantastic Wooden Towels", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 8, 14, 48, 541, DateTimeKind.Local).AddTicks(4750), "Small Concrete Tuna", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 3, 19, 29, 234, DateTimeKind.Local).AddTicks(5985), "Fantastic Frozen Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 19, 20, 10, 71, DateTimeKind.Local).AddTicks(193), "Small Plastic Fish", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 2, 50, 53, 368, DateTimeKind.Local).AddTicks(9452), "Handcrafted Cotton Mouse", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 0, 16, 58, 144, DateTimeKind.Local).AddTicks(4703), "Awesome Cotton Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 0, 37, 56, 41, DateTimeKind.Local).AddTicks(5526), "Sleek Soft Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 19, 47, 6, 606, DateTimeKind.Local).AddTicks(2757), "Licensed Soft Shirt", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 0, 53, 33, 236, DateTimeKind.Local).AddTicks(8084), "Handmade Cotton Salad", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 21, 26, 59, 218, DateTimeKind.Local).AddTicks(308), "Small Frozen Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 20, 7, 13, 238, DateTimeKind.Local).AddTicks(9132), "Incredible Wooden Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 1, 57, 8, 309, DateTimeKind.Local).AddTicks(9511), "Awesome Frozen Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 14, 35, 11, 519, DateTimeKind.Local).AddTicks(5360), "Handmade Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 14, 19, 43, 567, DateTimeKind.Local).AddTicks(5107), "Intelligent Plastic Car", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 3, 42, 11, 17, DateTimeKind.Local).AddTicks(1861), "Licensed Metal Bacon", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 7, 25, 8, 50, 12, 670, DateTimeKind.Local).AddTicks(5186), "Fantastic Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 12, 28, 52, 875, DateTimeKind.Local).AddTicks(9100), "Fantastic Wooden Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 22, 43, 47, 100, DateTimeKind.Local).AddTicks(7140), "Small Granite Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 3, 19, 29, 260, DateTimeKind.Local).AddTicks(5228), "Gorgeous Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 6, 38, 46, 725, DateTimeKind.Local).AddTicks(5616), "Tasty Metal Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 0, 3, 7, 812, DateTimeKind.Local).AddTicks(2587), "Gorgeous Plastic Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 13, 21, 43, 461, DateTimeKind.Local).AddTicks(5435), "Rustic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 13, 51, 16, 818, DateTimeKind.Local).AddTicks(7662), "Tasty Wooden Computer", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 12, 32, 54, 805, DateTimeKind.Local).AddTicks(4280), "Rustic Cotton Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 11, 26, 51, 288, DateTimeKind.Local).AddTicks(3766), "Refined Rubber Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 19, 45, 44, 319, DateTimeKind.Local).AddTicks(6711), "Licensed Wooden Fish", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 6, 19, 6, 320, DateTimeKind.Local).AddTicks(3938), "Fantastic Fresh Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 2, 10, 40, 928, DateTimeKind.Local).AddTicks(6723), "Unbranded Cotton Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 21, 35, 20, 399, DateTimeKind.Local).AddTicks(5114), "Practical Granite Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 12, 19, 51, 558, DateTimeKind.Local).AddTicks(7792), "Refined Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 21, 19, 12, 262, DateTimeKind.Local).AddTicks(4467), "Gorgeous Frozen Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 7, 10, 18, 26, DateTimeKind.Local).AddTicks(6269), "Incredible Fresh Pizza", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 2, 17, 12, 995, DateTimeKind.Local).AddTicks(3599), "Generic Rubber Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 22, 35, 19, 52, DateTimeKind.Local).AddTicks(4934), "Awesome Fresh Cheese", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 11, 7, 53, 307, DateTimeKind.Local).AddTicks(8237), "Practical Rubber Salad", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 17, 9, 36, 37, DateTimeKind.Local).AddTicks(2565), "Generic Wooden Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 3, 35, 15, 341, DateTimeKind.Local).AddTicks(9343), "Awesome Wooden Chicken", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 7, 13, 31, 645, DateTimeKind.Local).AddTicks(2207), "Practical Frozen Shoes", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 14, 32, 47, 334, DateTimeKind.Local).AddTicks(4445), "Generic Wooden Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 17, 14, 12, 996, DateTimeKind.Local).AddTicks(1488), "Awesome Wooden Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 0, 20, 43, 9, DateTimeKind.Local).AddTicks(895), "Fantastic Rubber Car", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 21, 13, 34, 763, DateTimeKind.Local).AddTicks(5001), "Rustic Plastic Fish", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 6, 12, 25, 296, DateTimeKind.Local).AddTicks(7698), "Practical Wooden Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 10, 52, 41, 362, DateTimeKind.Local).AddTicks(2411), "Ergonomic Plastic Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 21, 2, 4, 190, DateTimeKind.Local).AddTicks(5440), "Rustic Steel Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 5, 1, 37, 929, DateTimeKind.Local).AddTicks(3604), "Refined Wooden Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 16, 12, 32, 923, DateTimeKind.Local).AddTicks(4175), "Handcrafted Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 7, 8, 17, 220, DateTimeKind.Local).AddTicks(4901), "Fantastic Wooden Cheese", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 13, 47, 8, 541, DateTimeKind.Local).AddTicks(8108), "Refined Cotton Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 13, 11, 33, 189, DateTimeKind.Local).AddTicks(4864), "Sleek Rubber Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 22, 20, 34, 717, DateTimeKind.Local).AddTicks(665), "Handmade Metal Sausages", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 18, 51, 56, 234, DateTimeKind.Local).AddTicks(9800), "Incredible Steel Pants", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 14, 15, 52, 330, DateTimeKind.Local).AddTicks(5550), "Refined Rubber Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 12, 47, 20, 907, DateTimeKind.Local).AddTicks(3491), "Tasty Cotton Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 11, 35, 23, 577, DateTimeKind.Local).AddTicks(7248), "Small Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 22, 25, 1, 701, DateTimeKind.Local).AddTicks(7866), "Refined Rubber Pizza", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 23, 46, 13, 200, DateTimeKind.Local).AddTicks(5700), "Handcrafted Plastic Cheese", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 16, 25, 3, 249, DateTimeKind.Local).AddTicks(2142), "Handcrafted Wooden Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 15, 17, 36, 628, DateTimeKind.Local).AddTicks(4554), "Licensed Plastic Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 9, 0, 17, 901, DateTimeKind.Local).AddTicks(4690), "Handcrafted Soft Gloves", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 9, 49, 16, 336, DateTimeKind.Local).AddTicks(4731), "Sleek Steel Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 11, 15, 27, 517, DateTimeKind.Local).AddTicks(4327), "Unbranded Cotton Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 22, 18, 31, 967, DateTimeKind.Local).AddTicks(6783), "Rustic Rubber Pants", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 20, 58, 22, 87, DateTimeKind.Local).AddTicks(6589), "Practical Rubber Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 5, 38, 492, DateTimeKind.Local).AddTicks(6250), "Sleek Steel Sausages", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 4, 42, 4, 579, DateTimeKind.Local).AddTicks(1803), "Small Fresh Table", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 8, 41, 46, 745, DateTimeKind.Local).AddTicks(2954), "Practical Frozen Chair", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 2, 9, 51, 580, DateTimeKind.Local).AddTicks(1251), "Tasty Frozen Fish", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 19, 40, 58, 38, DateTimeKind.Local).AddTicks(9147), "Generic Concrete Cheese", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 5, 2, 41, 114, DateTimeKind.Local).AddTicks(5263), "Small Cotton Chips", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 2, 47, 14, 320, DateTimeKind.Local).AddTicks(1716), "Incredible Concrete Fish", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 7, 37, 27, 769, DateTimeKind.Local).AddTicks(6296), "Generic Steel Towels", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 13, 58, 33, 628, DateTimeKind.Local).AddTicks(1381), "Incredible Cotton Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 19, 35, 19, 714, DateTimeKind.Local).AddTicks(3652), "Handmade Cotton Ball", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 7, 29, 16, 945, DateTimeKind.Local).AddTicks(555), "Rustic Concrete Chips", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 1, 22, 6, 850, DateTimeKind.Local).AddTicks(1919), "Sleek Wooden Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 18, 3, 35, 776, DateTimeKind.Local).AddTicks(6139), "Practical Frozen Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 11, 38, 42, 642, DateTimeKind.Local).AddTicks(4482), "Awesome Fresh Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 21, 44, 12, 634, DateTimeKind.Local).AddTicks(3981), "Handmade Fresh Car", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 0, 36, 41, 359, DateTimeKind.Local).AddTicks(9687), "Handmade Rubber Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 23, 20, 5, 656, DateTimeKind.Local).AddTicks(994), "Small Wooden Sausages", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 17, 19, 4, 298, DateTimeKind.Local).AddTicks(9441), "Incredible Plastic Cheese", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 20, 11, 28, 514, DateTimeKind.Local).AddTicks(3274), "Ergonomic Wooden Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 3, 15, 21, 877, DateTimeKind.Local).AddTicks(5029), "Gorgeous Concrete Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 20, 49, 42, 458, DateTimeKind.Local).AddTicks(4206), "Refined Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 20, 43, 33, 628, DateTimeKind.Local).AddTicks(7368), "Licensed Cotton Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 7, 53, 2, 579, DateTimeKind.Local).AddTicks(7253), "Gorgeous Metal Chicken", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 13, 2, 5, 742, DateTimeKind.Local).AddTicks(5710), "Small Soft Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 9, 15, 4, 224, DateTimeKind.Local).AddTicks(7238), "Tasty Rubber Cheese", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 6, 35, 11, 92, DateTimeKind.Local).AddTicks(4501), "Small Rubber Salad", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 3, 24, 45, 200, DateTimeKind.Local).AddTicks(5116), "Refined Plastic Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 2, 21, 56, 557, DateTimeKind.Local).AddTicks(6396), "Practical Wooden Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 22, 14, 8, 889, DateTimeKind.Local).AddTicks(4062), "Awesome Frozen Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 2, 38, 27, 852, DateTimeKind.Local).AddTicks(4984), "Fantastic Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 22, 32, 51, 178, DateTimeKind.Local).AddTicks(8835), "Licensed Granite Keyboard", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 10, 43, 24, 861, DateTimeKind.Local).AddTicks(9996), "Fantastic Plastic Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 20, 16, 11, 444, DateTimeKind.Local).AddTicks(5739), "Intelligent Steel Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 22, 32, 7, 815, DateTimeKind.Local).AddTicks(9353), "Small Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 0, 29, 499, DateTimeKind.Local).AddTicks(1292), "Intelligent Plastic Chicken", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 15, 10, 57, 687, DateTimeKind.Local).AddTicks(2539), "Refined Fresh Cheese", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 8, 34, 39, 854, DateTimeKind.Local).AddTicks(4072), "Rustic Fresh Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 19, 9, 55, 648, DateTimeKind.Local).AddTicks(5453), "Awesome Metal Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 14, 4, 52, 876, DateTimeKind.Local).AddTicks(6649), "Handmade Rubber Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 11, 51, 56, 685, DateTimeKind.Local).AddTicks(6579), "Ergonomic Cotton Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 1, 12, 20, 402, DateTimeKind.Local).AddTicks(7980), "Incredible Rubber Bacon", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 3, 49, 602, DateTimeKind.Local).AddTicks(873), "Sleek Fresh Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 44, 41, 984, DateTimeKind.Local).AddTicks(4321), "Refined Frozen Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 5, 40, 55, 701, DateTimeKind.Local).AddTicks(6807), "Incredible Plastic Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 0, 18, 41, 539, DateTimeKind.Local).AddTicks(5806), "Licensed Wooden Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 15, 13, 59, 511, DateTimeKind.Local).AddTicks(2261), "Ergonomic Rubber Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 4, 3, 2, 699, DateTimeKind.Local).AddTicks(2464), "Incredible Cotton Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 0, 2, 42, 387, DateTimeKind.Local).AddTicks(7860), "Handmade Soft Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 3, 30, 21, 401, DateTimeKind.Local).AddTicks(9361), "Tasty Plastic Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 7, 25, 1, 59, 0, 504, DateTimeKind.Local).AddTicks(2282), "Tasty Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 7, 38, 20, 306, DateTimeKind.Local).AddTicks(3379), "Tasty Rubber Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 21, 50, 16, 626, DateTimeKind.Local).AddTicks(3840), "Licensed Wooden Tuna", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 12, 2, 47, 750, DateTimeKind.Local).AddTicks(1225), "Unbranded Cotton Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 6, 16, 22, 934, DateTimeKind.Local).AddTicks(2383), "Practical Fresh Fish", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 22, 43, 5, 285, DateTimeKind.Local).AddTicks(3057), "Practical Rubber Keyboard", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 12, 50, 22, 373, DateTimeKind.Local).AddTicks(2344), "Gorgeous Cotton Salad", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 38, 20, 665, DateTimeKind.Local).AddTicks(9748), "Ergonomic Metal Tuna", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 12, 2, 0, 161, DateTimeKind.Local).AddTicks(3089), "Gorgeous Metal Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 16, 31, 14, 687, DateTimeKind.Local).AddTicks(2341), "Generic Soft Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 4, 58, 16, 581, DateTimeKind.Local).AddTicks(7613), "Awesome Granite Chips", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 12, 50, 56, 771, DateTimeKind.Local).AddTicks(3146), "Tasty Wooden Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 5, 11, 49, 839, DateTimeKind.Local).AddTicks(3525), "Handmade Steel Table", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 21, 34, 35, 62, DateTimeKind.Local).AddTicks(5636), "Incredible Fresh Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 6, 20, 42, 484, DateTimeKind.Local).AddTicks(7325), "Generic Granite Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 12, 56, 8, 43, DateTimeKind.Local).AddTicks(6356), "Handmade Steel Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 18, 56, 27, 463, DateTimeKind.Local).AddTicks(8180), "Sleek Rubber Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 1, 30, 21, 114, DateTimeKind.Local).AddTicks(2609), "Gorgeous Wooden Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 7, 4, 16, 831, DateTimeKind.Local).AddTicks(4688), "Practical Rubber Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 23, 32, 9, 280, DateTimeKind.Local).AddTicks(8427), "Licensed Frozen Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 22, 36, 36, 368, DateTimeKind.Local).AddTicks(6161), "Ergonomic Rubber Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 9, 23, 52, 68, DateTimeKind.Local).AddTicks(6121), "Small Metal Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 3, 49, 47, 29, DateTimeKind.Local).AddTicks(7349), "Refined Steel Soap", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 11, 5, 23, 113, DateTimeKind.Local).AddTicks(9883), "Ergonomic Plastic Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 20, 28, 5, 979, DateTimeKind.Local).AddTicks(6222), "Refined Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 0, 26, 11, 682, DateTimeKind.Local).AddTicks(6828), "Generic Fresh Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 16, 56, 39, 227, DateTimeKind.Local).AddTicks(2274), "Small Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 15, 7, 44, 581, DateTimeKind.Local).AddTicks(914), "Tasty Rubber Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 4, 34, 56, 211, DateTimeKind.Local).AddTicks(3800), "Small Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 14, 34, 26, 298, DateTimeKind.Local).AddTicks(7980), "Tasty Soft Tuna", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 11, 51, 22, 46, DateTimeKind.Local).AddTicks(4788), "Unbranded Metal Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 16, 40, 39, 159, DateTimeKind.Local).AddTicks(1740), "Awesome Frozen Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 23, 9, 30, 517, DateTimeKind.Local).AddTicks(3416), "Gorgeous Cotton Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 12, 47, 23, 985, DateTimeKind.Local).AddTicks(9846), "Generic Rubber Pizza", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 4, 32, 57, 555, DateTimeKind.Local).AddTicks(4903), "Small Rubber Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 14, 40, 58, 51, DateTimeKind.Local).AddTicks(2594), "Handcrafted Steel Chair", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 18, 25, 25, 839, DateTimeKind.Local).AddTicks(8328), "Generic Concrete Sausages", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 22, 59, 34, 811, DateTimeKind.Local).AddTicks(9565), "Fantastic Granite Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 0, 24, 1, 535, DateTimeKind.Local).AddTicks(232), "Generic Wooden Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 5, 58, 48, 361, DateTimeKind.Local).AddTicks(8396), "Handcrafted Granite Sausages", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 2, 22, 11, 521, DateTimeKind.Local).AddTicks(85), "Licensed Fresh Mouse", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 22, 36, 56, 892, DateTimeKind.Local).AddTicks(6949), "Sleek Wooden Cheese", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 11, 48, 9, 65, DateTimeKind.Local).AddTicks(5843), "Refined Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 15, 16, 2, 752, DateTimeKind.Local).AddTicks(3526), "Ergonomic Granite Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 12, 16, 7, 54, DateTimeKind.Local).AddTicks(8114), "Generic Wooden Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 0, 14, 1, 417, DateTimeKind.Local).AddTicks(3886), "Handmade Cotton Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 12, 58, 14, 769, DateTimeKind.Local).AddTicks(132), "Rustic Soft Salad", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 17, 57, 4, 905, DateTimeKind.Local).AddTicks(5011), "Unbranded Plastic Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 8, 14, 43, 222, DateTimeKind.Local).AddTicks(7812), "Awesome Wooden Table", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 1, 0, 54, 436, DateTimeKind.Local).AddTicks(8678), "Ergonomic Rubber Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 7, 25, 11, 10, 46, 458, DateTimeKind.Local).AddTicks(8714), "Ergonomic Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 11, 52, 27, 726, DateTimeKind.Local).AddTicks(6225), "Incredible Wooden Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 18, 34, 8, 207, DateTimeKind.Local).AddTicks(9551), "Refined Fresh Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 8, 29, 36, 842, DateTimeKind.Local).AddTicks(975), "Incredible Cotton Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 1, 18, 11, 180, DateTimeKind.Local).AddTicks(3671), "Awesome Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 21, 17, 52, 393, DateTimeKind.Local).AddTicks(7812), "Generic Plastic Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 13, 43, 43, 107, DateTimeKind.Local).AddTicks(3989), "Small Concrete Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 21, 49, 14, 276, DateTimeKind.Local).AddTicks(2310), "Generic Rubber Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 6, 39, 36, 93, DateTimeKind.Local).AddTicks(5498), "Awesome Frozen Shoes", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 6, 26, 38, 923, DateTimeKind.Local).AddTicks(7762), "Fantastic Soft Ball", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 21, 8, 56, 332, DateTimeKind.Local).AddTicks(7580), "Practical Cotton Ball", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 7, 40, 55, 894, DateTimeKind.Local).AddTicks(8215), "Small Concrete Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 12, 54, 15, 897, DateTimeKind.Local).AddTicks(332), "Sleek Soft Cheese", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 22, 30, 46, 774, DateTimeKind.Local).AddTicks(3977), "Intelligent Steel Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 5, 47, 47, 593, DateTimeKind.Local).AddTicks(3502), "Sleek Soft Soap", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 10, 47, 14, 793, DateTimeKind.Local).AddTicks(5878), "Licensed Metal Car", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 4, 43, 43, 642, DateTimeKind.Local).AddTicks(8255), "Rustic Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 5, 52, 56, 913, DateTimeKind.Local).AddTicks(58), "Handcrafted Concrete Pizza", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 3, 54, 59, 856, DateTimeKind.Local).AddTicks(2451), "Sleek Plastic Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 8, 0, 24, 587, DateTimeKind.Local).AddTicks(425), "Rustic Granite Chicken", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 19, 33, 32, 746, DateTimeKind.Local).AddTicks(5749), "Incredible Plastic Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 9, 56, 10, 900, DateTimeKind.Local).AddTicks(720), "Awesome Frozen Fish", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 11, 50, 23, 804, DateTimeKind.Local).AddTicks(9600), "Unbranded Wooden Bike", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 7, 28, 41, 935, DateTimeKind.Local).AddTicks(5653), "Awesome Soft Chips", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 12, 44, 4, 96, DateTimeKind.Local).AddTicks(3963), "Ergonomic Rubber Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 5, 15, 7, 728, DateTimeKind.Local).AddTicks(3855), "Unbranded Plastic Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 19, 53, 28, 530, DateTimeKind.Local).AddTicks(8208), "Small Metal Mouse", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 15, 17, 27, 635, DateTimeKind.Local).AddTicks(3760), "Fantastic Cotton Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 18, 5, 46, 809, DateTimeKind.Local).AddTicks(433), "Sleek Concrete Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 15, 31, 34, 710, DateTimeKind.Local).AddTicks(2458), "Handmade Granite Chicken", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 4, 53, 3, 774, DateTimeKind.Local).AddTicks(8884), "Small Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 0, 27, 8, 958, DateTimeKind.Local).AddTicks(8002), "Tasty Steel Table", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 3, 6, 28, 205, DateTimeKind.Local).AddTicks(5095), "Small Fresh Pants", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 7, 23, 36, 48, DateTimeKind.Local).AddTicks(4422), "Generic Granite Towels", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 56, 6, 14, DateTimeKind.Local).AddTicks(9354), "Practical Granite Soap", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 9, 46, 43, 432, DateTimeKind.Local).AddTicks(1088), "Incredible Rubber Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 17, 16, 55, 437, DateTimeKind.Local).AddTicks(735), "Licensed Granite Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 17, 49, 43, 938, DateTimeKind.Local).AddTicks(9903), "Small Cotton Cheese", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 5, 53, 57, 811, DateTimeKind.Local).AddTicks(5016), "Intelligent Rubber Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 8, 39, 4, 404, DateTimeKind.Local).AddTicks(8388), "Intelligent Steel Shirt", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 19, 24, 27, 942, DateTimeKind.Local).AddTicks(3939), "Practical Steel Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 1, 51, 46, 373, DateTimeKind.Local).AddTicks(6714), "Awesome Concrete Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 9, 51, 42, 702, DateTimeKind.Local).AddTicks(2074), "Gorgeous Rubber Hat", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 16, 19, 40, 462, DateTimeKind.Local).AddTicks(4388), "Small Steel Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 20, 40, 51, 406, DateTimeKind.Local).AddTicks(8182), "Generic Metal Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 1, 59, 19, 805, DateTimeKind.Local).AddTicks(8538), "Gorgeous Granite Shoes", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 23, 3, 44, 394, DateTimeKind.Local).AddTicks(5954), "Awesome Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 37, 17, 656, DateTimeKind.Local).AddTicks(1400), "Practical Fresh Chips", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 31, 54, 200, DateTimeKind.Local).AddTicks(4766), "Intelligent Granite Computer", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 3, 17, 11, 441, DateTimeKind.Local).AddTicks(5487), "Ergonomic Soft Car", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 21, 8, 15, 942, DateTimeKind.Local).AddTicks(2853), "Practical Plastic Cheese", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 20, 55, 47, 813, DateTimeKind.Local).AddTicks(4250), "Small Rubber Car", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 10, 10, 44, 221, DateTimeKind.Local).AddTicks(7496), "Refined Soft Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 15, 3, 49, 116, DateTimeKind.Local).AddTicks(3406), "Fantastic Steel Gloves", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 9, 6, 2, 779, DateTimeKind.Local).AddTicks(2035), "Unbranded Frozen Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 12, 28, 59, 45, DateTimeKind.Local).AddTicks(3330), "Fantastic Metal Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 20, 48, 13, 493, DateTimeKind.Local).AddTicks(95), "Rustic Cotton Table", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 9, 2, 47, 200, DateTimeKind.Local).AddTicks(9296), "Generic Fresh Computer", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 12, 57, 11, 534, DateTimeKind.Local).AddTicks(6683), "Rustic Soft Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 18, 11, 7, 92, DateTimeKind.Local).AddTicks(8992), "Handcrafted Wooden Keyboard", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 20, 7, 43, 452, DateTimeKind.Local).AddTicks(4783), "Sleek Rubber Sausages", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 7, 10, 2, 612, DateTimeKind.Local).AddTicks(7782), "Practical Metal Ball", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 6, 16, 43, 581, DateTimeKind.Local).AddTicks(1053), "Practical Wooden Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 11, 46, 15, 283, DateTimeKind.Local).AddTicks(8837), "Unbranded Frozen Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 10, 47, 14, 425, DateTimeKind.Local).AddTicks(3367), "Unbranded Plastic Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 6, 43, 37, 483, DateTimeKind.Local).AddTicks(1314), "Generic Steel Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 17, 9, 4, 719, DateTimeKind.Local).AddTicks(1302), "Awesome Concrete Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 18, 28, 34, 716, DateTimeKind.Local).AddTicks(9400), "Awesome Plastic Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 13, 12, 39, 988, DateTimeKind.Local).AddTicks(142), "Sleek Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 20, 10, 303, DateTimeKind.Local).AddTicks(1561), "Generic Cotton Computer", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 1, 49, 59, 95, DateTimeKind.Local).AddTicks(6409), "Gorgeous Rubber Cheese", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 21, 10, 35, 219, DateTimeKind.Local).AddTicks(7090), "Rustic Granite Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 18, 50, 27, 911, DateTimeKind.Local).AddTicks(4582), "Ergonomic Metal Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 18, 0, 47, 979, DateTimeKind.Local).AddTicks(2460), "Awesome Steel Car", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 10, 7, 54, 267, DateTimeKind.Local).AddTicks(8546), "Refined Fresh Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 5, 41, 15, 285, DateTimeKind.Local).AddTicks(1169), "Licensed Soft Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 17, 22, 38, 744, DateTimeKind.Local).AddTicks(7701), "Handmade Cotton Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 9, 40, 2, 669, DateTimeKind.Local).AddTicks(8989), "Unbranded Metal Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 5, 28, 52, 361, DateTimeKind.Local).AddTicks(2889), "Practical Granite Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 37, 26, 559, DateTimeKind.Local).AddTicks(1345), "Practical Metal Chair", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 15, 5, 37, 749, DateTimeKind.Local).AddTicks(8552), "Handcrafted Wooden Salad", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 4, 34, 50, 682, DateTimeKind.Local).AddTicks(6346), "Handcrafted Metal Computer", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 23, 12, 19, 367, DateTimeKind.Local).AddTicks(9332), "Sleek Metal Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 7, 8, 35, 785, DateTimeKind.Local).AddTicks(3284), "Rustic Soft Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 2, 35, 18, 539, DateTimeKind.Local).AddTicks(809), "Gorgeous Steel Soap", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 23, 29, 16, 543, DateTimeKind.Local).AddTicks(3773), "Rustic Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 18, 16, 35, 874, DateTimeKind.Local).AddTicks(7781), "Ergonomic Frozen Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 11, 4, 34, 4, DateTimeKind.Local).AddTicks(9507), "Handcrafted Steel Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 4, 56, 35, 35, DateTimeKind.Local).AddTicks(9232), "Ergonomic Frozen Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 22, 38, 49, 201, DateTimeKind.Local).AddTicks(9832), "Awesome Metal Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 20, 12, 50, 500, DateTimeKind.Local).AddTicks(6515), "Handcrafted Cotton Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 15, 41, 12, 116, DateTimeKind.Local).AddTicks(91), "Practical Rubber Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 11, 2, 35, 13, DateTimeKind.Local).AddTicks(4507), "Sleek Wooden Chair", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 14, 3, 3, 954, DateTimeKind.Local).AddTicks(2504), "Licensed Concrete Hat", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 15, 26, 54, 893, DateTimeKind.Local).AddTicks(3850), "Awesome Cotton Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 4, 10, 26, 150, DateTimeKind.Local).AddTicks(7494), "Rustic Metal Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 16, 0, 47, 218, DateTimeKind.Local).AddTicks(7017), "Generic Plastic Cheese", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 18, 47, 22, 881, DateTimeKind.Local).AddTicks(2845), "Awesome Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 23, 10, 4, 312, DateTimeKind.Local).AddTicks(6537), "Unbranded Metal Chair", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 18, 57, 59, 901, DateTimeKind.Local).AddTicks(3583), "Gorgeous Granite Ball", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 12, 1, 24, 846, DateTimeKind.Local).AddTicks(4998), "Ergonomic Granite Cheese", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 11, 8, 53, 143, DateTimeKind.Local).AddTicks(1511), "Sleek Steel Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 16, 1, 50, 722, DateTimeKind.Local).AddTicks(7701), "Rustic Metal Chips", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 11, 36, 58, 67, DateTimeKind.Local).AddTicks(4874), "Generic Plastic Car", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 0, 39, 33, 862, DateTimeKind.Local).AddTicks(8678), "Handmade Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 11, 55, 11, 118, DateTimeKind.Local).AddTicks(9233), "Handmade Metal Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 7, 10, 47, 738, DateTimeKind.Local).AddTicks(6029), "Unbranded Fresh Salad", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 20, 32, 16, 388, DateTimeKind.Local).AddTicks(6295), "Ergonomic Concrete Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 6, 33, 22, 531, DateTimeKind.Local).AddTicks(321), "Licensed Cotton Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 15, 47, 41, 336, DateTimeKind.Local).AddTicks(3878), "Small Fresh Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 20, 8, 46, 870, DateTimeKind.Local).AddTicks(7571), "Gorgeous Steel Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 20, 28, 38, 12, DateTimeKind.Local).AddTicks(9903), "Tasty Cotton Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 17, 6, 23, 869, DateTimeKind.Local).AddTicks(6467), "Licensed Metal Pizza", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 12, 40, 5, 583, DateTimeKind.Local).AddTicks(2388), "Small Frozen Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 16, 55, 4, 518, DateTimeKind.Local).AddTicks(9618), "Sleek Steel Pizza", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 15, 51, 2, 605, DateTimeKind.Local).AddTicks(7715), "Small Fresh Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 2, 1, 39, 842, DateTimeKind.Local).AddTicks(1589), "Handcrafted Metal Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 22, 41, 39, 678, DateTimeKind.Local).AddTicks(543), "Incredible Soft Sausages", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 15, 43, 27, 158, DateTimeKind.Local).AddTicks(3708), "Handcrafted Metal Ball", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 7, 9, 35, 930, DateTimeKind.Local).AddTicks(4393), "Refined Cotton Gloves", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 13, 35, 4, 674, DateTimeKind.Local).AddTicks(3826), "Sleek Soft Salad", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 12, 23, 42, 261, DateTimeKind.Local).AddTicks(2130), "Handcrafted Cotton Chicken", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 5, 42, 48, 77, DateTimeKind.Local).AddTicks(8580), "Tasty Metal Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 10, 26, 50, 30, DateTimeKind.Local).AddTicks(693), "Incredible Soft Salad", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 10, 5, 50, 271, DateTimeKind.Local).AddTicks(2610), "Unbranded Granite Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 13, 32, 45, 843, DateTimeKind.Local).AddTicks(1655), "Fantastic Cotton Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 12, 24, 41, 981, DateTimeKind.Local).AddTicks(7872), "Unbranded Wooden Shoes", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 19, 31, 29, 321, DateTimeKind.Local).AddTicks(7482), "Refined Frozen Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 18, 1, 29, 309, DateTimeKind.Local).AddTicks(794), "Handcrafted Steel Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 16, 35, 35, 661, DateTimeKind.Local).AddTicks(6223), "Refined Steel Mouse", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 2, 55, 7, 47, DateTimeKind.Local).AddTicks(2467), "Tasty Wooden Computer", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 9, 1, 30, 515, DateTimeKind.Local).AddTicks(2043), "Intelligent Plastic Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 3, 34, 46, 326, DateTimeKind.Local).AddTicks(9050), "Small Plastic Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 10, 10, 22, 597, DateTimeKind.Local).AddTicks(6717), "Small Metal Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 18, 42, 434, DateTimeKind.Local).AddTicks(4971), "Sleek Metal Keyboard", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 12, 47, 52, 206, DateTimeKind.Local).AddTicks(630), "Fantastic Metal Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 25, 10, 954, DateTimeKind.Local).AddTicks(3610), "Refined Granite Soap", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 17, 32, 41, 334, DateTimeKind.Local).AddTicks(7261), "Sleek Cotton Shirt", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 15, 13, 47, 29, DateTimeKind.Local).AddTicks(4229), "Refined Rubber Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 9, 5, 0, 875, DateTimeKind.Local).AddTicks(4792), "Unbranded Concrete Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 4, 32, 21, 151, DateTimeKind.Local).AddTicks(4432), "Unbranded Fresh Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 19, 29, 28, 387, DateTimeKind.Local).AddTicks(7074), "Small Metal Ball", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 8, 52, 0, 639, DateTimeKind.Local).AddTicks(100), "Sleek Plastic Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 19, 12, 13, 585, DateTimeKind.Local).AddTicks(2014), "Tasty Steel Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 51, 9, 22, DateTimeKind.Local).AddTicks(3376), "Unbranded Fresh Shoes", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 11, 54, 25, 950, DateTimeKind.Local).AddTicks(7941), "Rustic Cotton Bacon", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 16, 38, 20, 282, DateTimeKind.Local).AddTicks(938), "Handmade Metal Hat", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 19, 5, 32, 155, DateTimeKind.Local).AddTicks(5849), "Fantastic Cotton Tuna", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 9, 34, 40, 897, DateTimeKind.Local).AddTicks(7371), "Unbranded Fresh Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 0, 6, 7, 285, DateTimeKind.Local).AddTicks(3628), "Intelligent Plastic Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 18, 21, 46, 817, DateTimeKind.Local).AddTicks(1807), "Incredible Plastic Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 21, 29, 40, 649, DateTimeKind.Local).AddTicks(6909), "Handmade Metal Towels", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 14, 22, 34, 307, DateTimeKind.Local).AddTicks(5693), "Sleek Plastic Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 4, 53, 41, 50, DateTimeKind.Local).AddTicks(3432), "Generic Metal Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 21, 11, 47, 171, DateTimeKind.Local).AddTicks(864), "Gorgeous Metal Bike", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 16, 12, 7, 366, DateTimeKind.Local).AddTicks(8078), "Practical Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 21, 22, 2, 220, DateTimeKind.Local).AddTicks(1606), "Awesome Rubber Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 32, 28, 98, DateTimeKind.Local).AddTicks(4368), "Incredible Wooden Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 12, 42, 17, 554, DateTimeKind.Local).AddTicks(8267), "Refined Wooden Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 6, 26, 33, 444, DateTimeKind.Local).AddTicks(4462), "Ergonomic Rubber Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 3, 8, 29, 642, DateTimeKind.Local).AddTicks(6873), "Incredible Frozen Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 10, 9, 25, 860, DateTimeKind.Local).AddTicks(95), "Generic Cotton Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 23, 54, 8, 531, DateTimeKind.Local).AddTicks(3083), "Intelligent Rubber Pants", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 5, 38, 15, 152, DateTimeKind.Local).AddTicks(5173), "Small Frozen Cheese", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 4, 49, 53, 427, DateTimeKind.Local).AddTicks(2574), "Generic Granite Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 0, 25, 29, 845, DateTimeKind.Local).AddTicks(1855), "Small Fresh Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 17, 59, 6, 241, DateTimeKind.Local).AddTicks(3977), "Awesome Metal Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 2, 27, 39, 367, DateTimeKind.Local).AddTicks(1698), "Ergonomic Plastic Car", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 5, 58, 23, 390, DateTimeKind.Local).AddTicks(57), "Rustic Soft Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 2, 6, 51, 610, DateTimeKind.Local).AddTicks(8959), "Generic Frozen Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 5, 27, 51, 843, DateTimeKind.Local).AddTicks(1516), "Gorgeous Rubber Soap", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 9, 46, 21, 621, DateTimeKind.Local).AddTicks(2462), "Awesome Rubber Fish", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 10, 3, 19, 790, DateTimeKind.Local).AddTicks(9742), "Generic Metal Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 11, 45, 2, 230, DateTimeKind.Local).AddTicks(3514), "Tasty Cotton Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 8, 58, 18, 908, DateTimeKind.Local).AddTicks(1163), "Refined Rubber Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 13, 31, 11, 579, DateTimeKind.Local).AddTicks(6964), "Incredible Metal Towels", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 20, 15, 35, 80, DateTimeKind.Local).AddTicks(5949), "Generic Granite Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 17, 45, 42, 722, DateTimeKind.Local).AddTicks(7129), "Tasty Steel Table", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 34, 53, 688, DateTimeKind.Local).AddTicks(1571), "Refined Concrete Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 2, 2, 42, 145, DateTimeKind.Local).AddTicks(7568), "Ergonomic Granite Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 12, 34, 21, 621, DateTimeKind.Local).AddTicks(2998), "Sleek Fresh Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 10, 19, 47, 801, DateTimeKind.Local).AddTicks(5433), "Generic Frozen Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 20, 42, 3, 708, DateTimeKind.Local).AddTicks(8681), "Generic Steel Soap", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 5, 41, 24, 263, DateTimeKind.Local).AddTicks(4902), "Tasty Cotton Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 2, 1, 884, DateTimeKind.Local).AddTicks(3075), "Gorgeous Steel Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 4, 18, 37, 657, DateTimeKind.Local).AddTicks(4287), "Rustic Granite Car", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 12, 29, 43, 296, DateTimeKind.Local).AddTicks(1985), "Ergonomic Soft Fish", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 11, 27, 40, 515, DateTimeKind.Local).AddTicks(1451), "Rustic Plastic Table", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 9, 17, 49, 573, DateTimeKind.Local).AddTicks(1842), "Small Plastic Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 11, 23, 33, 708, DateTimeKind.Local).AddTicks(221), "Handmade Metal Sausages", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 23, 23, 45, 614, DateTimeKind.Local).AddTicks(6520), "Generic Fresh Table", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 19, 27, 13, 562, DateTimeKind.Local).AddTicks(1414), "Ergonomic Wooden Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 8, 21, 54, 36, DateTimeKind.Local).AddTicks(2602), "Generic Granite Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 15, 12, 14, 886, DateTimeKind.Local).AddTicks(4658), "Practical Soft Towels", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 43, 25, 102, DateTimeKind.Local).AddTicks(3667), "Tasty Cotton Soap", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 2, 40, 58, 938, DateTimeKind.Local).AddTicks(4359), "Intelligent Soft Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 1, 30, 12, 105, DateTimeKind.Local).AddTicks(781), "Practical Concrete Computer", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 13, 23, 24, 744, DateTimeKind.Local).AddTicks(2147), "Rustic Granite Chips", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 7, 7, 25, 763, DateTimeKind.Local).AddTicks(9052), "Intelligent Metal Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 6, 8, 14, 633, DateTimeKind.Local).AddTicks(7492), "Small Soft Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 0, 23, 41, 400, DateTimeKind.Local).AddTicks(8610), "Tasty Steel Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 17, 27, 1, 783, DateTimeKind.Local).AddTicks(8976), "Small Cotton Fish", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 1, 31, 1, 290, DateTimeKind.Local).AddTicks(4784), "Intelligent Wooden Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 3, 28, 49, 489, DateTimeKind.Local).AddTicks(9049), "Fantastic Steel Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 15, 39, 3, 96, DateTimeKind.Local).AddTicks(7424), "Incredible Fresh Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 3, 59, 36, 921, DateTimeKind.Local).AddTicks(3029), "Unbranded Granite Shirt", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 1, 14, 41, 178, DateTimeKind.Local).AddTicks(135), "Practical Rubber Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 4, 12, 19, 108, DateTimeKind.Local).AddTicks(9875), "Gorgeous Concrete Fish", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 5, 2, 54, 711, DateTimeKind.Local).AddTicks(7118), "Incredible Rubber Mouse", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 8, 47, 52, 107, DateTimeKind.Local).AddTicks(1292), "Generic Fresh Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 18, 39, 49, 64, DateTimeKind.Local).AddTicks(2953), "Tasty Soft Car", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 14, 24, 23, 354, DateTimeKind.Local).AddTicks(6022), "Practical Frozen Mouse", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 16, 6, 33, 415, DateTimeKind.Local).AddTicks(4212), "Intelligent Concrete Sausages", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 11, 16, 51, 525, DateTimeKind.Local).AddTicks(8478), "Tasty Rubber Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 13, 56, 59, 648, DateTimeKind.Local).AddTicks(3928), "Handcrafted Rubber Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 59, 36, 397, DateTimeKind.Local).AddTicks(1459), "Handmade Concrete Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 23, 10, 40, 586, DateTimeKind.Local).AddTicks(1319), "Sleek Cotton Chair", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 15, 25, 59, 822, DateTimeKind.Local).AddTicks(1289), "Rustic Concrete Salad", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 8, 30, 36, 936, DateTimeKind.Local).AddTicks(3726), "Awesome Metal Gloves", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 7, 33, 13, 193, DateTimeKind.Local).AddTicks(1295), "Ergonomic Plastic Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 8, 20, 54, 362, DateTimeKind.Local).AddTicks(9532), "Incredible Cotton Mouse", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 0, 49, 29, 612, DateTimeKind.Local).AddTicks(4768), "Handmade Steel Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 21, 34, 9, 766, DateTimeKind.Local).AddTicks(1854), "Tasty Concrete Computer", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 8, 28, 51, 324, DateTimeKind.Local).AddTicks(5876), "Intelligent Soft Fish", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 7, 52, 15, 78, DateTimeKind.Local).AddTicks(6780), "Intelligent Plastic Hat", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 21, 17, 6, 246, DateTimeKind.Local).AddTicks(5805), "Gorgeous Rubber Chicken", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 6, 11, 23, 275, DateTimeKind.Local).AddTicks(1460), "Tasty Plastic Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 15, 28, 38, 931, DateTimeKind.Local).AddTicks(9729), "Unbranded Concrete Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 9, 18, 23, 35, DateTimeKind.Local).AddTicks(8995), "Gorgeous Wooden Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 0, 3, 46, 758, DateTimeKind.Local).AddTicks(5943), "Tasty Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 4, 41, 54, 803, DateTimeKind.Local).AddTicks(4186), "Unbranded Rubber Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 21, 3, 39, 385, DateTimeKind.Local).AddTicks(1358), "Generic Steel Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 21, 30, 49, 941, DateTimeKind.Local).AddTicks(8306), "Licensed Frozen Pants", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 5, 53, 32, 615, DateTimeKind.Local).AddTicks(3079), "Ergonomic Plastic Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 23, 1, 42, 357, DateTimeKind.Local).AddTicks(4773), "Rustic Granite Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 20, 48, 8, 237, DateTimeKind.Local).AddTicks(192), "Unbranded Fresh Gloves", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 20, 50, 27, 659, DateTimeKind.Local).AddTicks(7744), "Handcrafted Wooden Sausages", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 4, 10, 21, 625, DateTimeKind.Local).AddTicks(9712), "Fantastic Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 12, 21, 4, 737, DateTimeKind.Local).AddTicks(7082), "Ergonomic Concrete Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 19, 53, 11, 733, DateTimeKind.Local).AddTicks(9973), "Tasty Granite Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 13, 24, 35, 457, DateTimeKind.Local).AddTicks(5187), "Refined Metal Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 2, 14, 16, 767, DateTimeKind.Local).AddTicks(8804), "Fantastic Metal Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 15, 31, 41, 488, DateTimeKind.Local).AddTicks(3080), "Tasty Frozen Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 10, 51, 42, 873, DateTimeKind.Local).AddTicks(704), "Fantastic Frozen Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 19, 35, 12, 545, DateTimeKind.Local).AddTicks(6695), "Awesome Wooden Pizza", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 6, 6, 6, 542, DateTimeKind.Local).AddTicks(761), "Licensed Cotton Chips", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 14, 59, 16, 366, DateTimeKind.Local).AddTicks(6218), "Practical Plastic Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 3, 27, 0, 511, DateTimeKind.Local).AddTicks(1742), "Intelligent Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 4, 35, 3, 384, DateTimeKind.Local).AddTicks(2552), "Sleek Fresh Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 13, 44, 24, 209, DateTimeKind.Local).AddTicks(2383), "Awesome Granite Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 1, 47, 5, 401, DateTimeKind.Local).AddTicks(9438), "Fantastic Granite Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 14, 11, 13, 65, DateTimeKind.Local).AddTicks(4870), "Ergonomic Cotton Bacon", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 0, 41, 10, 450, DateTimeKind.Local).AddTicks(3252), "Handcrafted Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 5, 22, 30, 554, DateTimeKind.Local).AddTicks(1631), "Handcrafted Steel Hat", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 9, 10, 31, 393, DateTimeKind.Local).AddTicks(3392), "Tasty Metal Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 12, 7, 59, 255, DateTimeKind.Local).AddTicks(5189), "Gorgeous Concrete Table", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 10, 46, 6, 666, DateTimeKind.Local).AddTicks(8158), "Handcrafted Rubber Car", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 22, 52, 38, 428, DateTimeKind.Local).AddTicks(7569), "Awesome Cotton Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 4, 45, 45, 242, DateTimeKind.Local).AddTicks(9046), "Ergonomic Steel Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 21, 32, 88, DateTimeKind.Local).AddTicks(7489), "Awesome Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 14, 8, 39, 65, DateTimeKind.Local).AddTicks(8183), "Ergonomic Plastic Chair", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 18, 43, 55, 8, DateTimeKind.Local).AddTicks(4899), "Incredible Wooden Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 19, 18, 30, 481, DateTimeKind.Local).AddTicks(3227), "Small Fresh Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 1, 19, 33, 303, DateTimeKind.Local).AddTicks(2733), "Rustic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 23, 10, 49, 60, DateTimeKind.Local).AddTicks(1040), "Handmade Steel Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 10, 38, 37, 403, DateTimeKind.Local).AddTicks(2190), "Unbranded Rubber Soap", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 18, 38, 683, DateTimeKind.Local).AddTicks(2074), "Incredible Steel Sausages", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 0, 48, 47, 875, DateTimeKind.Local).AddTicks(314), "Tasty Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 3, 12, 50, 515, DateTimeKind.Local).AddTicks(3843), "Handcrafted Granite Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 13, 49, 10, 645, DateTimeKind.Local).AddTicks(260), "Handcrafted Concrete Shirt", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 12, 43, 40, 578, DateTimeKind.Local).AddTicks(6768), "Tasty Granite Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 21, 21, 30, 644, DateTimeKind.Local).AddTicks(1149), "Rustic Steel Towels", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 22, 54, 10, 417, DateTimeKind.Local).AddTicks(4553), "Licensed Plastic Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 6, 22, 48, 135, DateTimeKind.Local).AddTicks(7337), "Unbranded Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 16, 16, 30, 228, DateTimeKind.Local).AddTicks(2885), "Sleek Frozen Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 3, 14, 14, 547, DateTimeKind.Local).AddTicks(2823), "Sleek Concrete Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 1, 45, 40, 637, DateTimeKind.Local).AddTicks(2759), "Tasty Soft Ball", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 22, 28, 32, 185, DateTimeKind.Local).AddTicks(571), "Sleek Granite Chips", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 11, 43, 29, 396, DateTimeKind.Local).AddTicks(4207), "Fantastic Wooden Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 19, 52, 14, 357, DateTimeKind.Local).AddTicks(5623), "Intelligent Rubber Gloves", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 19, 50, 33, 563, DateTimeKind.Local).AddTicks(7296), "Licensed Granite Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 22, 24, 34, 286, DateTimeKind.Local).AddTicks(330), "Tasty Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 12, 7, 56, 333, DateTimeKind.Local).AddTicks(312), "Licensed Granite Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 12, 4, 22, 101, DateTimeKind.Local).AddTicks(7246), "Licensed Frozen Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 1, 27, 30, 503, DateTimeKind.Local).AddTicks(9630), "Small Soft Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 21, 34, 17, 62, DateTimeKind.Local).AddTicks(3460), "Ergonomic Wooden Soap", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 6, 49, 43, 5, DateTimeKind.Local).AddTicks(4553), "Ergonomic Frozen Pants", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 57, 58, 16, DateTimeKind.Local).AddTicks(2560), "Ergonomic Metal Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 2, 55, 57, 187, DateTimeKind.Local).AddTicks(2622), "Tasty Wooden Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 7, 4, 0, 26, DateTimeKind.Local).AddTicks(6051), "Intelligent Frozen Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 5, 37, 5, 871, DateTimeKind.Local).AddTicks(4462), "Handmade Steel Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 22, 31, 49, 783, DateTimeKind.Local).AddTicks(6166), "Tasty Concrete Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 16, 27, 7, 767, DateTimeKind.Local).AddTicks(2695), "Handcrafted Fresh Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 16, 57, 43, 650, DateTimeKind.Local).AddTicks(2929), "Small Frozen Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 12, 48, 3, 780, DateTimeKind.Local).AddTicks(5005), "Gorgeous Rubber Shoes", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 23, 17, 39, 747, DateTimeKind.Local).AddTicks(2137), "Practical Wooden Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 19, 46, 54, 972, DateTimeKind.Local).AddTicks(4312), "Practical Granite Towels", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 10, 41, 11, 86, DateTimeKind.Local).AddTicks(9632), "Unbranded Metal Pizza", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 6, 5, 53, 410, DateTimeKind.Local).AddTicks(5704), "Handmade Steel Cheese", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 17, 45, 58, 793, DateTimeKind.Local).AddTicks(2012), "Handmade Plastic Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 5, 12, 19, 576, DateTimeKind.Local).AddTicks(9753), "Licensed Granite Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 23, 34, 42, 333, DateTimeKind.Local).AddTicks(1190), "Tasty Frozen Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 18, 28, 32, 932, DateTimeKind.Local).AddTicks(5192), "Small Concrete Cheese", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 15, 18, 39, 352, DateTimeKind.Local).AddTicks(7250), "Sleek Granite Car", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 2, 49, 837, DateTimeKind.Local).AddTicks(9312), "Refined Granite Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 2, 52, 18, 375, DateTimeKind.Local).AddTicks(1654), "Rustic Frozen Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 11, 36, 6, 912, DateTimeKind.Local).AddTicks(2075), "Incredible Frozen Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 12, 12, 24, 138, DateTimeKind.Local).AddTicks(1042), "Refined Cotton Hat", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 16, 39, 49, 287, DateTimeKind.Local).AddTicks(4178), "Tasty Granite Ball", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 19, 25, 58, 837, DateTimeKind.Local).AddTicks(6356), "Refined Steel Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 20, 22, 58, 254, DateTimeKind.Local).AddTicks(5980), "Awesome Soft Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 14, 48, 50, 36, DateTimeKind.Local).AddTicks(2678), "Incredible Soft Table", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 9, 57, 4, 849, DateTimeKind.Local).AddTicks(8609), "Tasty Steel Bacon", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 3, 17, 2, 594, DateTimeKind.Local).AddTicks(4672), "Generic Fresh Mouse", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 20, 29, 35, 382, DateTimeKind.Local).AddTicks(4231), "Awesome Rubber Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 0, 18, 12, 783, DateTimeKind.Local).AddTicks(2214), "Awesome Rubber Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 14, 0, 6, 387, DateTimeKind.Local).AddTicks(339), "Intelligent Concrete Shoes", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 0, 49, 10, 741, DateTimeKind.Local).AddTicks(9219), "Gorgeous Cotton Bike", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 10, 34, 46, 192, DateTimeKind.Local).AddTicks(4005), "Intelligent Metal Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 31, 37, 597, DateTimeKind.Local).AddTicks(1050), "Sleek Cotton Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 6, 15, 1, 748, DateTimeKind.Local).AddTicks(7412), "Fantastic Granite Salad", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 16, 24, 14, 343, DateTimeKind.Local).AddTicks(498), "Small Cotton Salad", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 9, 57, 33, 27, DateTimeKind.Local).AddTicks(2289), "Tasty Frozen Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 0, 58, 49, 327, DateTimeKind.Local).AddTicks(3135), "Rustic Rubber Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 23, 43, 56, 51, DateTimeKind.Local).AddTicks(4390), "Handcrafted Plastic Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 8, 16, 12, 557, DateTimeKind.Local).AddTicks(667), "Small Frozen Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 12, 4, 58, 882, DateTimeKind.Local).AddTicks(5156), "Small Rubber Fish", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 10, 4, 29, 601, DateTimeKind.Local).AddTicks(3624), "Unbranded Plastic Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 6, 44, 46, 400, DateTimeKind.Local).AddTicks(1816), "Incredible Wooden Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 10, 58, 40, 393, DateTimeKind.Local).AddTicks(3750), "Rustic Fresh Bike", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 18, 25, 43, 655, DateTimeKind.Local).AddTicks(5071), "Handmade Soft Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 8, 59, 24, 682, DateTimeKind.Local).AddTicks(4421), "Unbranded Rubber Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 18, 43, 55, 304, DateTimeKind.Local).AddTicks(3007), "Practical Fresh Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 16, 45, 8, 947, DateTimeKind.Local).AddTicks(6007), "Tasty Soft Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 8, 46, 29, 829, DateTimeKind.Local).AddTicks(5017), "Intelligent Granite Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 13, 45, 53, 669, DateTimeKind.Local).AddTicks(5039), "Licensed Plastic Tuna", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 4, 28, 10, 371, DateTimeKind.Local).AddTicks(4629), "Intelligent Frozen Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 18, 55, 3, 649, DateTimeKind.Local).AddTicks(5033), "Unbranded Steel Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 7, 10, 45, 945, DateTimeKind.Local).AddTicks(3982), "Awesome Frozen Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 0, 19, 29, 12, DateTimeKind.Local).AddTicks(4266), "Fantastic Granite Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 9, 2, 21, 259, DateTimeKind.Local).AddTicks(7044), "Tasty Frozen Table", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 0, 12, 58, 981, DateTimeKind.Local).AddTicks(3319), "Gorgeous Wooden Bike", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 3, 25, 22, 942, DateTimeKind.Local).AddTicks(5554), "Tasty Cotton Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 7, 36, 41, 150, DateTimeKind.Local).AddTicks(8380), "Handmade Frozen Shoes", 49m });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDetailId",
                table: "Orders",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailId",
                table: "Orders",
                column: "OrderDetailId",
                principalTable: "OrderDetails",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderDetailId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDetailId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 21, 10, 40, 937, DateTimeKind.Local).AddTicks(6597), "Gorgeous Concrete Car", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 16, 29, 16, 735, DateTimeKind.Local).AddTicks(2809), "Intelligent Concrete Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 1, 35, 32, 857, DateTimeKind.Local).AddTicks(1960), "Refined Steel Salad", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 3, 54, 59, 879, DateTimeKind.Local).AddTicks(6178), "Ergonomic Steel Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 11, 21, 53, 650, DateTimeKind.Local).AddTicks(6249), "Gorgeous Wooden Towels", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 13, 21, 33, 564, DateTimeKind.Local).AddTicks(4381), "Tasty Rubber Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 1, 4, 26, 245, DateTimeKind.Local).AddTicks(2935), "Gorgeous Plastic Shirt", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 7, 7, 41, 234, DateTimeKind.Local).AddTicks(4451), "Small Soft Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 5, 49, 42, 572, DateTimeKind.Local).AddTicks(3413), "Practical Cotton Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 13, 3, 2, 929, DateTimeKind.Local).AddTicks(2217), "Refined Frozen Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 9, 52, 1, 150, DateTimeKind.Local).AddTicks(7724), "Incredible Metal Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 17, 19, 51, 759, DateTimeKind.Local).AddTicks(6564), "Sleek Wooden Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 10, 30, 38, 123, DateTimeKind.Local).AddTicks(4466), "Awesome Granite Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 1, 2, 51, 20, DateTimeKind.Local).AddTicks(2658), "Handmade Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 5, 52, 22, 537, DateTimeKind.Local).AddTicks(6406), "Licensed Concrete Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 0, 49, 10, 899, DateTimeKind.Local).AddTicks(9196), "Generic Cotton Keyboard", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 23, 30, 27, 748, DateTimeKind.Local).AddTicks(4453), "Sleek Granite Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 15, 33, 24, 208, DateTimeKind.Local).AddTicks(296), "Ergonomic Plastic Hat", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 7, 57, 4, 460, DateTimeKind.Local).AddTicks(5705), "Practical Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 8, 32, 21, 609, DateTimeKind.Local).AddTicks(2988), "Incredible Metal Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 13, 30, 23, 439, DateTimeKind.Local).AddTicks(6129), "Gorgeous Granite Pizza", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 8, 55, 26, 812, DateTimeKind.Local).AddTicks(3725), "Incredible Rubber Hat", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 12, 1, 19, 189, DateTimeKind.Local).AddTicks(292), "Incredible Concrete Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 23, 55, 5, 331, DateTimeKind.Local).AddTicks(116), "Incredible Wooden Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 11, 47, 34, 362, DateTimeKind.Local).AddTicks(5683), "Practical Steel Table", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 11, 11, 5, 854, DateTimeKind.Local).AddTicks(9016), "Practical Concrete Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 19, 36, 19, 117, DateTimeKind.Local).AddTicks(5484), "Small Fresh Computer", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 3, 34, 7, 710, DateTimeKind.Local).AddTicks(4383), "Handcrafted Rubber Chicken", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 22, 12, 11, 558, DateTimeKind.Local).AddTicks(9486), "Intelligent Granite Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 9, 9, 37, 520, DateTimeKind.Local).AddTicks(8482), "Fantastic Steel Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 15, 36, 46, 756, DateTimeKind.Local).AddTicks(3584), "Gorgeous Concrete Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 13, 59, 45, 787, DateTimeKind.Local).AddTicks(6711), "Incredible Metal Cheese", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 0, 28, 11, 224, DateTimeKind.Local).AddTicks(2685), "Incredible Granite Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 8, 27, 56, 433, DateTimeKind.Local).AddTicks(8511), "Fantastic Cotton Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 5, 52, 45, 189, DateTimeKind.Local).AddTicks(4502), "Small Plastic Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 19, 34, 41, 714, DateTimeKind.Local).AddTicks(9278), "Ergonomic Frozen Bacon", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 14, 45, 35, 229, DateTimeKind.Local).AddTicks(2693), "Small Steel Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 3, 16, 57, 829, DateTimeKind.Local).AddTicks(8427), "Tasty Wooden Bike", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 14, 28, 25, 149, DateTimeKind.Local).AddTicks(2546), "Gorgeous Granite Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 14, 32, 38, 189, DateTimeKind.Local).AddTicks(7899), "Licensed Rubber Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 38, 14, 460, DateTimeKind.Local).AddTicks(8058), "Handmade Soft Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 20, 30, 10, 374, DateTimeKind.Local).AddTicks(9137), "Tasty Plastic Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 8, 21, 56, 623, DateTimeKind.Local).AddTicks(3835), "Licensed Plastic Gloves", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 4, 16, 46, 307, DateTimeKind.Local).AddTicks(730), "Incredible Rubber Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 17, 46, 54, 255, DateTimeKind.Local).AddTicks(7984), "Licensed Rubber Mouse", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 12, 21, 39, 894, DateTimeKind.Local).AddTicks(8091), "Unbranded Wooden Shoes", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 18, 43, 14, 185, DateTimeKind.Local).AddTicks(387), "Intelligent Metal Chair", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 6, 35, 51, 18, DateTimeKind.Local).AddTicks(9787), "Handcrafted Frozen Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 16, 55, 53, 261, DateTimeKind.Local).AddTicks(1461), "Tasty Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 2, 54, 57, 284, DateTimeKind.Local).AddTicks(8123), "Awesome Cotton Keyboard", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 28, 14, 322, DateTimeKind.Local).AddTicks(4750), "Awesome Soft Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 12, 19, 31, 186, DateTimeKind.Local).AddTicks(5123), "Gorgeous Concrete Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 16, 35, 46, 670, DateTimeKind.Local).AddTicks(8092), "Awesome Steel Tuna", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 4, 37, 11, 680, DateTimeKind.Local).AddTicks(8839), "Gorgeous Granite Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 9, 41, 52, 838, DateTimeKind.Local).AddTicks(7484), "Practical Granite Car", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 19, 44, 30, 263, DateTimeKind.Local).AddTicks(1858), "Tasty Granite Bacon", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 8, 44, 7, 22, DateTimeKind.Local).AddTicks(472), "Unbranded Granite Pizza", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 12, 30, 3, 642, DateTimeKind.Local).AddTicks(403), "Rustic Metal Ball", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 6, 31, 59, 866, DateTimeKind.Local).AddTicks(9406), "Licensed Concrete Gloves", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 7, 53, 42, 79, DateTimeKind.Local).AddTicks(9945), "Refined Cotton Keyboard", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 14, 35, 49, 455, DateTimeKind.Local).AddTicks(6706), "Refined Concrete Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 20, 27, 0, 898, DateTimeKind.Local).AddTicks(1073), "Handcrafted Fresh Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 15, 37, 43, 548, DateTimeKind.Local).AddTicks(3746), "Ergonomic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 18, 24, 44, 459, DateTimeKind.Local).AddTicks(9591), "Refined Steel Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 11, 11, 39, 133, DateTimeKind.Local).AddTicks(9681), "Practical Frozen Car", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 17, 36, 6, 895, DateTimeKind.Local).AddTicks(4510), "Handmade Concrete Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 6, 12, 14, 260, DateTimeKind.Local).AddTicks(2582), "Small Cotton Car", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 14, 47, 21, 191, DateTimeKind.Local).AddTicks(8227), "Gorgeous Steel Sausages", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 22, 27, 26, 261, DateTimeKind.Local).AddTicks(8044), "Handcrafted Rubber Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 19, 27, 17, 931, DateTimeKind.Local).AddTicks(1079), "Sleek Cotton Pants", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 15, 21, 45, 924, DateTimeKind.Local).AddTicks(3600), "Refined Plastic Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 1, 46, 21, 95, DateTimeKind.Local).AddTicks(9828), "Sleek Fresh Chips", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 15, 59, 275, DateTimeKind.Local).AddTicks(4919), "Gorgeous Concrete Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 2, 37, 49, 440, DateTimeKind.Local).AddTicks(9095), "Tasty Steel Table", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 12, 59, 25, 683, DateTimeKind.Local).AddTicks(7969), "Gorgeous Wooden Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 8, 49, 23, 256, DateTimeKind.Local).AddTicks(317), "Intelligent Fresh Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 9, 27, 14, 507, DateTimeKind.Local).AddTicks(6233), "Sleek Cotton Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 2, 38, 45, 404, DateTimeKind.Local).AddTicks(130), "Handcrafted Wooden Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 13, 12, 58, 683, DateTimeKind.Local).AddTicks(3833), "Gorgeous Fresh Cheese", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 12, 55, 31, 252, DateTimeKind.Local).AddTicks(6331), "Tasty Plastic Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 8, 0, 50, 208, DateTimeKind.Local).AddTicks(5672), "Gorgeous Concrete Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 9, 14, 52, 253, DateTimeKind.Local).AddTicks(4702), "Rustic Granite Sausages", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 17, 20, 37, 634, DateTimeKind.Local).AddTicks(8888), "Intelligent Soft Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 1, 27, 28, 668, DateTimeKind.Local).AddTicks(5407), "Gorgeous Rubber Bike", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 23, 39, 17, 960, DateTimeKind.Local).AddTicks(7525), "Licensed Fresh Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 0, 46, 9, 826, DateTimeKind.Local).AddTicks(825), "Fantastic Granite Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 11, 35, 58, 490, DateTimeKind.Local).AddTicks(7392), "Handcrafted Wooden Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 4, 44, 42, 508, DateTimeKind.Local).AddTicks(2909), "Ergonomic Metal Pizza", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 21, 49, 19, 744, DateTimeKind.Local).AddTicks(7251), "Generic Cotton Sausages", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 5, 54, 8, 277, DateTimeKind.Local).AddTicks(4154), "Small Cotton Bacon", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 2, 51, 0, 144, DateTimeKind.Local).AddTicks(9648), "Incredible Granite Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 4, 52, 31, 270, DateTimeKind.Local).AddTicks(586), "Tasty Concrete Soap", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 19, 29, 14, 791, DateTimeKind.Local).AddTicks(1628), "Tasty Fresh Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 11, 16, 29, 455, DateTimeKind.Local).AddTicks(4083), "Unbranded Concrete Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 8, 57, 14, 970, DateTimeKind.Local).AddTicks(5213), "Sleek Wooden Fish", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 7, 12, 53, 448, DateTimeKind.Local).AddTicks(9414), "Handmade Plastic Pizza", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 11, 58, 36, 431, DateTimeKind.Local).AddTicks(8699), "Handcrafted Soft Shirt", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 13, 2, 26, 411, DateTimeKind.Local).AddTicks(2915), "Sleek Plastic Hat", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 12, 40, 21, 346, DateTimeKind.Local).AddTicks(4016), "Unbranded Frozen Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 11, 19, 51, 383, DateTimeKind.Local).AddTicks(5440), "Refined Steel Hat", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 8, 44, 49, 540, DateTimeKind.Local).AddTicks(7409), "Intelligent Cotton Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 9, 20, 14, 680, DateTimeKind.Local).AddTicks(8681), "Handmade Plastic Ball", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 15, 34, 28, 851, DateTimeKind.Local).AddTicks(1356), "Refined Granite Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 2, 35, 34, 202, DateTimeKind.Local).AddTicks(3463), "Licensed Steel Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 7, 8, 9, 228, DateTimeKind.Local).AddTicks(3629), "Handcrafted Rubber Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 4, 19, 19, 230, DateTimeKind.Local).AddTicks(3010), "Sleek Metal Cheese", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 7, 21, 46, 631, DateTimeKind.Local).AddTicks(20), "Generic Concrete Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 2, 16, 42, 432, DateTimeKind.Local).AddTicks(9359), "Incredible Concrete Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 19, 2, 221, DateTimeKind.Local).AddTicks(4765), "Handmade Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 20, 23, 27, 494, DateTimeKind.Local).AddTicks(3015), "Tasty Plastic Shoes", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 20, 27, 59, 395, DateTimeKind.Local).AddTicks(9281), "Intelligent Wooden Pizza", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 7, 6, 0, 603, DateTimeKind.Local).AddTicks(7791), "Handcrafted Metal Fish", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 8, 49, 12, 43, DateTimeKind.Local).AddTicks(4988), "Handcrafted Concrete Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 8, 34, 30, 80, DateTimeKind.Local).AddTicks(9056), "Intelligent Granite Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 18, 53, 54, 395, DateTimeKind.Local).AddTicks(9392), "Fantastic Concrete Cheese", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 13, 56, 3, 193, DateTimeKind.Local).AddTicks(4284), "Refined Soft Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 16, 1, 30, 788, DateTimeKind.Local).AddTicks(4537), "Intelligent Granite Fish", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 21, 35, 24, 186, DateTimeKind.Local).AddTicks(671), "Tasty Fresh Chicken", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 1, 30, 40, 688, DateTimeKind.Local).AddTicks(6767), "Incredible Frozen Pizza", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 5, 16, 4, 717, DateTimeKind.Local).AddTicks(6753), "Tasty Frozen Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 16, 28, 32, 951, DateTimeKind.Local).AddTicks(4628), "Rustic Soft Bacon", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 16, 36, 17, 816, DateTimeKind.Local).AddTicks(8119), "Unbranded Concrete Tuna", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 20, 59, 56, 509, DateTimeKind.Local).AddTicks(2794), "Handmade Granite Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 1, 59, 406, DateTimeKind.Local).AddTicks(5297), "Ergonomic Cotton Sausages", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 10, 11, 50, 173, DateTimeKind.Local).AddTicks(9904), "Handcrafted Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 19, 23, 56, 744, DateTimeKind.Local).AddTicks(2151), "Handmade Concrete Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 22, 24, 26, 812, DateTimeKind.Local).AddTicks(998), "Generic Fresh Shoes", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 17, 8, 41, 159, DateTimeKind.Local).AddTicks(2237), "Fantastic Soft Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 12, 53, 39, 979, DateTimeKind.Local).AddTicks(267), "Tasty Metal Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 9, 10, 24, 18, DateTimeKind.Local).AddTicks(8757), "Licensed Concrete Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 16, 53, 59, 729, DateTimeKind.Local).AddTicks(9841), "Ergonomic Frozen Bacon", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 7, 10, 47, 621, DateTimeKind.Local).AddTicks(9296), "Licensed Rubber Soap", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 2, 11, 47, 447, DateTimeKind.Local).AddTicks(6028), "Sleek Steel Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 23, 9, 43, 365, DateTimeKind.Local).AddTicks(1062), "Tasty Metal Sausages", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 6, 10, 6, 806, DateTimeKind.Local).AddTicks(4786), "Intelligent Cotton Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 2, 11, 34, 488, DateTimeKind.Local).AddTicks(7046), "Awesome Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 12, 20, 25, 864, DateTimeKind.Local).AddTicks(6189), "Gorgeous Wooden Shoes", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 1, 33, 3, 836, DateTimeKind.Local).AddTicks(1316), "Handcrafted Soft Pizza", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 1, 15, 1, 508, DateTimeKind.Local).AddTicks(4794), "Refined Concrete Pizza", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 1, 36, 22, 259, DateTimeKind.Local).AddTicks(7488), "Licensed Rubber Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 0, 2, 6, 135, DateTimeKind.Local).AddTicks(9117), "Licensed Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 14, 57, 57, 323, DateTimeKind.Local).AddTicks(1915), "Rustic Metal Hat", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 13, 19, 3, 656, DateTimeKind.Local).AddTicks(8012), "Ergonomic Frozen Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 9, 45, 48, 230, DateTimeKind.Local).AddTicks(8668), "Unbranded Metal Cheese", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 12, 32, 47, 416, DateTimeKind.Local).AddTicks(6673), "Licensed Steel Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 31, 23, 123, DateTimeKind.Local).AddTicks(2915), "Unbranded Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 13, 59, 5, 286, DateTimeKind.Local).AddTicks(1329), "Sleek Fresh Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 21, 12, 14, 192, DateTimeKind.Local).AddTicks(4504), "Awesome Wooden Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 10, 48, 16, 335, DateTimeKind.Local).AddTicks(8640), "Incredible Soft Pants", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 23, 1, 38, 706, DateTimeKind.Local).AddTicks(9440), "Tasty Steel Hat", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 17, 33, 34, 839, DateTimeKind.Local).AddTicks(2015), "Licensed Steel Shirt", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 19, 1, 56, 442, DateTimeKind.Local).AddTicks(3710), "Tasty Wooden Car", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 4, 48, 1, 524, DateTimeKind.Local).AddTicks(5259), "Rustic Rubber Tuna", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 22, 25, 41, 785, DateTimeKind.Local).AddTicks(4600), "Ergonomic Rubber Pizza", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 16, 14, 0, 233, DateTimeKind.Local).AddTicks(9256), "Small Granite Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 5, 35, 54, 951, DateTimeKind.Local).AddTicks(8509), "Licensed Metal Gloves", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 19, 43, 29, 251, DateTimeKind.Local).AddTicks(4662), "Awesome Plastic Car", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 22, 17, 35, 413, DateTimeKind.Local).AddTicks(4851), "Awesome Cotton Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 21, 25, 52, 841, DateTimeKind.Local).AddTicks(1871), "Refined Frozen Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 17, 21, 44, 26, DateTimeKind.Local).AddTicks(206), "Rustic Rubber Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 17, 5, 56, 601, DateTimeKind.Local).AddTicks(6303), "Generic Granite Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 16, 27, 44, 342, DateTimeKind.Local).AddTicks(7171), "Tasty Steel Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 7, 0, 54, 987, DateTimeKind.Local).AddTicks(9047), "Generic Metal Shirt", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 14, 10, 45, 166, DateTimeKind.Local).AddTicks(6895), "Gorgeous Concrete Bike", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 19, 45, 38, 525, DateTimeKind.Local).AddTicks(89), "Practical Concrete Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 4, 55, 1, 128, DateTimeKind.Local).AddTicks(3846), "Tasty Wooden Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 18, 2, 46, 743, DateTimeKind.Local).AddTicks(7140), "Small Steel Shoes", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 14, 27, 36, 469, DateTimeKind.Local).AddTicks(6221), "Licensed Soft Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 11, 31, 36, 893, DateTimeKind.Local).AddTicks(6936), "Practical Plastic Gloves", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 17, 48, 59, 491, DateTimeKind.Local).AddTicks(5626), "Generic Concrete Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 1, 7, 25, 760, DateTimeKind.Local).AddTicks(7090), "Tasty Metal Car", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 4, 17, 54, 344, DateTimeKind.Local).AddTicks(7244), "Awesome Wooden Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 5, 48, 59, 795, DateTimeKind.Local).AddTicks(3071), "Handcrafted Soft Tuna", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 7, 17, 16, 205, DateTimeKind.Local).AddTicks(6464), "Handmade Granite Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 7, 14, 53, 52, DateTimeKind.Local).AddTicks(589), "Generic Soft Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 3, 55, 28, 310, DateTimeKind.Local).AddTicks(8252), "Intelligent Rubber Soap", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 7, 53, 41, 793, DateTimeKind.Local).AddTicks(9427), "Practical Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 19, 36, 1, 446, DateTimeKind.Local).AddTicks(3360), "Handcrafted Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 16, 28, 0, 225, DateTimeKind.Local).AddTicks(7048), "Practical Fresh Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 2, 58, 6, 547, DateTimeKind.Local).AddTicks(346), "Licensed Granite Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 4, 44, 24, 638, DateTimeKind.Local).AddTicks(6268), "Handcrafted Plastic Shoes", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 3, 44, 40, 750, DateTimeKind.Local).AddTicks(7307), "Intelligent Steel Soap", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 16, 25, 25, 217, DateTimeKind.Local).AddTicks(723), "Refined Frozen Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 0, 37, 1, 157, DateTimeKind.Local).AddTicks(3331), "Small Rubber Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 8, 13, 0, 269, DateTimeKind.Local).AddTicks(2932), "Unbranded Soft Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 1, 17, 30, 6, DateTimeKind.Local).AddTicks(9560), "Awesome Concrete Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 20, 35, 28, 393, DateTimeKind.Local).AddTicks(7757), "Intelligent Metal Salad", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 19, 46, 12, 914, DateTimeKind.Local).AddTicks(7111), "Awesome Wooden Shoes", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 8, 8, 22, 160, DateTimeKind.Local).AddTicks(1087), "Generic Frozen Chair", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 3, 49, 28, 904, DateTimeKind.Local).AddTicks(6972), "Intelligent Granite Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 16, 16, 11, 48, DateTimeKind.Local).AddTicks(7011), "Unbranded Plastic Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 56, 42, 658, DateTimeKind.Local).AddTicks(7030), "Licensed Frozen Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 14, 46, 41, 787, DateTimeKind.Local).AddTicks(8925), "Rustic Soft Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 17, 11, 45, 414, DateTimeKind.Local).AddTicks(2901), "Licensed Fresh Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 19, 43, 19, 578, DateTimeKind.Local).AddTicks(8110), "Fantastic Granite Sausages", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 22, 4, 32, 134, DateTimeKind.Local).AddTicks(1010), "Incredible Cotton Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 20, 34, 4, 948, DateTimeKind.Local).AddTicks(4264), "Small Wooden Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 17, 38, 47, 495, DateTimeKind.Local).AddTicks(1566), "Small Metal Soap", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 21, 36, 9, 646, DateTimeKind.Local).AddTicks(1412), "Gorgeous Rubber Chips", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 21, 47, 9, 461, DateTimeKind.Local).AddTicks(4923), "Rustic Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 12, 14, 33, 562, DateTimeKind.Local).AddTicks(2645), "Intelligent Concrete Keyboard", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 22, 44, 15, 998, DateTimeKind.Local).AddTicks(7862), "Rustic Plastic Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 2, 5, 44, 224, DateTimeKind.Local).AddTicks(8888), "Refined Frozen Hat", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 21, 44, 16, 692, DateTimeKind.Local).AddTicks(234), "Handcrafted Granite Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 7, 8, 30, 38, DateTimeKind.Local).AddTicks(7909), "Rustic Steel Pizza", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 5, 49, 18, 378, DateTimeKind.Local).AddTicks(5070), "Awesome Rubber Pizza", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 23, 41, 48, 984, DateTimeKind.Local).AddTicks(4268), "Unbranded Fresh Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 3, 2, 12, 16, DateTimeKind.Local).AddTicks(7310), "Fantastic Wooden Keyboard", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 22, 33, 50, 965, DateTimeKind.Local).AddTicks(8262), "Small Concrete Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 11, 40, 21, 93, DateTimeKind.Local).AddTicks(4329), "Practical Granite Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 18, 1, 16, 616, DateTimeKind.Local).AddTicks(2120), "Small Rubber Ball", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 6, 8, 57, 602, DateTimeKind.Local).AddTicks(5058), "Licensed Frozen Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 17, 2, 31, 577, DateTimeKind.Local).AddTicks(9306), "Fantastic Frozen Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 3, 53, 35, 761, DateTimeKind.Local).AddTicks(4659), "Incredible Wooden Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 8, 37, 29, 833, DateTimeKind.Local).AddTicks(1974), "Licensed Plastic Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 13, 23, 15, 324, DateTimeKind.Local).AddTicks(5626), "Fantastic Concrete Towels", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 21, 13, 34, 45, DateTimeKind.Local).AddTicks(72), "Licensed Cotton Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 10, 36, 48, 310, DateTimeKind.Local).AddTicks(7954), "Ergonomic Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 11, 18, 59, 152, DateTimeKind.Local).AddTicks(7168), "Handcrafted Metal Table", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 23, 5, 51, 286, DateTimeKind.Local).AddTicks(956), "Small Wooden Chips", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 14, 26, 56, 143, DateTimeKind.Local).AddTicks(1389), "Generic Metal Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 4, 1, 38, 846, DateTimeKind.Local).AddTicks(1497), "Handmade Frozen Chips", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 0, 43, 56, 250, DateTimeKind.Local).AddTicks(6875), "Awesome Rubber Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 14, 16, 20, 267, DateTimeKind.Local).AddTicks(5207), "Awesome Soft Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 19, 20, 15, 619, DateTimeKind.Local).AddTicks(9950), "Practical Cotton Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 16, 31, 45, 973, DateTimeKind.Local).AddTicks(4480), "Refined Soft Salad", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 6, 57, 38, 681, DateTimeKind.Local).AddTicks(9313), "Ergonomic Fresh Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 2, 18, 18, 292, DateTimeKind.Local).AddTicks(154), "Sleek Steel Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 6, 2, 5, 3, DateTimeKind.Local).AddTicks(3277), "Intelligent Fresh Pizza", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 19, 40, 23, 913, DateTimeKind.Local).AddTicks(3900), "Sleek Granite Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 18, 48, 14, 956, DateTimeKind.Local).AddTicks(8282), "Tasty Fresh Gloves", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 20, 12, 40, 312, DateTimeKind.Local).AddTicks(5435), "Gorgeous Cotton Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 14, 16, 7, 46, DateTimeKind.Local).AddTicks(1196), "Handcrafted Granite Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 16, 17, 40, 241, DateTimeKind.Local).AddTicks(8025), "Generic Frozen Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 10, 3, 0, 732, DateTimeKind.Local).AddTicks(5713), "Unbranded Frozen Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 3, 2, 47, 957, DateTimeKind.Local).AddTicks(6760), "Ergonomic Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 9, 24, 21, 639, DateTimeKind.Local).AddTicks(4836), "Gorgeous Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 22, 29, 40, 807, DateTimeKind.Local).AddTicks(4216), "Generic Cotton Soap", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 20, 57, 2, 482, DateTimeKind.Local).AddTicks(930), "Sleek Metal Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 10, 37, 42, 156, DateTimeKind.Local).AddTicks(8673), "Handcrafted Frozen Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 0, 43, 52, 83, DateTimeKind.Local).AddTicks(2209), "Rustic Wooden Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 1, 40, 2, 323, DateTimeKind.Local).AddTicks(5773), "Generic Concrete Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 11, 4, 6, 933, DateTimeKind.Local).AddTicks(9548), "Gorgeous Rubber Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 0, 59, 48, 759, DateTimeKind.Local).AddTicks(4801), "Generic Frozen Chips", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 3, 50, 16, 589, DateTimeKind.Local).AddTicks(2362), "Licensed Soft Pizza", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 3, 52, 54, 220, DateTimeKind.Local).AddTicks(3034), "Intelligent Cotton Gloves", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 21, 54, 5, 252, DateTimeKind.Local).AddTicks(2717), "Handmade Granite Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 3, 50, 21, 636, DateTimeKind.Local).AddTicks(306), "Fantastic Rubber Fish", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 23, 24, 54, 428, DateTimeKind.Local).AddTicks(9126), "Licensed Wooden Keyboard", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 9, 28, 19, 894, DateTimeKind.Local).AddTicks(6468), "Awesome Concrete Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 9, 9, 44, 118, DateTimeKind.Local).AddTicks(8348), "Intelligent Cotton Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 2, 10, 37, 300, DateTimeKind.Local).AddTicks(7838), "Tasty Plastic Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 20, 10, 6, 609, DateTimeKind.Local).AddTicks(8843), "Tasty Frozen Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 2, 36, 26, 49, DateTimeKind.Local).AddTicks(4571), "Unbranded Plastic Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 4, 20, 45, 553, DateTimeKind.Local).AddTicks(4275), "Handcrafted Plastic Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 1, 44, 51, 611, DateTimeKind.Local).AddTicks(1771), "Practical Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 7, 12, 22, 353, DateTimeKind.Local).AddTicks(9858), "Sleek Metal Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 5, 15, 49, 459, DateTimeKind.Local).AddTicks(4447), "Tasty Wooden Mouse", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 12, 13, 49, 986, DateTimeKind.Local).AddTicks(8319), "Small Fresh Pants", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 22, 47, 16, 787, DateTimeKind.Local).AddTicks(9097), "Rustic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 8, 7, 53, 586, DateTimeKind.Local).AddTicks(6567), "Tasty Concrete Shirt", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 10, 37, 9, 312, DateTimeKind.Local).AddTicks(7297), "Fantastic Soft Mouse", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 5, 5, 54, 308, DateTimeKind.Local).AddTicks(2743), "Sleek Granite Pizza", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 5, 19, 11, 219, DateTimeKind.Local).AddTicks(103), "Small Steel Bacon", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 21, 29, 19, 107, DateTimeKind.Local).AddTicks(3057), "Tasty Cotton Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 5, 28, 50, 542, DateTimeKind.Local).AddTicks(968), "Ergonomic Fresh Salad", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 13, 20, 0, 262, DateTimeKind.Local).AddTicks(5279), "Licensed Granite Fish", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 4, 27, 41, 907, DateTimeKind.Local).AddTicks(8093), "Fantastic Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 13, 23, 29, 32, DateTimeKind.Local).AddTicks(7150), "Gorgeous Cotton Cheese", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 5, 52, 0, 536, DateTimeKind.Local).AddTicks(5176), "Generic Concrete Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 3, 26, 9, 873, DateTimeKind.Local).AddTicks(4803), "Small Frozen Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 13, 14, 8, 885, DateTimeKind.Local).AddTicks(9653), "Fantastic Granite Computer", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 10, 37, 20, 963, DateTimeKind.Local).AddTicks(7756), "Ergonomic Soft Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 3, 32, 48, 496, DateTimeKind.Local).AddTicks(7162), "Fantastic Steel Cheese", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 4, 58, 58, 14, DateTimeKind.Local).AddTicks(263), "Handmade Soft Towels", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 12, 41, 39, 200, DateTimeKind.Local).AddTicks(1374), "Refined Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 4, 28, 36, 481, DateTimeKind.Local).AddTicks(4498), "Awesome Cotton Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 10, 52, 10, 188, DateTimeKind.Local).AddTicks(4180), "Refined Rubber Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 5, 38, 45, 677, DateTimeKind.Local).AddTicks(8465), "Intelligent Steel Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 14, 35, 20, 375, DateTimeKind.Local).AddTicks(2177), "Awesome Granite Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 7, 29, 44, 583, DateTimeKind.Local).AddTicks(5354), "Awesome Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 19, 56, 59, 822, DateTimeKind.Local).AddTicks(7338), "Small Frozen Cheese", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 10, 8, 11, 222, DateTimeKind.Local).AddTicks(3096), "Refined Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 0, 54, 13, 123, DateTimeKind.Local).AddTicks(3305), "Awesome Cotton Salad", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 1, 34, 25, 549, DateTimeKind.Local).AddTicks(6581), "Incredible Concrete Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 1, 46, 55, 105, DateTimeKind.Local).AddTicks(3952), "Sleek Frozen Ball", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 3, 23, 28, 76, DateTimeKind.Local).AddTicks(5441), "Intelligent Rubber Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 20, 18, 3, 939, DateTimeKind.Local).AddTicks(2514), "Awesome Concrete Pizza", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 14, 37, 15, 503, DateTimeKind.Local).AddTicks(889), "Rustic Plastic Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 19, 17, 47, 852, DateTimeKind.Local).AddTicks(1261), "Rustic Frozen Tuna", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 6, 17, 46, 772, DateTimeKind.Local).AddTicks(7140), "Fantastic Granite Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 18, 53, 49, 126, DateTimeKind.Local).AddTicks(5893), "Ergonomic Granite Ball", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 11, 21, 9, 681, DateTimeKind.Local).AddTicks(485), "Refined Plastic Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 8, 28, 51, 708, DateTimeKind.Local).AddTicks(9513), "Handcrafted Steel Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 14, 12, 11, 280, DateTimeKind.Local).AddTicks(9037), "Ergonomic Concrete Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 15, 28, 42, 257, DateTimeKind.Local).AddTicks(6209), "Sleek Steel Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 4, 57, 20, 764, DateTimeKind.Local).AddTicks(7050), "Incredible Metal Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 17, 55, 47, 979, DateTimeKind.Local).AddTicks(8150), "Handcrafted Soft Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 21, 38, 45, 199, DateTimeKind.Local).AddTicks(614), "Sleek Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 21, 48, 22, 16, DateTimeKind.Local).AddTicks(1687), "Small Frozen Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 1, 49, 15, 305, DateTimeKind.Local).AddTicks(1924), "Generic Wooden Shoes", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 9, 40, 22, 240, DateTimeKind.Local).AddTicks(3382), "Incredible Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 13, 43, 57, 884, DateTimeKind.Local).AddTicks(1489), "Practical Cotton Cheese", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 1, 32, 50, 880, DateTimeKind.Local).AddTicks(2210), "Incredible Granite Table", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 15, 59, 28, 301, DateTimeKind.Local).AddTicks(1815), "Sleek Wooden Pizza", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 10, 2, 17, 125, DateTimeKind.Local).AddTicks(2314), "Rustic Steel Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 18, 10, 43, 326, DateTimeKind.Local).AddTicks(5479), "Incredible Rubber Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 5, 12, 10, 317, DateTimeKind.Local).AddTicks(718), "Small Wooden Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 6, 35, 8, 504, DateTimeKind.Local).AddTicks(1503), "Ergonomic Metal Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 21, 15, 24, 823, DateTimeKind.Local).AddTicks(5876), "Intelligent Concrete Chair", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 11, 49, 49, 67, DateTimeKind.Local).AddTicks(4720), "Sleek Metal Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 20, 58, 47, 190, DateTimeKind.Local).AddTicks(3322), "Sleek Fresh Keyboard", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 2, 26, 3, 884, DateTimeKind.Local).AddTicks(6804), "Licensed Fresh Soap", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 2, 21, 13, 922, DateTimeKind.Local).AddTicks(7934), "Fantastic Cotton Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 17, 29, 44, 780, DateTimeKind.Local).AddTicks(1996), "Small Rubber Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 22, 4, 9, 877, DateTimeKind.Local).AddTicks(1325), "Rustic Granite Ball", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 20, 20, 36, 302, DateTimeKind.Local).AddTicks(3961), "Awesome Frozen Salad", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 22, 34, 45, 103, DateTimeKind.Local).AddTicks(752), "Practical Wooden Cheese", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 15, 52, 36, 176, DateTimeKind.Local).AddTicks(901), "Tasty Frozen Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 5, 50, 43, 32, DateTimeKind.Local).AddTicks(6774), "Awesome Concrete Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 13, 53, 33, 940, DateTimeKind.Local).AddTicks(2590), "Sleek Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 15, 24, 9, 257, DateTimeKind.Local).AddTicks(483), "Gorgeous Concrete Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 20, 27, 17, 319, DateTimeKind.Local).AddTicks(157), "Generic Concrete Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 15, 39, 27, 436, DateTimeKind.Local).AddTicks(9957), "Ergonomic Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 15, 40, 30, 7, DateTimeKind.Local).AddTicks(7611), "Tasty Fresh Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 9, 12, 35, 230, DateTimeKind.Local).AddTicks(3471), "Practical Granite Ball", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 22, 6, 46, 919, DateTimeKind.Local).AddTicks(8033), "Fantastic Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 6, 21, 41, 340, DateTimeKind.Local).AddTicks(5608), "Awesome Soft Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 14, 56, 23, 20, DateTimeKind.Local).AddTicks(9466), "Licensed Metal Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 6, 30, 6, 336, DateTimeKind.Local).AddTicks(5874), "Gorgeous Frozen Sausages", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 12, 46, 25, 794, DateTimeKind.Local).AddTicks(5849), "Handmade Plastic Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 7, 3, 35, 347, DateTimeKind.Local).AddTicks(9539), "Generic Frozen Shoes", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 6, 14, 24, 733, DateTimeKind.Local).AddTicks(3478), "Tasty Granite Chair", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 23, 16, 41, 719, DateTimeKind.Local).AddTicks(7763), "Refined Fresh Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 8, 4, 34, 602, DateTimeKind.Local).AddTicks(287), "Sleek Soft Ball", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 18, 54, 36, 723, DateTimeKind.Local).AddTicks(9963), "Rustic Granite Fish", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 13, 27, 3, 304, DateTimeKind.Local).AddTicks(12), "Generic Concrete Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 21, 27, 41, 818, DateTimeKind.Local).AddTicks(9292), "Awesome Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 4, 0, 19, 876, DateTimeKind.Local).AddTicks(4528), "Fantastic Wooden Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 23, 28, 10, 355, DateTimeKind.Local).AddTicks(3701), "Practical Cotton Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 13, 57, 40, 126, DateTimeKind.Local).AddTicks(4748), "Practical Granite Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 1, 50, 12, 280, DateTimeKind.Local).AddTicks(8015), "Licensed Frozen Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 14, 43, 46, 128, DateTimeKind.Local).AddTicks(3247), "Fantastic Frozen Gloves", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 3, 42, 43, 896, DateTimeKind.Local).AddTicks(5822), "Small Metal Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 2, 14, 24, 238, DateTimeKind.Local).AddTicks(5169), "Sleek Wooden Cheese", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 19, 17, 52, 603, DateTimeKind.Local).AddTicks(2041), "Gorgeous Steel Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 10, 26, 56, 996, DateTimeKind.Local).AddTicks(5135), "Licensed Frozen Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 4, 27, 20, 409, DateTimeKind.Local).AddTicks(3626), "Generic Frozen Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 2, 25, 18, 88, DateTimeKind.Local).AddTicks(6167), "Fantastic Cotton Soap", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 6, 9, 17, 999, DateTimeKind.Local).AddTicks(2370), "Handmade Metal Bacon", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 15, 42, 9, 734, DateTimeKind.Local).AddTicks(9546), "Tasty Fresh Towels", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 17, 23, 37, 120, DateTimeKind.Local).AddTicks(3992), "Refined Cotton Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 8, 45, 53, 148, DateTimeKind.Local).AddTicks(8482), "Fantastic Steel Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 40, 53, 356, DateTimeKind.Local).AddTicks(9996), "Unbranded Soft Table", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 15, 8, 13, 57, DateTimeKind.Local).AddTicks(1837), "Practical Cotton Car", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 13, 21, 15, 442, DateTimeKind.Local).AddTicks(6821), "Handcrafted Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 4, 50, 23, 22, DateTimeKind.Local).AddTicks(2591), "Intelligent Frozen Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 10, 19, 14, 338, DateTimeKind.Local).AddTicks(6535), "Handmade Metal Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 18, 37, 19, 839, DateTimeKind.Local).AddTicks(1601), "Fantastic Metal Hat", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 20, 47, 45, 87, DateTimeKind.Local).AddTicks(3607), "Practical Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 15, 58, 4, 79, DateTimeKind.Local).AddTicks(8060), "Small Granite Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 1, 15, 36, 582, DateTimeKind.Local).AddTicks(4252), "Unbranded Wooden Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 3, 9, 33, 582, DateTimeKind.Local).AddTicks(9016), "Handcrafted Wooden Salad", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 9, 33, 31, 242, DateTimeKind.Local).AddTicks(9427), "Incredible Fresh Cheese", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 3, 6, 49, 711, DateTimeKind.Local).AddTicks(6684), "Small Cotton Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 3, 31, 33, 505, DateTimeKind.Local).AddTicks(6513), "Licensed Fresh Fish", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 18, 54, 44, 346, DateTimeKind.Local).AddTicks(6098), "Practical Fresh Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 12, 39, 4, 7, DateTimeKind.Local).AddTicks(1081), "Generic Steel Bacon", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 5, 22, 13, 499, DateTimeKind.Local).AddTicks(2058), "Handcrafted Wooden Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 5, 40, 50, 36, DateTimeKind.Local).AddTicks(27), "Licensed Frozen Bacon", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 5, 56, 12, 429, DateTimeKind.Local).AddTicks(8494), "Handmade Rubber Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 18, 38, 25, 636, DateTimeKind.Local).AddTicks(7368), "Fantastic Plastic Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 39, 7, 948, DateTimeKind.Local).AddTicks(3145), "Small Fresh Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 9, 11, 49, 855, DateTimeKind.Local).AddTicks(6860), "Small Metal Bacon", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 6, 52, 53, 640, DateTimeKind.Local).AddTicks(7703), "Small Granite Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 14, 54, 8, 162, DateTimeKind.Local).AddTicks(1210), "Refined Soft Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 7, 19, 29, 584, DateTimeKind.Local).AddTicks(3115), "Handcrafted Plastic Fish", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 11, 19, 55, 957, DateTimeKind.Local).AddTicks(7314), "Ergonomic Soft Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 17, 55, 38, 680, DateTimeKind.Local).AddTicks(6425), "Small Granite Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 8, 45, 27, 850, DateTimeKind.Local).AddTicks(4659), "Small Metal Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 6, 48, 677, DateTimeKind.Local).AddTicks(7278), "Licensed Plastic Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 4, 29, 56, 878, DateTimeKind.Local).AddTicks(4156), "Generic Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 4, 30, 8, 534, DateTimeKind.Local).AddTicks(238), "Licensed Cotton Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 0, 51, 21, 1, DateTimeKind.Local).AddTicks(9049), "Gorgeous Rubber Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 15, 42, 2, 677, DateTimeKind.Local).AddTicks(156), "Rustic Soft Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 21, 7, 9, 611, DateTimeKind.Local).AddTicks(8423), "Incredible Fresh Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 4, 35, 37, 350, DateTimeKind.Local).AddTicks(6136), "Practical Soft Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 19, 22, 37, 873, DateTimeKind.Local).AddTicks(5336), "Tasty Granite Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 1, 35, 24, 265, DateTimeKind.Local).AddTicks(1529), "Intelligent Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 3, 18, 9, 287, DateTimeKind.Local).AddTicks(8883), "Sleek Wooden Sausages", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 12, 37, 59, 826, DateTimeKind.Local).AddTicks(6040), "Incredible Metal Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 14, 27, 16, 622, DateTimeKind.Local).AddTicks(8236), "Licensed Concrete Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 12, 55, 59, 450, DateTimeKind.Local).AddTicks(4510), "Small Concrete Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 14, 15, 10, 895, DateTimeKind.Local).AddTicks(7178), "Tasty Granite Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 19, 40, 7, 454, DateTimeKind.Local).AddTicks(8494), "Tasty Cotton Towels", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 20, 57, 30, 889, DateTimeKind.Local).AddTicks(7698), "Handmade Cotton Ball", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 4, 12, 51, 721, DateTimeKind.Local).AddTicks(2862), "Incredible Metal Salad", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 4, 47, 10, 37, DateTimeKind.Local).AddTicks(170), "Intelligent Soft Sausages", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 14, 8, 3, 898, DateTimeKind.Local).AddTicks(1367), "Rustic Rubber Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 14, 24, 3, 567, DateTimeKind.Local).AddTicks(4682), "Generic Granite Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 17, 18, 23, 701, DateTimeKind.Local).AddTicks(2467), "Rustic Soft Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 20, 11, 24, 845, DateTimeKind.Local).AddTicks(4494), "Intelligent Steel Salad", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 13, 45, 7, 643, DateTimeKind.Local).AddTicks(6692), "Gorgeous Rubber Chips", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 21, 16, 55, 194, DateTimeKind.Local).AddTicks(8246), "Practical Wooden Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 23, 59, 32, 636, DateTimeKind.Local).AddTicks(4322), "Rustic Fresh Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 2, 49, 51, 317, DateTimeKind.Local).AddTicks(235), "Ergonomic Steel Car", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 2, 38, 5, 422, DateTimeKind.Local).AddTicks(323), "Practical Rubber Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 7, 18, 38, 364, DateTimeKind.Local).AddTicks(2419), "Handmade Soft Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 2, 25, 36, 841, DateTimeKind.Local).AddTicks(3163), "Refined Cotton Computer", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 20, 29, 27, 879, DateTimeKind.Local).AddTicks(7756), "Tasty Plastic Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 0, 20, 6, 633, DateTimeKind.Local).AddTicks(6297), "Tasty Rubber Hat", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 11, 1, 40, 961, DateTimeKind.Local).AddTicks(2501), "Small Metal Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 0, 9, 48, 362, DateTimeKind.Local).AddTicks(7506), "Generic Rubber Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 19, 49, 27, 605, DateTimeKind.Local).AddTicks(7248), "Handcrafted Concrete Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 19, 56, 20, 913, DateTimeKind.Local).AddTicks(4906), "Tasty Fresh Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 11, 20, 24, 687, DateTimeKind.Local).AddTicks(4250), "Rustic Frozen Fish", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 23, 56, 28, 241, DateTimeKind.Local).AddTicks(4997), "Awesome Frozen Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 14, 50, 28, 263, DateTimeKind.Local).AddTicks(2854), "Sleek Metal Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 3, 6, 10, 598, DateTimeKind.Local).AddTicks(7293), "Refined Steel Shoes", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 18, 4, 26, 60, DateTimeKind.Local).AddTicks(4330), "Unbranded Plastic Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 5, 16, 51, 637, DateTimeKind.Local).AddTicks(8074), "Licensed Cotton Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 19, 27, 49, 171, DateTimeKind.Local).AddTicks(2669), "Unbranded Wooden Keyboard", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 1, 10, 26, 153, DateTimeKind.Local).AddTicks(8463), "Tasty Rubber Pizza", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 16, 46, 19, 30, DateTimeKind.Local).AddTicks(5926), "Intelligent Granite Cheese", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 18, 49, 45, 674, DateTimeKind.Local).AddTicks(2686), "Fantastic Steel Cheese", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 10, 41, 12, 8, DateTimeKind.Local).AddTicks(1076), "Incredible Plastic Table", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 4, 26, 0, 424, DateTimeKind.Local).AddTicks(6537), "Rustic Rubber Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 13, 7, 3, 300, DateTimeKind.Local).AddTicks(6805), "Incredible Concrete Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 20, 16, 18, 823, DateTimeKind.Local).AddTicks(817), "Rustic Concrete Chips", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 17, 26, 24, 515, DateTimeKind.Local).AddTicks(4967), "Generic Granite Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 3, 59, 56, 898, DateTimeKind.Local).AddTicks(6163), "Gorgeous Granite Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 1, 12, 15, 992, DateTimeKind.Local).AddTicks(4047), "Handcrafted Fresh Bike", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 8, 15, 8, 644, DateTimeKind.Local).AddTicks(4765), "Handcrafted Cotton Fish", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 19, 58, 28, 524, DateTimeKind.Local).AddTicks(355), "Refined Steel Keyboard", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 1, 23, 27, 820, DateTimeKind.Local).AddTicks(4631), "Licensed Plastic Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 8, 57, 39, 792, DateTimeKind.Local).AddTicks(3089), "Handcrafted Frozen Pants", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 18, 40, 21, 175, DateTimeKind.Local).AddTicks(9678), "Fantastic Metal Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 16, 53, 55, 834, DateTimeKind.Local).AddTicks(3302), "Ergonomic Rubber Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 21, 29, 25, 537, DateTimeKind.Local).AddTicks(5549), "Unbranded Concrete Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 12, 20, 15, 710, DateTimeKind.Local).AddTicks(1402), "Gorgeous Soft Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 12, 58, 10, 236, DateTimeKind.Local).AddTicks(4953), "Handmade Wooden Table", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 15, 12, 26, 839, DateTimeKind.Local).AddTicks(8227), "Unbranded Cotton Chips", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 16, 13, 27, 347, DateTimeKind.Local).AddTicks(2827), "Handcrafted Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 12, 47, 43, 810, DateTimeKind.Local).AddTicks(7835), "Handmade Soft Soap", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 19, 56, 47, 543, DateTimeKind.Local).AddTicks(3742), "Handcrafted Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 19, 35, 53, 26, DateTimeKind.Local).AddTicks(7864), "Ergonomic Concrete Table", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 13, 50, 32, 873, DateTimeKind.Local).AddTicks(4861), "Unbranded Metal Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 11, 55, 44, 958, DateTimeKind.Local).AddTicks(9330), "Small Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 21, 28, 14, 228, DateTimeKind.Local).AddTicks(8804), "Refined Frozen Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 19, 11, 57, 56, DateTimeKind.Local).AddTicks(7988), "Licensed Cotton Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 8, 46, 29, 88, DateTimeKind.Local).AddTicks(1935), "Awesome Fresh Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 11, 46, 34, 377, DateTimeKind.Local).AddTicks(7297), "Awesome Rubber Ball", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 21, 29, 2, 300, DateTimeKind.Local).AddTicks(2876), "Fantastic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 22, 1, 59, 836, DateTimeKind.Local).AddTicks(9812), "Small Granite Keyboard", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 19, 18, 23, 80, DateTimeKind.Local).AddTicks(4963), "Licensed Cotton Bike", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 10, 22, 13, 676, DateTimeKind.Local).AddTicks(2833), "Gorgeous Metal Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 1, 1, 56, 947, DateTimeKind.Local).AddTicks(6514), "Refined Plastic Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 23, 4, 48, 861, DateTimeKind.Local).AddTicks(1070), "Small Granite Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 18, 11, 11, 135, DateTimeKind.Local).AddTicks(2720), "Small Frozen Cheese", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 2, 6, 30, 650, DateTimeKind.Local).AddTicks(1688), "Small Plastic Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 21, 57, 26, 67, DateTimeKind.Local).AddTicks(4458), "Small Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 2, 44, 19, 4, DateTimeKind.Local).AddTicks(7198), "Sleek Fresh Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 9, 14, 33, 878, DateTimeKind.Local).AddTicks(7798), "Handcrafted Cotton Car", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 22, 48, 32, 617, DateTimeKind.Local).AddTicks(3017), "Handcrafted Rubber Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 9, 27, 42, 440, DateTimeKind.Local).AddTicks(2943), "Tasty Steel Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 13, 51, 23, 513, DateTimeKind.Local).AddTicks(7527), "Handmade Soft Tuna", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 7, 29, 35, 454, DateTimeKind.Local).AddTicks(9638), "Handmade Rubber Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 19, 38, 45, 162, DateTimeKind.Local).AddTicks(625), "Awesome Fresh Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 5, 46, 58, 525, DateTimeKind.Local).AddTicks(7153), "Gorgeous Plastic Bacon", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 21, 28, 0, 517, DateTimeKind.Local).AddTicks(9208), "Sleek Soft Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 10, 32, 2, 814, DateTimeKind.Local).AddTicks(9964), "Incredible Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 0, 58, 41, 277, DateTimeKind.Local).AddTicks(4092), "Intelligent Soft Hat", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 0, 21, 44, 797, DateTimeKind.Local).AddTicks(5139), "Unbranded Wooden Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 12, 56, 29, 99, DateTimeKind.Local).AddTicks(370), "Small Plastic Sausages", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 22, 53, 15, 746, DateTimeKind.Local).AddTicks(8668), "Small Wooden Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 8, 24, 48, 458, DateTimeKind.Local).AddTicks(3552), "Tasty Concrete Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 18, 13, 29, 619, DateTimeKind.Local).AddTicks(6670), "Small Steel Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 0, 15, 51, 631, DateTimeKind.Local).AddTicks(7251), "Tasty Frozen Bike", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 35, 6, 427, DateTimeKind.Local).AddTicks(8070), "Incredible Wooden Chips", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 3, 25, 56, 31, DateTimeKind.Local).AddTicks(3263), "Unbranded Wooden Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 20, 10, 49, 806, DateTimeKind.Local).AddTicks(5043), "Unbranded Metal Shoes", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 19, 41, 6, 190, DateTimeKind.Local).AddTicks(4903), "Unbranded Steel Cheese", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 3, 16, 30, 749, DateTimeKind.Local).AddTicks(8616), "Licensed Metal Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 1, 47, 45, 9, DateTimeKind.Local).AddTicks(3868), "Licensed Plastic Car", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 18, 57, 5, 403, DateTimeKind.Local).AddTicks(6061), "Ergonomic Metal Fish", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 23, 58, 53, 140, DateTimeKind.Local).AddTicks(3450), "Unbranded Soft Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 4, 57, 31, 745, DateTimeKind.Local).AddTicks(9611), "Unbranded Rubber Towels", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 16, 21, 52, 671, DateTimeKind.Local).AddTicks(8999), "Fantastic Rubber Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 12, 30, 39, 656, DateTimeKind.Local).AddTicks(1560), "Licensed Wooden Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 4, 29, 16, 994, DateTimeKind.Local).AddTicks(5555), "Handmade Concrete Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 15, 38, 36, 195, DateTimeKind.Local).AddTicks(2760), "Refined Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 8, 34, 23, 415, DateTimeKind.Local).AddTicks(6318), "Practical Frozen Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 10, 11, 48, 121, DateTimeKind.Local).AddTicks(3527), "Unbranded Granite Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 14, 50, 51, 76, DateTimeKind.Local).AddTicks(2690), "Handmade Frozen Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 55, 2, 226, DateTimeKind.Local).AddTicks(6965), "Awesome Steel Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 22, 29, 25, 964, DateTimeKind.Local).AddTicks(9212), "Fantastic Wooden Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 12, 11, 46, 887, DateTimeKind.Local).AddTicks(3958), "Fantastic Wooden Shoes", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 8, 30, 12, 372, DateTimeKind.Local).AddTicks(4806), "Practical Rubber Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 2, 42, 59, 408, DateTimeKind.Local).AddTicks(6460), "Sleek Concrete Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 23, 0, 14, 559, DateTimeKind.Local).AddTicks(1602), "Licensed Concrete Chips", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 18, 45, 12, 117, DateTimeKind.Local).AddTicks(5446), "Rustic Concrete Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 20, 54, 16, 464, DateTimeKind.Local).AddTicks(2202), "Ergonomic Metal Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 56, 40, 869, DateTimeKind.Local).AddTicks(6380), "Fantastic Wooden Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 10, 37, 26, 263, DateTimeKind.Local).AddTicks(8339), "Small Rubber Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 5, 24, 48, 231, DateTimeKind.Local).AddTicks(4365), "Unbranded Frozen Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 14, 12, 34, 291, DateTimeKind.Local).AddTicks(3383), "Refined Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 16, 12, 53, 90, DateTimeKind.Local).AddTicks(6123), "Awesome Concrete Fish", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 0, 0, 9, 575, DateTimeKind.Local).AddTicks(6191), "Generic Fresh Fish", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 7, 25, 6, 59, 37, 743, DateTimeKind.Local).AddTicks(3771), "Tasty Cotton Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 3, 36, 4, 921, DateTimeKind.Local).AddTicks(1060), "Practical Soft Pants", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 19, 14, 55, 230, DateTimeKind.Local).AddTicks(7525), "Incredible Wooden Gloves", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 18, 4, 41, 982, DateTimeKind.Local).AddTicks(429), "Small Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 6, 25, 15, 64, DateTimeKind.Local).AddTicks(6499), "Generic Steel Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 8, 59, 2, 713, DateTimeKind.Local).AddTicks(5731), "Fantastic Concrete Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 8, 24, 43, 535, DateTimeKind.Local).AddTicks(1952), "Unbranded Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 16, 31, 11, 10, DateTimeKind.Local).AddTicks(6549), "Gorgeous Granite Table", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 13, 20, 29, 421, DateTimeKind.Local).AddTicks(9043), "Gorgeous Wooden Ball", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 14, 41, 14, 391, DateTimeKind.Local).AddTicks(6836), "Sleek Concrete Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 2, 2, 1, 535, DateTimeKind.Local).AddTicks(2353), "Sleek Rubber Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 3, 56, 20, 288, DateTimeKind.Local).AddTicks(4442), "Awesome Frozen Keyboard", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 5, 20, 11, 885, DateTimeKind.Local).AddTicks(15), "Generic Fresh Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 5, 9, 1, 23, DateTimeKind.Local).AddTicks(7176), "Rustic Cotton Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 18, 53, 48, 456, DateTimeKind.Local).AddTicks(5668), "Awesome Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 2, 51, 21, 264, DateTimeKind.Local).AddTicks(4234), "Generic Soft Pants", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 13, 39, 54, 25, DateTimeKind.Local).AddTicks(462), "Awesome Fresh Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 16, 49, 54, 822, DateTimeKind.Local).AddTicks(1350), "Practical Steel Computer", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 10, 28, 53, 9, DateTimeKind.Local).AddTicks(8644), "Tasty Steel Chair", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 3, 36, 8, 107, DateTimeKind.Local).AddTicks(5532), "Practical Plastic Towels", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 6, 46, 51, 651, DateTimeKind.Local).AddTicks(7628), "Refined Soft Fish", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 11, 25, 20, 58, DateTimeKind.Local).AddTicks(134), "Handmade Fresh Sausages", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 20, 36, 26, 233, DateTimeKind.Local).AddTicks(3658), "Handcrafted Fresh Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 10, 55, 52, 722, DateTimeKind.Local).AddTicks(2915), "Intelligent Fresh Fish", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 14, 16, 45, 700, DateTimeKind.Local).AddTicks(840), "Licensed Granite Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 23, 30, 46, 363, DateTimeKind.Local).AddTicks(7765), "Sleek Plastic Table", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 23, 46, 41, 239, DateTimeKind.Local).AddTicks(9185), "Licensed Fresh Cheese", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 13, 24, 46, 203, DateTimeKind.Local).AddTicks(7995), "Practical Frozen Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 38, 3, 911, DateTimeKind.Local).AddTicks(4746), "Intelligent Frozen Tuna", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 6, 37, 22, 914, DateTimeKind.Local).AddTicks(4772), "Handmade Granite Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 10, 57, 15, 361, DateTimeKind.Local).AddTicks(5750), "Refined Cotton Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 8, 7, 2, 466, DateTimeKind.Local).AddTicks(1929), "Sleek Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 22, 30, 55, 176, DateTimeKind.Local).AddTicks(7218), "Gorgeous Fresh Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 14, 19, 28, 657, DateTimeKind.Local).AddTicks(1144), "Licensed Steel Gloves", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 5, 37, 56, 941, DateTimeKind.Local).AddTicks(6794), "Practical Rubber Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 4, 4, 33, 279, DateTimeKind.Local).AddTicks(9988), "Ergonomic Wooden Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 5, 12, 9, 971, DateTimeKind.Local).AddTicks(269), "Tasty Cotton Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 19, 2, 22, 93, DateTimeKind.Local).AddTicks(2734), "Small Concrete Mouse", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 7, 5, 22, 73, DateTimeKind.Local).AddTicks(8443), "Licensed Rubber Shirt", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 14, 36, 31, 639, DateTimeKind.Local).AddTicks(3577), "Unbranded Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 19, 51, 56, 23, DateTimeKind.Local).AddTicks(474), "Incredible Plastic Soap", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 16, 31, 9, 549, DateTimeKind.Local).AddTicks(1666), "Intelligent Wooden Chicken", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 16, 51, 18, 854, DateTimeKind.Local).AddTicks(645), "Handmade Metal Cheese", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 20, 52, 0, 247, DateTimeKind.Local).AddTicks(3638), "Handmade Plastic Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 22, 14, 19, 266, DateTimeKind.Local).AddTicks(6368), "Ergonomic Granite Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 17, 52, 33, 866, DateTimeKind.Local).AddTicks(5114), "Refined Concrete Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 26, 30, 389, DateTimeKind.Local).AddTicks(5770), "Practical Fresh Mouse", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 12, 9, 23, 480, DateTimeKind.Local).AddTicks(4501), "Refined Fresh Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 8, 38, 12, 454, DateTimeKind.Local).AddTicks(575), "Refined Granite Pizza", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 7, 50, 16, 436, DateTimeKind.Local).AddTicks(5954), "Gorgeous Steel Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 4, 47, 40, 666, DateTimeKind.Local).AddTicks(9721), "Sleek Wooden Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 2, 45, 30, 186, DateTimeKind.Local).AddTicks(7046), "Intelligent Granite Car", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 5, 30, 53, 707, DateTimeKind.Local).AddTicks(5640), "Practical Fresh Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 9, 12, 3, 518, DateTimeKind.Local).AddTicks(6102), "Unbranded Frozen Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 3, 35, 38, 57, DateTimeKind.Local).AddTicks(972), "Awesome Frozen Tuna", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 14, 23, 42, 34, DateTimeKind.Local).AddTicks(3193), "Handmade Concrete Bike", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 17, 14, 11, 128, DateTimeKind.Local).AddTicks(716), "Fantastic Cotton Pizza", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 19, 13, 9, 6, DateTimeKind.Local).AddTicks(6329), "Sleek Fresh Ball", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 16, 19, 36, 677, DateTimeKind.Local).AddTicks(4734), "Awesome Rubber Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 9, 36, 23, 738, DateTimeKind.Local).AddTicks(8879), "Ergonomic Cotton Computer", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 16, 5, 32, 816, DateTimeKind.Local).AddTicks(5362), "Rustic Soft Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 4, 38, 888, DateTimeKind.Local).AddTicks(1459), "Unbranded Metal Table", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 1, 34, 6, 762, DateTimeKind.Local).AddTicks(2610), "Fantastic Frozen Ball", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 3, 45, 10, 457, DateTimeKind.Local).AddTicks(6308), "Tasty Steel Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 7, 3, 42, 567, DateTimeKind.Local).AddTicks(7961), "Handcrafted Wooden Shoes", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 17, 54, 12, 18, DateTimeKind.Local).AddTicks(6652), "Ergonomic Steel Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 18, 53, 28, 378, DateTimeKind.Local).AddTicks(6527), "Ergonomic Granite Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 9, 57, 42, 774, DateTimeKind.Local).AddTicks(1846), "Incredible Frozen Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 9, 15, 20, 238, DateTimeKind.Local).AddTicks(5600), "Practical Plastic Cheese", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 1, 47, 57, 876, DateTimeKind.Local).AddTicks(4762), "Unbranded Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 23, 57, 45, 844, DateTimeKind.Local).AddTicks(9829), "Fantastic Steel Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 7, 33, 40, 714, DateTimeKind.Local).AddTicks(3655), "Handmade Cotton Bacon", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 15, 5, 47, 170, DateTimeKind.Local).AddTicks(7084), "Gorgeous Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 6, 39, 42, 45, DateTimeKind.Local), "Handmade Granite Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 14, 40, 6, 639, DateTimeKind.Local).AddTicks(8189), "Handmade Rubber Pants", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 10, 18, 55, 217, DateTimeKind.Local).AddTicks(250), "Tasty Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 13, 5, 21, 652, DateTimeKind.Local).AddTicks(2147), "Handmade Concrete Car", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 9, 48, 57, 541, DateTimeKind.Local).AddTicks(9884), "Awesome Cotton Sausages", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 10, 10, 53, 282, DateTimeKind.Local).AddTicks(8400), "Rustic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 23, 34, 59, 670, DateTimeKind.Local).AddTicks(527), "Small Granite Sausages", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 2, 21, 38, 601, DateTimeKind.Local).AddTicks(6073), "Intelligent Cotton Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 2, 44, 2, 424, DateTimeKind.Local).AddTicks(2658), "Small Concrete Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 16, 50, 50, 130, DateTimeKind.Local).AddTicks(1118), "Intelligent Cotton Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 18, 0, 4, 771, DateTimeKind.Local).AddTicks(7914), "Awesome Frozen Salad", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 3, 31, 4, 673, DateTimeKind.Local).AddTicks(2345), "Practical Plastic Hat", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 17, 6, 1, 7, DateTimeKind.Local).AddTicks(2738), "Rustic Soft Tuna", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 7, 31, 40, 982, DateTimeKind.Local).AddTicks(4451), "Intelligent Concrete Shirt", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 3, 34, 14, 669, DateTimeKind.Local).AddTicks(7188), "Tasty Cotton Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 0, 51, 10, 322, DateTimeKind.Local).AddTicks(2755), "Sleek Granite Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 23, 28, 15, 211, DateTimeKind.Local).AddTicks(1523), "Fantastic Wooden Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 10, 3, 192, DateTimeKind.Local).AddTicks(4686), "Refined Metal Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 15, 30, 41, 452, DateTimeKind.Local).AddTicks(9291), "Practical Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 23, 33, 50, 148, DateTimeKind.Local).AddTicks(410), "Tasty Wooden Shirt", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 3, 27, 57, 875, DateTimeKind.Local).AddTicks(8163), "Handcrafted Soft Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 15, 44, 57, 439, DateTimeKind.Local).AddTicks(9813), "Licensed Steel Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 21, 3, 1, 968, DateTimeKind.Local).AddTicks(8631), "Handcrafted Granite Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 0, 1, 49, 68, DateTimeKind.Local).AddTicks(6742), "Incredible Steel Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 11, 57, 46, 463, DateTimeKind.Local).AddTicks(6777), "Awesome Frozen Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 7, 25, 9, 30, 50, 830, DateTimeKind.Local).AddTicks(6047), "Rustic Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 22, 42, 39, 710, DateTimeKind.Local).AddTicks(5564), "Intelligent Granite Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 5, 41, 5, 21, DateTimeKind.Local).AddTicks(5747), "Licensed Steel Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 15, 43, 55, 185, DateTimeKind.Local).AddTicks(7), "Intelligent Rubber Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 15, 37, 35, 412, DateTimeKind.Local).AddTicks(7910), "Intelligent Fresh Computer", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 6, 6, 18, 664, DateTimeKind.Local).AddTicks(369), "Gorgeous Metal Chair", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 2, 4, 10, 412, DateTimeKind.Local).AddTicks(9121), "Refined Granite Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 6, 13, 37, 976, DateTimeKind.Local).AddTicks(8568), "Unbranded Plastic Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 22, 29, 25, 452, DateTimeKind.Local).AddTicks(3241), "Generic Rubber Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 15, 19, 32, 100, DateTimeKind.Local).AddTicks(902), "Sleek Wooden Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 15, 20, 34, 905, DateTimeKind.Local).AddTicks(3000), "Handcrafted Granite Sausages", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 19, 54, 7, 468, DateTimeKind.Local).AddTicks(2672), "Handcrafted Rubber Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 21, 50, 14, 872, DateTimeKind.Local).AddTicks(303), "Gorgeous Rubber Mouse", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 12, 1, 21, 998, DateTimeKind.Local).AddTicks(6753), "Awesome Plastic Soap", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 9, 42, 58, 175, DateTimeKind.Local).AddTicks(9113), "Incredible Wooden Bike", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 13, 6, 9, 795, DateTimeKind.Local).AddTicks(8574), "Ergonomic Frozen Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 18, 27, 33, 565, DateTimeKind.Local).AddTicks(8829), "Sleek Wooden Car", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 15, 20, 9, 786, DateTimeKind.Local).AddTicks(9309), "Intelligent Plastic Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 13, 17, 12, 964, DateTimeKind.Local).AddTicks(1531), "Handcrafted Plastic Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 23, 5, 25, 557, DateTimeKind.Local).AddTicks(8418), "Refined Granite Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 2, 2, 0, 78, DateTimeKind.Local).AddTicks(6076), "Practical Concrete Table", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 16, 3, 56, 33, DateTimeKind.Local).AddTicks(2930), "Incredible Steel Salad", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 14, 6, 41, 656, DateTimeKind.Local).AddTicks(9969), "Unbranded Concrete Pants", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 12, 6, 35, 72, DateTimeKind.Local).AddTicks(5036), "Ergonomic Metal Chicken", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 10, 31, 21, 180, DateTimeKind.Local).AddTicks(6368), "Practical Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 22, 50, 20, 766, DateTimeKind.Local).AddTicks(3669), "Intelligent Fresh Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 20, 49, 30, 203, DateTimeKind.Local).AddTicks(7147), "Gorgeous Cotton Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 12, 11, 3, 462, DateTimeKind.Local).AddTicks(4411), "Tasty Wooden Ball", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 17, 6, 20, 543, DateTimeKind.Local).AddTicks(7962), "Sleek Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 4, 25, 46, 432, DateTimeKind.Local).AddTicks(9502), "Handmade Metal Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 6, 46, 39, 876, DateTimeKind.Local).AddTicks(199), "Small Wooden Cheese", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 3, 32, 6, 31, DateTimeKind.Local).AddTicks(3816), "Refined Concrete Table", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 4, 53, 43, 459, DateTimeKind.Local).AddTicks(8183), "Refined Steel Chair", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 22, 41, 44, 153, DateTimeKind.Local).AddTicks(9479), "Handmade Fresh Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 9, 40, 4, 851, DateTimeKind.Local).AddTicks(4427), "Practical Fresh Chips", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 9, 7, 46, 868, DateTimeKind.Local).AddTicks(8715), "Rustic Metal Cheese", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 6, 54, 54, 80, DateTimeKind.Local).AddTicks(7120), "Refined Wooden Bike", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 6, 6, 8, 567, DateTimeKind.Local).AddTicks(392), "Intelligent Steel Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 11, 30, 55, 745, DateTimeKind.Local).AddTicks(5895), "Ergonomic Rubber Shirt", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 10, 30, 20, 121, DateTimeKind.Local).AddTicks(7380), "Intelligent Metal Towels", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 4, 35, 51, 573, DateTimeKind.Local).AddTicks(9773), "Handcrafted Frozen Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 4, 25, 33, 353, DateTimeKind.Local).AddTicks(178), "Tasty Wooden Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 16, 34, 20, 248, DateTimeKind.Local).AddTicks(4733), "Handcrafted Soft Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 23, 32, 10, 928, DateTimeKind.Local).AddTicks(2865), "Refined Metal Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 21, 52, 50, 509, DateTimeKind.Local).AddTicks(217), "Unbranded Fresh Keyboard", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 15, 52, 38, 979, DateTimeKind.Local).AddTicks(9288), "Awesome Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 18, 42, 38, 874, DateTimeKind.Local).AddTicks(3296), "Ergonomic Granite Towels", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 10, 22, 248, DateTimeKind.Local).AddTicks(4380), "Ergonomic Fresh Shirt", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 15, 44, 18, 385, DateTimeKind.Local).AddTicks(5220), "Incredible Steel Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 17, 14, 2, 175, DateTimeKind.Local).AddTicks(7887), "Small Fresh Keyboard", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 7, 25, 11, 30, 47, 956, DateTimeKind.Local).AddTicks(2137), "Small Rubber Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 10, 18, 38, 694, DateTimeKind.Local).AddTicks(8106), "Refined Concrete Towels", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 22, 52, 55, 817, DateTimeKind.Local).AddTicks(1277), "Intelligent Metal Chair", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 21, 19, 8, 424, DateTimeKind.Local).AddTicks(5910), "Handmade Plastic Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 1, 33, 49, 162, DateTimeKind.Local).AddTicks(4528), "Unbranded Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 7, 32, 39, 717, DateTimeKind.Local).AddTicks(4026), "Gorgeous Granite Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 12, 54, 16, 283, DateTimeKind.Local).AddTicks(8921), "Small Wooden Table", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 17, 37, 47, 974, DateTimeKind.Local).AddTicks(1413), "Tasty Frozen Mouse", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 17, 47, 6, 606, DateTimeKind.Local).AddTicks(5894), "Intelligent Frozen Car", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 19, 5, 37, 723, DateTimeKind.Local).AddTicks(9023), "Practical Granite Shoes", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 10, 7, 6, 86, DateTimeKind.Local).AddTicks(7336), "Generic Soft Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 22, 12, 30, 597, DateTimeKind.Local).AddTicks(7998), "Gorgeous Cotton Table", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 11, 14, 39, 491, DateTimeKind.Local).AddTicks(4009), "Awesome Cotton Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 8, 15, 11, 459, DateTimeKind.Local).AddTicks(8389), "Practical Granite Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 18, 26, 55, 73, DateTimeKind.Local).AddTicks(1246), "Tasty Cotton Bike", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 5, 2, 50, 940, DateTimeKind.Local).AddTicks(3895), "Refined Metal Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 20, 6, 19, 664, DateTimeKind.Local).AddTicks(4361), "Incredible Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 22, 48, 0, 25, DateTimeKind.Local).AddTicks(6794), "Small Granite Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 15, 24, 38, 540, DateTimeKind.Local).AddTicks(4861), "Tasty Frozen Bacon", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 24, 19, 50, 34, 542, DateTimeKind.Local).AddTicks(1964), "Sleek Cotton Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 20, 35, 50, 515, DateTimeKind.Local).AddTicks(1862), "Practical Frozen Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 6, 19, 42, 945, DateTimeKind.Local).AddTicks(5767), "Generic Rubber Pants", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 6, 22, 38, 976, DateTimeKind.Local).AddTicks(9339), "Gorgeous Fresh Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 8, 38, 50, 209, DateTimeKind.Local).AddTicks(6689), "Sleek Concrete Bike", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 1, 26, 33, 989, DateTimeKind.Local).AddTicks(901), "Tasty Granite Keyboard", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 11, 19, 39, 83, DateTimeKind.Local).AddTicks(4133), "Unbranded Plastic Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 18, 52, 51, 111, DateTimeKind.Local).AddTicks(6019), "Gorgeous Plastic Hat", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 17, 43, 16, 97, DateTimeKind.Local).AddTicks(5409), "Awesome Rubber Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 4, 26, 50, 239, DateTimeKind.Local).AddTicks(8492), "Fantastic Soft Chair", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 19, 5, 59, 687, DateTimeKind.Local).AddTicks(8958), "Ergonomic Steel Gloves", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 19, 3, 59, 630, DateTimeKind.Local).AddTicks(4756), "Tasty Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 24, 22, 57, 32, 572, DateTimeKind.Local).AddTicks(1600), "Refined Soft Bike", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 14, 58, 41, 337, DateTimeKind.Local).AddTicks(9580), "Ergonomic Frozen Tuna", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 16, 15, 5, 804, DateTimeKind.Local).AddTicks(3497), "Licensed Frozen Soap", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 6, 42, 2, 817, DateTimeKind.Local).AddTicks(6907), "Ergonomic Metal Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 11, 47, 56, 328, DateTimeKind.Local).AddTicks(1075), "Awesome Frozen Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 3, 9, 43, 900, DateTimeKind.Local).AddTicks(1964), "Handcrafted Cotton Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 13, 18, 50, 16, DateTimeKind.Local).AddTicks(3222), "Gorgeous Metal Cheese", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 6, 54, 24, 490, DateTimeKind.Local).AddTicks(7831), "Tasty Plastic Shoes", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 20, 13, 44, 341, DateTimeKind.Local).AddTicks(9188), "Tasty Fresh Bacon", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 5, 19, 23, 725, DateTimeKind.Local).AddTicks(2544), "Incredible Granite Pants", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 14, 4, 38, 850, DateTimeKind.Local).AddTicks(7142), "Fantastic Rubber Cheese", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 0, 44, 1, 216, DateTimeKind.Local).AddTicks(6792), "Intelligent Metal Bike", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 19, 16, 20, 433, DateTimeKind.Local).AddTicks(5606), "Intelligent Rubber Car", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 9, 16, 25, 59, DateTimeKind.Local).AddTicks(6249), "Ergonomic Rubber Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 17, 30, 30, 552, DateTimeKind.Local).AddTicks(4790), "Awesome Fresh Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 22, 21, 31, 366, DateTimeKind.Local).AddTicks(1984), "Licensed Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 12, 9, 8, 788, DateTimeKind.Local).AddTicks(549), "Sleek Frozen Bacon", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 15, 8, 47, 162, DateTimeKind.Local).AddTicks(8591), "Intelligent Frozen Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 5, 8, 20, 640, DateTimeKind.Local).AddTicks(5536), "Handmade Rubber Sausages", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 12, 35, 17, 700, DateTimeKind.Local).AddTicks(7570), "Incredible Cotton Tuna", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 16, 49, 22, 982, DateTimeKind.Local).AddTicks(810), "Licensed Granite Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 19, 40, 58, 19, DateTimeKind.Local).AddTicks(4024), "Tasty Fresh Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 11, 34, 3, 810, DateTimeKind.Local).AddTicks(9154), "Practical Concrete Sausages", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 6, 30, 38, 95, DateTimeKind.Local).AddTicks(4832), "Ergonomic Concrete Car", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 10, 8, 27, 671, DateTimeKind.Local).AddTicks(6254), "Incredible Concrete Sausages", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 5, 22, 1, 638, DateTimeKind.Local).AddTicks(634), "Ergonomic Wooden Chair", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 21, 17, 17, 964, DateTimeKind.Local).AddTicks(6894), "Tasty Granite Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 6, 2, 18, 669, DateTimeKind.Local).AddTicks(8585), "Licensed Plastic Sausages" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 1, 13, 4, 379, DateTimeKind.Local).AddTicks(757), "Tasty Soft Chips", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 1, 59, 601, DateTimeKind.Local).AddTicks(2747), "Awesome Steel Hat", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 59, 18, 119, DateTimeKind.Local).AddTicks(724), "Generic Steel Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 12, 0, 31, 19, DateTimeKind.Local).AddTicks(1761), "Sleek Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 10, 7, 8, 280, DateTimeKind.Local).AddTicks(8587), "Practical Rubber Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 7, 49, 6, 897, DateTimeKind.Local).AddTicks(1715), "Sleek Fresh Sausages", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 22, 54, 30, 397, DateTimeKind.Local).AddTicks(6331), "Fantastic Granite Shirt", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 9, 57, 24, 975, DateTimeKind.Local).AddTicks(4550), "Handmade Granite Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 9, 37, 56, 193, DateTimeKind.Local).AddTicks(3748), "Incredible Frozen Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 10, 44, 58, 763, DateTimeKind.Local).AddTicks(7801), "Rustic Metal Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 7, 35, 54, 930, DateTimeKind.Local).AddTicks(8418), "Handcrafted Soft Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 18, 37, 59, 109, DateTimeKind.Local).AddTicks(3486), "Practical Wooden Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 3, 41, 54, 621, DateTimeKind.Local).AddTicks(5823), "Handcrafted Wooden Towels", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 9, 18, 17, 577, DateTimeKind.Local).AddTicks(9811), "Gorgeous Rubber Car", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 3, 41, 13, 610, DateTimeKind.Local).AddTicks(7495), "Unbranded Plastic Shoes", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 4, 12, 11, 215, DateTimeKind.Local).AddTicks(9303), "Rustic Plastic Chair", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 21, 25, 20, 195, DateTimeKind.Local).AddTicks(2337), "Sleek Frozen Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 3, 43, 1, 265, DateTimeKind.Local).AddTicks(294), "Incredible Steel Cheese", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 19, 32, 58, 507, DateTimeKind.Local).AddTicks(3916), "Handcrafted Fresh Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 20, 33, 790, DateTimeKind.Local).AddTicks(5533), "Intelligent Cotton Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 14, 2, 21, 783, DateTimeKind.Local).AddTicks(8967), "Practical Steel Shirt", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 6, 11, 58, 273, DateTimeKind.Local).AddTicks(5126), "Rustic Cotton Computer", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 4, 46, 6, 922, DateTimeKind.Local).AddTicks(8077), "Licensed Soft Fish", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 16, 49, 9, 186, DateTimeKind.Local).AddTicks(4840), "Tasty Soft Cheese", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 20, 15, 22, 945, DateTimeKind.Local).AddTicks(291), "Refined Granite Tuna", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 1, 5, 12, 261, DateTimeKind.Local).AddTicks(996), "Refined Wooden Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 6, 53, 20, 572, DateTimeKind.Local).AddTicks(673), "Incredible Metal Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 18, 58, 32, 341, DateTimeKind.Local).AddTicks(7724), "Licensed Fresh Shirt", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 15, 14, 4, 483, DateTimeKind.Local).AddTicks(9753), "Incredible Cotton Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 0, 14, 57, 3, DateTimeKind.Local).AddTicks(2371), "Ergonomic Plastic Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 3, 7, 44, 604, DateTimeKind.Local).AddTicks(5142), "Rustic Soft Table", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 0, 23, 10, 771, DateTimeKind.Local).AddTicks(5998), "Gorgeous Cotton Cheese", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 5, 48, 49, 913, DateTimeKind.Local).AddTicks(3884), "Generic Wooden Towels", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 22, 6, 15, 70, DateTimeKind.Local).AddTicks(7282), "Tasty Plastic Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 4, 13, 44, 56, DateTimeKind.Local).AddTicks(7121), "Unbranded Metal Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 8, 57, 21, 151, DateTimeKind.Local).AddTicks(6123), "Tasty Metal Chair", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 4, 21, 21, 938, DateTimeKind.Local).AddTicks(8352), "Awesome Steel Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 12, 39, 59, 522, DateTimeKind.Local).AddTicks(1232), "Unbranded Concrete Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 23, 57, 7, 809, DateTimeKind.Local).AddTicks(9499), "Intelligent Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 11, 44, 1, 230, DateTimeKind.Local).AddTicks(2718), "Handcrafted Granite Cheese", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 16, 51, 38, 179, DateTimeKind.Local).AddTicks(7571), "Rustic Granite Pants", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 18, 13, 49, 123, DateTimeKind.Local).AddTicks(1710), "Licensed Wooden Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 18, 27, 28, 506, DateTimeKind.Local).AddTicks(8237), "Handmade Plastic Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 5, 2, 58, 133, DateTimeKind.Local).AddTicks(2242), "Unbranded Soft Keyboard", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 2, 7, 39, 356, DateTimeKind.Local).AddTicks(723), "Small Concrete Shoes", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 0, 9, 36, 798, DateTimeKind.Local).AddTicks(6433), "Tasty Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 16, 7, 53, 875, DateTimeKind.Local).AddTicks(6121), "Tasty Frozen Ball", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 5, 16, 23, 936, DateTimeKind.Local).AddTicks(8449), "Gorgeous Metal Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 10, 35, 10, 732, DateTimeKind.Local).AddTicks(6397), "Unbranded Fresh Table", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 0, 57, 28, 418, DateTimeKind.Local).AddTicks(8506), "Awesome Rubber Table", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 6, 58, 34, 510, DateTimeKind.Local).AddTicks(4778), "Handcrafted Metal Pizza", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 1, 42, 54, 832, DateTimeKind.Local).AddTicks(9673), "Fantastic Soft Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 14, 12, 21, 683, DateTimeKind.Local).AddTicks(7342), "Handmade Soft Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 13, 5, 10, 194, DateTimeKind.Local).AddTicks(9917), "Handmade Fresh Table", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 16, 5, 0, 580, DateTimeKind.Local).AddTicks(9066), "Intelligent Granite Bike", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 20, 23, 17, 986, DateTimeKind.Local).AddTicks(6281), "Handmade Frozen Table", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 19, 33, 34, 882, DateTimeKind.Local).AddTicks(4768), "Small Steel Computer", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 21, 49, 52, 789, DateTimeKind.Local).AddTicks(3611), "Handmade Concrete Gloves", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 4, 33, 49, 742, DateTimeKind.Local).AddTicks(1226), "Refined Wooden Shoes", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 4, 29, 19, 86, DateTimeKind.Local).AddTicks(8919), "Licensed Steel Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 14, 46, 35, 186, DateTimeKind.Local).AddTicks(5087), "Licensed Wooden Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 3, 13, 50, 230, DateTimeKind.Local).AddTicks(355), "Unbranded Steel Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 46, 12, 395, DateTimeKind.Local).AddTicks(4146), "Sleek Steel Gloves", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 12, 34, 29, 387, DateTimeKind.Local).AddTicks(7266), "Incredible Rubber Ball", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 2, 16, 33, 569, DateTimeKind.Local).AddTicks(3325), "Refined Frozen Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 19, 38, 23, 148, DateTimeKind.Local).AddTicks(4463), "Intelligent Granite Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 21, 30, 19, 967, DateTimeKind.Local).AddTicks(216), "Ergonomic Soft Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 21, 22, 41, 324, DateTimeKind.Local).AddTicks(8390), "Generic Metal Soap", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 5, 13, 36, 200, DateTimeKind.Local).AddTicks(5579), "Sleek Rubber Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 9, 5, 44, 505, DateTimeKind.Local).AddTicks(38), "Unbranded Wooden Fish", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 17, 20, 24, 403, DateTimeKind.Local).AddTicks(6198), "Handcrafted Wooden Table", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 48, 38, 250, DateTimeKind.Local).AddTicks(2470), "Incredible Wooden Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 13, 11, 14, 235, DateTimeKind.Local).AddTicks(147), "Unbranded Wooden Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 1, 42, 960, DateTimeKind.Local).AddTicks(8141), "Intelligent Cotton Soap", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 18, 57, 38, 985, DateTimeKind.Local).AddTicks(4251), "Small Frozen Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 21, 42, 6, 216, DateTimeKind.Local).AddTicks(1396), "Tasty Fresh Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 11, 35, 5, 711, DateTimeKind.Local).AddTicks(1793), "Rustic Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 3, 20, 20, 675, DateTimeKind.Local).AddTicks(148), "Awesome Cotton Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 20, 30, 51, 137, DateTimeKind.Local).AddTicks(6315), "Ergonomic Fresh Car", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 5, 50, 11, 507, DateTimeKind.Local).AddTicks(2664), "Incredible Wooden Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 4, 24, 24, 168, DateTimeKind.Local).AddTicks(670), "Refined Cotton Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 1, 24, 53, 248, DateTimeKind.Local).AddTicks(4511), "Practical Rubber Soap", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 23, 49, 15, 792, DateTimeKind.Local).AddTicks(9033), "Refined Concrete Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 15, 55, 37, 897, DateTimeKind.Local).AddTicks(105), "Intelligent Soft Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 2, 6, 13, 611, DateTimeKind.Local).AddTicks(8144), "Small Rubber Hat", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 5, 2, 41, 274, DateTimeKind.Local).AddTicks(1037), "Awesome Frozen Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 9, 18, 37, 873, DateTimeKind.Local).AddTicks(1239), "Handcrafted Steel Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 13, 31, 10, 631, DateTimeKind.Local).AddTicks(5516), "Intelligent Frozen Chips", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 10, 7, 27, 169, DateTimeKind.Local).AddTicks(9014), "Ergonomic Cotton Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 4, 30, 46, 900, DateTimeKind.Local).AddTicks(1652), "Handmade Fresh Tuna", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 7, 58, 30, 103, DateTimeKind.Local).AddTicks(9749), "Fantastic Cotton Towels", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 50, 26, 597, DateTimeKind.Local).AddTicks(5212), "Awesome Soft Ball", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 19, 45, 46, 25, DateTimeKind.Local).AddTicks(2271), "Gorgeous Plastic Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 22, 25, 2, 189, DateTimeKind.Local).AddTicks(4059), "Awesome Fresh Shoes", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 0, 14, 55, 809, DateTimeKind.Local).AddTicks(410), "Licensed Plastic Table", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 11, 50, 54, 685, DateTimeKind.Local).AddTicks(8547), "Small Rubber Pants", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 10, 15, 47, 714, DateTimeKind.Local).AddTicks(701), "Handmade Metal Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 22, 20, 4, 724, DateTimeKind.Local).AddTicks(6850), "Gorgeous Concrete Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 41, 9, 253, DateTimeKind.Local).AddTicks(2112), "Handcrafted Frozen Soap", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 18, 42, 18, 285, DateTimeKind.Local).AddTicks(8073), "Tasty Plastic Pants", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 2, 28, 7, 462, DateTimeKind.Local).AddTicks(6194), "Unbranded Soft Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 14, 38, 40, 710, DateTimeKind.Local).AddTicks(1293), "Generic Metal Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 3, 4, 28, 901, DateTimeKind.Local).AddTicks(8383), "Incredible Cotton Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 6, 37, 19, 106, DateTimeKind.Local).AddTicks(9689), "Sleek Concrete Computer", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 24, 32, 967, DateTimeKind.Local).AddTicks(4290), "Sleek Concrete Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 10, 44, 853, DateTimeKind.Local).AddTicks(7515), "Incredible Concrete Computer", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 16, 43, 19, 667, DateTimeKind.Local).AddTicks(4645), "Handcrafted Fresh Pants", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 17, 56, 15, 551, DateTimeKind.Local).AddTicks(8316), "Gorgeous Cotton Soap", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 7, 33, 16, 851, DateTimeKind.Local).AddTicks(1288), "Intelligent Concrete Mouse", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 4, 50, 46, 202, DateTimeKind.Local).AddTicks(9341), "Awesome Wooden Chips", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 11, 22, 27, 537, DateTimeKind.Local).AddTicks(7864), "Small Frozen Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 24, 23, 7, 41, 796, DateTimeKind.Local).AddTicks(9510), "Practical Metal Bacon", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 0, 45, 25, 926, DateTimeKind.Local).AddTicks(8288), "Handcrafted Granite Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 2, 9, 40, 582, DateTimeKind.Local).AddTicks(6651), "Small Fresh Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 3, 34, 54, 824, DateTimeKind.Local).AddTicks(1018), "Refined Cotton Gloves", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 3, 19, 13, 44, DateTimeKind.Local).AddTicks(5435), "Sleek Rubber Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 17, 17, 6, 765, DateTimeKind.Local).AddTicks(191), "Sleek Frozen Bike", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 14, 29, 45, 677, DateTimeKind.Local).AddTicks(5652), "Unbranded Granite Bacon", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 24, 17, 19, 53, 777, DateTimeKind.Local).AddTicks(4940), "Handmade Steel Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 12, 11, 13, 474, DateTimeKind.Local).AddTicks(2270), "Small Metal Car", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 16, 43, 14, 675, DateTimeKind.Local).AddTicks(9898), "Gorgeous Concrete Ball", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 5, 44, 59, 173, DateTimeKind.Local).AddTicks(9417), "Generic Rubber Table", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 13, 22, 46, 706, DateTimeKind.Local).AddTicks(8252), "Awesome Fresh Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 14, 23, 44, 32, DateTimeKind.Local).AddTicks(4554), "Awesome Soft Sausages", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 3, 2, 2, 161, DateTimeKind.Local).AddTicks(5490), "Unbranded Concrete Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 18, 37, 34, 335, DateTimeKind.Local).AddTicks(6827), "Awesome Concrete Sausages", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 21, 17, 32, 244, DateTimeKind.Local).AddTicks(6337), "Tasty Steel Bike", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 8, 58, 37, 31, DateTimeKind.Local).AddTicks(8787), "Incredible Cotton Ball", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 14, 21, 20, 173, DateTimeKind.Local).AddTicks(8910), "Ergonomic Metal Gloves", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 12, 22, 50, 659, DateTimeKind.Local).AddTicks(941), "Small Concrete Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 23, 33, 16, 99, DateTimeKind.Local).AddTicks(4007), "Unbranded Fresh Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 19, 39, 6, 605, DateTimeKind.Local).AddTicks(9039), "Practical Wooden Pizza", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 23, 7, 36, 136, DateTimeKind.Local).AddTicks(5049), "Sleek Soft Cheese", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 10, 33, 37, 616, DateTimeKind.Local).AddTicks(757), "Gorgeous Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 14, 30, 9, 336, DateTimeKind.Local).AddTicks(5907), "Tasty Frozen Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 14, 28, 28, 441, DateTimeKind.Local).AddTicks(8088), "Handmade Plastic Towels", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 6, 25, 43, 137, DateTimeKind.Local).AddTicks(808), "Unbranded Fresh Towels", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 19, 57, 18, 408, DateTimeKind.Local).AddTicks(8741), "Handcrafted Granite Chips", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 17, 4, 410, DateTimeKind.Local).AddTicks(3080), "Rustic Frozen Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 1, 52, 42, 145, DateTimeKind.Local).AddTicks(3644), "Generic Granite Ball", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 4, 19, 15, 198, DateTimeKind.Local).AddTicks(7411), "Handmade Steel Shirt", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 11, 22, 57, 808, DateTimeKind.Local).AddTicks(1007), "Handcrafted Concrete Gloves", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 24, 22, 6, 56, 972, DateTimeKind.Local).AddTicks(7324), "Generic Concrete Table", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 17, 24, 56, 601, DateTimeKind.Local).AddTicks(1752), "Refined Plastic Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 0, 4, 36, 79, DateTimeKind.Local).AddTicks(5760), "Generic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 7, 39, 31, 131, DateTimeKind.Local).AddTicks(2421), "Fantastic Metal Keyboard", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 20, 27, 52, 187, DateTimeKind.Local).AddTicks(7435), "Generic Wooden Gloves", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 3, 26, 55, 186, DateTimeKind.Local).AddTicks(2932), "Incredible Frozen Chips", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 15, 41, 30, 654, DateTimeKind.Local).AddTicks(1581), "Small Concrete Bike", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 23, 56, 18, 114, DateTimeKind.Local).AddTicks(8416), "Refined Soft Shoes", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 10, 34, 57, 690, DateTimeKind.Local).AddTicks(3242), "Licensed Fresh Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 0, 18, 1, 922, DateTimeKind.Local).AddTicks(5652), "Awesome Frozen Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 16, 30, 33, 770, DateTimeKind.Local).AddTicks(5044), "Intelligent Rubber Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 12, 9, 1, 43, DateTimeKind.Local).AddTicks(5707), "Awesome Fresh Table", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 16, 33, 51, 258, DateTimeKind.Local).AddTicks(5556), "Awesome Concrete Fish", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 10, 5, 19, 280, DateTimeKind.Local).AddTicks(3608), "Generic Plastic Shoes", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 7, 13, 47, 796, DateTimeKind.Local).AddTicks(2039), "Ergonomic Wooden Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 6, 46, 1, 349, DateTimeKind.Local).AddTicks(732), "Incredible Fresh Ball", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 22, 0, 18, 668, DateTimeKind.Local).AddTicks(4239), "Licensed Soft Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 20, 3, 3, 787, DateTimeKind.Local).AddTicks(1732), "Handmade Steel Salad", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 12, 34, 54, 739, DateTimeKind.Local).AddTicks(7443), "Ergonomic Plastic Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 12, 7, 58, 147, DateTimeKind.Local).AddTicks(9605), "Fantastic Concrete Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 17, 49, 33, 632, DateTimeKind.Local).AddTicks(9589), "Gorgeous Wooden Bacon", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 12, 39, 8, 128, DateTimeKind.Local).AddTicks(8959), "Practical Wooden Bike", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 17, 38, 1, 799, DateTimeKind.Local).AddTicks(3481), "Gorgeous Soft Soap", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 10, 31, 0, 20, DateTimeKind.Local).AddTicks(5056), "Handmade Steel Mouse", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 0, 53, 51, 248, DateTimeKind.Local).AddTicks(2487), "Handmade Cotton Chair", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 24, 17, 23, 4, 594, DateTimeKind.Local).AddTicks(2926), "Handcrafted Granite Hat", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 17, 54, 42, 996, DateTimeKind.Local).AddTicks(9401), "Rustic Frozen Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 8, 1, 31, 627, DateTimeKind.Local).AddTicks(3632), "Intelligent Concrete Soap", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 20, 43, 4, 48, DateTimeKind.Local).AddTicks(5962), "Generic Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 22, 38, 10, 222, DateTimeKind.Local).AddTicks(74), "Unbranded Frozen Cheese", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 15, 18, 38, 306, DateTimeKind.Local).AddTicks(5300), "Licensed Frozen Fish", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 15, 57, 41, 5, DateTimeKind.Local).AddTicks(4281), "Unbranded Wooden Tuna", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 22, 39, 51, 569, DateTimeKind.Local).AddTicks(9945), "Awesome Plastic Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 24, 19, 5, 22, 625, DateTimeKind.Local).AddTicks(1908), "Intelligent Rubber Shirt", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 11, 6, 9, 122, DateTimeKind.Local).AddTicks(2176), "Intelligent Metal Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 12, 45, 19, 930, DateTimeKind.Local).AddTicks(2537), "Sleek Concrete Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 13, 45, 46, 703, DateTimeKind.Local).AddTicks(7603), "Gorgeous Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 18, 15, 4, 89, DateTimeKind.Local).AddTicks(3252), "Intelligent Fresh Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 2, 20, 18, 864, DateTimeKind.Local).AddTicks(5149), "Refined Concrete Table", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 8, 12, 10, 348, DateTimeKind.Local).AddTicks(8475), "Generic Cotton Towels", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 0, 30, 30, 945, DateTimeKind.Local).AddTicks(825), "Rustic Metal Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 14, 20, 34, 139, DateTimeKind.Local).AddTicks(1779), "Fantastic Wooden Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 8, 44, 38, 901, DateTimeKind.Local).AddTicks(4519), "Intelligent Granite Computer", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Outdoors", new DateTime(2022, 7, 25, 10, 7, 34, 12, DateTimeKind.Local).AddTicks(3970), "Incredible Frozen Gloves", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 2, 48, 2, 698, DateTimeKind.Local).AddTicks(7658), "Fantastic Fresh Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 7, 27, 9, 902, DateTimeKind.Local).AddTicks(8134), "Intelligent Soft Shirt", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Health", new DateTime(2022, 7, 24, 19, 53, 53, 653, DateTimeKind.Local).AddTicks(9105), "Sleek Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 24, 22, 57, 25, 672, DateTimeKind.Local).AddTicks(7873), "Rustic Frozen Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 3, 47, 10, 586, DateTimeKind.Local).AddTicks(9613), "Fantastic Steel Car", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 24, 19, 16, 12, 955, DateTimeKind.Local).AddTicks(8448), "Incredible Wooden Sausages", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 1, 40, 20, 148, DateTimeKind.Local).AddTicks(501), "Incredible Steel Mouse", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 12, 2, 7, 740, DateTimeKind.Local).AddTicks(8837), "Licensed Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 24, 17, 45, 15, 963, DateTimeKind.Local).AddTicks(5932), "Sleek Soft Sausages", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 7, 41, 51, 515, DateTimeKind.Local).AddTicks(4601), "Unbranded Fresh Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Health", new DateTime(2022, 7, 25, 16, 40, 12, 145, DateTimeKind.Local).AddTicks(4873), "Gorgeous Frozen Table", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 17, 0, 55, 852, DateTimeKind.Local).AddTicks(6070), "Small Fresh Chicken", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 7, 48, 18, 672, DateTimeKind.Local).AddTicks(9675), "Refined Metal Chair", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 0, 1, 48, 917, DateTimeKind.Local).AddTicks(3188), "Ergonomic Concrete Chair", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 3, 41, 10, 844, DateTimeKind.Local).AddTicks(4503), "Ergonomic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 12, 52, 34, 308, DateTimeKind.Local).AddTicks(3323), "Rustic Plastic Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 2, 3, 27, 783, DateTimeKind.Local).AddTicks(7851), "Handcrafted Soft Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 16, 15, 12, 427, DateTimeKind.Local).AddTicks(489), "Intelligent Plastic Tuna", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 6, 0, 31, 915, DateTimeKind.Local).AddTicks(3919), "Practical Frozen Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 2, 13, 48, 986, DateTimeKind.Local).AddTicks(1314), "Generic Cotton Shoes", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 16, 1, 59, 327, DateTimeKind.Local).AddTicks(1484), "Sleek Metal Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 10, 8, 30, 512, DateTimeKind.Local).AddTicks(2405), "Tasty Wooden Salad", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 25, 12, 28, 54, 8, DateTimeKind.Local).AddTicks(9912), "Practical Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 9, 21, 52, 49, DateTimeKind.Local).AddTicks(3012), "Awesome Frozen Bacon", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 8, 12, 31, 644, DateTimeKind.Local).AddTicks(454), "Small Fresh Pizza", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 21, 55, 10, 872, DateTimeKind.Local).AddTicks(9267), "Fantastic Rubber Salad", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 21, 28, 19, 842, DateTimeKind.Local).AddTicks(5708), "Fantastic Concrete Chips", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 16, 5, 10, 332, DateTimeKind.Local).AddTicks(9829), "Gorgeous Cotton Chair", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 8, 58, 5, 350, DateTimeKind.Local).AddTicks(4490), "Generic Granite Soap" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 5, 55, 13, 162, DateTimeKind.Local).AddTicks(7334), "Intelligent Cotton Pants", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 1, 1, 48, 721, DateTimeKind.Local).AddTicks(4646), "Handmade Frozen Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 2, 54, 9, 557, DateTimeKind.Local).AddTicks(7026), "Licensed Rubber Bike", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 17, 4, 41, 846, DateTimeKind.Local).AddTicks(2645), "Sleek Rubber Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 8, 4, 52, 385, DateTimeKind.Local).AddTicks(5717), "Generic Metal Hat", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 0, 30, 55, 227, DateTimeKind.Local).AddTicks(6493), "Fantastic Rubber Pizza", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 10, 28, 27, 579, DateTimeKind.Local).AddTicks(5464), "Sleek Metal Soap", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 20, 12, 8, 235, DateTimeKind.Local).AddTicks(5083), "Gorgeous Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 20, 0, 48, 809, DateTimeKind.Local).AddTicks(7540), "Awesome Steel Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 11, 45, 54, 690, DateTimeKind.Local).AddTicks(8800), "Fantastic Plastic Keyboard", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 1, 49, 6, 823, DateTimeKind.Local).AddTicks(7534), "Ergonomic Wooden Chicken", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 24, 22, 46, 14, 172, DateTimeKind.Local).AddTicks(9609), "Tasty Steel Tuna", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 14, 53, 48, 756, DateTimeKind.Local).AddTicks(8025), "Refined Granite Soap", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 24, 23, 25, 33, 320, DateTimeKind.Local).AddTicks(5422), "Tasty Fresh Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 25, 9, 36, 49, 178, DateTimeKind.Local).AddTicks(5744), "Practical Cotton Computer", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 13, 58, 25, 882, DateTimeKind.Local).AddTicks(1900), "Incredible Concrete Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 0, 10, 48, 889, DateTimeKind.Local).AddTicks(7219), "Gorgeous Steel Hat", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 8, 37, 40, 183, DateTimeKind.Local).AddTicks(9489), "Rustic Plastic Table", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 0, 44, 36, 216, DateTimeKind.Local).AddTicks(8389), "Handcrafted Concrete Gloves", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 24, 21, 33, 38, 779, DateTimeKind.Local).AddTicks(2502), "Tasty Soft Ball", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 22, 40, 19, 636, DateTimeKind.Local).AddTicks(854), "Fantastic Concrete Chips", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 24, 19, 20, 26, 482, DateTimeKind.Local).AddTicks(3888), "Licensed Frozen Chips", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 2, 43, 59, 912, DateTimeKind.Local).AddTicks(4903), "Generic Granite Mouse", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 10, 0, 39, 160, DateTimeKind.Local).AddTicks(9976), "Generic Plastic Mouse", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 24, 18, 51, 23, 423, DateTimeKind.Local).AddTicks(4803), "Rustic Soft Pants", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 7, 21, 18, 399, DateTimeKind.Local).AddTicks(3382), "Practical Rubber Bike", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 10, 5, 51, 463, DateTimeKind.Local).AddTicks(5270), "Unbranded Concrete Sausages", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 6, 30, 10, 210, DateTimeKind.Local).AddTicks(2074), "Licensed Wooden Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 18, 35, 13, 286, DateTimeKind.Local).AddTicks(6182), "Intelligent Steel Keyboard", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Sports", new DateTime(2022, 7, 25, 14, 31, 48, 82, DateTimeKind.Local).AddTicks(7861), "Awesome Wooden Chips", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 16, 59, 12, 399, DateTimeKind.Local).AddTicks(4511), "Incredible Plastic Car", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 0, 27, 29, 567, DateTimeKind.Local).AddTicks(5994), "Practical Fresh Table", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 6, 43, 16, 549, DateTimeKind.Local).AddTicks(315), "Tasty Steel Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 11, 34, 31, 151, DateTimeKind.Local).AddTicks(7634), "Handmade Concrete Soap", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 25, 9, 20, 53, 653, DateTimeKind.Local).AddTicks(4473), "Refined Steel Pizza", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 25, 12, 33, 20, 242, DateTimeKind.Local).AddTicks(9912), "Intelligent Soft Mouse", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 24, 21, 2, 29, 307, DateTimeKind.Local).AddTicks(7358), "Small Fresh Car", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 12, 39, 53, 279, DateTimeKind.Local).AddTicks(5662), "Tasty Metal Hat", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 24, 17, 47, 3, 482, DateTimeKind.Local).AddTicks(3839), "Sleek Frozen Bike", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Beauty", new DateTime(2022, 7, 25, 4, 30, 34, 373, DateTimeKind.Local).AddTicks(2394), "Licensed Steel Soap", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Tools", new DateTime(2022, 7, 25, 4, 28, 15, 865, DateTimeKind.Local).AddTicks(8046), "Gorgeous Frozen Mouse", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Movies", new DateTime(2022, 7, 24, 22, 30, 2, 314, DateTimeKind.Local).AddTicks(653), "Gorgeous Steel Towels", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 9, 59, 15, 86, DateTimeKind.Local).AddTicks(6195), "Ergonomic Metal Keyboard", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 13, 36, 16, 746, DateTimeKind.Local).AddTicks(9464), "Incredible Frozen Salad", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Industrial", new DateTime(2022, 7, 24, 23, 35, 31, 760, DateTimeKind.Local).AddTicks(8601), "Gorgeous Granite Chicken", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Books", new DateTime(2022, 7, 25, 14, 22, 7, 87, DateTimeKind.Local).AddTicks(2218), "Generic Plastic Pants", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Garden", new DateTime(2022, 7, 25, 12, 58, 8, 729, DateTimeKind.Local).AddTicks(3369), "Handmade Soft Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 17, 12, 27, 378, DateTimeKind.Local).AddTicks(9622), "Intelligent Wooden Mouse", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Shoes", new DateTime(2022, 7, 25, 10, 19, 25, 50, DateTimeKind.Local).AddTicks(331), "Handcrafted Concrete Salad", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 0, 0, 37, 801, DateTimeKind.Local).AddTicks(2160), "Ergonomic Metal Computer", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Games", new DateTime(2022, 7, 25, 13, 24, 5, 506, DateTimeKind.Local).AddTicks(4614), "Refined Soft Sausages", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 8, 0, 16, 569, DateTimeKind.Local).AddTicks(6820), "Intelligent Fresh Shoes", 55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Automotive", new DateTime(2022, 7, 25, 0, 27, 22, 594, DateTimeKind.Local).AddTicks(8529), "Generic Fresh Chair", 52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 5, 52, 22, 577, DateTimeKind.Local).AddTicks(1980), "Tasty Plastic Chicken", 56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 6, 21, 40, 595, DateTimeKind.Local).AddTicks(2946), "Incredible Fresh Keyboard", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Music", new DateTime(2022, 7, 25, 1, 3, 59, 903, DateTimeKind.Local).AddTicks(7269), "Sleek Granite Fish", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Toys", new DateTime(2022, 7, 25, 13, 52, 24, 459, DateTimeKind.Local).AddTicks(3101), "Sleek Granite Soap", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 29, 21, 38, DateTimeKind.Local).AddTicks(7309), "Sleek Frozen Hat", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Category", "CreatedDate", "Description" },
                values: new object[] { "Computers", new DateTime(2022, 7, 24, 21, 51, 46, 38, DateTimeKind.Local).AddTicks(6966), "Refined Cotton Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Grocery", new DateTime(2022, 7, 24, 19, 27, 24, 108, DateTimeKind.Local).AddTicks(2948), "Ergonomic Granite Tuna", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 3, 24, 37, 481, DateTimeKind.Local).AddTicks(3208), "Unbranded Frozen Fish", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Kids", new DateTime(2022, 7, 25, 4, 59, 16, 678, DateTimeKind.Local).AddTicks(4911), "Handmade Metal Sausages", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { new DateTime(2022, 7, 25, 7, 44, 55, 266, DateTimeKind.Local).AddTicks(3262), "Gorgeous Steel Towels", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Home", new DateTime(2022, 7, 25, 8, 42, 21, 120, DateTimeKind.Local).AddTicks(168), "Handmade Metal Salad", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Clothing", new DateTime(2022, 7, 25, 12, 46, 45, 683, DateTimeKind.Local).AddTicks(9016), "Generic Metal Chicken", 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Jewelery", new DateTime(2022, 7, 25, 4, 38, 4, 76, DateTimeKind.Local).AddTicks(3060), "Rustic Granite Sausages", 57m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Electronics", new DateTime(2022, 7, 24, 23, 45, 23, 602, DateTimeKind.Local).AddTicks(7476), "Generic Rubber Chicken", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 14, 9, 35, 817, DateTimeKind.Local).AddTicks(2310), "Refined Metal Pizza", 51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Computers", new DateTime(2022, 7, 25, 6, 26, 14, 170, DateTimeKind.Local).AddTicks(4808), "Incredible Soft Shoes", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Category", "CreatedDate", "Description", "UnitPrice" },
                values: new object[] { "Baby", new DateTime(2022, 7, 25, 1, 40, 21, 129, DateTimeKind.Local).AddTicks(3406), "Handcrafted Rubber Sausages", 54m });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDetailsId",
                table: "Orders",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderDetails_OrderDetailsId",
                table: "Orders",
                column: "OrderDetailsId",
                principalTable: "OrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
