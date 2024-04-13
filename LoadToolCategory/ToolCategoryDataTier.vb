'Title:         Tool Category Data Tier
'Date:          12-22-14
'Author:        Terry Holmes

'Description:   This is the data tier for the application

Option Strict On

Public Class ToolCategoryDataTier

    'Setting up global variables
    Private aToolsDataTableAdapters As ToolsDataSetTableAdapters.toolsTableAdapter
    Private aToolsDataSet As ToolsDataSet

    Private aToolCategoryDataSetTableAdapters As ToolCategoryDataSetTableAdapters.toolcategoryTableAdapter
    Private aToolCategoryDataSet As ToolCategoryDataSet

    'Setting up the Functions
    Public Function GetToolsInformation() As ToolsDataSet

        'Setting up try catch
        Try

            aToolsDataSet = New ToolsDataSet
            aToolsDataTableAdapters = New ToolsDataSetTableAdapters.toolsTableAdapter
            aToolsDataTableAdapters.Fill(aToolsDataSet.tools)
            Return aToolsDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aToolsDataSet
        End Try

    End Function

    'Sub routine to updata tools data set
    Public Sub UpdateToolsDB(ByVal aToolsDataSet As ToolsDataSet)

        'Try Catch to capture thrown exceptions
        Try
            aToolsDataTableAdapters.Update(aToolsDataSet.tools)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Function GetToolCategoryInformation() As ToolCategoryDataSet

        'Setting up try catch
        Try

            aToolCategoryDataSet = New ToolCategoryDataSet
            aToolCategoryDataSetTableAdapters = New ToolCategoryDataSetTableAdapters.toolcategoryTableAdapter
            aToolCategoryDataSetTableAdapters.Fill(aToolCategoryDataSet.toolcategory)
            Return aToolCategoryDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aToolCategoryDataSet
        End Try

    End Function

    'Sub routine to updata tools data set
    Public Sub UpdateToolCategoryDB(ByVal aToolCategoryDataSet As ToolCategoryDataSet)

        'Try Catch to capture thrown exceptions
        Try
            aToolCategoryDataSetTableAdapters.Update(aToolCategoryDataSet.toolcategory)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
