using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.CreatingReadingAndSaving
{
    public class SaveProjectDataAsHTML
    {
        public static void Run()
        {
            // ExStart:SaveProjectDataAsHTML
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName); 
            Project project = new Project(dataDir + "CreateProject2.mpp");
            HtmlSaveOptions option = new HtmlSaveOptions();
            project.Save(dataDir + "SaveProjectDataAsHTML_out.html", option);

            // OR

            project = new Project(dataDir + "CreateProject2.mpp");
            option = new HtmlSaveOptions();
            option.Pages.Add(2); // Adding only one page (page number 2)
            project.Save(dataDir + "SaveProjectDataAsHTML2_out.html", option);
            // ExEnd:SaveProjectDataAsHTML
        }
    }
}