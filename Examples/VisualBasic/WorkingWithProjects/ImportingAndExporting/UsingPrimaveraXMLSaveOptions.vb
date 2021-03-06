﻿Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace WorkingWithProjects.ImportingAndExporting
    Public Class UsingPrimaveraXMLSaveOptions
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)


            ' ExStart:UsingPrimaveraXMLSaveOptions
            Dim project As New Project(dataDir + "project.xml")

            ' Specify xml save options
            Dim options As New PrimaveraXmlSaveOptions()
            options.SaveRootTask = False
            project.Save("UsingPrimaveraXMLSaveOptions_out.xml", options)
            ' ExEnd:UsingPrimaveraXMLSaveOptions
        End Sub
    End Class
End Namespace
