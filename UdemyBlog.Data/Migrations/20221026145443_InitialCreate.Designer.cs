﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyBlog.Data.Concrete.EntityFramework.Contexts;

#nullable disable

namespace UdemyBlog.Data.Migrations
{
    [DbContext(typeof(UdemyBlogContext))]
    [Migration("20221026145443_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9126),
                            Date = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9124),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9127),
                            Note = "C# 9.0 ve NET 5 Yenilikleri",
                            SeoAuthor = "Ferhat Kaplan",
                            SeoDescription = "C# 9.0 ve NET 5 Yenilikleri",
                            SeoTags = "C# , C# 9 , .NET , .NET Framework , .NET Core",
                            Thumbnail = "Default.jpg",
                            Title = "C# 9.0 ve .NET 5 Yenilikleri",
                            UserId = 1,
                            ViewCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9133),
                            Date = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9132),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9134),
                            Note = "C++ 11 ve 19 Yenilikleri",
                            SeoAuthor = "Ferhat Kaplan",
                            SeoDescription = "C++ 11 ve 19 Yenilikleri",
                            SeoTags = "C++ , C++ 11 , C++ 19",
                            Thumbnail = "Default.jpg",
                            Title = "C++ 11 ve 19 Yenilikleri",
                            UserId = 1,
                            ViewCount = 295
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9138),
                            Date = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9137),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 830, DateTimeKind.Local).AddTicks(9139),
                            Note = "JavaScript ES2019 ve ES2020 Yenilikleri",
                            SeoAuthor = "Ferhat Kaplan",
                            SeoDescription = "JavaScript ES2019 ve ES2020 Yenilikleri",
                            SeoTags = "JavaScript , Java , JavaScript ES2019 , JavaScript ES2020 ",
                            Thumbnail = "Default.jpg",
                            Title = "JavaScript ES2019 ve ES2020 Yenilikleri",
                            UserId = 1,
                            ViewCount = 12
                        });
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(593),
                            Description = "C# Programlama Dili İle İlgili En Güncel Bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(594),
                            Name = "C#",
                            Note = "C# Blog Kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(597),
                            Description = "C++ Programlama Dili İle İlgili En Güncel Bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(598),
                            Name = "C++",
                            Note = "C++ Blog Kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(601),
                            Description = "JavaScript Programlama Dili İle İlgili En Güncel Bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(602),
                            Name = "JavaScript",
                            Note = "JavaScript Blog Kategorisi"
                        });
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(3083),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(3084),
                            Note = "C# Makale yorumu",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(3087),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(3088),
                            Note = "C++ Makale yorumu",
                            Text = "1500'lerden beri kullanılmakta olan standard Lorem Ipsum metinleri ilgilenenler için yeniden üretilmiştir. Çiçero tarafından yazılan 1.10.32 ve 1.10.33 bölümleri de 1914 H. Rackham çevirisinden alınan İngilizce sürümleri eşliğinde özgün biçiminden yeniden üretilmiştir."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(3092),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(3093),
                            Note = "JavaScript Makale yorumu",
                            Text = "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır."
                        });
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(4357),
                            Description = "Admin Rolü, Tüm Haklara Sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "ınitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(4358),
                            Name = "Admin",
                            Note = "Admin Rolüdür."
                        });
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(8181),
                            Description = "İlk Admin Kullanıcısı",
                            Email = "admin@gmail.com",
                            FirstName = "Ferhat",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Kaplan",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 10, 26, 17, 54, 42, 831, DateTimeKind.Local).AddTicks(8182),
                            Note = "Admin Kullanıcısı",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = "Default.jpg",
                            RoleId = 1,
                            UserName = "ferhatkaplan"
                        });
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Article", b =>
                {
                    b.HasOne("UdemyBlog.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyBlog.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("UdemyBlog.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.User", b =>
                {
                    b.HasOne("UdemyBlog.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("UdemyBlog.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
