/* Private Constructor: 

   Syntax: 
    
   // Ctor One
   public Employee(string name, string email)
   {
        this.name = name;
        this.email = email;
   }
    
   // Ctor Two
   public Employee(Date joiningDate): this("Raj", "email@email.com")
   {
        this.joining = joiningDate;
   }
     
 */

namespace CrashConsole.AdvancedConstructors
{
    public class ScoreManager
    {
        // static field to hold the single instance
        private static ScoreManager _instance;

        // Auto Properties
        public int CurrentScore { get; private set; }
        public int HighScore { get; private set; }
        public int LivesRemaining { get; private set; }

        // private ctor - to prevent multiple object creation
        private ScoreManager()
        {
            CurrentScore = 0;
            HighScore = 0;
            LivesRemaining = 3;
        }

        // Public static method to get single instance for object
        // creation bcz private ctor cant be used outside of class to create object.
        public static ScoreManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ScoreManager();
            }
            return _instance;
        }

        // Regular Methods
        public void AddPoints(int points)
        {
            CurrentScore += points;
            Console.WriteLine($"Score: {CurrentScore}");

            if (CurrentScore > HighScore)
            {
                HighScore = CurrentScore;
                Console.WriteLine($"New High Score: {HighScore}");
            }
        }

        public void LoseLife()
        {
            LivesRemaining--;
            Console.WriteLine($"Lives remaining: {LivesRemaining}");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Current Score: {CurrentScore}");
            Console.WriteLine($"High Score: {HighScore}");
            Console.WriteLine($"Lives: {LivesRemaining}");
        }

        public void ResetGame()
        {
            CurrentScore = 0;
            LivesRemaining = 3;
            Console.WriteLine("Game Reset! (High score preserved)");
        }
    }


    public class ProgramSM
    {
        public static void MainSM()
        {
            // Getting score manager from level 1
            Console.WriteLine("Level 1 Code:");
            ScoreManager level1Score = ScoreManager.GetInstance();
            level1Score.AddPoints(100); // current score will - 100
            level1Score.AddPoints(50); // current score will - 150

            // Getting score manager from level 2
            Console.WriteLine("\n Level 2 Code: ");
            ScoreManager level2Score = ScoreManager.GetInstance();
            level2Score.AddPoints(200); // current score will - 350

            // Getting score manager from Game Over Screen
            Console.WriteLine("\nGame Over Screen: ");
            ScoreManager gameOver = ScoreManager.GetInstance();
            gameOver.ShowStatus();

            // Getting score manager to Reset Game
            Console.WriteLine("\nReset Game");
            ScoreManager gameReset = ScoreManager.GetInstance();
            gameReset.ResetGame();

            // Proving its the same object
            Console.WriteLine($"\n Same Object? {ReferenceEquals(level1Score, level2Score)}");
        }
    }
}