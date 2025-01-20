using ECOMMHUB.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ECOMMHUB.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        public  List<Game> GamesList = new List<Game>(){
            new Game{
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Description = "An open-world adventure game where you explore the kingdom of Hyrule.",
                CoverImageURL = "https://www.mobygames.com/game/legend-of-zelda-breath-of-the-wild/cover-art/gameCoverId,497130/",
                Price = 59.99M
             },
            new Game{
                Id = 2,
                Title = "Minecraft",
                Description = "A sandbox game about building, mining, and exploring.",
                CoverImageURL = "https://www.mobygames.com/game/minecraft/cover-art/gameCoverId,363275/",
                Price = 26.95M
            },
            new Game{
                Id = 3,
                Title = "The Witcher 3: Wild Hunt",
                Description = "An epic RPG about the monster hunter Geralt of Rivia.",
                CoverImageURL = "https://www.mobygames.com/game/witcher-3-wild-hunt/cover-art/gameCoverId,392214/",
                Price = 39.99M
            },
            new Game{
                Id = 4,
                Title = "Cyberpunk 2077",
                Description = "An open-world RPG set in a futuristic dystopian city.",
                CoverImageURL = "https://www.mobygames.com/game/cyberpunk-2077/cover-art/gameCoverId,783446/",
                Price = 49.99M
            },
            new Game{
                Id = 5,
                Title = "Elden Ring",
                Description = "A fantasy action RPG developed by FromSoftware.",
                CoverImageURL = "https://www.mobygames.com/game/elden-ring/cover-art/gameCoverId,797967/",
                Price = 59.99M
            },
            new Game{
                Id = 6,
                Title = "Grand Theft Auto V",
                Description = "An open-world game about crime and chaos in Los Santos.",
                CoverImageURL = "https://www.mobygames.com/game/grand-theft-auto-v/cover-art/gameCoverId,363275/",
                Price = 29.99M
            },
            new Game{
                Id = 7,
                Title = "Among Us",
                Description = "A multiplayer game of teamwork and betrayal in space.",
                CoverImageURL = "https://www.mobygames.com/game/among-us/cover-art/gameCoverId,704090/",
                Price = 4.99M
            },
            new Game{
                Id = 8,
                Title = "Red Dead Redemption 2",
                Description = "A Western-themed open-world game about outlaws and survival.",
                CoverImageURL = "https://www.mobygames.com/game/red-dead-redemption-ii/cover-art/gameCoverId,115902/",
                Price = 59.99M
            },
            new Game{
                Id = 9,
                Title = "Fortnite",
                Description = "A battle royale game with building mechanics.",
                CoverImageURL = "https://www.mobygames.com/game/fortnite/cover-art/gameCoverId,783446/",
                Price = 0.00M // Free-to-play
            },
            new Game{
                Id = 10,
                Title = "Call of Duty: Modern Warfare II",
                Description = "An action-packed first-person shooter.",
                CoverImageURL = "https://www.mobygames.com/game/call-of-duty-modern-warfare-2/cover-art/gameCoverId,170512/",
                Price = 69.99M
            }
         };



        [HttpGet]
        [Route("getGamesList")]
        public async ActionResult<List<Game>> GetGamesList()
        {
            return Ok(GamesList);
        }
    }
}
