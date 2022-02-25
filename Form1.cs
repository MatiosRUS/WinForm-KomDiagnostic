using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_KomDiagnostic
{
    public partial class Form1 : Form
    {       

        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "komdiagnosticDataSet.Table_1".
            this.table_1TableAdapter.Fill(this.komdiagnosticDataSet.Table_1);
        }

        #region Обработчики нажатия кнопок
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            enableChangeFieldEditing();
            name_of_bookRichTextBox.Focus();
        }

        private void toolStripEditButton_Click(object sender, EventArgs e)
        {
            enableChangeFieldEditing();
        }           

        private void table_1BindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.table_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.komdiagnosticDataSet);  
            closeChangeFieldEditing();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить данную книгу?\n" + name_of_bookRichTextBox.Text, "Удаление книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Validate();
                this.table_1BindingSource.RemoveCurrent();
                this.table_1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.komdiagnosticDataSet);
            }
        }

        /// <summary>
        /// Перемещение на следующий элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            closeChangeFieldEditing();
            this.Invalidate();
        }

        /// <summary>
        /// Перемещение на предыдущий элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            closeChangeFieldEditing();
        }
        #endregion

        #region Функции для работы с полями
        /// <summary>
        /// Функция включение полей для редактирования
        /// </summary>
        private void enableChangeFieldEditing()
        {           
            name_of_bookRichTextBox.ReadOnly = false;
            authorRichTextBox.ReadOnly = false;
            iSBNTextBox.ReadOnly = false;
            short_descriptionRichTextBox.ReadOnly = false;
            yearTextBox.ReadOnly = false;   
            contextMenuStrip1.Enabled = true;
        }
       
        /// <summary>
        /// Функция выключения полей для редактирования
        /// </summary>
        private void closeChangeFieldEditing()
        {           
            name_of_bookRichTextBox.ReadOnly = true;
            authorRichTextBox.ReadOnly = true;
            iSBNTextBox.ReadOnly = true;
            short_descriptionRichTextBox.ReadOnly = true;
            yearTextBox.ReadOnly = true;
            contextMenuStrip1.Enabled = false;
        }

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void iSBNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void загрузитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cover_imagePictureBox.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
