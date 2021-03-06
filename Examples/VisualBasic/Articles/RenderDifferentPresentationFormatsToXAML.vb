﻿Imports Aspose.Tasks.Visualization
Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    Public Class RenderDifferentPresentationFormatsToXAML
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:RenderDifferentPresentationFormatsToXAML
            Dim project As New Project(dataDir & "Project2.mpp")

            Dim presentationFormat As PresentationFormat = presentationFormat.GanttChart
            Dim resultFile As String = "RenderDifferentPresentationFormatsToXAML_" & presentationFormat.ToString & "_out.xaml"
            Dim options As SaveOptions = New XamlOptions()
            options.PresentationFormat = presentationFormat

            project.Save(dataDir & resultFile, options)
            ' ExEnd:RenderDifferentPresentationFormatsToXAML
        End Sub
    End Class
End Namespace