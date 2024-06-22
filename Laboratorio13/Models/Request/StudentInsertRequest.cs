namespace Laboratorio13.Models.Request
{
    public class StudentInsertRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int GradeID { get; set; }
    }
}
