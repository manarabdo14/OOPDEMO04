using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace Assgnment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Part 01
//            Question 1:
//What is the primary purpose of an interface in C#?

//b) To define a blueprint for a class

//Question 2:
//Which of the following is NOT a valid access modifier for interface members in C#?
//a) private


//Question 3:
//Can an interface contain fields in C#?
//b) No


//Question 4:
//In C#, can an interface inherit from another interface?
//b) Yes, interfaces can inherit from multiple interfaces

//Question 5:
//Which keyword is used to implement an interface in a class in C#?
//d) implements

//Question 6:
//Can an interface contain static methods in C#?
//a) Yes


//Question 7:
//In C#, can an interface have explicit access modifiers for its members?
//b) No, all members are implicitly public

//Question 8:
//What is the purpose of an explicit interface implementation in C#?
//b) To provide a clear separation between interface and class members



//Question 9:
//In C#, can an interface have a constructor?

//b) No, interfaces cannot have constructors


//Question 10:
//How can a C# class implement multiple interfaces?
//c) By separating interface names with commas

    #endregion
            #region Part 02

    #region Question 01  Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.

    //ICircle circle = new Circle(5.0);
    // circle.DisplayShapeInfo();

    // IRectangle rectangle = new Rectangle(4.0, 6.0);
    // rectangle.DisplayShapeInfo();
    #endregion

    #region  Question 02:
    //IAuthenticationService authService = new BasicAuthenticationService();

    //string username = "Manar";
    //string password = "password";
    //string role = "admin";

    //bool isAuthenticated = authService.AuthenticateUser(username, password);
    //bool isAuthorized = authService.AuthorizeUser(username, role);

    //Console.WriteLine($"Is Authenticated: {isAuthenticated}");
    //Console.WriteLine($"Is Authorized: {isAuthorized}");
    #endregion

    #region Question 03:

    //INotificationService emailService = new EmailNotificationService();
    //INotificationService smsService = new SmsNotificationService();
    //INotificationService pushService = new PushNotificationService();

    //string recipient = "ManarAbdo@gmail.com";
    //string message = "Hello, this is a notification.";

    //emailService.SendNotification(recipient, message);
    //smsService.SendNotification(recipient, message);
    //pushService.SendNotification(recipient, message);
    #endregion

    #endregion
    }
}
}
