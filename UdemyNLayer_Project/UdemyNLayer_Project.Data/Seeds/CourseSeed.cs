using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayer_Project.Core.Models;

namespace UdemyNLayer_Project.Data.Seeds
{
    public class CourseSeed : IEntityTypeConfiguration<Course>
    {
        private readonly int[] _instructorId;
        private readonly int[] _categoryId;
        public CourseSeed(int[] instructorId, int[] categoryId)
        {
            this._instructorId = instructorId;
            this._categoryId = categoryId;
        }
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(new Course { Id = 1, Name = "C# İLE OOP TEMELLERİ: ADIM ADIM KATMANLI MİMARİ", Description = "Uygulamalı Proje Üzerinde OOP (Object Oriented Programming) Kavramlarını Modüler Bir Müfredatla Öğrenin!", Price = 33.99m, Course_Hour = 9.5m, InstructorId = _instructorId[1], CategoryId = _categoryId[2] },
                new Course { Id = 2, Name = "ASP .NET MVC Yazılımcıların Yükselişi", Description = "ASPNET MVC, Bootstrap, Entity Framework CodeFirst, JQuery(ajax) Kullanarak Visual Studio ile Web Projeleri Geliştirin", Price = 41.99m, Course_Hour = 45.5m, InstructorId = _instructorId[3], CategoryId = _categoryId[0] },
                new Course { Id = 3, Name = "Asp.Net Core API ( 5.0 ) + Token bazlı kimlik doğrulama(JWT)", Description = "Katmanlı mimari yapısı ile token bazlı kimlik doğrulama/yetkilendirme yapısını inşa etmeyi öğreneceksiniz.", Price = 29.99m, Course_Hour = 9.5m, InstructorId = _instructorId[0], CategoryId = _categoryId[2] },
                new Course { Id = 4, Name = "Bootstrap 4 ile Sıfırdan Harika Web Projeleri Oluşturun", Description = "BOOTSTRAP en son sürümünü öğrenerek Facebook, Onedio, 140Journos gibi BOOTSTRAP 4 premium tasarımlar yapıyoruz.", Price = 41.99m, Course_Hour = 13.5m, InstructorId = _instructorId[2], CategoryId = _categoryId[0] });
        }
    }
}
