namespace DemoMVC.Models
{
    public class BMI
    {
        public float Height { get; set; } // Chiều cao (m)
        public float Weight { get; set; } // Cân nặng (kg)
        public float BMIValue { get; set; } // Chỉ số BMI
        public required string BMICategory { get; set; } // Phân loại BMI
    }
}