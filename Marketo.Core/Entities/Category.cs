﻿namespace Marketo.Core.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Furniture> Furnitures { get; set; }

        
    }
}
