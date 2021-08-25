using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Data.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _categoryId;
        public CategorySeed(int[] categoryId)
        {
            this._categoryId = categoryId;
        }
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category { Id = _categoryId[0], Name = "Web Geliştirme" },
                new Category { Id = _categoryId[1], Name = "Mobil Yazılım Geliştirme" },
                new Category { Id = _categoryId[2], Name = "Programlama Dilleri" },
                new Category { Id = _categoryId[3], Name = "Oyun Geliştirme" });
        }
    }
}
