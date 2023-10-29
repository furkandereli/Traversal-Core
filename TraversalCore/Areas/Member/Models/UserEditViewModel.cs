namespace TraversalCore.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? password { get; set; }
        public string? confirmPassword { get; set; }
        public string? phoneNumber { get; set; }
        public string? email { get; set; }
        public string? imageUrl { get; set; }
        public IFormFile? Image {  get; set; }


    }
}
