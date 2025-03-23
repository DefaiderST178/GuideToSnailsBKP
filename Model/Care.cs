namespace GuideToSnailsBKP.Model
{
    public class Care
    {
        public string Title { get; set; } // Название (ухода)
        public string Description { get; set; } // Описание ухода
        public List<string> DopDescription { get; set; } // Дополн описание
        public List<string> Images { get; set; } // Изображения
    }
}
