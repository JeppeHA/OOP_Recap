namespace ExerciseProject.DataTypes;

public class Story
{
    // Insert your age, name and favorite color 
    private int age;
    private string name;
    private string favoriteColor;

    
    public void TellStory()
    {
        Console.WriteLine("Hello my name is " + name + " and i am "  + age + " years old and my favorite color is " + favoriteColor);
    }
}