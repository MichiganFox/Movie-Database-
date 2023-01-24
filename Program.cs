// See https://aka.ms/new-console-template for more information



//What will the application do?




//Build Specifications:

//Class has member variables of the correct type —2  points total
//Class has constructor—1 point
//In your program.cs file, create a List<Movie> and store at least 10 movies there. You can use literals to construct the movies. Make sure to have a mixture of categories.
//Program constructs list properly—1 point
//Program puts at least 10 properly instantiated Movies into the List—1 point
//When the user enters a category, the program should read through all of the movies in the List and display a line for any movie whose category matches the category entered by the user.
//Program takes user input correctly—1 point
//Program gives explicit feedback if user enters invalid category—1 point
//Program iterates through List validly—1 point
//Program only outputs if movie matches category—1 point
//Program loops if user wants to continue.
//Program loops back to ask category again based on user input—1 point

//Hints:
//Don’t overthink this! Think about how you would do this in real life if you work at a video store, and you have a stack of movies and somebody wants to see which movies in that stack belong to a particular category. When one customer asks for a list of movies, how many times do you loop through the stack of movies?

//Extra Challenges:
//Standardize the category codes by displaying a menu of categories and having the user select the category by number rather than entering the name.
//Display the movies for the selected category in alphabetical order.
//Expand the information in your Movie class—run time in minutes, year released, etc. Display the additional information when listing movies.

//Build a Movie class with two member variables:  title and category. Both of these should be strings.


using MOVIE_DATABASE;
//The application stores a list of 10 movies and displays them by category.
List<Movies> movieChoice = new List<Movies>()
{
    new Movies("Bmovie", "animated"),
    new Movies("Cmovie", "horror"),
    new Movies("Dmovie", "drama"),
    new Movies("Emovie", "animated"),
    new Movies("Fmovie", "scifi"),
    new Movies("Gmovie", "scifi"),
    new Movies("Hmovie", "scifi"),
    new Movies("Imovie", "drama"),
    new Movies("Jmovie", "animated"),
  
};
Console.WriteLine(movieChoice);


bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Would you like to view or add to the movie list?");
    Console.WriteLine("1. To view the movie list");
    Console.WriteLine("2. Enter add to the list:  ");
    Console.WriteLine("3. Display the list by movie type (Action, Thriller, Suspense, Comedy, Other).  Enter a type:  ");
    

    int choice = int.Parse(Console.ReadLine());

    if (choice == 1) //view all
        foreach (Movies e in movieChoice)
        {
            Console.WriteLine(e.GetDetails());
        }
    else if (choice == 2)
    {
             
            Console.WriteLine("What is the movie's name?");
            string name = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("What is the movie type (Action, Thriller, Suspense, Comedy, Other)?");
            string type = Console.ReadLine().ToLower().Trim();

            movieChoice.Add(new Movies(name, type));
            Console.WriteLine($"{name} has been added");
        
    }
    //The user can enter any of the following categories to display the films in the list that match the category: animated ,drama , horror, scifi.
    //view by department
    else if (choice == 3)
    {
        foreach (Movies e in movieChoice)
        {
            Console.WriteLine(e.GetType());
            Console.WriteLine(e.GetName());
        }

    }

    runProgram = Movies.GetContinue();
    
        
 
}



