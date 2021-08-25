using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayer_Project.Core;

namespace UdemyNLayer_Project.Data.Seeds
{
    public class InstructorSeed : IEntityTypeConfiguration<Instructor>
    {
        private readonly int[] _instructorId;
        public InstructorSeed(int[] instructorId)
        {
            this._instructorId = instructorId;
        }
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasData(new Instructor { Id = _instructorId[0], Name = "Fatih", Surname = "Çakıroğlu", TCNo = "12345678910", Telephone = "05424381234", About = "2008 yılından itibaren yazılım teknolojileriyle ilgilenmekteyim. Ağırlıklı olarak .Net teknolojileri üzerine projeler geliştiriyorum. Özel ve Kamu kurumlarına  yazılım eğitimleri  vermekteyim. İkinci üniversite olarak Yönetim Bilişim Sistemleri mezunuyum. Yazılım teknolojileri ilgili her konuyu merak ediyor ve  bilgi sahibi olmaya çalışıyorum. Sıkı bir medium okuyucusuyum. Daha çok üzerinde durduğum teknolojiler; Asp Net Core,Web Api, Azure, Angular,Native Android,Docker, DevOps ... Boş zamanlarımda native android uygulamalar üzerine geliştirmeler yapıyorum. 2017 yılından itibaren Ankarada yaşamaktayım.", Degree = ".Net Developer | Full Stack Developer", Mail = "fatih@gmail.com", Password = "123456" },
                new Instructor { Id = _instructorId[1], Name = "Murat", Surname = "Yücedağ", TCNo = "12345678911", Telephone = "05424381235", About = "Yazılım Mühendisliği mezunuyum. Udemy'de 14 farklı kursta 60 binden fazla öğrenci (Udemy 1'den fazla kursa kayıtlı öğrencileri tek öğrenci olarak sayıyor) ile 4.72 eğitmen puan ortalaması ile oldukça güzel geri dönüşler alarak eğitim alanında çalışmalarımı sürdürmekteyim.  Profesyonel olarak yazılım alanında projeler yürütmenin yanında aynı zamanda bu alanda eğitmenlik de yapmaktayım. İstanbul'da bulunan ofisimde eğitimler ve proje çalışmalarını bir arada yürüyorum. Üniversite sürecimde İstanbul TeknoPark, Yıldız TeknoPark ve Elazığ TeknoPark'larda bulunan birçok farklı şirkette, alanında lider kıdemli yazılımcılarla beraber projelerde farklı roller üstlenme şansına eriştim.", Degree = "Yazılım Mühendisi ve Eğitmen", Mail = "murat@gmail.com", Password = "123456" },
                new Instructor { Id = _instructorId[2], Name = "Emrah", Surname = "Yüksel", TCNo = "12345678912", Telephone = "05424381236", About = "Kurslarıma ilgi gösterek beni 2017'de Udemy'nin En İyi 3 Eğitmeni arasına sokan değerli öğrencilerime teşekkürler. Anadolu Üniversitesi - Yönetim Bilişim Sistemleri lisans derecemi tamamlamakla birlikte çeşitli kamu kuruluşlarında edindiğim  11 yıla yakın tecrübenin ardından şu an Bilgi İşlem Yöneticisi olarak profesyonel hayatıma devam etmekteyim.  Ek olarak freelancer ve olarak Web Programlama üzerine aktif olarak çalışarak projeler geliştiriyorum. Son yıllarda çeşitli platformlar üzerinde 400 'den fazla konu üzerine yayınladığım eğitim videoları 2.000.000'u aşan izlenme almış bulunmakta. 2017 itibariyle Udemy'de, kapsayıcı müfredata sahip çeşitli konular üzerine yeni eğitimler üretmeye karar vermiş bulunmaktayım. ", Degree = "Web Geliştirici ve Eğitmen", Mail = "emrah@gmail.com", Password = "123456" },
                new Instructor { Id = _instructorId[3], Name = "Murat ", Surname = "Baseren", TCNo = "12345678912", Telephone = "05424381236", About = "Yazılım Danışmanı, Yazılım Mimarı, MCP ve Eğitmen olarak İstanbul, Türkiye'de yaşıyorum. Bilim ve teknolojiye bayılırım. Sektörde çeşitli bilişim firmalarında kıdemli yazılım geliştirici, yazılım mimarı, proje danışmanı ve teknoloji yöneticisi olarak görev yaptım ve yapmaktayım. Kahve kokusu olmadan yapamayan birisiyimdir. Hayatı zevkli yaşamayı sever, sürekli öğrenmeyi ve öğrendiklerimi paylaşmayı hayatıma anlam katan özelliklerim olarak görürüm. ", Degree = "Software Consultant, Software Architect, MCP & Instructor", Mail = "muratBaseren@gmail.com", Password = "123456" });
        }
    }
}
