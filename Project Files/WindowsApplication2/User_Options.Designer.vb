<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Options))
        Me.User_List_B = New System.Windows.Forms.Button()
        Me.Notes_Button = New System.Windows.Forms.Button()
        Me.Images_Button = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProjectDataSet1 = New WindowsApplication2.PROJECTDataSet()
        Me.AccessTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.ACCESSTableAdapter()
        Me.UsersTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.UsersTableAdapter()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User_List_B
        '
        Me.User_List_B.BackgroundImage = CType(resources.GetObject("User_List_B.BackgroundImage"), System.Drawing.Image)
        Me.User_List_B.Cursor = System.Windows.Forms.Cursors.Default
        Me.User_List_B.Enabled = False
        Me.User_List_B.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.User_List_B.FlatAppearance.BorderSize = 5
        Me.User_List_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.User_List_B.Location = New System.Drawing.Point(50, 50)
        Me.User_List_B.Margin = New System.Windows.Forms.Padding(0)
        Me.User_List_B.Name = "User_List_B"
        Me.User_List_B.Size = New System.Drawing.Size(205, 205)
        Me.User_List_B.TabIndex = 0
        Me.User_List_B.UseVisualStyleBackColor = True
        '
        'Notes_Button
        '
        Me.Notes_Button.BackgroundImage = CType(resources.GetObject("Notes_Button.BackgroundImage"), System.Drawing.Image)
        Me.Notes_Button.Enabled = False
        Me.Notes_Button.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Notes_Button.FlatAppearance.BorderSize = 5
        Me.Notes_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Notes_Button.Location = New System.Drawing.Point(260, 50)
        Me.Notes_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Notes_Button.Name = "Notes_Button"
        Me.Notes_Button.Size = New System.Drawing.Size(205, 205)
        Me.Notes_Button.TabIndex = 1
        Me.Notes_Button.UseVisualStyleBackColor = True
        '
        'Images_Button
        '
        Me.Images_Button.BackgroundImage = CType(resources.GetObject("Images_Button.BackgroundImage"), System.Drawing.Image)
        Me.Images_Button.Enabled = False
        Me.Images_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.Images_Button.FlatAppearance.BorderSize = 5
        Me.Images_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Images_Button.Location = New System.Drawing.Point(50, 260)
        Me.Images_Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Images_Button.Name = "Images_Button"
        Me.Images_Button.Size = New System.Drawing.Size(205, 205)
        Me.Images_Button.TabIndex = 2
        Me.Images_Button.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button4.FlatAppearance.BorderSize = 5
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(260, 260)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(205, 205)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(234, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UserName       "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(440, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        '
        'ToolTip2
        '
        Me.ToolTip2.AutomaticDelay = 0
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ProjectDataSet1
        '
        Me.ProjectDataSet1.DataSetName = "PROJECTDataSet"
        Me.ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccessTableAdapter1
        '
        Me.AccessTableAdapter1.ClearBeforeFill = True
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'ToolTip3
        '
        Me.ToolTip3.AutomaticDelay = 0
        Me.ToolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ToolTip4
        '
        Me.ToolTip4.AutomaticDelay = 0
        Me.ToolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ToolTip5
        '
        Me.ToolTip5.AutomaticDelay = 0
        Me.ToolTip5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'User_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 511)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Images_Button)
        Me.Controls.Add(Me.Notes_Button)
        Me.Controls.Add(Me.User_List_B)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User_Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents User_List_B As Button
    Friend WithEvents Notes_Button As Button
    Friend WithEvents Images_Button As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ProjectDataSet1 As PROJECTDataSet
    Friend WithEvents AccessTableAdapter1 As PROJECTDataSetTableAdapters.ACCESSTableAdapter
    Friend WithEvents UsersTableAdapter1 As PROJECTDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
End Class
