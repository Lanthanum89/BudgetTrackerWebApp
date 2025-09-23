using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BudgettrackerWebApp.Pages
{
    public class IndexModel : PageModel
    {
        // Simple in-memory store (shared across requests; not for production).
        private static readonly List<Expense> _store = new();
        private static decimal? _budget;

    // Exposed to the Razor page.
    public IReadOnlyList<Expense> Expenses => _store;
    public decimal? CurrentBudget => _budget;

        // These names match the form input 'name' attributes.
        [BindProperty]
        public string Description { get; set; } = "";

        [BindProperty]
        public decimal Amount { get; set; }

    [BindProperty]
    public decimal Budget { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // No-op; Expenses is read-only wrapper over _store.
        }

        public IActionResult OnPostAddExpense()
        {
            if (!ModelState.IsValid)
                return Page();

            _store.Add(new Expense
            {
                Description = Description,
                Amount = Amount,
                Date = DateTime.Today
            });

            // PRG pattern to avoid duplicate posts on refresh.
            return RedirectToPage();
        }

        public IActionResult OnPostSetBudget()
        {
            if (!ModelState.IsValid)
                return Page();

            if (Budget < 0)
            {
                ModelState.AddModelError(nameof(Budget), "Budget must be zero or greater.");
                return Page();
            }

            _budget = Budget;
            return RedirectToPage();
        }
    }

    public class Expense
    {
        public string Description { get; set; } = "";
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}