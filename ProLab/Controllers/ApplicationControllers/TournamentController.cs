using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProLab.Data;
using ProLab.Models.DataModels;


namespace ProLab.Controllers.ApplicationControllers
{
    public class TournamentController : Controller
    {

        private readonly ProLabContext _context;

        public TournamentController(ProLabContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Tournaments()
        {
            return View();
        }


        public async Task<IActionResult> ListGamesRef(string searchString, string searchString1,
            string searchString2, string searchString3)
        {
            var hockeyGames = from h in _context.HockeyGame
                .Include(h => h.Arena)
                .Include(h => h.AwayTeam)
                .Include(h => h.GameCategory)
                .Include(h => h.GameStatus)
                .Include(h => h.GameType)
                .Include(h => h.HD1)
                .Include(h => h.HD2)
                .Include(h => h.HomeTeam)
                .Include(h => h.LD1)
                .Include(h => h.LD2)
                .Include(h => h.Series)

                              select h;
            if (!String.IsNullOrEmpty(searchString))
            {
                hockeyGames = hockeyGames
                .Include(h => h.Arena)
                .Include(h => h.AwayTeam)
                .Include(h => h.GameCategory)
                .Include(h => h.GameStatus)
                .Include(h => h.GameType)
                .Include(h => h.HD1)
                .Include(h => h.HD2)
                .Include(h => h.HomeTeam)
                .Include(h => h.LD1)
                .Include(h => h.LD2)
                .Include(h => h.Series)
                .Where(s => s.GameDateTime.ToString().Contains(searchString));

            }
            if (!String.IsNullOrEmpty(searchString1))
            {
                hockeyGames = hockeyGames
               .Include(h => h.Arena)
               .Include(h => h.AwayTeam)
               .Include(h => h.GameCategory)
               .Include(h => h.GameStatus)
               .Include(h => h.GameType)
               .Include(h => h.HD1)
               .Include(h => h.HD2)
               .Include(h => h.HomeTeam)
               .Include(h => h.LD1)
               .Include(h => h.LD2)
               .Include(h => h.Series)
               .Where(s => s.Arena.ArenaName.Contains(searchString1));

            }
            if (!String.IsNullOrEmpty(searchString2))
            {
                hockeyGames = hockeyGames
               .Include(h => h.Arena)
               .Include(h => h.AwayTeam)
               .Include(h => h.GameCategory)
               .Include(h => h.GameStatus)
               .Include(h => h.GameType)
               .Include(h => h.HD1)
               .Include(h => h.HD2)
               .Include(h => h.HomeTeam)
               .Include(h => h.LD1)
               .Include(h => h.LD2)
               .Include(h => h.Series)
               .Where(s => s.Notes.Contains(searchString2));

            }
            if (!String.IsNullOrEmpty(searchString3))
            {
                hockeyGames = hockeyGames
               .Include(h => h.Arena)
               .Include(h => h.AwayTeam)
               .Include(h => h.GameCategory)
               .Include(h => h.GameStatus)
               .Include(h => h.GameType)
               .Include(h => h.HD1)
               .Include(h => h.HD2)
               .Include(h => h.HomeTeam)
               .Include(h => h.LD1)
               .Include(h => h.LD2)
               .Include(h => h.Series)
               .Where(s => s.GameStatus.GameStatusName.Contains(searchString3));

            }
            return View(await hockeyGames.ToListAsync());
        }
    }
}
