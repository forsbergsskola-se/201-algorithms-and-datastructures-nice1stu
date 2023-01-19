//Reference TurboCollections
//Use TurboLinkedQueue
//The User repeatedly has the following options:

//[s]kip to next song: If there is another song in the queue, it prints $"Now Playing {songName}.". else, it says "No more songs in the Queue. Add new Songs to the Queue first."
//[a]dd new song to the queue: The application asks for a Song Name and then adds it to the Queue.

public class SpotifySongQueue
{
    static void Main(string[] args)
    {
        var queue = new TurboLinkedQueue<string>();

        while (true)
        {
            Console.WriteLine("What would you like to do? [s]kip or [a]dd?");
            
            string userInput = Console.ReadLine();

            if (userInput == "s")
            {
                if (queue.Count > 0)
                {
                    string songName = queue.Dequeue();
                    Console.WriteLine($"Now Playing: {songName}");
                }
                else
                {
                    Console.WriteLine("There is no more songs in the Queue.");
                }

            }
            else if (userInput == "a")
            {
                Console.WriteLine("Enter the Song's Name");
                string songName = Console.ReadLine();
                queue.Enqueue(songName);
            }
        }
    }
}