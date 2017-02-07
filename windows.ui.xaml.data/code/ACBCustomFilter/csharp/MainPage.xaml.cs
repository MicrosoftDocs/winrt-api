using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace ACBCustomFilter
{
    public partial class MainPage : UserControl
    {
        // Use snippets 1,10,11,13,14,16 for custom string search.
        // Use snippets 1,10,12,13,15,16 for custom object search.

        //<snippet10>
        List<Employee> employees = new List<Employee>();
        public MainPage()
        {
            InitializeComponent();
            // Add some items to the employee list.
            employees.Add(new Employee("Sells", "Chris", "csells", 1234));
            employees.Add(new Employee("Cabatana", "Reina", "rcaba", 5678));
            employees.Add(new Employee("Sprenger", "Christof", "cspreng", 9123));
            employees.Add(new Employee("Brandel", "Jonas", "jbrandel", 4567));
            employees.Add(new Employee("Bye", "Dennis", "dbye", 8912));
            employees.Add(new Employee("Reid", "Miles", "mreid", 3456));

            // Set the item source.
            //myACB.ItemsSource = employees;
            //</snippet10>

            //<snippet11>
            // Set the TextFilter property to the search method.
            //myACB.TextFilter += SearchEmployees;
            //</snippet11>

            //<snippet12>
            // Set the ItemFilter property to the search method.
            //myACB.ItemFilter += SearchEmployees;
            //</snippet12>
            //<snippet13>
        }
        //</snippet13>

        //<snippet14>
        bool SearchEmployees(string search, string value)
        {
            value = value.ToLower();
            // Split the string a new line.
            string[] words = value.Split(System.Environment.NewLine.ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            string[] names = words[0].Split(' ');

            // Look for a match in the first line; discarding the "employee:" entry.
            foreach (string name in names)
            {
                if (name != "employee:")
                    if (name.StartsWith(search))
                        return true;
            }
            // If no match, return false.
            return false;
        }
        //</snippet14>

        //<snippet15>
        bool SearchEmployees(string search, object value)
        {
            // Cast the value to an Employee.
            Employee emp = value as Employee;
            if (emp != null)
            {
                // Look for a match in the first and last names.
                if (emp.LastName.ToLower().StartsWith(search))
                    return true;

                else if (emp.FirstName.ToLower().StartsWith(search))
                    return true;
            }
            // If no match, return false.
            return false;
        }
        //</snippet15>
    }

    //<snippet16>
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailName { get; set; }
        public int ID { get; set; }
        public Employee(string empLastName, string empFirstName, string empEmail, int empID)
        {
            LastName = empLastName;
            FirstName = empFirstName;
            EmailName = empEmail;
            ID = empID;
        }
        public override string ToString()
        {
            return "Employee: " + FirstName + " " + 
                LastName + System.Environment.NewLine + 
                "Email: " + EmailName + System.Environment.NewLine + "ID: " +
                ID.ToString();
        }
    }
    //</snippet16>
}
