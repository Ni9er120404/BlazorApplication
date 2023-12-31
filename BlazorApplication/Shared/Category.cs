﻿namespace BlazorApplication.Shared
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Url { get; set; } = null!;

        public string Icon { get; set; } = null!;
    }
}