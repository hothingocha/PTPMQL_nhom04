namespace MvcMovie.Models
{
    public class GradeModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double Index() // Đổi tên từ CalculateFinalGrade thành Index
        {
            return A * 0.6 + B * 0.3 + C * 0.1;
        }

        public string GetClassification()
        {
            double finalGrade = Index(); // Gọi Index thay vì CalculateFinalGrade
            if (finalGrade >= 8.5) return "Giỏi";
            else if (finalGrade >= 6.5) return "Khá";
            else if (finalGrade >= 5) return "Trung bình";
            else return "Yếu";
        }
    }
}