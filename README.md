# Budget Tracker Web App

A simple ASP.NET Core Razor Pages application to help you track expenses, set a budget, and stay on target.

## Features

- Set a monthly budget
- Add expenses with description and amount
- See a running total and remaining budget
- Visual feedback when you go over budget
- Clean, coder-inspired lilac/white theme

## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Modern web browser

## Getting Started

1. **Clone the repository:**
   ```pwsh
   git clone https://github.com/Lanthanum89/BudgetTrackerWebApp.git
   cd BudgetTrackerWebApp
   ```

2. **Build the project:**
   ```pwsh
   dotnet build BudgettrackerWebApp/BudgettrackerWebApp.csproj
   ```

3. **Run the app:**
   ```pwsh
   dotnet run --project BudgettrackerWebApp/BudgettrackerWebApp.csproj --launch-profile https
   ```
   - Open your browser to [https://localhost:7175](https://localhost:7175) (or the URL shown in the terminal).

4. **Trust the developer certificate (if prompted):**
   ```pwsh
   dotnet dev-certs https --trust
   ```

## Usage

- **Set your budget** at the top of the page.
- **Add expenses** using the form.
- **See your total spent and remaining budget** update live.
- If you go over budget, you'll see a warning in red.

## Customization

- Edit `wwwroot/css/site.css` to change colors or fonts.
- Expenses are stored in memory (not persistent). For real use, connect a database.

## License

MIT