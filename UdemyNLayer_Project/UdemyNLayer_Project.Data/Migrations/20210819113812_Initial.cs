using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemyNLayer_Project.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TCNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Course_Hour = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Course_ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Web Geliştirme" },
                    { 2, "Mobil Yazılım Geliştirme" },
                    { 3, "Programlama Dilleri" },
                    { 4, "Oyun Geliştirme" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "About", "Degree", "ImageUrl", "Mail", "Name", "Password", "Surname", "TCNo", "Telephone" },
                values: new object[,]
                {
                    { 1, "2008 yılından itibaren yazılım teknolojileriyle ilgilenmekteyim. Ağırlıklı olarak .Net teknolojileri üzerine projeler geliştiriyorum. Özel ve Kamu kurumlarına  yazılım eğitimleri  vermekteyim. İkinci üniversite olarak Yönetim Bilişim Sistemleri mezunuyum. Yazılım teknolojileri ilgili her konuyu merak ediyor ve  bilgi sahibi olmaya çalışıyorum. Sıkı bir medium okuyucusuyum. Daha çok üzerinde durduğum teknolojiler; Asp Net Core,Web Api, Azure, Angular,Native Android,Docker, DevOps ... Boş zamanlarımda native android uygulamalar üzerine geliştirmeler yapıyorum. 2017 yılından itibaren Ankarada yaşamaktayım.", ".Net Developer | Full Stack Developer", null, "fatih@gmail.com", "Fatih", "123456", "Çakıroğlu", "12345678910", "05424381234" },
                    { 2, "Yazılım Mühendisliği mezunuyum. Udemy'de 14 farklı kursta 60 binden fazla öğrenci (Udemy 1'den fazla kursa kayıtlı öğrencileri tek öğrenci olarak sayıyor) ile 4.72 eğitmen puan ortalaması ile oldukça güzel geri dönüşler alarak eğitim alanında çalışmalarımı sürdürmekteyim.  Profesyonel olarak yazılım alanında projeler yürütmenin yanında aynı zamanda bu alanda eğitmenlik de yapmaktayım. İstanbul'da bulunan ofisimde eğitimler ve proje çalışmalarını bir arada yürüyorum. Üniversite sürecimde İstanbul TeknoPark, Yıldız TeknoPark ve Elazığ TeknoPark'larda bulunan birçok farklı şirkette, alanında lider kıdemli yazılımcılarla beraber projelerde farklı roller üstlenme şansına eriştim.", "Yazılım Mühendisi ve Eğitmen", null, "murat@gmail.com", "Murat", "123456", "Yücedağ", "12345678911", "05424381235" },
                    { 3, "Kurslarıma ilgi gösterek beni 2017'de Udemy'nin En İyi 3 Eğitmeni arasına sokan değerli öğrencilerime teşekkürler. Anadolu Üniversitesi - Yönetim Bilişim Sistemleri lisans derecemi tamamlamakla birlikte çeşitli kamu kuruluşlarında edindiğim  11 yıla yakın tecrübenin ardından şu an Bilgi İşlem Yöneticisi olarak profesyonel hayatıma devam etmekteyim.  Ek olarak freelancer ve olarak Web Programlama üzerine aktif olarak çalışarak projeler geliştiriyorum. Son yıllarda çeşitli platformlar üzerinde 400 'den fazla konu üzerine yayınladığım eğitim videoları 2.000.000'u aşan izlenme almış bulunmakta. 2017 itibariyle Udemy'de, kapsayıcı müfredata sahip çeşitli konular üzerine yeni eğitimler üretmeye karar vermiş bulunmaktayım. ", "Web Geliştirici ve Eğitmen", null, "emrah@gmail.com", "Emrah", "123456", "Yüksel", "12345678912", "05424381236" },
                    { 4, "Yazılım Danışmanı, Yazılım Mimarı, MCP ve Eğitmen olarak İstanbul, Türkiye'de yaşıyorum. Bilim ve teknolojiye bayılırım. Sektörde çeşitli bilişim firmalarında kıdemli yazılım geliştirici, yazılım mimarı, proje danışmanı ve teknoloji yöneticisi olarak görev yaptım ve yapmaktayım. Kahve kokusu olmadan yapamayan birisiyimdir. Hayatı zevkli yaşamayı sever, sürekli öğrenmeyi ve öğrendiklerimi paylaşmayı hayatıma anlam katan özelliklerim olarak görürüm. ", "Software Consultant, Software Architect, MCP & Instructor", null, "muratBaseren@gmail.com", "Murat ", "123456", "Baseren", "12345678912", "05424381236" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Mail", "Name", "Password", "Surname", "Telephone" },
                values: new object[,]
                {
                    { 1, "beytullah@gmail.com", "Beytullah", "123456", "Tiryaki", "05434382577" },
                    { 2, "burak@gmail.com", "Burak", "123456", "Tiryaki", "05434382557" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Course_Hour", "Course_ImageUrl", "Description", "InstructorId", "Name", "Price", "StudentsId" },
                values: new object[,]
                {
                    { 2, 1, 45.5m, null, "ASPNET MVC, Bootstrap, Entity Framework CodeFirst, JQuery(ajax) Kullanarak Visual Studio ile Web Projeleri Geliştirin", 4, "ASP .NET MVC Yazılımcıların Yükselişi", 41.99m, null },
                    { 4, 1, 13.5m, null, "BOOTSTRAP en son sürümünü öğrenerek Facebook, Onedio, 140Journos gibi BOOTSTRAP 4 premium tasarımlar yapıyoruz.", 3, "Bootstrap 4 ile Sıfırdan Harika Web Projeleri Oluşturun", 41.99m, null },
                    { 1, 3, 9.5m, null, "Uygulamalı Proje Üzerinde OOP (Object Oriented Programming) Kavramlarını Modüler Bir Müfredatla Öğrenin!", 2, "C# İLE OOP TEMELLERİ: ADIM ADIM KATMANLI MİMARİ", 33.99m, null },
                    { 3, 3, 9.5m, null, "Katmanlı mimari yapısı ile token bazlı kimlik doğrulama/yetkilendirme yapısını inşa etmeyi öğreneceksiniz.", 1, "Asp.Net Core API ( 5.0 ) + Token bazlı kimlik doğrulama(JWT)", 29.99m, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CourseId", "OrderTime", "StudentId" },
                values: new object[] { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CourseId", "OrderTime", "StudentId" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CourseId", "OrderTime", "StudentId" },
                values: new object[] { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentsId",
                table: "Courses",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CourseId",
                table: "Orders",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StudentId",
                table: "Orders",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
