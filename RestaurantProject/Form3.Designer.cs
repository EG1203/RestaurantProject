namespace RestaurantProject
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label времяLabel;
            System.Windows.Forms.Label фИО_заказчикаLabel;
            this.restaurantDataSet = new RestaurantProject.RestaurantDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new RestaurantProject.RestaurantDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new RestaurantProject.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.заказBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.заказBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.времяTextBox = new System.Windows.Forms.TextBox();
            this.фИО_заказчикаTextBox = new System.Windows.Forms.TextBox();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new RestaurantProject.RestaurantDataSetTableAdapters.ЗаказыTableAdapter();
            датаLabel = new System.Windows.Forms.Label();
            времяLabel = new System.Windows.Forms.Label();
            фИО_заказчикаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).BeginInit();
            this.заказBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.restaurantDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RestaurantProject.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.Меню1TableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // заказBindingNavigator
            // 
            this.заказBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказBindingNavigator.BindingSource = this.заказBindingSource;
            this.заказBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.заказBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказBindingNavigatorSaveItem});
            this.заказBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказBindingNavigator.Name = "заказBindingNavigator";
            this.заказBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.заказBindingNavigator.TabIndex = 0;
            this.заказBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // заказBindingNavigatorSaveItem
            // 
            this.заказBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказBindingNavigatorSaveItem.Image")));
            this.заказBindingNavigatorSaveItem.Name = "заказBindingNavigatorSaveItem";
            this.заказBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.заказBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказBindingNavigatorSaveItem_Click);
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(305, 84);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(42, 16);
            датаLabel.TabIndex = 1;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(353, 80);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаDateTimePicker.TabIndex = 2;
            // 
            // времяLabel
            // 
            времяLabel.AutoSize = true;
            времяLabel.Location = new System.Drawing.Point(307, 141);
            времяLabel.Name = "времяLabel";
            времяLabel.Size = new System.Drawing.Size(51, 16);
            времяLabel.TabIndex = 3;
            времяLabel.Text = "Время:";
            // 
            // времяTextBox
            // 
            this.времяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Время", true));
            this.времяTextBox.Location = new System.Drawing.Point(364, 138);
            this.времяTextBox.Name = "времяTextBox";
            this.времяTextBox.Size = new System.Drawing.Size(100, 22);
            this.времяTextBox.TabIndex = 4;
            // 
            // фИО_заказчикаLabel
            // 
            фИО_заказчикаLabel.AutoSize = true;
            фИО_заказчикаLabel.Location = new System.Drawing.Point(305, 185);
            фИО_заказчикаLabel.Name = "фИО_заказчикаLabel";
            фИО_заказчикаLabel.Size = new System.Drawing.Size(114, 16);
            фИО_заказчикаLabel.TabIndex = 5;
            фИО_заказчикаLabel.Text = "ФИО заказчика:";
            // 
            // фИО_заказчикаTextBox
            // 
            this.фИО_заказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "ФИО заказчика", true));
            this.фИО_заказчикаTextBox.Location = new System.Drawing.Point(425, 179);
            this.фИО_заказчикаTextBox.Name = "фИО_заказчикаTextBox";
            this.фИО_заказчикаTextBox.Size = new System.Drawing.Size(100, 22);
            this.фИО_заказчикаTextBox.TabIndex = 6;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.restaurantDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(фИО_заказчикаLabel);
            this.Controls.Add(this.фИО_заказчикаTextBox);
            this.Controls.Add(времяLabel);
            this.Controls.Add(this.времяTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.заказBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).EndInit();
            this.заказBindingNavigator.ResumeLayout(false);
            this.заказBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private RestaurantDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox времяTextBox;
        private System.Windows.Forms.TextBox фИО_заказчикаTextBox;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private RestaurantDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
    }
}