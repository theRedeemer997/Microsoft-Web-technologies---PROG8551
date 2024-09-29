namespace HelloWorld_StringModelWithServiceVersion.Services
{
    public class GreetingService : IGreetingService
    {
        public GreetingService()
        {
            Console.WriteLine("In GreetingService constructor");
        }

        public string GetGreeting()
        {
            int hour = DateTime.Now.Hour;
            string greetingMsg;
            if (hour < 12)
                greetingMsg = "Good morning";
            else if (hour >= 12 && hour < 18)
                greetingMsg = "Good afternoon";
            else
                greetingMsg = "Good evening";

            return greetingMsg;
        }
    }
}
