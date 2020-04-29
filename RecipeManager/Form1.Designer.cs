namespace RecipeManager
{
    partial class Form1
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.recipeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.recipeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.stepsGroupBox = new System.Windows.Forms.GroupBox();
            this.stepsDataGridView = new System.Windows.Forms.DataGridView();
            this.stepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingNavigator)).BeginInit();
            this.recipeBindingNavigator.SuspendLayout();
            this.ingredientsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            this.recipeGroupBox.SuspendLayout();
            this.stepsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 43);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(39, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Title:";
            // 
            // recipeBindingNavigator
            // 
            this.recipeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recipeBindingNavigator.BindingSource = this.recipeBindingSource;
            this.recipeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recipeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recipeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.recipeBindingNavigatorSaveItem});
            this.recipeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.recipeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recipeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recipeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recipeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recipeBindingNavigator.Name = "recipeBindingNavigator";
            this.recipeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recipeBindingNavigator.Size = new System.Drawing.Size(482, 25);
            this.recipeBindingNavigator.TabIndex = 0;
            this.recipeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // recipeBindingNavigatorSaveItem
            // 
            this.recipeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recipeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recipeBindingNavigatorSaveItem.Image")));
            this.recipeBindingNavigatorSaveItem.Name = "recipeBindingNavigatorSaveItem";
            this.recipeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.recipeBindingNavigatorSaveItem.Text = "Save Data";
            this.recipeBindingNavigatorSaveItem.Click += new System.EventHandler(this.recipeBindingNavigatorSaveItem_Click);
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Controls.Add(this.ingredientsDataGridView);
            this.ingredientsGroupBox.Location = new System.Drawing.Point(12, 205);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(457, 184);
            this.ingredientsGroupBox.TabIndex = 5;
            this.ingredientsGroupBox.TabStop = false;
            this.ingredientsGroupBox.Text = "Ingredients";
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AutoGenerateColumns = false;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ingredientsDataGridView.DataSource = this.ingredientsBindingSource;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(9, 22);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.Size = new System.Drawing.Size(441, 148);
            this.ingredientsDataGridView.TabIndex = 0;
            this.ingredientsDataGridView.EnabledChanged += new System.EventHandler(this.DataGridView_EnabledChanged);
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "Ingredients";
            this.ingredientsBindingSource.DataSource = this.recipeBindingSource;
            // 
            // recipeGroupBox
            // 
            this.recipeGroupBox.Controls.Add(descriptionLabel);
            this.recipeGroupBox.Controls.Add(this.descriptionTextBox);
            this.recipeGroupBox.Controls.Add(titleLabel);
            this.recipeGroupBox.Controls.Add(this.titleTextBox);
            this.recipeGroupBox.Location = new System.Drawing.Point(12, 39);
            this.recipeGroupBox.Name = "recipeGroupBox";
            this.recipeGroupBox.Size = new System.Drawing.Size(457, 160);
            this.recipeGroupBox.TabIndex = 6;
            this.recipeGroupBox.TabStop = false;
            this.recipeGroupBox.Text = "Recipe Information";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipeBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(75, 40);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(375, 114);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipeBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(75, 14);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(375, 20);
            this.titleTextBox.TabIndex = 10;
            // 
            // stepsGroupBox
            // 
            this.stepsGroupBox.Controls.Add(this.stepsDataGridView);
            this.stepsGroupBox.Location = new System.Drawing.Point(12, 395);
            this.stepsGroupBox.Name = "stepsGroupBox";
            this.stepsGroupBox.Size = new System.Drawing.Size(457, 252);
            this.stepsGroupBox.TabIndex = 7;
            this.stepsGroupBox.TabStop = false;
            this.stepsGroupBox.Text = "Steps";
            // 
            // stepsDataGridView
            // 
            this.stepsDataGridView.AutoGenerateColumns = false;
            this.stepsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stepsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.stepsDataGridView.DataSource = this.stepsBindingSource;
            this.stepsDataGridView.Location = new System.Drawing.Point(9, 19);
            this.stepsDataGridView.Name = "stepsDataGridView";
            this.stepsDataGridView.Size = new System.Drawing.Size(441, 221);
            this.stepsDataGridView.TabIndex = 0;
            this.stepsDataGridView.EnabledChanged += new System.EventHandler(this.DataGridView_EnabledChanged);
            // 
            // stepsBindingSource
            // 
            this.stepsBindingSource.DataMember = "Steps";
            this.stepsBindingSource.DataSource = this.recipeBindingSource;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StepId";
            this.dataGridViewTextBoxColumn4.HeaderText = "StepId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 380;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Recipe";
            this.dataGridViewTextBoxColumn6.HeaderText = "Recipe";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // recipeBindingSource
            // 
            this.recipeBindingSource.DataSource = typeof(RecipeManager.Models.Recipe);
            this.recipeBindingSource.CurrentChanged += new System.EventHandler(this.recipeBindingSource_CurrentChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IngredientId";
            this.dataGridViewTextBoxColumn1.HeaderText = "IngredientId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 380;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Recipe";
            this.dataGridViewTextBoxColumn3.HeaderText = "Recipe";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 660);
            this.Controls.Add(this.stepsGroupBox);
            this.Controls.Add(this.recipeGroupBox);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Controls.Add(this.recipeBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Recipe Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingNavigator)).EndInit();
            this.recipeBindingNavigator.ResumeLayout(false);
            this.recipeBindingNavigator.PerformLayout();
            this.ingredientsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            this.recipeGroupBox.ResumeLayout(false);
            this.recipeGroupBox.PerformLayout();
            this.stepsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stepsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource recipeBindingSource;
        private System.Windows.Forms.BindingNavigator recipeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton recipeBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private System.Windows.Forms.GroupBox recipeGroupBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.GroupBox stepsGroupBox;
        private System.Windows.Forms.DataGridView stepsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource stepsBindingSource;
    }
}

