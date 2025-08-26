using Microsoft.EntityFrameworkCore;

namespace VideoGameAPI.Data
{
    public class VideoGameDbContext : DbContext
    {
        public VideoGameDbContext(DbContextOptions<VideoGameDbContext> options)
            : base(options)
        {
        }

        public DbSet<VideoGame> VideoGames => Set<VideoGame>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "The Legend of Zelda: Breath of the Wild", Platform = "Nintendo Switch", Developer = "Nintendo", Publisher = "Nintendo" },
                new VideoGame { Id = 2, Title = "God of War", Platform = "PlayStation 4", Developer = "Santa Monica Studio", Publisher = "Sony Interactive Entertainment" },
                new VideoGame { Id = 3, Title = "Red Dead Redemption 2", Platform = "PlayStation 4, Xbox One, PC", Developer = "Rockstar Games", Publisher = "Rockstar Games" },
                new VideoGame { Id = 4, Title = "The Witcher 3: Wild Hunt", Platform = "PlayStation 4, Xbox One, PC, Nintendo Switch", Developer = "CD Projekt Red", Publisher = "CD Projekt" },
                new VideoGame { Id = 5, Title = "Minecraft", Platform = "PC, Console, Mobile", Developer = "Mojang Studios", Publisher = "Mojang Studios" },
                new VideoGame { Id = 6, Title = "Fortnite", Platform = "PC, Console, Mobile", Developer = "Epic Games", Publisher = "Epic Games" },
                new VideoGame { Id = 7, Title = "Among Us", Platform = "PC, Mobile, Console", Developer = "Innersloth", Publisher = "Innersloth" },
                new VideoGame { Id = 8, Title = "Animal Crossing: New Horizons", Platform = "Nintendo Switch", Developer = "Nintendo", Publisher = "Nintendo" },
                new VideoGame { Id = 9, Title = "Elden Ring", Platform = "PC, PlayStation, Xbox", Developer = "FromSoftware", Publisher = "Bandai Namco" },
                new VideoGame { Id = 10, Title = "Hades", Platform = "PC, Console", Developer = "Supergiant Games", Publisher = "Supergiant Games" },
                new VideoGame { Id = 11, Title = "Super Mario Odyssey", Platform = "Nintendo Switch", Developer = "Nintendo", Publisher = "Nintendo" },
                new VideoGame { Id = 12, Title = "Apex Legends", Platform = "PC, Console", Developer = "Respawn Entertainment", Publisher = "Electronic Arts" },
                new VideoGame { Id = 13, Title = "Call of Duty: Modern Warfare II", Platform = "PC, Console", Developer = "Infinity Ward", Publisher = "Activision" },
                new VideoGame { Id = 14, Title = "Hogwarts Legacy", Platform = "PC, Console", Developer = "Portkey Games", Publisher = "Warner Bros. Games" },
                new VideoGame { Id = 15, Title = "FIFA 23", Platform = "PC, Console", Developer = "EA Sports", Publisher = "Electronic Arts" },
                new VideoGame { Id = 16, Title = "Resident Evil 4 Remake", Platform = "PC, Console", Developer = "Capcom", Publisher = "Capcom" },
                new VideoGame { Id = 17, Title = "Marvel's Spider-Man", Platform = "PlayStation", Developer = "Insomniac Games", Publisher = "Sony Interactive Entertainment" },
                new VideoGame { Id = 18, Title = "Stardew Valley", Platform = "PC, Console, Mobile", Developer = "ConcernedApe", Publisher = "ConcernedApe" },
                new VideoGame { Id = 19, Title = "League of Legends", Platform = "PC", Developer = "Riot Games", Publisher = "Riot Games" },
                new VideoGame { Id = 20, Title = "Valorant", Platform = "PC", Developer = "Riot Games", Publisher = "Riot Games" }
            );
        }

    }
}
