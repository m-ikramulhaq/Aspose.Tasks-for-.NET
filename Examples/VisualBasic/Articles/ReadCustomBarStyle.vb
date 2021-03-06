﻿Imports Aspose.Tasks.Visualization
Imports System.Drawing

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    Public Class ReadCustomBarStyle
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ReadCustomBarStyle
            Dim project As New Project(dataDir + "CustomBarStyle.mpp")

            Dim view As GanttChartView = TryCast(project.DefaultView, GanttChartView)
            Console.WriteLine("Custom bar styles count: {0}", view.CustomBarStyles.Count)

            Dim style1 As GanttBarStyle = view.CustomBarStyles(0)

            Console.WriteLine("Style1.LeftField is TaskDurationText : {0}", style1.LeftField.Equals(Field.TaskDurationText))
            Console.WriteLine("Style1.RightField is TaskResourceNames : {0}", style1.RightField.Equals(Field.TaskResourceNames))
            Console.WriteLine("Style1.TopField is TaskACWP: {0}", style1.TopField.Equals(Field.TaskACWP))
            Console.WriteLine("Style1.BottomField is Undefined : {0}", style1.BottomField.Equals(Field.Undefined))
            Console.WriteLine("Style1.InsideField is Undefined : {0}", style1.InsideField.Equals(Field.Undefined))

            Dim style2 As GanttBarStyle = view.CustomBarStyles(1)
            Console.WriteLine("Style2.LeftField is TaskActualWork : {0}", style2.LeftField.Equals(Field.TaskActualWork))
            Console.WriteLine("Style2.RightField is TaskActualCost : {0}", style2.RightField.Equals(Field.TaskActualCost))
            Console.WriteLine("Style2.TopField is Undefined : {0}", style2.TopField.Equals(Field.Undefined))
            Console.WriteLine("Style2.BottomField is Undefined : {0}", style2.BottomField.Equals(Field.Undefined))
            Console.WriteLine("Style2.InsideField is Undefined : {0}", style2.InsideField.Equals(Field.Undefined))

            Dim style3 As GanttBarStyle = view.CustomBarStyles(2)
            Console.WriteLine("Style3.LeftField is TaskPercentComplete : {0}", style3.LeftField.Equals(Field.TaskPercentComplete))
            Console.WriteLine("Style3.RightField is TaskPercentWorkComplete : {0}", style3.RightField.Equals(Field.TaskPercentWorkComplete))
            Console.WriteLine("Style3.TopField is Field.TaskActive : {0}", style3.TopField.Equals(Field.TaskActive))
            Console.WriteLine("Style3.BottomField is TaskActualCost : {0}", style3.BottomField.Equals(Field.TaskActualCost))
            Console.WriteLine("Style3.InsideField is Field.TaskActualDuration : {0}", style3.InsideField.Equals(Field.TaskActualDuration))

            Console.WriteLine("Style3.StartShape is HouseDown : {0}", style3.StartShape.Equals(GanttBarEndShape.HouseDown))
            Console.WriteLine("Style3.StartShapeType is Framed : {0}", style3.StartShapeType.Equals(GanttBarType.Framed))
            Console.WriteLine("Style3.StartShapeColor is Red : {0}", style3.StartShapeColor.Equals(Color.FromArgb(Color.Red.ToArgb())))

            Console.WriteLine("Style3.EndShape is CircleDiamond : {0}", style3.EndShape.Equals(GanttBarEndShape.CircleDiamond))
            Console.WriteLine("Style3.EndShapeType is Solid : {0}", style3.EndShapeType.Equals(GanttBarType.Solid))
            Console.WriteLine("Style3.EndShapeColor is Yellow : {0}", style3.EndShapeColor.Equals(Color.FromArgb(Color.Yellow.ToArgb())))

            Console.WriteLine("Style3.MiddleShape is RectangleTop : {0}", style3.MiddleShape.Equals(GanttBarMiddleShape.RectangleTop))
            Console.WriteLine("Style3.MiddleFillPattern is SolidFill : {0}", style3.MiddleFillPattern.Equals(GanttBarFillPattern.SolidFill))
            Console.WriteLine("Style3.EndShapeColor is Red : {0}", style3.MiddleShapeColor.Equals(Color.FromArgb(Color.Red.ToArgb())))
            ' ExEnd:ReadCustomBarStyle
        End Sub
    End Class
End Namespace