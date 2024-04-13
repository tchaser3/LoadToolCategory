<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboToolKey = New System.Windows.Forms.ComboBox()
        Me.txtToolID = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtAsset = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtToolCat = New System.Windows.Forms.TextBox()
        Me.cboCateogoryID = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEnterToolCategory = New System.Windows.Forms.TextBox()
        Me.btnUpdateCategory = New System.Windows.Forms.Button()
        Me.btnUpdateAll = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSelectCategory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboToolKey
        '
        Me.cboToolKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboToolKey.FormattingEnabled = True
        Me.cboToolKey.Location = New System.Drawing.Point(141, 143)
        Me.cboToolKey.Name = "cboToolKey"
        Me.cboToolKey.Size = New System.Drawing.Size(121, 21)
        Me.cboToolKey.TabIndex = 2
        '
        'txtToolID
        '
        Me.txtToolID.Location = New System.Drawing.Point(141, 171)
        Me.txtToolID.Name = "txtToolID"
        Me.txtToolID.ReadOnly = True
        Me.txtToolID.Size = New System.Drawing.Size(121, 20)
        Me.txtToolID.TabIndex = 1
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(141, 197)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(121, 20)
        Me.txtType.TabIndex = 2
        '
        'txtAsset
        '
        Me.txtAsset.Location = New System.Drawing.Point(141, 223)
        Me.txtAsset.Name = "txtAsset"
        Me.txtAsset.ReadOnly = True
        Me.txtAsset.Size = New System.Drawing.Size(121, 20)
        Me.txtAsset.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tool Key"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tool ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Type"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Asset"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(300, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tool Cat."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(300, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Category ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtToolCat
        '
        Me.txtToolCat.Location = New System.Drawing.Point(406, 172)
        Me.txtToolCat.Name = "txtToolCat"
        Me.txtToolCat.ReadOnly = True
        Me.txtToolCat.Size = New System.Drawing.Size(121, 20)
        Me.txtToolCat.TabIndex = 4
        '
        'cboCateogoryID
        '
        Me.cboCateogoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCateogoryID.FormattingEnabled = True
        Me.cboCateogoryID.Location = New System.Drawing.Point(406, 144)
        Me.cboCateogoryID.Name = "cboCateogoryID"
        Me.cboCateogoryID.Size = New System.Drawing.Size(121, 21)
        Me.cboCateogoryID.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(534, 42)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Update Tool Asset Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Enter Tool Category"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEnterToolCategory
        '
        Me.txtEnterToolCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnterToolCategory.Location = New System.Drawing.Point(207, 76)
        Me.txtEnterToolCategory.Name = "txtEnterToolCategory"
        Me.txtEnterToolCategory.Size = New System.Drawing.Size(121, 20)
        Me.txtEnterToolCategory.TabIndex = 0
        '
        'btnUpdateCategory
        '
        Me.btnUpdateCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCategory.Location = New System.Drawing.Point(346, 68)
        Me.btnUpdateCategory.Name = "btnUpdateCategory"
        Me.btnUpdateCategory.Size = New System.Drawing.Size(145, 35)
        Me.btnUpdateCategory.TabIndex = 1
        Me.btnUpdateCategory.Text = "Update Category"
        Me.btnUpdateCategory.UseVisualStyleBackColor = True
        '
        'btnUpdateAll
        '
        Me.btnUpdateAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAll.Location = New System.Drawing.Point(293, 210)
        Me.btnUpdateAll.Name = "btnUpdateAll"
        Me.btnUpdateAll.Size = New System.Drawing.Size(107, 55)
        Me.btnUpdateAll.TabIndex = 5
        Me.btnUpdateAll.Text = "Update All"
        Me.btnUpdateAll.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(359, 284)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 55)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSelectCategory
        '
        Me.btnSelectCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectCategory.Location = New System.Drawing.Point(420, 210)
        Me.btnSelectCategory.Name = "btnSelectCategory"
        Me.btnSelectCategory.Size = New System.Drawing.Size(107, 55)
        Me.btnSelectCategory.TabIndex = 6
        Me.btnSelectCategory.Text = "Select Category"
        Me.btnSelectCategory.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSelectCategory)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdateAll)
        Me.Controls.Add(Me.btnUpdateCategory)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEnterToolCategory)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtToolCat)
        Me.Controls.Add(Me.cboCateogoryID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAsset)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtToolID)
        Me.Controls.Add(Me.cboToolKey)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Tool Asset Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboToolKey As System.Windows.Forms.ComboBox
    Friend WithEvents txtToolID As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtAsset As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtToolCat As System.Windows.Forms.TextBox
    Friend WithEvents cboCateogoryID As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEnterToolCategory As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateCategory As System.Windows.Forms.Button
    Friend WithEvents btnUpdateAll As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSelectCategory As System.Windows.Forms.Button

End Class
