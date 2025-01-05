using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CsharpPractice.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string[] Array = new[] { "rock", "paper", "scissors" };
    public string HumanChoice { get; set; } = string.Empty;
    public string ComputerSelection { get; set; } = string.Empty;
    
    public void OnGet(string choice)
    {
        
       
        if (!string.IsNullOrEmpty(choice))
        {
            // Generate a random number between 0 and 2 (inclusive)
            Random random = new Random();
            int randomIndex = random.Next(0, Array.Length);

            // Set human and computer choices
            HumanChoice = choice;
            ComputerSelection = Array[randomIndex];
            if (HumanChoice == "rock" && ComputerSelection == "scissors")
            {
                ViewData["message"] = "You Win";
                ViewData["computer"] = ComputerSelection;
                ViewData["human"] = HumanChoice;
            }
            else if (HumanChoice == "rock" && ComputerSelection == "paper")
            {
                ViewData["message"] = "Computer Win";
                ViewData["computer"] = ComputerSelection;
                ViewData["human"] = HumanChoice;
            }
            else if (HumanChoice == "scissors" && ComputerSelection == "rock")
            {
                ViewData["message"] = "Computer Win";
                ViewData["computer"] = ComputerSelection;
                ViewData["human"] = HumanChoice;
            }
            else if (HumanChoice == "rock" && ComputerSelection == "scissors")
            {
                ViewData["message"] = "Computer Win";
                ViewData["computer"] = ComputerSelection;
                ViewData["human"] = HumanChoice;
                
            }
            else if (HumanChoice == ComputerSelection )
            {
                ViewData["message"] = "Tie";
                ViewData["computer"] = ComputerSelection;
                ViewData["human"] = HumanChoice;
                
            }
        }
        
        // if (choice !="")
        //     
        // {
        //     switch (choice)
        //     {
        //         case "rock":
        //             Console.WriteLine("rock");
        //             this.computerSelection =this.array[randomNumber];
        //             Console.WriteLine("computer",this.computerSelection);
        //             humenChoice = "rock";
        //             break;
        //         case "paper":
        //             Console.WriteLine("paper");
        //             this.computerSelection =this.array[randomNumber];
        //             Console.WriteLine("computer",this.computerSelection);
        //             humenChoice = "paper";
        //             break;
        //         case "scissors":
        //             Console.WriteLine("scissors");
        //             this.computerSelection =this.array[randomNumber];
        //             Console.WriteLine("computer",this.computerSelection);
        //             humenChoice = "scissors";
        //             break;
        //         default:
        //             break;
        //     }
        // }
        //
        //
        //
        //
        // Console.WriteLine($"choice: {choice}");
    }

   
}