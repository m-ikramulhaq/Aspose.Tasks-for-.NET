﻿Imports Aspose.Tasks.Visualization

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Miscellaneous
    Public Class SaveLateTasksReport
        Public Shared Sub Run()
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:SaveLateTasksReport
            Dim project1 As New Project(dataDir & "Residential Construction.mpp")
            project1.SaveReport(dataDir & "LateTasks_out.pdf", ReportType.LateTasks)
            ' ExEnd:SaveLateTasksReport
        End Sub
    End Class
End Namespace