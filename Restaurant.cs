// Created by Derek Kennard
// Solution: OdeToFood
// Project Name: OdeToFood.Core
// File Name: Restaurant.cs
// Created on: 05/25/2021 at 12:27 AM
// Edited on: 05/25/2021 at 12:30 AM
// Developed and Copyrighted by Derek "Doctork" Kennard

namespace OdeToFood.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}