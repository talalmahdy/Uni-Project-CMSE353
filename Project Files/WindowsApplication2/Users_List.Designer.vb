<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Users_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users_List))
        Me.UsersList = New System.Windows.Forms.ListBox()
        Me.ProjectDataSet1 = New WindowsApplication2.PROJECTDataSet()
        Me.addnew = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.UsersTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.UsersTableAdapter()
        Me.AccessTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.ACCESSTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsersList
        '
        Me.UsersList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsersList.DataSource = Me.ProjectDataSet1
        Me.UsersList.DisplayMember = "Users.User_Name"
        Me.UsersList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersList.FormattingEnabled = True
        Me.UsersList.ItemHeight = 20
        Me.UsersList.Location = New System.Drawing.Point(342, 12)
        Me.UsersList.Name = "UsersList"
        Me.UsersList.Size = New System.Drawing.Size(137, 260)
        Me.UsersList.TabIndex = 0
        Me.UsersList.ValueMember = "Users.ID"
        '
        'ProjectDataSet1
        '
        Me.ProjectDataSet1.DataSetName = "PROJECTDataSet"
        Me.ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'addnew
        '
        Me.addnew.BackgroundImage = CType(resources.GetObject("addnew.BackgroundImage"), System.Drawing.Image)
        Me.addnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addnew.FlatAppearance.BorderSize = 0
        Me.addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addnew.Location = New System.Drawing.Point(431, 288)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(30, 30)
        Me.addnew.TabIndex = 1
        Me.addnew.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectDataSet1, "Users.User_Name", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(47, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(159, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectDataSet1, "Users.Password", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(47, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(159, 26)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(157, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'delete
        '
        Me.delete.BackgroundImage = CType(resources.GetObject("delete.BackgroundImage"), System.Drawing.Image)
        Me.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete.FlatAppearance.BorderSize = 0
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(369, 288)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(30, 30)
        Me.delete.TabIndex = 6
        Me.delete.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProjectDataSet1, "Users.Admin", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(113, 139)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Admin"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Location = New System.Drawing.Point(26, 184)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "Users"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Location = New System.Drawing.Point(113, 184)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox3.TabIndex = 9
        Me.CheckBox3.Text = "Notes"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox4.Location = New System.Drawing.Point(200, 184)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "Images"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'AccessTableAdapter1
        '
        Me.AccessTableAdapter1.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Stone Inf OS ITC TT", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(80, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Stone Inf OS ITC TT", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(75, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "User Name"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(26, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 33)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.IsBalloon = True
        '
        'Users_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 330)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.addnew)
        Me.Controls.Add(Me.UsersList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Users_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsersList As ListBox
    Friend WithEvents addnew As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents delete As Button
    Friend WithEvents ProjectDataSet1 As PROJECTDataSet
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents UsersTableAdapter1 As PROJECTDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents AccessTableAdapter1 As PROJECTDataSetTableAdapters.ACCESSTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
