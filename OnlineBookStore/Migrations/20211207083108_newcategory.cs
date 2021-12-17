using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class newcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageUrl",
                value: ".\\Images\\tj1.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageUrl",
                value: ".\\Images\\a-tale-of-two-cities.jpg");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 4, "Stories", null },
                    { 5, "Biography & Autobiography", null },
                    { 6, "Fiction", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorName", "CategoryId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 5, "Sudha Murty", 4, ".\\images\\here,there&everywhere.jpeg", true, "Sudha Murty has many titles to her credit. She’s a philanthropist, an entrepreneur, a computer scientist, an engineer, a teacher, and a storyteller. Her literary works span adult non-fiction, adult fiction, children’s books, travelogues, and technical books. Here, There, and Everywhere is a celebration of her journey in the literary world. It brings together her best-loved stories from various collections. A thoughtful introduction and some new works make this book a multi-faceted read in every sense of the word.", "Here,There and Everywhere", 350m, "Lorem Ipsum" },
                    { 6, "Helen Keller", 5, ".\\images\\thestoryofmylife.jpeg", true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "The Story of my Life", 500m, "Lorem Ipsum" },
                    { 7, "Anne Frank", 5, ".\\images\\thediaryofayounggirl.jpeg", true, "In July 1942 Anne Frank and her family,fleeing the horrors of Nazi occupation hid in the back of an Amsterdam warehouse.Anne was thirteen when the family went into the Secret Annexe and,over the next two years,she vividly describes in her diary the frustrations of living is such confined quarters,the constant threat of discovery,the hunger and fear.Her diary ends abruptly when, in August 1944,she and her family were finally discovered by the Nazis.Anne Frank died in March 1945, aged fifteen, in Bergen - Belsen concentration camp in Germany.This book provides a deeply moving and unforgettable portrait of Anne Frank – an ordinary and yet an extraordinary teenage girl.", "The Diary of a Young Girl", 800m, "THE DIARY OF A YOUNG GIRL remains the single most poignant true - life story to emerge from the Second World War." },
                    { 10, "Sudha Murty", 5, ".\\images\\three-thousand-stitches.jpeg", true, "The first story deals with Sudha Murthy’s desire to eradicate the Devadasi system which she tried hard. How she deals with it forms the crux of this story number one. The second story is about her experience as the only female student in her engineering college and how she managed to tackle the situation. In this way, every story is taken from various incidents that happened in her life. It is an inspiring read for the readers of all age groups with the narration in the simplest English and can make you want to finish the book in one or two sittings.", "Three Thousand Stitches:Ordinary People, Extraordinary Lives", 350m, "Eleven different extraordinary tales that are inspired by Sudha Murthy’s life. " },
                    { 11, "Mahatma Gandhi", 5, ".\\images\\the-story-of-my-experiments-with-truth.jpeg", true, "He came like a tidal wave, with the promise of a calm breeze. He spoke of peace, and he promised total non-cooperation. A frail old man, clad in hand-woven khadi, the British didn’t take him seriously. After all, what could one fakir do against the British Empire? In retrospect, the dramatic awe the situation inspires is too good to be true. Mohandas Karamchand Gandhi was born into a simple family. He studied to be a lawyer, was married young and loved his wife immensely. He began to realize the follies of being too beleaguered by sexual needs, and he gave up non-vegetarianism, trying meat only once. He went to London, where he studied law and hoped to be a lawyer. He journeyed to South Africa to practice, and there, outside his home, he discovered the true face of the British reign. He began to see how the coloured races were treated, and he began to fight against the regime. He returned to India, fuelled by one desire: independence. He battled the powerful British Empire with peace, nonviolence and total non-cooperation. His message of peace began to spread through the Indian people like a brushfire, and he led them in their fight for freedom. His teachings, principles and philosophy inspired them, and in return, they gave him a new name, one history would never forget: the name of Mahatma Gandhi. This is his autobiography, one of the most widely read and most detailed accounts of his life ever written.", "The Story of My Experiments with Truth ", 900m, "Autobiography of Mahatma Gandhi. " },
                    { 8, "Sudha Murty", 6, ".\\images\\the-mother-i-never-knew.jpeg", true, "In July 1942 Anne Frank and her family,fleeing the horrors of Nazi occupation hid in the back of an Amsterdam warehouse.Anne was thirteen when the family went into the Secret Annexe and,over the next two years,she vividly describes in her diary the frustrations of living is such confined quarters,the constant threat of discovery,the hunger and fear.Her diary ends abruptly when, in August 1944,she and her family were finally discovered by the Nazis.Anne Frank died in March 1945, aged fifteen, in Bergen - Belsen concentration camp in Germany.This book provides a deeply moving and unforgettable portrait of Anne Frank – an ordinary and yet an extraordinary teenage girl.", "The Mother I Never Knew", 600m, "THE DIARY OF A YOUNG GIRL remains the single most poignant true - life story to emerge from the Second World War." },
                    { 9, "Jules Verne", 6, ".\\images\\around-the-world-in-eighty-days.jpeg", true, "One ill-fated evening at the Reform Club, Phileas Fogg rashly bets his companions 20,000 pounds that he can travel around the entire globe in just eighty days – and he is determined not to lose. Breaking the well-established routine of his daily life, the reserved Englishman immediately sets off for Dover, accompanied by his hot-blooded French manservant Passepartout. Travelling by train, steamship, sailing boat, sledge and even elephant, they must overcome storms, kidnappings, natural disasters, Sioux attacks and the dogged Inspector Fix of Scotland Yard – who believes that Fogg has robbed the Bank of England – to win the extraordinary wager. Around the World in Eighty Days gripped audiences on its publication and remains hugely popular, combining exploration, adventure and a thrilling race against time.", "Around The World In Eighty Days", 250m, " " },
                    { 12, "Austen Jane", 6, ".\\images\\pride-prejudice.jpeg", true, "Jane Austen’s ‘Pride and Prejudice’ represents the conflict between marrying for love and marrying for economic reasons in the 18th century Georgian England. Mrs Bennet, who is desperate to see her five young daughters get married, makes efforts to arrange a meeting with Mr Bingley, a rich young man who also happens to be their new neighbour. Elizabeth Bennet, the second of the Bennet daughters, struggles with the pressures of the society and also rejects Mr Darcy’s advances and proposals. Buy Pride and Prejudice online and find out how the conflicts are resolved.", "Pride & Prejudice", 800m, "Story of conflict between marrying for love and marrying for economic reasons." },
                    { 13, "H.G.Wells", 6, ".\\images\\the-time-machine.jpeg", true, "A compelling science fiction, the Time Machine is a first-hand account of a Time Traveler's journey into the future. a pull of the lever and the machine sends him to the year 802,701, when humanity has split into two bizarre races—the ethereal Eloi and the subterranean Morlocks. Here, his machine is stolen and with the help of Weena, an Eloi he saved from drowning, the traveler is able to retrieve it. Whizzing thirty million years further into the future, he finds a slowly dying earth, where the bloated red sun sits motionless in the sky and the only sign of life is a black blob with tentacles. He returns to the Victorian time, overwhelmed, just three hours after he originally left. Credited with inventing the time machine in this masterpiece, the provocative insight of H. G. Wells continues to enthrall the readers. the Time Machine has since been adapted into many feature films and television series and has inspired many more works of fiction.", "The Time Machine", 300m, "A compelling science fiction" },
                    { 14, "Charles Dickens", 6, ".\\images\\great-expectations.jpeg", true, " The protagonist of the book is Philip Pirrip, who is known by his nickname Pip. In the very beginning, he is introduced by Dickens as a young boy who lives with his sister and her husband because he was orphaned at a very young age. He is scared by a convict who asks him to steal food and a file to grind his iron shackles, while he is sitting in a cemetery looking at his parents tombstones. Out of great fear, Pip obeys his instructions, but the convict is captured before long.One day,Pip’s Uncle Pumblechook takes him to Miss Havisham’s house,where he encounters Estella.She’s the most beautiful girl Pip has ever seen and he falls in love with her instantly.But to his disappointment,Estella doesn’t treat him well,and thereon,he begins to dream of becoming a rich gentleman so that he can receive her love,respect,and attention.In a twist of fate,Pip does become wealthy,but is faced with harsh realities that change the way he sees life and love in general.The book takes readers through the life of Pip,and whether he finally manages to marry his childhood sweetheart.", "Great Expectations", 400m, "The story of young Pip and his journey through the various stages of life" },
                    { 15, "Lewis Carroll", 6, ".\\images\\alice-s-adventures-in-wonderland.jpeg", true, "When Alice is resting on the riverbank with her elder sister, she feels bored, because just sitting around isn’t any fun. She spots a curious talking White Rabbit sporting a fine coat, and a pocket watch, mumbling to himself that he’s late. Surprised, she follows the Rabbit into a rabbit hole, and falls into a strange hall with many locked doors. She realizes that she’s in some strange land where the rules don’t make sense. She is right, for she is in Wonderland, and here she may find that being bored isn’t an option. Join Alice, the Mad Hatter, the White Rabbit, the March Hare, and the Queen of Hearts in an adventure which will risk Alice’s life, her stature and definitely her curiosity in this eternal tale by Lewis Carroll.", "Alice's Adventures in Wonderland ", 150m, "When a little girl follows a strange White Rabbit into the Rabbit Hole, she discovers that she is no longer in ordinary world." },
                    { 16, "Charles Dickens", 6, ".\\images\\a-christmas-carol.jpeg", true, "Charles Dickens, A Christmas Carol A Christmas Carol (1843) by Charles Dickens recounts the story of Ebenezer Scrooge, an elderly miser who refuses donations to people on the occasion of Christmas. The story takes an interesting turn when Scrooge is visited by the ghost of his former business partner Jacob Marley and the spirits of Christmas Past, Present and Yet to Come who teach him a great deal of lessons. As the story unfolds, it will take you along on an enthralling and enlightening journey of Scrooge’s transformation into a kinder, gentler man.", "A Christmas Carol", 400m, "The transformation of an elderly miser into a kinder, gentler man." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageUrl",
                value: ".\\Images	j1.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageUrl",
                value: ".\\Images-tale-of-two-cities.jpg");
        }
    }
}
