namespace WinForm_KomDiagnostic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_bookLabel;
            System.Windows.Forms.Label name_of_bookLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label short_descriptionLabel;
            System.Windows.Forms.Label yearLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cover_imagePictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.загрузитьИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.komdiagnosticDataSet = new WinForm_KomDiagnostic.komdiagnosticDataSet();
            this.iD_bookTextBox = new System.Windows.Forms.TextBox();
            this.name_of_bookRichTextBox = new System.Windows.Forms.RichTextBox();
            this.authorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.short_descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.table_1TableAdapter = new WinForm_KomDiagnostic.komdiagnosticDataSetTableAdapters.Table_1TableAdapter();
            this.tableAdapterManager = new WinForm_KomDiagnostic.komdiagnosticDataSetTableAdapters.TableAdapterManager();
            this.table_1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEditButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.table_1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            iD_bookLabel = new System.Windows.Forms.Label();
            name_of_bookLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            short_descriptionLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cover_imagePictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komdiagnosticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_1BindingNavigator)).BeginInit();
            this.table_1BindingNavigator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_bookLabel
            // 
            iD_bookLabel.AutoSize = true;
            iD_bookLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_bookLabel.Location = new System.Drawing.Point(3, 0);
            iD_bookLabel.Name = "iD_bookLabel";
            iD_bookLabel.Size = new System.Drawing.Size(67, 18);
            iD_bookLabel.TabIndex = 0;
            iD_bookLabel.Text = "ID книги:";
            // 
            // name_of_bookLabel
            // 
            name_of_bookLabel.AutoSize = true;
            name_of_bookLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_of_bookLabel.Location = new System.Drawing.Point(3, 31);
            name_of_bookLabel.Name = "name_of_bookLabel";
            name_of_bookLabel.Size = new System.Drawing.Size(71, 36);
            name_of_bookLabel.TabIndex = 2;
            name_of_bookLabel.Text = "Название книги:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            authorLabel.Location = new System.Drawing.Point(3, 99);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(49, 18);
            authorLabel.TabIndex = 4;
            authorLabel.Text = "Автор:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iSBNLabel.Location = new System.Drawing.Point(3, 181);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(46, 18);
            iSBNLabel.TabIndex = 6;
            iSBNLabel.Text = "ISBN:";
            // 
            // short_descriptionLabel
            // 
            short_descriptionLabel.AutoSize = true;
            short_descriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            short_descriptionLabel.Location = new System.Drawing.Point(3, 215);
            short_descriptionLabel.Name = "short_descriptionLabel";
            short_descriptionLabel.Size = new System.Drawing.Size(79, 18);
            short_descriptionLabel.TabIndex = 10;
            short_descriptionLabel.Text = "Аннотация:";
            short_descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            yearLabel.Location = new System.Drawing.Point(3, 360);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(91, 18);
            yearLabel.TabIndex = 12;
            yearLabel.Text = "Год издания:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 441);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.cover_imagePictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 337);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обложка";
            // 
            // cover_imagePictureBox
            // 
            this.cover_imagePictureBox.ContextMenuStrip = this.contextMenuStrip1;
            this.cover_imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.table_1BindingSource, "cover_image", true));
            this.cover_imagePictureBox.Location = new System.Drawing.Point(15, 19);
            this.cover_imagePictureBox.Name = "cover_imagePictureBox";
            this.cover_imagePictureBox.Size = new System.Drawing.Size(185, 299);
            this.cover_imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover_imagePictureBox.TabIndex = 9;
            this.cover_imagePictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьИзображениеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 26);
            // 
            // загрузитьИзображениеToolStripMenuItem
            // 
            this.загрузитьИзображениеToolStripMenuItem.Name = "загрузитьИзображениеToolStripMenuItem";
            this.загрузитьИзображениеToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.загрузитьИзображениеToolStripMenuItem.Text = "Загрузить изображение";
            this.загрузитьИзображениеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзображениеToolStripMenuItem_Click);
            // 
            // table_1BindingSource
            // 
            this.table_1BindingSource.DataMember = "Table_1";
            this.table_1BindingSource.DataSource = this.komdiagnosticDataSet;
            // 
            // komdiagnosticDataSet
            // 
            this.komdiagnosticDataSet.DataSetName = "komdiagnosticDataSet";
            this.komdiagnosticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_bookTextBox
            // 
            this.iD_bookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "ID_book", true));
            this.iD_bookTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iD_bookTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_bookTextBox.Location = new System.Drawing.Point(103, 3);
            this.iD_bookTextBox.MinimumSize = new System.Drawing.Size(155, 25);
            this.iD_bookTextBox.Name = "iD_bookTextBox";
            this.iD_bookTextBox.ReadOnly = true;
            this.iD_bookTextBox.Size = new System.Drawing.Size(166, 26);
            this.iD_bookTextBox.TabIndex = 1;
            // 
            // name_of_bookRichTextBox
            // 
            this.name_of_bookRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "name_of_book", true));
            this.name_of_bookRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_of_bookRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_of_bookRichTextBox.Location = new System.Drawing.Point(103, 34);
            this.name_of_bookRichTextBox.Name = "name_of_bookRichTextBox";
            this.name_of_bookRichTextBox.ReadOnly = true;
            this.name_of_bookRichTextBox.Size = new System.Drawing.Size(166, 62);
            this.name_of_bookRichTextBox.TabIndex = 3;
            this.name_of_bookRichTextBox.Text = "";
            // 
            // authorRichTextBox
            // 
            this.authorRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "author", true));
            this.authorRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorRichTextBox.Location = new System.Drawing.Point(103, 102);
            this.authorRichTextBox.MinimumSize = new System.Drawing.Size(155, 60);
            this.authorRichTextBox.Name = "authorRichTextBox";
            this.authorRichTextBox.ReadOnly = true;
            this.authorRichTextBox.Size = new System.Drawing.Size(166, 76);
            this.authorRichTextBox.TabIndex = 5;
            this.authorRichTextBox.Text = "";
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "ISBN", true));
            this.iSBNTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iSBNTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iSBNTextBox.Location = new System.Drawing.Point(103, 184);
            this.iSBNTextBox.MaxLength = 17;
            this.iSBNTextBox.MinimumSize = new System.Drawing.Size(155, 26);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.ReadOnly = true;
            this.iSBNTextBox.Size = new System.Drawing.Size(166, 26);
            this.iSBNTextBox.TabIndex = 7;
            this.iSBNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iSBNTextBox_KeyPress);
            // 
            // short_descriptionRichTextBox
            // 
            this.short_descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "short_description", true));
            this.short_descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.short_descriptionRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.short_descriptionRichTextBox.Location = new System.Drawing.Point(103, 218);
            this.short_descriptionRichTextBox.Name = "short_descriptionRichTextBox";
            this.short_descriptionRichTextBox.ReadOnly = true;
            this.short_descriptionRichTextBox.Size = new System.Drawing.Size(166, 139);
            this.short_descriptionRichTextBox.TabIndex = 11;
            this.short_descriptionRichTextBox.Text = "";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_1BindingSource, "year", true));
            this.yearTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTextBox.Location = new System.Drawing.Point(103, 363);
            this.yearTextBox.MaxLength = 4;
            this.yearTextBox.MinimumSize = new System.Drawing.Size(155, 26);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(166, 26);
            this.yearTextBox.TabIndex = 13;
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearTextBox_KeyPress);
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_1TableAdapter = this.table_1TableAdapter;
            this.tableAdapterManager.UpdateOrder = WinForm_KomDiagnostic.komdiagnosticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table_1BindingNavigator
            // 
            this.table_1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_1BindingNavigator.BindingSource = this.table_1BindingSource;
            this.table_1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_1BindingNavigator.DeleteItem = null;
            this.table_1BindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table_1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripEditButton,
            this.bindingNavigatorDeleteItem,
            this.table_1BindingNavigatorSaveItem});
            this.table_1BindingNavigator.Location = new System.Drawing.Point(0, 416);
            this.table_1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_1BindingNavigator.Name = "table_1BindingNavigator";
            this.table_1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_1BindingNavigator.Size = new System.Drawing.Size(524, 25);
            this.table_1BindingNavigator.TabIndex = 1;
            this.table_1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить новую книгу";
            this.bindingNavigatorAddNewItem.ToolTipText = "Добавить книгу";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripEditButton
            // 
            this.toolStripEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditButton.Image = global::WinForm_KomDiagnostic.Properties.Resources.editing;
            this.toolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditButton.Name = "toolStripEditButton";
            this.toolStripEditButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripEditButton.Text = "Изменить данные о книге";
            this.toolStripEditButton.ToolTipText = "Изменить данные о книге";
            this.toolStripEditButton.Click += new System.EventHandler(this.toolStripEditButton_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить текущую книгу";
            this.bindingNavigatorDeleteItem.ToolTipText = "Удалить текущую книгу";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // table_1BindingNavigatorSaveItem
            // 
            this.table_1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_1BindingNavigatorSaveItem.Image")));
            this.table_1BindingNavigatorSaveItem.Name = "table_1BindingNavigatorSaveItem";
            this.table_1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table_1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.table_1BindingNavigatorSaveItem.Click += new System.EventHandler(this.table_1BindingNavigatorSaveItem_Click_4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.iD_bookTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(iD_bookLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(yearLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.short_descriptionRichTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.yearTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(short_descriptionLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.iSBNTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(iSBNLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(authorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.authorRichTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.name_of_bookRichTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(name_of_bookLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(240, 17);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(272, 396);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 396);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.table_1BindingNavigator);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека книг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cover_imagePictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komdiagnosticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_1BindingNavigator)).EndInit();
            this.table_1BindingNavigator.ResumeLayout(false);
            this.table_1BindingNavigator.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private komdiagnosticDataSet komdiagnosticDataSet;
        private System.Windows.Forms.BindingSource table_1BindingSource;
        private komdiagnosticDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private komdiagnosticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton table_1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_bookTextBox;
        private System.Windows.Forms.RichTextBox name_of_bookRichTextBox;
        private System.Windows.Forms.RichTextBox authorRichTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.PictureBox cover_imagePictureBox;
        private System.Windows.Forms.RichTextBox short_descriptionRichTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.ToolStripButton toolStripEditButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзображениеToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

