using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace __C__Adv_03
{
    internal class Program
    {
        public static void PrintPhoneBook(Dictionary<string, string> pb)
        {
            foreach (var entry in pb)
            {
                Console.WriteLine($"- {entry.Key}: {entry.Value}");
            }
        }
        static void Main(string[] args)
        {

            #region Q1
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //Console.WriteLine("Grades: " + string.Join(", ", grades));
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First Grade: " + grades.First());
            //Console.WriteLine("Last Grade: " + grades.Last());
            //grades.Sort();
            //Console.WriteLine("Sorted Grades: " + string.Join(", ", grades));
            //int firstAbove90 = grades.FirstOrDefault(g => g > 90);
            //Console.WriteLine("First Grade Above 90: " + firstAbove90);
            //var failingGrades = grades.Where(g => g < 75).ToList();
            //Console.WriteLine("Failing Grades: " + string.Join(", ", failingGrades));
            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("Grades after removing failing ones: " + string.Join(", ", grades));
            //bool hasPerfectScore = grades.Contains(100);
            //Console.WriteLine("Contains grade of 100: " + hasPerfectScore);
            //List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            //Console.WriteLine("Grade Strings: " + string.Join(", ", gradeStrings));
            //#endregion
            //Console.WriteLine("\n-----------------------------\n");
            //Console.WriteLine("\n-------------------------------------------------\n");
            #endregion
            #region Q2 Leaderboard Management

            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali  ");
            //leaderboard.Add(350, "Mona");
            //Console.WriteLine("Leaderboard:");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}                                   
            //var firstEntry = leaderboard.First();
            //Console.WriteLine($"First Entry - Score: {firstEntry.Key}, Player: {firstEntry.Value}");
            //bool hasScore500 = leaderboard.ContainsKey(500);
            //Console.WriteLine("Contains score of 500: " + hasScore500);
            //if (leaderboard.TryGetValue(999, out string? player999))
            //{
            //    Console.WriteLine("Player with score 999: " + player999);
            //}
            //else
            //{
            //    Console.WriteLine("No player with score 999 found.");
            //}
            //leaderboard.Remove(200);
            //Console.WriteLine("Updated Leaderboard:");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}
            //#endregion
            //Console.WriteLine("\n-----------------------------\n");
            //Console.WriteLine("\n--------------\n");
            #endregion
            #region Q3  Build a phone book application.

        //    Dictionary<string, string> phoneBook = new Dictionary<string, string>
        //{
        //    { "Alice", "111-222-3333" },
        //    { "Bob", "444-555-6666" },
        //    { "Charlie", "777-888-9999" },
        //    { "David", "000-111-2222" }
        //    };
        //    Console.WriteLine("Initial Phone Book:");
        //    PrintPhoneBook(phoneBook);
        //    //adding
        //    Console.WriteLine("\nAdding a new contact (Eve) using [] syntax:");
        //    phoneBook["Eve"] = "333-444-5555";
        //    Console.WriteLine("Phone Book after adding Eve:");
        //    PrintPhoneBook(phoneBook);
        //    //updating
        //    Console.WriteLine("\nUpdating Bob's number using [] syntax:");
        //    phoneBook["Bob"] = "999-888-7777";
        //    Console.WriteLine("Phone Book after updating Bob:");
        //    PrintPhoneBook(phoneBook);
        //    //add()
        //    Console.WriteLine("\nAttempting to add a duplicate (Alice) using .Add():");
        //    try
        //    {
        //        phoneBook.Add("Alice", "123-456-7890");
        //        Console.WriteLine("Alice added successfully (this should not happen).");
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }
        //    //tryadd
        //    Console.WriteLine("\nAttempting to add a duplicate (Charlie) using .TryAdd():");
        //    bool tryAddSucceeded = phoneBook.TryAdd("Charlie", "555-666-7777");
        //    Console.WriteLine($"TryAdd for Charlie succeeded: {tryAddSucceeded}");
        //    Console.WriteLine("Phone Book after TryAdd for Charlie:");
        //    PrintPhoneBook(phoneBook);
        //    //dosnot exit
        //    Console.WriteLine("\nSearching for a non-existent contact (Grace):");
        //    if (phoneBook.ContainsKey("Grace"))
        //    {
        //        Console.WriteLine($"Grace's number: {phoneBook["Grace"]}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Grace not found in phone book.");

        //    }
        //    //feedback
        //    Console.WriteLine("\nGetting a contact (David) with fallback:");
        //    string davidNumber;
        //    if (phoneBook.TryGetValue("David", out davidNumber))
        //    {
        //        Console.WriteLine($"David's number: {davidNumber}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("David not found (this should not happen).");
        //    }

        //    Console.WriteLine("\nGetting a non-existent contact (Harry) with fallback:");
        //    string harryNumber = phoneBook.GetValueOrDefault("Harry", "Not Found");
        //    Console.WriteLine($"Harry's number: {harryNumber}");
            #endregion

            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine("\n--------------\n");

            #region Q4 Use Collection to manage unique email addresses.
            //var emailSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            //// Add emails
            //emailSet.Add("ahmed@test.com");
            //emailSet.Add("AHMED@test.com");
            //emailSet.Add("sara@test.com");
            //emailSet.Add("Sara@Test.Com");
            //// Print Count
            //Console.WriteLine($"Unique email count: {emailSet.Count}"); // Should be 2


            //// Create two sets
            //var setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //var setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            //// Print UnionWith
            //setA.UnionWith(setB);
            //Console.WriteLine("Union: " + string.Join(", ", setA));
            //// Print IntersectWith
            //setA.IntersectWith(setB);
            //Console.WriteLine("Intersection: " + string.Join(", ", setA));
            //// Print ExceptWith
            //setA.ExceptWith(setB);
            //Console.WriteLine("Except: " + string.Join(", ", setA));
            //// Check subset
            //Console.WriteLine($"Is {{ 1, 2 }} a subset of Set A? " + (setA.IsSubsetOf(new HashSet<int> { 1, 2 })));
            //#endregion
            //Console.WriteLine("\n-----------------------------\n");
            //Console.WriteLine("\n--------------\n");
            #region Q5 Print Queue Simulator


            Queue<string> Simulator = new();
            Simulator.Enqueue("Report.pdf");
            Simulator.Enqueue("Invoice.pdf");
            Simulator.Enqueue("Letter.docx");
            Simulator.Enqueue("Resume.pdf");
            Simulator.Enqueue("Photo.jpg");
            Console.WriteLine(Simulator.Count);
            Console.WriteLine("Documents in queue: " + string.Join(", ", Simulator));
            Console.WriteLine("Next document to print: " + Simulator.Peek());

            // Process the queue
            while (Simulator.Count > 0)
            {
                Console.WriteLine("Printing: " + Simulator.Dequeue());
            }

            // Try TryDequeue on the now-empty queue
            if (!Simulator.TryDequeue(out string nextDocument))
            {
                Console.WriteLine("No more documents in the queue.");
            }


            #endregion

            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine("\n--------------\n");
            #region Q6
        
            Stack<string> browserHistory = new Stack<string>();
            browserHistory.Push("google.com");
            browserHistory.Push("github.com");
            browserHistory.Push("stackoverflow.com");
            browserHistory.Push("youtube.com");
            browserHistory.Push("claude.ai");
            Console.WriteLine("Current page: " + browserHistory.Peek());
            Console.WriteLine("Pressing back...");
            for (int i = 0; i < 3; i++)
            {
                if (browserHistory.Count > 0)
                {
                    string leftPage = browserHistory.Pop();
                    Console.WriteLine("Left page: " + leftPage);
                }
                else
                {
                    Console.WriteLine("No more pages to go back to.");
                    break;
                }
            }
            if (browserHistory.Count > 0)
            {
                Console.WriteLine("Current page after going back: " + browserHistory.Peek());
            }
            else
            {
                Console.WriteLine("No current page (history is empty).");
            }


            #endregion 

        }
    }
}
