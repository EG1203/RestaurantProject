namespace RestaurantProject
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_должностиLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортные_данныеLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.restaurantDataSet = new RestaurantProject.RestaurantDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new RestaurantProject.RestaurantDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new RestaurantProject.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.сотрудникиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_должностиTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.паспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.restaurantDataSet1 = new RestaurantProject.RestaurantDataSet1();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter1 = new RestaurantProject.RestaurantDataSet1TableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager1 = new RestaurantProject.RestaurantDataSet1TableAdapters.TableAdapterManager();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            код_должностиLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортные_данныеLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).BeginInit();
            this.сотрудникиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // код_должностиLabel
            // 
            код_должностиLabel.AutoSize = true;
            код_должностиLabel.Location = new System.Drawing.Point(253, 138);
            код_должностиLabel.Name = "код_должностиLabel";
            код_должностиLabel.Size = new System.Drawing.Size(108, 16);
            код_должностиLabel.TabIndex = 3;
            код_должностиLabel.Text = "Код должности:";
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Location = new System.Drawing.Point(253, 176);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(65, 16);
            возрастLabel.TabIndex = 5;
            возрастLabel.Text = "Возраст:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(253, 214);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(36, 16);
            полLabel.TabIndex = 7;
            полLabel.Text = "Пол:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(253, 258);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(50, 16);
            адресLabel.TabIndex = 9;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(253, 295);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 11;
            телефонLabel.Text = "Телефон:";
            // 
            // паспортные_данныеLabel
            // 
            паспортные_данныеLabel.AutoSize = true;
            паспортные_данныеLabel.Location = new System.Drawing.Point(253, 331);
            паспортные_данныеLabel.Name = "паспортные_данныеLabel";
            паспортные_данныеLabel.Size = new System.Drawing.Size(143, 16);
            паспортные_данныеLabel.TabIndex = 13;
            паспортные_данныеLabel.Text = "Паспортные данные:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(253, 365);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(114, 16);
            код_сотрудникаLabel.TabIndex = 15;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(253, 93);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(41, 16);
            фИОLabel.TabIndex = 24;
            фИОLabel.Text = "ФИО:";
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.restaurantDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RestaurantProject.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.Меню1TableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // сотрудникиBindingNavigator
            // 
            this.сотрудникиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сотрудникиBindingNavigator.BindingSource = this.сотрудникиBindingSource;
            this.сотрудникиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сотрудникиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сотрудникиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.сотрудникиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.сотрудникиBindingNavigatorSaveItem});
            this.сотрудникиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сотрудникиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сотрудникиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сотрудникиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сотрудникиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сотрудникиBindingNavigator.Name = "сотрудникиBindingNavigator";
            this.сотрудникиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сотрудникиBindingNavigator.Size = new System.Drawing.Size(807, 31);
            this.сотрудникиBindingNavigator.TabIndex = 0;
            this.сотрудникиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // сотрудникиBindingNavigatorSaveItem
            // 
            this.сотрудникиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сотрудникиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сотрудникиBindingNavigatorSaveItem.Image")));
            this.сотрудникиBindingNavigatorSaveItem.Name = "сотрудникиBindingNavigatorSaveItem";
            this.сотрудникиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.сотрудникиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сотрудникиBindingNavigatorSaveItem.Click += new System.EventHandler(this.сотрудникиBindingNavigatorSaveItem_Click);
            // 
            // код_должностиTextBox
            // 
            this.код_должностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Код должности", true));
            this.код_должностиTextBox.Location = new System.Drawing.Point(367, 138);
            this.код_должностиTextBox.Name = "код_должностиTextBox";
            this.код_должностиTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_должностиTextBox.TabIndex = 4;
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Возраст", true));
            this.возрастTextBox.Location = new System.Drawing.Point(333, 176);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(100, 22);
            this.возрастTextBox.TabIndex = 6;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(295, 214);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(100, 22);
            this.полTextBox.TabIndex = 8;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(308, 258);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 22);
            this.адресTextBox.TabIndex = 10;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(329, 292);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 22);
            this.телефонTextBox.TabIndex = 12;
            // 
            // паспортные_данныеTextBox
            // 
            this.паспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Паспортные данные", true));
            this.паспортные_данныеTextBox.Location = new System.Drawing.Point(402, 331);
            this.паспортные_данныеTextBox.Name = "паспортные_данныеTextBox";
            this.паспортные_данныеTextBox.Size = new System.Drawing.Size(100, 22);
            this.паспортные_данныеTextBox.TabIndex = 14;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(373, 365);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(100, 22);
            this.код_сотрудникаTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(264, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Таблица \"Сотрудники\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(312, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(468, 463);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(312, 516);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // restaurantDataSet1
            // 
            this.restaurantDataSet1.DataSetName = "RestaurantDataSet1";
            this.restaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.restaurantDataSet1;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = RestaurantProject.RestaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ДолжностиTableAdapter = null;
            this.tableAdapterManager1.ЗаказTableAdapter = null;
            this.tableAdapterManager1.Меню1TableAdapter = null;
            this.tableAdapterManager1.СкладTableAdapter = null;
            this.tableAdapterManager1.СотрудникиTableAdapter = this.сотрудникиTableAdapter1;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(312, 93);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 22);
            this.фИОTextBox.TabIndex = 25;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 671);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(паспортные_данныеLabel);
            this.Controls.Add(this.паспортные_данныеTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(код_должностиLabel);
            this.Controls.Add(this.код_должностиTextBox);
            this.Controls.Add(this.сотрудникиBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).EndInit();
            this.сотрудникиBindingNavigator.ResumeLayout(false);
            this.сотрудникиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private RestaurantDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сотрудникиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сотрудникиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_должностиTextBox;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox паспортные_данныеTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private RestaurantDataSet1 restaurantDataSet1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private RestaurantDataSet1TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private RestaurantDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox фИОTextBox;
    }
}