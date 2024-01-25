namespace SheduleHubWeb
{
    public class UserService
    {
        public int UserId { get; set; }

        public string Email { get; set; } = null!;

        public string Pssword { get; set; } = null!;

        public string NameFirst { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public string Patronymic { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public int? IdGroup { get; set; }

        public int? IdRole { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<UserService>();
        }
    }
}
