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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ClassesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseProjectDataSet = New DatabaseVB.DatabaseProjectDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClassesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ClassesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALPHAToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ALPHAToolStrip = New System.Windows.Forms.ToolStrip()
        Me.HighGPAToolStrip = New System.Windows.Forms.ToolStrip()
        Me.HighGPAToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Alpha1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Alpha1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EnrolledBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassesTableAdapter = New DatabaseVB.DatabaseProjectDataSetTableAdapters.ClassesTableAdapter()
        Me.TableAdapterManager = New DatabaseVB.DatabaseProjectDataSetTableAdapters.TableAdapterManager()
        Me.EnrolledTableAdapter = New DatabaseVB.DatabaseProjectDataSetTableAdapters.EnrolledTableAdapter()
        Me.StudentsTableAdapter = New DatabaseVB.DatabaseProjectDataSetTableAdapters.StudentsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CollegeAlgebraToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CollegeAlgebraToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HighIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.HighIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.ClassesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClassesBindingNavigator.SuspendLayout()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALPHAToolStrip.SuspendLayout()
        Me.HighGPAToolStrip.SuspendLayout()
        Me.Alpha1ToolStrip.SuspendLayout()
        CType(Me.EnrolledBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CollegeAlgebraToolStrip.SuspendLayout()
        Me.HighIDToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClassesBindingNavigator
        '
        Me.ClassesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClassesBindingNavigator.BindingSource = Me.StudentsBindingSource
        Me.ClassesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClassesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClassesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClassesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClassesBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.ClassesBindingNavigator.Location = New System.Drawing.Point(0, 348)
        Me.ClassesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClassesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClassesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClassesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClassesBindingNavigator.Name = "ClassesBindingNavigator"
        Me.ClassesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClassesBindingNavigator.Size = New System.Drawing.Size(445, 25)
        Me.ClassesBindingNavigator.TabIndex = 0
        Me.ClassesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ClassesBindingSource
        '
        Me.ClassesBindingSource.DataMember = "Classes"
        Me.ClassesBindingSource.DataSource = Me.DatabaseProjectDataSet
        '
        'DatabaseProjectDataSet
        '
        Me.DatabaseProjectDataSet.DataSetName = "DatabaseProjectDataSet"
        Me.DatabaseProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ClassesBindingNavigatorSaveItem
        '
        Me.ClassesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClassesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClassesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClassesBindingNavigatorSaveItem.Name = "ClassesBindingNavigatorSaveItem"
        Me.ClassesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClassesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 1, 10, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton1.Text = "   Exit   "
        '
        'ClassesDataGridView
        '
        Me.ClassesDataGridView.AutoGenerateColumns = False
        Me.ClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClassesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.GPADataGridViewTextBoxColumn})
        Me.ClassesDataGridView.DataSource = Me.StudentsBindingSource
        Me.ClassesDataGridView.Location = New System.Drawing.Point(-1, 121)
        Me.ClassesDataGridView.Name = "ClassesDataGridView"
        Me.ClassesDataGridView.Size = New System.Drawing.Size(445, 224)
        Me.ClassesDataGridView.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'GPADataGridViewTextBoxColumn
        '
        Me.GPADataGridViewTextBoxColumn.DataPropertyName = "GPA"
        Me.GPADataGridViewTextBoxColumn.HeaderText = "GPA"
        Me.GPADataGridViewTextBoxColumn.Name = "GPADataGridViewTextBoxColumn"
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.DatabaseProjectDataSet
        '
        'ALPHAToolStripButton
        '
        Me.ALPHAToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ALPHAToolStripButton.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.ALPHAToolStripButton.Name = "ALPHAToolStripButton"
        Me.ALPHAToolStripButton.Size = New System.Drawing.Size(59, 29)
        Me.ALPHAToolStripButton.Text = "Reset"
        '
        'ALPHAToolStrip
        '
        Me.ALPHAToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ALPHAToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ALPHAToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALPHAToolStripButton})
        Me.ALPHAToolStrip.Location = New System.Drawing.Point(-3, 17)
        Me.ALPHAToolStrip.Name = "ALPHAToolStrip"
        Me.ALPHAToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ALPHAToolStrip.Size = New System.Drawing.Size(62, 32)
        Me.ALPHAToolStrip.TabIndex = 3
        Me.ALPHAToolStrip.Text = "ALPHAToolStrip"
        '
        'HighGPAToolStrip
        '
        Me.HighGPAToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.HighGPAToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HighGPAToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HighGPAToolStripButton})
        Me.HighGPAToolStrip.Location = New System.Drawing.Point(62, 13)
        Me.HighGPAToolStrip.Name = "HighGPAToolStrip"
        Me.HighGPAToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HighGPAToolStrip.Size = New System.Drawing.Size(91, 32)
        Me.HighGPAToolStrip.TabIndex = 4
        Me.HighGPAToolStrip.Text = "HighGPAToolStrip"
        '
        'HighGPAToolStripButton
        '
        Me.HighGPAToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HighGPAToolStripButton.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.HighGPAToolStripButton.Name = "HighGPAToolStripButton"
        Me.HighGPAToolStripButton.Size = New System.Drawing.Size(88, 29)
        Me.HighGPAToolStripButton.Text = "HighGPA"
        '
        'Alpha1ToolStrip
        '
        Me.Alpha1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Alpha1ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Alpha1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Alpha1ToolStripButton})
        Me.Alpha1ToolStrip.Location = New System.Drawing.Point(156, 13)
        Me.Alpha1ToolStrip.Name = "Alpha1ToolStrip"
        Me.Alpha1ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Alpha1ToolStrip.Size = New System.Drawing.Size(65, 32)
        Me.Alpha1ToolStrip.TabIndex = 5
        Me.Alpha1ToolStrip.Text = "Alpha1ToolStrip"
        '
        'Alpha1ToolStripButton
        '
        Me.Alpha1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Alpha1ToolStripButton.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Alpha1ToolStripButton.Name = "Alpha1ToolStripButton"
        Me.Alpha1ToolStripButton.Size = New System.Drawing.Size(62, 29)
        Me.Alpha1ToolStripButton.Text = "Alpha"
        '
        'EnrolledBindingSource
        '
        Me.EnrolledBindingSource.DataMember = "Enrolled"
        Me.EnrolledBindingSource.DataSource = Me.DatabaseProjectDataSet
        '
        'ClassesTableAdapter
        '
        Me.ClassesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassesTableAdapter = Me.ClassesTableAdapter
        Me.TableAdapterManager.EnrolledTableAdapter = Me.EnrolledTableAdapter
        Me.TableAdapterManager.StudentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = DatabaseVB.DatabaseProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EnrolledTableAdapter
        '
        Me.EnrolledTableAdapter.ClearBeforeFill = True
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.CollegeAlgebraToolStrip)
        Me.Panel1.Controls.Add(Me.HighIDToolStrip)
        Me.Panel1.Controls.Add(Me.ALPHAToolStrip)
        Me.Panel1.Location = New System.Drawing.Point(0, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 52)
        Me.Panel1.TabIndex = 6
        '
        'CollegeAlgebraToolStrip
        '
        Me.CollegeAlgebraToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.CollegeAlgebraToolStrip.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.CollegeAlgebraToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.CollegeAlgebraToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CollegeAlgebraToolStripButton})
        Me.CollegeAlgebraToolStrip.Location = New System.Drawing.Point(302, 17)
        Me.CollegeAlgebraToolStrip.Name = "CollegeAlgebraToolStrip"
        Me.CollegeAlgebraToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CollegeAlgebraToolStrip.Size = New System.Drawing.Size(149, 32)
        Me.CollegeAlgebraToolStrip.TabIndex = 7
        Me.CollegeAlgebraToolStrip.Text = "CollegeAlgebraToolStrip"
        '
        'CollegeAlgebraToolStripButton
        '
        Me.CollegeAlgebraToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CollegeAlgebraToolStripButton.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CollegeAlgebraToolStripButton.Name = "CollegeAlgebraToolStripButton"
        Me.CollegeAlgebraToolStripButton.Size = New System.Drawing.Size(146, 29)
        Me.CollegeAlgebraToolStripButton.Text = "CollegeAlgebra"
        '
        'HighIDToolStrip
        '
        Me.HighIDToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.HighIDToolStrip.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.HighIDToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HighIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HighIDToolStripButton})
        Me.HighIDToolStrip.Location = New System.Drawing.Point(224, 17)
        Me.HighIDToolStrip.Name = "HighIDToolStrip"
        Me.HighIDToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HighIDToolStrip.Size = New System.Drawing.Size(75, 32)
        Me.HighIDToolStrip.TabIndex = 7
        Me.HighIDToolStrip.Text = "HighIDToolStrip"
        '
        'HighIDToolStripButton
        '
        Me.HighIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HighIDToolStripButton.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.HighIDToolStripButton.Name = "HighIDToolStripButton"
        Me.HighIDToolStripButton.Size = New System.Drawing.Size(72, 29)
        Me.HighIDToolStripButton.Text = "HighID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Last Name"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(200, 23)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox2.Location = New System.Drawing.Point(233, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(200, 23)
        Me.TextBox2.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 373)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Alpha1ToolStrip)
        Me.Controls.Add(Me.HighGPAToolStrip)
        Me.Controls.Add(Me.ClassesDataGridView)
        Me.Controls.Add(Me.ClassesBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Student Database"
        CType(Me.ClassesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClassesBindingNavigator.ResumeLayout(False)
        Me.ClassesBindingNavigator.PerformLayout()
        CType(Me.ClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALPHAToolStrip.ResumeLayout(False)
        Me.ALPHAToolStrip.PerformLayout()
        Me.HighGPAToolStrip.ResumeLayout(False)
        Me.HighGPAToolStrip.PerformLayout()
        Me.Alpha1ToolStrip.ResumeLayout(False)
        Me.Alpha1ToolStrip.PerformLayout()
        CType(Me.EnrolledBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CollegeAlgebraToolStrip.ResumeLayout(False)
        Me.CollegeAlgebraToolStrip.PerformLayout()
        Me.HighIDToolStrip.ResumeLayout(False)
        Me.HighIDToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseProjectDataSet As DatabaseVB.DatabaseProjectDataSet
    Friend WithEvents ClassesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassesTableAdapter As DatabaseVB.DatabaseProjectDataSetTableAdapters.ClassesTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseVB.DatabaseProjectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClassesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClassesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClassesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StudentsTableAdapter As DatabaseVB.DatabaseProjectDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnrolledTableAdapter As DatabaseVB.DatabaseProjectDataSetTableAdapters.EnrolledTableAdapter
    Friend WithEvents EnrolledBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALPHAToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ALPHAToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents HighGPAToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents HighGPAToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alpha1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Alpha1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HighIDToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents HighIDToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CollegeAlgebraToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CollegeAlgebraToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
