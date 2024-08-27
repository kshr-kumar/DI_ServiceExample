namespace DependencyInjectionPractice1.Services
{
    public class GreetingServices : IGreetingServices
    {
        public string Greet(string name)
        {
            return $"hello {name} "; 
        }
    }

}
