// I customized the app, giving it a medieval/RPG theme:
//I added a welcome screen styled after the "Hero's Codex" to provide instructions and make the game more engaging.
//I created a leveling system with medieval-style ranks based on score.
//Additionally, the app prompts for the player's name (_playerName) at startup.
//I added a ShowSpinner animation to display loading effects when saving.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}