namespace D201_Practical_exam
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
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label member_IDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.membersScoresDataSet = new D201_Practical_exam.MembersScoresDataSet();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoresTableAdapter = new D201_Practical_exam.MembersScoresDataSetTableAdapters.scoresTableAdapter();
            this.tableAdapterManager = new D201_Practical_exam.MembersScoresDataSetTableAdapters.TableAdapterManager();
            this.membersTableAdapter = new D201_Practical_exam.MembersScoresDataSetTableAdapters.membersTableAdapter();
            this.scoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.scoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersListBox = new System.Windows.Forms.ListBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.scoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbShow = new System.Windows.Forms.CheckBox();
            this.genderdrop = new System.Windows.Forms.ComboBox();
            this.Average = new System.Windows.Forms.Label();
            this.AVG = new System.Windows.Forms.Label();
            this.noviceToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.noviceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.event_yearToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._yearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.member_IDLabel2 = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            member_IDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.membersScoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingNavigator)).BeginInit();
            this.scoresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).BeginInit();
            this.noviceToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(279, 91);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(55, 13);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "first name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(279, 117);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(55, 13);
            last_nameLabel.TabIndex = 6;
            last_nameLabel.Text = "last name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(279, 143);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(279, 169);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "password:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(279, 195);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(43, 13);
            genderLabel.TabIndex = 12;
            genderLabel.Text = "gender:";
            // 
            // member_IDLabel1
            // 
            member_IDLabel1.AutoSize = true;
            member_IDLabel1.Location = new System.Drawing.Point(279, 62);
            member_IDLabel1.Name = "member_IDLabel1";
            member_IDLabel1.Size = new System.Drawing.Size(61, 13);
            member_IDLabel1.TabIndex = 20;
            member_IDLabel1.Text = "member ID:";
            // 
            // membersScoresDataSet
            // 
            this.membersScoresDataSet.DataSetName = "MembersScoresDataSet";
            this.membersScoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoresBindingSource
            // 
            this.scoresBindingSource.DataMember = "scores";
            this.scoresBindingSource.DataSource = this.membersScoresDataSet;
            // 
            // scoresTableAdapter
            // 
            this.scoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.membersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.scoresTableAdapter = this.scoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = D201_Practical_exam.MembersScoresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // scoresBindingNavigator
            // 
            this.scoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.scoresBindingNavigator.BindingSource = this.scoresBindingSource;
            this.scoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.scoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.scoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.scoresBindingNavigatorSaveItem});
            this.scoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.scoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.scoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.scoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.scoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.scoresBindingNavigator.Name = "scoresBindingNavigator";
            this.scoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.scoresBindingNavigator.Size = new System.Drawing.Size(827, 25);
            this.scoresBindingNavigator.TabIndex = 0;
            this.scoresBindingNavigator.Text = "bindingNavigator1";
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
            // scoresBindingNavigatorSaveItem
            // 
            this.scoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("scoresBindingNavigatorSaveItem.Image")));
            this.scoresBindingNavigatorSaveItem.Name = "scoresBindingNavigatorSaveItem";
            this.scoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.scoresBindingNavigatorSaveItem.Text = "Save Data";
            this.scoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.scoresBindingNavigatorSaveItem_Click);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.membersScoresDataSet;
            // 
            // membersListBox
            // 
            this.membersListBox.DataSource = this.membersBindingSource;
            this.membersListBox.DisplayMember = "first_name";
            this.membersListBox.FormattingEnabled = true;
            this.membersListBox.Location = new System.Drawing.Point(21, 45);
            this.membersListBox.Name = "membersListBox";
            this.membersListBox.Size = new System.Drawing.Size(180, 212);
            this.membersListBox.Sorted = true;
            this.membersListBox.TabIndex = 1;
            this.membersListBox.ValueMember = "member_ID";
            this.membersListBox.SelectedIndexChanged += new System.EventHandler(this.membersListBox_SelectedIndexChanged);
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(346, 88);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(346, 114);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_nameTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(346, 140);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(346, 166);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // scoresBindingSource1
            // 
            this.scoresBindingSource1.DataMember = "membersscores";
            this.scoresBindingSource1.DataSource = this.membersBindingSource;
            // 
            // scoresDataGridView
            // 
            this.scoresDataGridView.AutoGenerateColumns = false;
            this.scoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.scoresDataGridView.DataSource = this.scoresBindingSource1;
            this.scoresDataGridView.Location = new System.Drawing.Point(49, 299);
            this.scoresDataGridView.Name = "scoresDataGridView";
            this.scoresDataGridView.Size = new System.Drawing.Size(470, 220);
            this.scoresDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "event";
            this.dataGridViewTextBoxColumn3.HeaderText = "event";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn4.HeaderText = "score";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "event_year";
            this.dataGridViewTextBoxColumn5.HeaderText = "event_year";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "season";
            this.dataGridViewTextBoxColumn6.HeaderText = "season";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ckbShow
            // 
            this.ckbShow.AutoSize = true;
            this.ckbShow.Location = new System.Drawing.Point(453, 169);
            this.ckbShow.Name = "ckbShow";
            this.ckbShow.Size = new System.Drawing.Size(53, 17);
            this.ckbShow.TabIndex = 16;
            this.ckbShow.Text = "Show";
            this.ckbShow.UseVisualStyleBackColor = true;
            this.ckbShow.CheckedChanged += new System.EventHandler(this.ckbShow_CheckedChanged);
            // 
            // genderdrop
            // 
            this.genderdrop.FormattingEnabled = true;
            this.genderdrop.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderdrop.Location = new System.Drawing.Point(346, 195);
            this.genderdrop.Name = "genderdrop";
            this.genderdrop.Size = new System.Drawing.Size(100, 21);
            this.genderdrop.TabIndex = 17;
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(154, 525);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(50, 13);
            this.Average.TabIndex = 18;
            this.Average.Text = "Average:";
            this.Average.Click += new System.EventHandler(this.label1_Click);
            // 
            // AVG
            // 
            this.AVG.AutoSize = true;
            this.AVG.Location = new System.Drawing.Point(211, 526);
            this.AVG.Name = "AVG";
            this.AVG.Size = new System.Drawing.Size(0, 13);
            this.AVG.TabIndex = 19;
            // 
            // noviceToolStrip
            // 
            this.noviceToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.noviceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.noviceToolStripButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.event_yearToolStripTextBox,
            this._yearToolStripButton,
            this.toolStripButton5});
            this.noviceToolStrip.Location = new System.Drawing.Point(728, 25);
            this.noviceToolStrip.Name = "noviceToolStrip";
            this.noviceToolStrip.Size = new System.Drawing.Size(99, 534);
            this.noviceToolStrip.TabIndex = 20;
            this.noviceToolStrip.Text = "noviceToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 15);
            this.toolStripLabel1.Text = "Event:";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // noviceToolStripButton
            // 
            this.noviceToolStripButton.BackColor = System.Drawing.Color.LimeGreen;
            this.noviceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.noviceToolStripButton.Name = "noviceToolStripButton";
            this.noviceToolStripButton.Size = new System.Drawing.Size(96, 19);
            this.noviceToolStripButton.Text = "Novice";
            this.noviceToolStripButton.Click += new System.EventHandler(this.noviceToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(96, 19);
            this.toolStripButton1.Text = "Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.Red;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(96, 19);
            this.toolStripButton2.Text = "Masters";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackColor = System.Drawing.Color.Orange;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(96, 19);
            this.toolStripButton3.Text = "Score Above 50";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackColor = System.Drawing.Color.Silver;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(96, 19);
            this.toolStripButton4.Text = "Score Below 50";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // event_yearToolStripTextBox
            // 
            this.event_yearToolStripTextBox.Name = "event_yearToolStripTextBox";
            this.event_yearToolStripTextBox.Size = new System.Drawing.Size(94, 23);
            // 
            // _yearToolStripButton
            // 
            this._yearToolStripButton.BackColor = System.Drawing.Color.Magenta;
            this._yearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._yearToolStripButton.Name = "_yearToolStripButton";
            this._yearToolStripButton.Size = new System.Drawing.Size(96, 19);
            this._yearToolStripButton.Text = "Year";
            this._yearToolStripButton.ToolTipText = "Year";
            this._yearToolStripButton.Click += new System.EventHandler(this._yearToolStripButton_Click_2);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.BackColor = System.Drawing.Color.Black;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.ForeColor = System.Drawing.Color.White;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(96, 19);
            this.toolStripButton5.Text = "Clear";
            this.toolStripButton5.ToolTipText = "Clear";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // member_IDLabel2
            // 
            this.member_IDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "member_ID", true));
            this.member_IDLabel2.Location = new System.Drawing.Point(346, 62);
            this.member_IDLabel2.Name = "member_IDLabel2";
            this.member_IDLabel2.Size = new System.Drawing.Size(100, 23);
            this.member_IDLabel2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 559);
            this.Controls.Add(member_IDLabel1);
            this.Controls.Add(this.member_IDLabel2);
            this.Controls.Add(this.noviceToolStrip);
            this.Controls.Add(this.AVG);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.genderdrop);
            this.Controls.Add(this.ckbShow);
            this.Controls.Add(this.scoresDataGridView);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.membersListBox);
            this.Controls.Add(this.scoresBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersScoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingNavigator)).EndInit();
            this.scoresBindingNavigator.ResumeLayout(false);
            this.scoresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).EndInit();
            this.noviceToolStrip.ResumeLayout(false);
            this.noviceToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MembersScoresDataSet membersScoresDataSet;
        private System.Windows.Forms.BindingSource scoresBindingSource;
        private MembersScoresDataSetTableAdapters.scoresTableAdapter scoresTableAdapter;
        private MembersScoresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator scoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton scoresBindingNavigatorSaveItem;
        private MembersScoresDataSetTableAdapters.membersTableAdapter membersTableAdapter;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.ListBox membersListBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.BindingSource scoresBindingSource1;
        private System.Windows.Forms.DataGridView scoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.CheckBox ckbShow;
        private System.Windows.Forms.ComboBox genderdrop;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label AVG;
        private System.Windows.Forms.ToolStrip noviceToolStrip;
        private System.Windows.Forms.ToolStripButton noviceToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label member_IDLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripTextBox event_yearToolStripTextBox;
        private System.Windows.Forms.ToolStripButton _yearToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

