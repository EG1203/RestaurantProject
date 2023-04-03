namespace RestaurantProject
{
    partial class Form2
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
            System.Windows.Forms.Label наименование_блюдаLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label время_приготовленияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.restaurantDataSet = new RestaurantProject.RestaurantDataSet();
            this.меню1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.меню1TableAdapter = new RestaurantProject.RestaurantDataSetTableAdapters.Меню1TableAdapter();
            this.tableAdapterManager = new RestaurantProject.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.меню1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.меню1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименование_блюдаTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.время_приготовленияTextBox = new System.Windows.Forms.TextBox();
            наименование_блюдаLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            время_приготовленияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.меню1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.меню1BindingNavigator)).BeginInit();
            this.меню1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // наименование_блюдаLabel
            // 
            наименование_блюдаLabel.AutoSize = true;
            наименование_блюдаLabel.Location = new System.Drawing.Point(95, 139);
            наименование_блюдаLabel.Name = "наименование_блюдаLabel";
            наименование_блюдаLabel.Size = new System.Drawing.Size(154, 16);
            наименование_блюдаLabel.TabIndex = 2;
            наименование_блюдаLabel.Text = "Наименование блюда:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(95, 180);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(80, 16);
            стоимостьLabel.TabIndex = 4;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // время_приготовленияLabel
            // 
            время_приготовленияLabel.AutoSize = true;
            время_приготовленияLabel.Location = new System.Drawing.Point(95, 217);
            время_приготовленияLabel.Name = "время_приготовленияLabel";
            время_приготовленияLabel.Size = new System.Drawing.Size(154, 16);
            время_приготовленияLabel.TabIndex = 6;
            время_приготовленияLabel.Text = "Время приготовления:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(205, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Меню\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // меню1BindingSource
            // 
            this.меню1BindingSource.DataMember = "Меню1";
            this.меню1BindingSource.DataSource = this.restaurantDataSet;
            // 
            // меню1TableAdapter
            // 
            this.меню1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RestaurantProject.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.Меню1TableAdapter = this.меню1TableAdapter;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // меню1BindingNavigator
            // 
            this.меню1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.меню1BindingNavigator.BindingSource = this.меню1BindingSource;
            this.меню1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.меню1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.меню1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.меню1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.меню1BindingNavigatorSaveItem});
            this.меню1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.меню1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.меню1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.меню1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.меню1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.меню1BindingNavigator.Name = "меню1BindingNavigator";
            this.меню1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.меню1BindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.меню1BindingNavigator.TabIndex = 1;
            this.меню1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // меню1BindingNavigatorSaveItem
            // 
            this.меню1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.меню1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("меню1BindingNavigatorSaveItem.Image")));
            this.меню1BindingNavigatorSaveItem.Name = "меню1BindingNavigatorSaveItem";
            this.меню1BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.меню1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.меню1BindingNavigatorSaveItem.Click += new System.EventHandler(this.меню1BindingNavigatorSaveItem_Click);
            // 
            // наименование_блюдаTextBox
            // 
            this.наименование_блюдаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.меню1BindingSource, "Наименование блюда", true));
            this.наименование_блюдаTextBox.Location = new System.Drawing.Point(255, 136);
            this.наименование_блюдаTextBox.Name = "наименование_блюдаTextBox";
            this.наименование_блюдаTextBox.Size = new System.Drawing.Size(100, 22);
            this.наименование_блюдаTextBox.TabIndex = 3;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.меню1BindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(181, 177);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 22);
            this.стоимостьTextBox.TabIndex = 5;
            // 
            // время_приготовленияTextBox
            // 
            this.время_приготовленияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.меню1BindingSource, "Время приготовления", true));
            this.время_приготовленияTextBox.Location = new System.Drawing.Point(255, 214);
            this.время_приготовленияTextBox.Name = "время_приготовленияTextBox";
            this.время_приготовленияTextBox.Size = new System.Drawing.Size(100, 22);
            this.время_приготовленияTextBox.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(время_приготовленияLabel);
            this.Controls.Add(this.время_приготовленияTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(наименование_блюдаLabel);
            this.Controls.Add(this.наименование_блюдаTextBox);
            this.Controls.Add(this.меню1BindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.меню1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.меню1BindingNavigator)).EndInit();
            this.меню1BindingNavigator.ResumeLayout(false);
            this.меню1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource меню1BindingSource;
        private RestaurantDataSetTableAdapters.Меню1TableAdapter меню1TableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator меню1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton меню1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименование_блюдаTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox время_приготовленияTextBox;
    }
}