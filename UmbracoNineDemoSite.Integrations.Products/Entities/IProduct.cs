﻿namespace UmbracoNineDemoSite.Integrations.Products.Entities
{
    public interface IProduct
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        string ImageUrl { get; }
        int Price { get; }
    }
}
