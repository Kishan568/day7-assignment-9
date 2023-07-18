using System;

namespace UserRegistration
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("User Registration");
                Console.WriteLine("------------------");    
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();    
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();                
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();              
                ValidateRegistrationData(name, email, password);              
                Console.WriteLine("\nUser registration success!");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Email: " + email);
                Console.WriteLine("Password: " + password);
            }
            catch (ValidationException ex)
            {              
                Console.WriteLine("\nValidation error: " + ex.Message);
            }
            catch (Exception ex)
            {             
                Console.WriteLine("\nAn error occurred: " + ex.Message);
            }
        }
        static void ValidateRegistrationData(string name, string email, string password)
        {    
            if (string.IsNullOrWhiteSpace(name))
                throw new ValidationException("Name is required.");
            if (string.IsNullOrWhiteSpace(email))
                throw new ValidationException("Email is required.");
            if (string.IsNullOrWhiteSpace(password))
                throw new ValidationException("Password is required.");     
            if (name.Length < 6)
                throw new ValidationException("Name must have at least 6 characters.");
            if (password.Length < 8)
                throw new ValidationException("Password must have at least 8 characters.");
        }
    }
}