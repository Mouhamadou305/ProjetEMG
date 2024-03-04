using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ProjetEMG2.Data;
using ProjetEMG2.Models;

public class SampleData
{
    public static async void Initialize(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetService<ApplicationDbContext>();

        string[] roles = new string[] { "Administrator", "User" };

        foreach (string role in roles)
        {
            var roleStore = new RoleStore<IdentityRole>(context);

            if (!context.Roles.Any(r => r.Name == role))
            {
                await roleStore.CreateAsync(new IdentityRole
                {
                    Name = role,
                    NormalizedName = role.ToUpper()
                });
            }
        }


        var user = new IdentityUser
        {
            Email = "Owner@example.com",
            NormalizedEmail = "OWNER@EXAMPLE.COM",
            UserName = "Owner@example.sn",
            NormalizedUserName = "OWNER",
            PhoneNumber = "+111111111111",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D")
        };


        if (!context.Users.Any(u => u.UserName == user.UserName))
        {
            var password = new PasswordHasher<IdentityUser>();
            var hashed = password.HashPassword(user, "P@ssword1234");
            user.PasswordHash = hashed;

            var userStore = new UserStore<IdentityUser>(context);
            var result = userStore.CreateAsync(user);

        }

        await AssignRoles(serviceProvider, user.Email, roles);

        await SeedCars(context);

        await context.SaveChangesAsync();
    }

    public static async Task<IdentityResult> AssignRoles(IServiceProvider services, string email, string[] roles)
    {
        UserManager<IdentityUser> _userManager = services.GetService<UserManager<IdentityUser>>();
        IdentityUser user = await _userManager.FindByEmailAsync(email);
        var result = await _userManager.AddToRolesAsync(user, roles);

        return result;
    }

    private static async Task SeedCars(ApplicationDbContext context)
    {
        if (!context.Cars.Any())
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Annee = 2019,
                    Marque = "Mazda",
                    Modele = "Miata",
                    Finition = "LE",
                    DateAchat = new DateTime(2022, 01, 07),
                    PrixAchat = 1800,
                    Reparations = "Restauration complète",
                    CoutsReparation = 7600,
                    DateDisponibilite = new DateTime(2022, 01, 07),
                    PrixVente = 9900,
                    DateVente = new DateTime(2022, 04, 08)
                },
                new Car
                {
                    Annee = 2007,
                    Marque = "Jeep",
                    Modele = "Liberty",
                    Finition = "Sport",
                    DateAchat = new DateTime(2022, 04, 02),
                    PrixAchat = 4500,
                    Reparations = "Roulements des roues avant",
                    CoutsReparation = 350,
                    DateDisponibilite = new DateTime(2022, 04, 07),
                    PrixVente = 5350,
                    DateVente = new DateTime(2022, 04, 09)
                },
                new Car
                {
                    Annee = 2007,
                    Marque = "Renault",
                    Modele = "Scénic",
                    Finition = "TCe",
                    DateAchat = new DateTime(2022, 04, 04),
                    PrixAchat = 1800,
                    Reparations = "Radiateur, freins",
                    CoutsReparation = 690,
                    DateDisponibilite = new DateTime(2022, 04, 08),
                    PrixVente = 2990
                },
                new Car
                {
                    Annee = 2017,
                    Marque = "Ford",
                    Modele = "Explorer",
                    Finition = "XLT",
                    DateAchat = new DateTime(2022, 04, 05),
                    PrixAchat = 24350,
                    Reparations = "Pneus, freins",
                    CoutsReparation = 1100,
                    DateDisponibilite = new DateTime(2022, 04, 09),
                    PrixVente = 25950
                },
                new Car
                {
                    Annee = 2008,
                    Marque = "Honda",
                    Modele = "Civic",
                    Finition = "LX",
                    DateAchat = new DateTime(2022, 04, 06),
                    PrixAchat = 4000,
                    Reparations = "Climatisation, freins",
                    CoutsReparation = 475,
                    DateDisponibilite = new DateTime(2022, 04, 09),
                    PrixVente = 4975
                },
                new Car
                {
                    Annee = 2016,
                    Marque = "Volkswagen",
                    Modele = "GTI",
                    Finition = "S",
                    DateAchat = new DateTime(2022, 04, 06),
                    PrixAchat = 15250,
                    Reparations = "Pneus",
                    CoutsReparation = 440,
                    DateDisponibilite = new DateTime(2022, 04, 10),
                    PrixVente = 16190,
                    DateVente = new DateTime(2022, 04, 12)
                },
                new Car
                {
                    Annee = 2013,
                    Marque = "Ford",
                    Modele = "Edge",
                    Finition = "SEL",
                    DateAchat = new DateTime(2022, 04, 07),
                    PrixAchat = 10990,
                    Reparations = "Pneus, freins, climatisation",
                    CoutsReparation = 950,
                    DateDisponibilite = new DateTime(2022, 04, 11),
                    PrixVente = 12440,
                    DateVente = new DateTime(2022, 04, 12)
                }
            };

            await context.Cars.AddRangeAsync(cars);
            await context.SaveChangesAsync();
        }
    }

}