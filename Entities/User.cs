using System;
namespace SmartHome.Entities
{
        public class User
        {
            public int Id { get; set; }

            public string Login { get; set; }

            public string Email { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int PhoneNumber { get; set; }

            public DateTime? DateOfBirth { get; set; }

            public string Street { get; set; }

            public string City { get; set; }

            public string PasswordHash { get; set; }

            public int RoleId { get; set; }

            public virtual Role Roles { get; set; }

            public virtual List<Sensor> Sensors { get; set; }
        }
}

