// <SnippetMainPageCodeFull>
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ItemsControlGroupingSnippets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DateTime startDate;
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DateTime.TryParse("1/1/2014", out startDate);

            PopulateProjects();
            PopulateActivities();
        }

        private void PopulateActivities()
        {
            // <SnippetPopulateActivities>
            List<Activity> Activities = new List<Activity>();

            Activities.Add(new Activity() 
                { Name = "Activity 1", Complete = true, 
                    DueDate = startDate.AddDays(4), Project = "Project 1" });
            Activities.Add(new Activity() 
                { Name = "Activity 2", Complete = true, 
                    DueDate = startDate.AddDays(5), Project = "Project 1" });
            Activities.Add(new Activity() 
                { Name = "Activity 3", Complete = false, 
                    DueDate = startDate.AddDays(7), Project = "Project 1" });
            Activities.Add(new Activity() 
                { Name = "Activity 4", Complete = false, 
                    DueDate = startDate.AddDays(9), Project = "Project 1" });
            Activities.Add(new Activity() 
                { Name = "Activity 5", Complete = false, 
                    DueDate = startDate.AddDays(14), Project = "Project 1" });
            Activities.Add(new Activity() 
                { Name = "Activity A", Complete = true, 
                    DueDate = startDate.AddDays(2), Project = "Project 2" });
            Activities.Add(new Activity() 
                { Name = "Activity B", Complete = false, 
                    DueDate = startDate.AddDays(4), Project = "Project 2" });
            Activities.Add(new Activity() 
                { Name = "Activity C", Complete = true, 
                    DueDate = startDate.AddDays(5), Project = "Project 2" });
            Activities.Add(new Activity() 
                { Name = "Activity D", Complete = false, 
                    DueDate = startDate.AddDays(9), Project = "Project 2" });
            Activities.Add(new Activity() 
                { Name = "Activity E", Complete = false, 
                    DueDate = startDate.AddDays(18), Project = "Project 2" });

            var result = from act in Activities group act by act.Project into grp orderby grp.Key select grp;
            cvsActivities.Source = result;
            // </SnippetPopulateActivities>
        }

        private void PopulateProjects()
        {
            // <SnippetPopulateProjects>
            List<Project> Projects = new List<Project>();

            Project newProject = new Project();
            newProject.Name = "Project 1";
            newProject.Activities.Add(new Activity() 
                { Name = "Activity 1", Complete = true, DueDate = startDate.AddDays(4) });
            newProject.Activities.Add(new Activity() 
                { Name = "Activity 2", Complete = true, DueDate = startDate.AddDays(5) });
            newProject.Activities.Add(new Activity() 
                { Name = "Activity 3", Complete = false, DueDate = startDate.AddDays(7) });
            newProject.Activities.Add(new Activity() 
                { Name = "Activity 4", Complete = false, DueDate = startDate.AddDays(9) });
            newProject.Activities.Add(new Activity() 
                { Name = "Activity 5", Complete = false, DueDate = startDate.AddDays(14) });
            Projects.Add(newProject);

            newProject = new Project();
            newProject.Name = "Project 2";
            newProject.Activities.Add(new Activity() 
                { Name = "Activity A", Complete = true, DueDate = startDate.AddDays(2) });
            newProject.Activities.Add(new Activity() 
                { Name = "Activity B", Complete = false, DueDate = startDate.AddDays(3) });
            newProject.Activities.Add(new Activity() 
                { Name = "Activity C", Complete = true, DueDate = startDate.AddDays(5) });
            newProject.Activities.Add(new Activity() 
                { Name = "Activity D", Complete = false, DueDate = startDate.AddDays(9) });
            newProject.Activities.Add(new Activity() 
                { Name = "Activity E", Complete = false, DueDate = startDate.AddDays(18) });
            Projects.Add(newProject);

            newProject = new Project();
            newProject.Name = "Project 3";
            Projects.Add(newProject);

            cvsProjects.Source = Projects;
            // </SnippetPopulateProjects>
        }

    }

    // <SnippetGroupStyleSelector>
    public class ListGroupStyleSelector : GroupStyleSelector
    {
        protected override GroupStyle SelectGroupStyleCore(object group, uint level)
        {
            return (GroupStyle)App.Current.Resources["listViewGroupStyle"];
        }
    }
    // </SnippetGroupStyleSelector>

    // <SnippetProjectClassDefinition>
    public class Project
    {
        public Project()
        {
            Activities = new ObservableCollection<Activity>();
        }

        public string Name { get; set; }
        public ObservableCollection<Activity> Activities { get; private set; }
    }
    // </SnippetProjectClassDefinition>

    // <SnippetActivityClassDefinition>   
    public class Activity
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }
        public string Project { get; set; }
    }
    // </SnippetActivityClassDefinition>
}
// </SnippetMainPageCodeFull>
