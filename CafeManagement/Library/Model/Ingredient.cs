using System;
using System.Collections.Generic;

#nullable disable

namespace Library.Model
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            IngredientProducts = new HashSet<IngredientProduct>();
            Storages = new HashSet<Storage>();
        }

        public int IngredientId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int Status { get; set; }

        public virtual ICollection<IngredientProduct> IngredientProducts { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
