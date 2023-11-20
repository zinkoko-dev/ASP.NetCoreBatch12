namespace FirstMVCDemo.Models
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address {  get; set; }
        public DateOnly DOB { get; set; }
        public string Gender { get; set; }  
        public string FullName { get {  return FirstName+" "+LastName; } }
    }
}
