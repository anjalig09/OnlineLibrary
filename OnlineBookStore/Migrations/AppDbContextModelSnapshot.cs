﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBookStore.Models;

namespace OnlineBookStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorName = "Joseph barbera",
                            CategoryId = 1,
                            ImageUrl = ".\\Images\\tj1.jpg",
                            InStock = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. ",
                            Name = "Tom and jerry",
                            Price = 400m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorName = "J.K Rowling",
                            CategoryId = 2,
                            ImageUrl = "https://www.wizardingworld.com/_next/image?url=%2Fimages%2Fproducts%2Fbooks%2FUK%2Frectangle-1.jpg&w=1920&q=75",
                            InStock = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                            Name = "Harry Potter",
                            Price = 1000m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorName = "Charles Dickens",
                            CategoryId = 3,
                            ImageUrl = "C:\\Users\\anjali.g\\source\repos\\OnlineLibrary\\OnlineBookStore\\wwwroot\\Images\\a-tale-of-two-cities.jpg",
                            InStock = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                            Name = "A tale of two cities",
                            Price = 250m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorName = "Arundhati Roy",
                            CategoryId = 3,
                            ImageUrl = "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/9/2/1441203713652/0bf35fbc-b649-4290-bf76-f1bdcc631bb6-399x600.jpeg?width=140&quality=85&auto=format&fit=max&s=fdc80d9419c7f6cea190503c556a39be",
                            InStock = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                            Name = "The God of Small Things",
                            Price = 800m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorName = "Sudha Murty",
                            CategoryId = 4,
                            ImageUrl = "~\\images\\here,there&everywhere.jpeg",
                            InStock = true,
                            LongDescription = "Sudha Murty has many titles to her credit. She’s a philanthropist, an entrepreneur, a computer scientist, an engineer, a teacher, and a storyteller. Her literary works span adult non-fiction, adult fiction, children’s books, travelogues, and technical books. Here, There, and Everywhere is a celebration of her journey in the literary world. It brings together her best-loved stories from various collections. A thoughtful introduction and some new works make this book a multi-faceted read in every sense of the word.",
                            Name = "Here,There and Everywhere",
                            Price = 350m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorName = "Helen Keller",
                            CategoryId = 5,
                            ImageUrl = ".\\images\\thestoryofmylife.jpeg",
                            InStock = true,
                            LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                            Name = "The Story of my Life",
                            Price = 500m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            BookId = 7,
                            AuthorName = "Anne Frank",
                            CategoryId = 5,
                            ImageUrl = ".\\images\\thediaryofayounggirl.jpeg",
                            InStock = true,
                            LongDescription = "In July 1942 Anne Frank and her family,fleeing the horrors of Nazi occupation hid in the back of an Amsterdam warehouse.Anne was thirteen when the family went into the Secret Annexe and,over the next two years,she vividly describes in her diary the frustrations of living is such confined quarters,the constant threat of discovery,the hunger and fear.Her diary ends abruptly when, in August 1944,she and her family were finally discovered by the Nazis.Anne Frank died in March 1945, aged fifteen, in Bergen - Belsen concentration camp in Germany.This book provides a deeply moving and unforgettable portrait of Anne Frank – an ordinary and yet an extraordinary teenage girl.",
                            Name = "The Diary of a Young Girl",
                            Price = 800m,
                            ShortDescription = "THE DIARY OF A YOUNG GIRL remains the single most poignant true - life story to emerge from the Second World War."
                        },
                        new
                        {
                            BookId = 8,
                            AuthorName = "Sudha Murty",
                            CategoryId = 6,
                            ImageUrl = ".\\images\\the-mother-i-never-knew.jpeg",
                            InStock = true,
                            LongDescription = "In July 1942 Anne Frank and her family,fleeing the horrors of Nazi occupation hid in the back of an Amsterdam warehouse.Anne was thirteen when the family went into the Secret Annexe and,over the next two years,she vividly describes in her diary the frustrations of living is such confined quarters,the constant threat of discovery,the hunger and fear.Her diary ends abruptly when, in August 1944,she and her family were finally discovered by the Nazis.Anne Frank died in March 1945, aged fifteen, in Bergen - Belsen concentration camp in Germany.This book provides a deeply moving and unforgettable portrait of Anne Frank – an ordinary and yet an extraordinary teenage girl.",
                            Name = "The Mother I Never Knew",
                            Price = 600m,
                            ShortDescription = "THE DIARY OF A YOUNG GIRL remains the single most poignant true - life story to emerge from the Second World War."
                        },
                        new
                        {
                            BookId = 9,
                            AuthorName = "Jules Verne",
                            CategoryId = 6,
                            ImageUrl = ".\\images\\around-the-world-in-eighty-days.jpeg",
                            InStock = true,
                            LongDescription = "One ill-fated evening at the Reform Club, Phileas Fogg rashly bets his companions 20,000 pounds that he can travel around the entire globe in just eighty days – and he is determined not to lose. Breaking the well-established routine of his daily life, the reserved Englishman immediately sets off for Dover, accompanied by his hot-blooded French manservant Passepartout. Travelling by train, steamship, sailing boat, sledge and even elephant, they must overcome storms, kidnappings, natural disasters, Sioux attacks and the dogged Inspector Fix of Scotland Yard – who believes that Fogg has robbed the Bank of England – to win the extraordinary wager. Around the World in Eighty Days gripped audiences on its publication and remains hugely popular, combining exploration, adventure and a thrilling race against time.",
                            Name = "Around The World In Eighty Days",
                            Price = 250m,
                            ShortDescription = " "
                        },
                        new
                        {
                            BookId = 10,
                            AuthorName = "Sudha Murty",
                            CategoryId = 5,
                            ImageUrl = ".\\images\\three-thousand-stitches.jpeg",
                            InStock = true,
                            LongDescription = "The first story deals with Sudha Murthy’s desire to eradicate the Devadasi system which she tried hard. How she deals with it forms the crux of this story number one. The second story is about her experience as the only female student in her engineering college and how she managed to tackle the situation. In this way, every story is taken from various incidents that happened in her life. It is an inspiring read for the readers of all age groups with the narration in the simplest English and can make you want to finish the book in one or two sittings.",
                            Name = "Three Thousand Stitches:Ordinary People, Extraordinary Lives",
                            Price = 350m,
                            ShortDescription = "Eleven different extraordinary tales that are inspired by Sudha Murthy’s life. "
                        },
                        new
                        {
                            BookId = 11,
                            AuthorName = "Mahatma Gandhi",
                            CategoryId = 5,
                            ImageUrl = ".\\images\\the-story-of-my-experiments-with-truth.jpeg",
                            InStock = true,
                            LongDescription = "He came like a tidal wave, with the promise of a calm breeze. He spoke of peace, and he promised total non-cooperation. A frail old man, clad in hand-woven khadi, the British didn’t take him seriously. After all, what could one fakir do against the British Empire? In retrospect, the dramatic awe the situation inspires is too good to be true. Mohandas Karamchand Gandhi was born into a simple family. He studied to be a lawyer, was married young and loved his wife immensely. He began to realize the follies of being too beleaguered by sexual needs, and he gave up non-vegetarianism, trying meat only once. He went to London, where he studied law and hoped to be a lawyer. He journeyed to South Africa to practice, and there, outside his home, he discovered the true face of the British reign. He began to see how the coloured races were treated, and he began to fight against the regime. He returned to India, fuelled by one desire: independence. He battled the powerful British Empire with peace, nonviolence and total non-cooperation. His message of peace began to spread through the Indian people like a brushfire, and he led them in their fight for freedom. His teachings, principles and philosophy inspired them, and in return, they gave him a new name, one history would never forget: the name of Mahatma Gandhi. This is his autobiography, one of the most widely read and most detailed accounts of his life ever written.",
                            Name = "The Story of My Experiments with Truth ",
                            Price = 900m,
                            ShortDescription = "Autobiography of Mahatma Gandhi. "
                        },
                        new
                        {
                            BookId = 12,
                            AuthorName = "Austen Jane",
                            CategoryId = 6,
                            ImageUrl = ".\\images\\pride-prejudice.jpeg",
                            InStock = true,
                            LongDescription = "Jane Austen’s ‘Pride and Prejudice’ represents the conflict between marrying for love and marrying for economic reasons in the 18th century Georgian England. Mrs Bennet, who is desperate to see her five young daughters get married, makes efforts to arrange a meeting with Mr Bingley, a rich young man who also happens to be their new neighbour. Elizabeth Bennet, the second of the Bennet daughters, struggles with the pressures of the society and also rejects Mr Darcy’s advances and proposals. Buy Pride and Prejudice online and find out how the conflicts are resolved.",
                            Name = "Pride & Prejudice",
                            Price = 800m,
                            ShortDescription = "Story of conflict between marrying for love and marrying for economic reasons."
                        },
                        new
                        {
                            BookId = 13,
                            AuthorName = "H.G.Wells",
                            CategoryId = 6,
                            ImageUrl = ".\\images\\the-time-machine.jpeg",
                            InStock = true,
                            LongDescription = "A compelling science fiction, the Time Machine is a first-hand account of a Time Traveler's journey into the future. a pull of the lever and the machine sends him to the year 802,701, when humanity has split into two bizarre races—the ethereal Eloi and the subterranean Morlocks. Here, his machine is stolen and with the help of Weena, an Eloi he saved from drowning, the traveler is able to retrieve it. Whizzing thirty million years further into the future, he finds a slowly dying earth, where the bloated red sun sits motionless in the sky and the only sign of life is a black blob with tentacles. He returns to the Victorian time, overwhelmed, just three hours after he originally left. Credited with inventing the time machine in this masterpiece, the provocative insight of H. G. Wells continues to enthrall the readers. the Time Machine has since been adapted into many feature films and television series and has inspired many more works of fiction.",
                            Name = "The Time Machine",
                            Price = 300m,
                            ShortDescription = "A compelling science fiction"
                        },
                        new
                        {
                            BookId = 14,
                            AuthorName = "Charles Dickens",
                            CategoryId = 6,
                            ImageUrl = ".\\images\\great-expectations.jpeg",
                            InStock = true,
                            LongDescription = " The protagonist of the book is Philip Pirrip, who is known by his nickname Pip. In the very beginning, he is introduced by Dickens as a young boy who lives with his sister and her husband because he was orphaned at a very young age. He is scared by a convict who asks him to steal food and a file to grind his iron shackles, while he is sitting in a cemetery looking at his parents tombstones. Out of great fear, Pip obeys his instructions, but the convict is captured before long.One day,Pip’s Uncle Pumblechook takes him to Miss Havisham’s house,where he encounters Estella.She’s the most beautiful girl Pip has ever seen and he falls in love with her instantly.But to his disappointment,Estella doesn’t treat him well,and thereon,he begins to dream of becoming a rich gentleman so that he can receive her love,respect,and attention.In a twist of fate,Pip does become wealthy,but is faced with harsh realities that change the way he sees life and love in general.The book takes readers through the life of Pip,and whether he finally manages to marry his childhood sweetheart.",
                            Name = "Great Expectations",
                            Price = 400m,
                            ShortDescription = "The story of young Pip and his journey through the various stages of life"
                        },
                        new
                        {
                            BookId = 15,
                            AuthorName = "Lewis Carroll",
                            CategoryId = 6,
                            ImageUrl = ".\\images\\alice-s-adventures-in-wonderland.jpeg",
                            InStock = true,
                            LongDescription = "When Alice is resting on the riverbank with her elder sister, she feels bored, because just sitting around isn’t any fun. She spots a curious talking White Rabbit sporting a fine coat, and a pocket watch, mumbling to himself that he’s late. Surprised, she follows the Rabbit into a rabbit hole, and falls into a strange hall with many locked doors. She realizes that she’s in some strange land where the rules don’t make sense. She is right, for she is in Wonderland, and here she may find that being bored isn’t an option. Join Alice, the Mad Hatter, the White Rabbit, the March Hare, and the Queen of Hearts in an adventure which will risk Alice’s life, her stature and definitely her curiosity in this eternal tale by Lewis Carroll.",
                            Name = "Alice's Adventures in Wonderland ",
                            Price = 150m,
                            ShortDescription = "When a little girl follows a strange White Rabbit into the Rabbit Hole, she discovers that she is no longer in ordinary world."
                        },
                        new
                        {
                            BookId = 16,
                            AuthorName = "Charles Dickens",
                            CategoryId = 6,
                            ImageUrl = ".\\images\\a-christmas-carol.jpeg",
                            InStock = true,
                            LongDescription = "Charles Dickens, A Christmas Carol A Christmas Carol (1843) by Charles Dickens recounts the story of Ebenezer Scrooge, an elderly miser who refuses donations to people on the occasion of Christmas. The story takes an interesting turn when Scrooge is visited by the ghost of his former business partner Jacob Marley and the spirits of Christmas Past, Present and Yet to Come who teach him a great deal of lessons. As the story unfolds, it will take you along on an enthralling and enlightening journey of Scrooge’s transformation into a kinder, gentler man.",
                            Name = "A Christmas Carol",
                            Price = 400m,
                            ShortDescription = "The transformation of an elderly miser into a kinder, gentler man."
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnlineBookStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Cartoon"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Novel"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Stories"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Biography & Autobiography"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Fiction"
                        });
                });

            modelBuilder.Entity("OnlineBookStore.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("State")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineBookStore.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("OnlineBookStore.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("BookId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Book", b =>
                {
                    b.HasOne("OnlineBookStore.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineBookStore.Models.OrderDetail", b =>
                {
                    b.HasOne("Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBookStore.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("OnlineBookStore.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("OnlineBookStore.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("OnlineBookStore.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
