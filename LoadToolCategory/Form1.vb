'Title:         Update Tool Asset Ability
'Date:          12-22-14
'Author:        Terry Holmes

'Description:   This program will update current asset status

Option Strict On

Public Class Form1

    'Setting up the controls
    Private TheToolsDataSet As ToolsDataSet
    Private TheToolsDataTier As ToolCategoryDataTier
    Private WithEvents TheToolsBindingSource As BindingSource

    Private TheToolCategoryDataSet As ToolCategoryDataSet
    Private TheToolCategoryDataTier As ToolCategoryDataTier
    Private WithEvents TheToolCategoryBindingSource As BindingSource

    'Setting global variables
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        'This will call the close program form
        CloseTheProgram.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'This will load the controls
        Try

            'Setting up the data controls
            TheToolsDataTier = New ToolCategoryDataTier
            TheToolsDataSet = TheToolsDataTier.GetToolsInformation
            TheToolsBindingSource = New BindingSource

            TheToolCategoryDataTier = New ToolCategoryDataTier
            TheToolCategoryDataSet = TheToolCategoryDataTier.GetToolCategoryInformation
            TheToolCategoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheToolsBindingSource
                .DataSource = TheToolsDataSet
                .DataMember = "tools"
                .MoveFirst()
                .MoveLast()
            End With

            With TheToolCategoryBindingSource
                .DataSource = TheToolCategoryDataSet
                .DataMember = "toolcategory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo boxes
            With cboToolKey
                .DataSource = TheToolsBindingSource
                .DisplayMember = "ToolKey"
                .DataBindings.Add("Text", TheToolsBindingSource, "ToolKey", False, DataSourceUpdateMode.Never)
            End With

            With cboCateogoryID
                .DataSource = TheToolCategoryBindingSource
                .DisplayMember = "CategoryID"
                .DataBindings.Add("text", TheToolCategoryBindingSource, "CategoryID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtAsset.DataBindings.Add("text", TheToolsBindingSource, "Asset")
            txtToolCat.DataBindings.Add("text", TheToolCategoryBindingSource, "ToolCategory")
            txtToolID.DataBindings.Add("text", TheToolsBindingSource, "ToolID")
            txtType.DataBindings.Add("text", TheToolsBindingSource, "Type")

        Catch ex As Exception

            'Message to use if there is a failure
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub SaveDataInformation()

        'Try Catch to catch exception
        Try

            TheToolsBindingSource.EndEdit()
            TheToolsDataTier.UpdateToolsDB(TheToolsDataSet)
            editingBoolean = False
            addingBoolean = False

        Catch ex As Exception

            'Message Box if there is an exception thrown
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnUpdateAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateAll.Click

        'This sub routine will run when the 

        'Setting local varibles
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer

        'Setting for the loop
        intNumberOfRecords = cboToolKey.Items.Count - 1

        'Preforming loop
        For intCounter = 0 To intNumberOfRecords

            'Setting incrementing the combo box
            cboToolKey.SelectedIndex = intCounter

            'Setting the text
            txtAsset.Text = "NO"

            'calling the save routine
            SaveDataInformation()

        Next

        Logon.mstrLastTransactionSummary = "CHANGED ALL TOOLS TO NOT BEING AN ASSET"
        LastTransaction.Show()

    End Sub

    Private Sub btnUpdateCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateCategory.Click

        'This will update tools to add them to the asset list

        'Setting local variables
        Dim intCategoryCounter As Integer
        Dim intCategoryNumberOfRecords As Integer
        Dim blnItemNotFound As Boolean = True
        Dim strToolCategoryForSearch As String
        Dim strToolCategoryFromTable As String
        Dim intCategorySelectedIndex As Integer
        Dim intToolCounter As Integer
        Dim intToolNumberOfRecords As Integer

        'Setting up data Validation
        strToolCategoryForSearch = txtEnterToolCategory.Text

        'Output to user if there is a problem
        If strToolCategoryForSearch = "" Then
            MessageBox.Show("No Text Was Entered", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Setting up for loop
        intCategoryNumberOfRecords = cboCateogoryID.Items.Count - 1

        'Performing search to verify category exists
        For intCategoryCounter = 0 To intCategoryNumberOfRecords

            'Incrementing the combo box
            cboCateogoryID.SelectedIndex = intCategoryCounter

            'Getting category from table
            strToolCategoryFromTable = txtToolCat.Text

            'If statement to verify the categories
            If strToolCategoryForSearch = strToolCategoryFromTable Then
                blnItemNotFound = False
                intCategorySelectedIndex = intCategoryCounter
            End If

        Next

        'Output to user if the category does not exist
        If blnItemNotFound = True Then
            txtEnterToolCategory.Text = ""
            MessageBox.Show("Category Entered Does Not Exist", "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'This places the combo box in the correct location
        cboCateogoryID.SelectedIndex = intCategorySelectedIndex

        'Setting up for the second loop
        intToolNumberOfRecords = cboToolKey.Items.Count - 1

        'Performing loop
        For intToolCounter = 0 To intToolNumberOfRecords

            'Incrementing the combo box
            cboToolKey.SelectedIndex = intToolCounter

            'Getting the category
            strToolCategoryFromTable = txtType.Text

            'Checking to see if the category matches
            If strToolCategoryForSearch = strToolCategoryFromTable Then

                'Setting the asset control
                txtAsset.Text = "YES"

                'Calling the saving sub routine
                SaveDataInformation()

            End If

        Next

        Logon.mstrLastTransactionSummary = "CHANGED ALL " + strToolCategoryForSearch + " TOOLS TO BEING AN ASSET"
        LastTransaction.Show()

    End Sub

    Private Sub btnSelectCategory_Click(sender As Object, e As EventArgs) Handles btnSelectCategory.Click

        'This will select the category and run the sub-routine
        txtEnterToolCategory.Text = txtToolCat.Text
        btnUpdateCategory.PerformClick()

    End Sub
End Class
