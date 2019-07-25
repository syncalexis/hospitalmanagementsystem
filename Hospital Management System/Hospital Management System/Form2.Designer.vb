<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.qweqwe = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.qweqwe.SuspendLayout
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(481, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'qweqwe
        '
        Me.qweqwe.Controls.Add(Me.Button1)
        Me.qweqwe.Controls.Add(Me.deleteBtn)
        Me.qweqwe.Controls.Add(Me.editBtn)
        Me.qweqwe.Controls.Add(Me.addbtn)
        Me.qweqwe.Controls.Add(Me.searchbtn)
        Me.qweqwe.Controls.Add(Me.searchBox)
        Me.qweqwe.Controls.Add(Me.Label1)
        Me.qweqwe.Location = New System.Drawing.Point(7, 7)
        Me.qweqwe.Name = "qweqwe"
        Me.qweqwe.Size = New System.Drawing.Size(461, 159)
        Me.qweqwe.TabIndex = 1
        Me.qweqwe.TabStop = False
        Me.qweqwe.Text = "Manage"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(380, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(380, 101)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.deleteBtn.TabIndex = 5
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(380, 72)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(75, 23)
        Me.editBtn.TabIndex = 4
        Me.editBtn.Text = "EDIT"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Location = New System.Drawing.Point(380, 43)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(75, 23)
        Me.addbtn.TabIndex = 3
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'searchbtn
        '
        Me.searchbtn.Location = New System.Drawing.Point(25, 118)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(75, 23)
        Me.searchbtn.TabIndex = 2
        Me.searchbtn.Text = "SERCH"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(134, 121)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(184, 20)
        Me.searchBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOSPITAL MANAGEMENT SYSTEM"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 326)
        Me.Controls.Add(Me.qweqwe)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.qweqwe.ResumeLayout(False)
        Me.qweqwe.PerformLayout
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents qweqwe As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents searchbtn As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents Label1 As Label
End Class
