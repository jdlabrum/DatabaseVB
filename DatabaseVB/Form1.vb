Public Class Form1

    Private Sub ClassesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClassesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseProjectDataSet)

    End Sub


    Private Sub StudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseProjectDataSet)

    End Sub


    Private Sub ClassesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClassesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseProjectDataSet)

    End Sub


    Private Sub ClassesBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles ClassesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClassesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseProjectDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseProjectDataSet.Enrolled' table. You can move, or remove it, as needed.
        Me.EnrolledTableAdapter.Fill(Me.DatabaseProjectDataSet.Enrolled)
        'TODO: This line of code loads data into the 'DatabaseProjectDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.DatabaseProjectDataSet.Students)
        'TODO: This line of code loads data into the 'DatabaseProjectDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.DatabaseProjectDataSet.Classes)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.EnrolledTableAdapter.FillBy1(Me.DatabaseProjectDataSet.Enrolled)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub ALPHAToolStripButton_Click(sender As Object, e As EventArgs) Handles ALPHAToolStripButton.Click
        Try
            Me.StudentsTableAdapter.ALPHA(Me.DatabaseProjectDataSet.Students)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub HighGPAToolStripButton_Click(sender As Object, e As EventArgs) Handles HighGPAToolStripButton.Click
        Try
            Me.StudentsTableAdapter.HighGPA(Me.DatabaseProjectDataSet.Students)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Alpha1ToolStripButton_Click(sender As Object, e As EventArgs) Handles Alpha1ToolStripButton.Click
        Try
            Me.StudentsTableAdapter.Alpha1(Me.DatabaseProjectDataSet.Students)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Application.Exit()
    End Sub

    Private Sub HighIDToolStripButton_Click(sender As Object, e As EventArgs) Handles HighIDToolStripButton.Click
        Try
            Me.StudentsTableAdapter.HighID(Me.DatabaseProjectDataSet.Students)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub CollegeAlgebraToolStripButton_Click(sender As Object, e As EventArgs) Handles CollegeAlgebraToolStripButton.Click
        Try
            Me.StudentsTableAdapter.CollegeAlgebra(Me.DatabaseProjectDataSet.Students)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub ClassesDataGridView_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClassesDataGridView.CellContentClick

        TextBox1.Text = CType(ClassesDataGridView.Rows(e.RowIndex).Cells(0).Value, String)
        TextBox2.Text = CType(ClassesDataGridView.Rows(e.RowIndex).Cells(2).Value, String)
    End Sub


    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        TextBox1.Text = CType(ClassesDataGridView.Rows(BindingNavigatorPositionItem.Text).Cells(0).Value, String)
        TextBox2.Text = CType(ClassesDataGridView.Rows(BindingNavigatorPositionItem.Text).Cells(2).Value, String)
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        TextBox1.Text = CType(ClassesDataGridView.Rows(CInt(BindingNavigatorPositionItem.Text) - 2).Cells(0).Value, String)
        TextBox2.Text = CType(ClassesDataGridView.Rows(CInt(BindingNavigatorPositionItem.Text) - 2).Cells(2).Value, String)

    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        TextBox1.Text = CType(ClassesDataGridView.Rows(0).Cells(0).Value, String)
        TextBox2.Text = CType(ClassesDataGridView.Rows(0).Cells(2).Value, String)

    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        TextBox1.Text = CType(ClassesDataGridView.Rows(ClassesDataGridView.RowCount - 2).Cells(0).Value, String)
        TextBox2.Text = CType(ClassesDataGridView.Rows(ClassesDataGridView.RowCount - 2).Cells(2).Value, String)

    End Sub
End Class
