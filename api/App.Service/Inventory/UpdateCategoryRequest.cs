namespace App.Service.Inventory
{
    using System;
    using App.Common.Validation.Attribute;

    public class UpdateCategoryRequest
    {
        public Guid Id { get; set; }
        [Required("inventory.addOrUpdateCategory.validation.nameRequired")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}