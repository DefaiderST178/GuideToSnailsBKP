namespace GuideToSnailsBKP.Model
{
    public class Snail
    {
        // Основная информация
        public string Name { get; set; } // Название
        public string ScientificName { get; set; } // Научное название
        public string Description { get; set; } // Описание
        public List<string> Images { get; set; } // Изображения

        // Физические характеристики
        public string AverageShellSize { get; set; } // Средний размер раковины в миллиметрах
        public string ShellColor { get; set; } // Цвет раковины
        public string BodyColor { get; set; } // Цвет тела
        public string LifespanInYears { get; set; } // Срок жизни
        
        // Обитание и рацион
        public string Region { get; set; }
        public string RegionDescription { get; set; }
        public string TypeDiet { get; set; }
        public string DietDescription { get; set; }
    }
}
