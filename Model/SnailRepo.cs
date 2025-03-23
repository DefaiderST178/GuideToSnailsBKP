namespace GuideToSnailsBKP.Model
{
    public class SnailRepo
    {
        public static List<Snail> AllSnails => new List<Snail>
        {
            //1
            new Snail
            {
                Name = "Ампулярия",
                ScientificName = "Pomacea bridgesii",
                Description = "Самая распространенная аквариумная улитка. Отличительная особенность этого моллюска – крупный размер и яркий окрас раковины – обычно насыщенно желтый. Ампулярия обладает как жаберным, так и легочным дыханием, поэтому ей необходимо регулярно всплывать на поверхность, чтобы вдохнуть порцию атмосферного воздуха.",
                Images = new List<string>
                {
                    "ampuliry1.jpg",
                    "ampuliry2.jpg",
                    "ampuliry3.jpg"
                },

                AverageShellSize ="30-50 мм",
                ShellColor = "светло-коричневого цвета с более тёмными полосками",
                BodyColor = "белый, синий, фиолетовый",
                LifespanInYears = "2-4 года"
            },
            //2
            new Snail
            {
                Name = "Мелания (песчаная)",
                ScientificName = "Melanoides tuberculata",
                Description = "Эти брюхоногие моллюски обитают в илистых и песчаных грунтах водоемов, ведут ночной образ жизни. В природе их экологическая роль значительна – они являются детритофагами, то есть питаются разлагающейся органикой. Также служат промежуточными хозяевами для некоторых видов паразитических червей.",
                Images = new List<string>
                {
                    "melanii_ulitki_2.jpg",
                    "melanii_ulitki_1.jpg",
                    "melanii_ulitki_3.jpg"
                },

                AverageShellSize ="20-36 мм",
                ShellColor = "серая или оливковая",
                BodyColor = "серый со светло-серым крапом",
                LifespanInYears = "2-3 года"
            },
            //3
            new Snail
            {
                Name = "Покемон",
                ScientificName = "Radix rubiginosa",
                Description = "Прозвище «покемон» моллюск получил за развитые треугольные выросты тела, напоминающие уши сказочных существ из популярного мультсериала.",
                Images = new List<string>
                {
                    "pokemon1.jpg",
                    "pokemon2.jpg",
                    "pokemon3.jpg"
                },

                AverageShellSize ="10-20 мм",
                ShellColor = "коричневая",
                BodyColor = "серый, коричневый",
                LifespanInYears = "1 год"
            },
            //4
            new Snail
            {
                Name = "Садовая улитка",
                ScientificName = "Cepaea hortensis",
                Description = "Наземный брюхоногий моллюск. Садовая улитка обитает в кустарниках и в редколесье, на камнях, скалах, дюнах, пастбищах. Питается в основном водорослями.",
                Images = new List<string>
                {
                    "sad1.jpg",
                    "sad2.jpg",
                    "sad3.jpg"
                },

                AverageShellSize ="23-46 мм",
                ShellColor = "желтоватый с коричневыми или черными полосами",
                BodyColor = "бежевый с коричневым оттенком",
                LifespanInYears = "7–8 лет"
            },
            //5
            new Snail
            {
                Name = "Улитка мариза",
                ScientificName = "Marisa cornuarietis",
                Description = "Аквариумная улитка, которая славится непомерным аппетитом. Типичный растительноядный вид, который не стоит высаживать в аквариум-травник. При малейшем недостатке корма улитки примутся за живые растения и могут съесть их под корень.",
                Images = new List<string>
                {
                    "mariza1.jpg",
                    "mariza2.jpg",
                    "mariza3.jpg"
                },

                AverageShellSize ="30-70 мм",
                ShellColor = "светло-коричневая или желтоватого цвета",
                BodyColor = "оранжевый или красновато-коричневый",
                LifespanInYears = "1-2 года"
            },
            //6
            new Snail
            {
                Name = "Тигровая улитка",
                ScientificName = "Cypraea tigris",
                Description = "Вид брюхоногих моллюсков, который обитает в Азии и на тихоокеанских островах.",
                Images = new List<string>
                {
                    "tigris1.jpg",
                    "tigris2.jpg",
                    "tigris3.jpg"
                },

                AverageShellSize ="42—153 мм",
                ShellColor = "оранжевый или ярко-желтого цвета",
                BodyColor = "тёмный или коричневый",
                LifespanInYears = "2-3 лет"
            },
            //7
            new Snail
            {
                Name = "Лесная улитка",
                ScientificName = "Cepaea nemoralis",
                Description = "Один из наиболее крупных моллюсков в мире. Его яркий окрас и полиформизм сделали этого брюхоногого одним из самых известных в Европе.",
                Images = new List<string>
                {
                    "lesnaya1.jpg",
                    "lesnaya2.jpg",
                    "lesnaya3.jpg"
                },

                AverageShellSize ="12-22 мм",
                ShellColor = "буроватая, желтая или беловатая",
                BodyColor = "жёлтая или розовая",
                LifespanInYears = "7–8 лет"
            },
            //8
            new Snail
            {
                Name = "Улитка катушка",
                ScientificName = "Planorbidae",
                Description = "Катушки необычайно выносливые моллюски, могут существовать в различных параметрах воды, легко и быстро размножаются. Эти беспозвоночные могут дышать двумя способами – используя кислород, растворенный в воде, и атмосферный воздух.",
                Images = new List<string>
                {
                    "katushka1.jpg",
                    "katushka2.jpg",
                    "katushka3.jpg"
                },

                AverageShellSize ="14-22 мм",
                ShellColor = "красного или коричневого цвета",
                BodyColor = "коричневого или буроватого цвета",
                LifespanInYears = "1-2 года"
            },
            //9
            new Snail
            {
                Name = "Лужанка (живородка)",
                ScientificName = "Viviparus",
                Description = "Пресноводная улитка, которая держится на дне водоёма. Здесь она питается илом, поедая заодно и его мельчайших обитателей — живых и мёртвых.",
                Images = new List<string>
                {
                    "lyja1.jpg",
                    "lyja2.jpg",
                    "lyja3.jpg"
                },

                AverageShellSize ="30-40 мм",
                ShellColor = "коричневого цвета",
                BodyColor = "темного серо-коричневого цвета",
                LifespanInYears = "7-10 лет"
            },
            //10
            new Snail
            {
                Name = "Букцинум (трубач)",
                ScientificName = "Buccinum",
                Description = "Это самый крупный вид моллюсков в Северном море. Раковина ребристая, желтовато-коричневого цвета. Устье овальное с утолщённой внешней губой.",
                Images = new List<string>
                {
                    "trubach1.jpg",
                    "trubach2.jpg",
                    "trubach3.jpg"
                },

                AverageShellSize ="60-110 мм",
                ShellColor = "серого или коричневого цвета",
                BodyColor = "светло-коричневого цвета",
                LifespanInYears = "10-15 лет"
            },
            //11
            new Snail
            {
                Name = "Хелена",
                ScientificName = "Anentome helena",
                Description = "Это достаточно красивые и привлекательные обитатели аквариума. Эти желто-полосатые представительницы водоемов Таиланда, Индонезии и Юго-Восточной Азии, неприхотливы в содержании, кормлении и разведении.",
                Images = new List<string>
                {
                    "helena1.jpg",
                    "helena2.jpg",
                    "helena3.jpg"
                },

                AverageShellSize ="15-25 мм",
                ShellColor = "желто-коричневого цвета",
                BodyColor = "сероватого цвета",
                LifespanInYears = "3-4 года"
            },
            //12
            new Snail
            {
                Name = "Битинии",
                ScientificName = "Bithynia",
                Description = "Узнаваемый род беспозвоночных животных класса брюхоногих моллюсков, обитатель проточных и стоячих водоёмов европейской части России.",
                Images = new List<string>
                {
                    "bitini1.jpg",
                    "bitini2.jpg",
                    "bitini3.jpg"
                },

                AverageShellSize ="12-15 мм",
                ShellColor = "коричневого цвета",
                BodyColor = "оливкового цвета",
                LifespanInYears = "5-6 лет"
            },
            //13
            new Snail
            {
                Name = "Радужная (конфетная)",
                ScientificName = "Liguus virgineus",
                Description = "Это яркая улитка, эндемик острова Эспаньола. Она обитает на деревьях и питается мхами и лишайниками, которые растут на коре.",
                Images = new List<string>
                {
                    "rainbow1.jpg",
                    "rainbow2.jpg",
                    "rainbow3.jpg"
                },

                AverageShellSize ="15-25 мм",
                ShellColor = "может быть различных цветов",
                BodyColor = "светло-серого цвета",
                LifespanInYears = "3-4 года"
            },
            //14
            new Snail
            {
                Name = "Ломкая янтина",
                ScientificName = "Janthina janthina",
                Description = "Эта разноцветная морская улитка обитает в субтропических и тропических районах Тихого, Атлантического и Индийского океанов. Раковина у неё окрашена в фиолетовый оттенок, близкий к цвету аметиста.",
                Images = new List<string>
                {
                    "lomkay1.jpg",
                    "lomkay2.jpg",
                    "lomkay3.jpg"
                },

                AverageShellSize ="22-33 мм",
                ShellColor = "серого цвета",
                BodyColor = "светло-серого цвета",
                LifespanInYears = "5-9 лет"
            },
            //15
            new Snail
            {
                Name = "Пёстрая полимита",
                ScientificName = "Polymita picta",
                Description = "Эта красивая разноцветная улитка также известна как кубинская расписная. Встречается она в основном в субтропических лесах и прибрежных районах на востоке Кубы.",
                Images = new List<string>
                {
                    "pestro1.jpg",
                    "pestro2.jpg",
                    "pestro3.jpg"
                },

                AverageShellSize ="15-20 мм",
                ShellColor = "может быть различных цветов",
                BodyColor = "желтого или белого цвета",
                LifespanInYears = "2-3 года"
            },
        };
    }
}
