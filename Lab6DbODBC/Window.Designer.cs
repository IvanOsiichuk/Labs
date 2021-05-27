namespace DbExplorer
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TableGrid = new System.Windows.Forms.DataGridView();
            this.SelectBox = new System.Windows.Forms.TextBox();
            this.ColumnsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FromIntoLabel = new System.Windows.Forms.Label();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.FromTableMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WhereLabel = new System.Windows.Forms.Label();
            this.WhereBox = new System.Windows.Forms.TextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.OwnQueryBox = new System.Windows.Forms.TextBox();
            this.BoxesClearButton = new System.Windows.Forms.Button();
            this.WindowSplit = new System.Windows.Forms.SplitContainer();
            this.OwnQueryCheck = new System.Windows.Forms.CheckBox();
            this.OperationBox = new System.Windows.Forms.ComboBox();
            this.OrderBox = new System.Windows.Forms.TextBox();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowSplit)).BeginInit();
            this.WindowSplit.Panel1.SuspendLayout();
            this.WindowSplit.Panel2.SuspendLayout();
            this.WindowSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-133, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "WHERE";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(-57, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "ORDER BY";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(-235, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(563, 27);
            this.textBox4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "GROUP BY";
            // 
            // TableGrid
            // 
            this.TableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TableGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGrid.Location = new System.Drawing.Point(3, 3);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.RowHeadersWidth = 51;
            this.TableGrid.RowTemplate.Height = 29;
            this.TableGrid.Size = new System.Drawing.Size(655, 319);
            this.TableGrid.TabIndex = 8;
            // 
            // SelectBox
            // 
            this.SelectBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectBox.ContextMenuStrip = this.ColumnsMenu;
            this.SelectBox.Location = new System.Drawing.Point(96, 3);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.PlaceholderText = "перелік стовпців";
            this.SelectBox.Size = new System.Drawing.Size(232, 29);
            this.SelectBox.TabIndex = 0;
            this.SelectBox.Tag = "";
            this.SelectBox.DoubleClick += new System.EventHandler(this.UpdateColumnsMenu_DoubleClick);
            // 
            // ColumnsMenu
            // 
            this.ColumnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ColumnsMenu.Name = "ColumnsMenu";
            this.ColumnsMenu.Size = new System.Drawing.Size(61, 4);
            this.ColumnsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ColumnsMenu_Click);
            // 
            // FromIntoLabel
            // 
            this.FromIntoLabel.AutoSize = true;
            this.FromIntoLabel.ForeColor = System.Drawing.Color.Blue;
            this.FromIntoLabel.Location = new System.Drawing.Point(3, 40);
            this.FromIntoLabel.Name = "FromIntoLabel";
            this.FromIntoLabel.Size = new System.Drawing.Size(50, 22);
            this.FromIntoLabel.TabIndex = 2;
            this.FromIntoLabel.Text = "FROM";
            // 
            // FromBox
            // 
            this.FromBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FromBox.ContextMenuStrip = this.FromTableMenu;
            this.FromBox.Location = new System.Drawing.Point(96, 38);
            this.FromBox.Name = "FromBox";
            this.FromBox.PlaceholderText = "таблиця";
            this.FromBox.Size = new System.Drawing.Size(232, 29);
            this.FromBox.TabIndex = 1;
            this.FromBox.Tag = "";
            // 
            // FromTableMenu
            // 
            this.FromTableMenu.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromTableMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FromTableMenu.Name = "FromTableMenu";
            this.FromTableMenu.Size = new System.Drawing.Size(61, 4);
            this.FromTableMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FromMenu_ItemClicked);
            // 
            // WhereLabel
            // 
            this.WhereLabel.AutoSize = true;
            this.WhereLabel.ForeColor = System.Drawing.Color.Blue;
            this.WhereLabel.Location = new System.Drawing.Point(3, 75);
            this.WhereLabel.Name = "WhereLabel";
            this.WhereLabel.Size = new System.Drawing.Size(60, 22);
            this.WhereLabel.TabIndex = 4;
            this.WhereLabel.Text = "WHERE";
            // 
            // WhereBox
            // 
            this.WhereBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WhereBox.Location = new System.Drawing.Point(96, 73);
            this.WhereBox.Name = "WhereBox";
            this.WhereBox.PlaceholderText = "умова";
            this.WhereBox.Size = new System.Drawing.Size(232, 29);
            this.WhereBox.TabIndex = 2;
            this.WhereBox.Tag = "";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.ForeColor = System.Drawing.Color.Blue;
            this.GroupLabel.Location = new System.Drawing.Point(3, 110);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(90, 22);
            this.GroupLabel.TabIndex = 6;
            this.GroupLabel.Text = "GROUP BY";
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.Location = new System.Drawing.Point(96, 108);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.PlaceholderText = "групувати за ";
            this.GroupBox.Size = new System.Drawing.Size(232, 29);
            this.GroupBox.TabIndex = 3;
            this.GroupBox.Tag = "";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Location = new System.Drawing.Point(193, 184);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(135, 29);
            this.ExecuteButton.TabIndex = 5;
            this.ExecuteButton.Text = "Виконати";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(134, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 37);
            this.label9.TabIndex = 12;
            this.label9.Text = "~";
            // 
            // OwnQueryBox
            // 
            this.OwnQueryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OwnQueryBox.Location = new System.Drawing.Point(6, 239);
            this.OwnQueryBox.Multiline = true;
            this.OwnQueryBox.Name = "OwnQueryBox";
            this.OwnQueryBox.Size = new System.Drawing.Size(322, 227);
            this.OwnQueryBox.TabIndex = 6;
            // 
            // BoxesClearButton
            // 
            this.BoxesClearButton.Location = new System.Drawing.Point(6, 182);
            this.BoxesClearButton.Name = "BoxesClearButton";
            this.BoxesClearButton.Size = new System.Drawing.Size(106, 29);
            this.BoxesClearButton.TabIndex = 7;
            this.BoxesClearButton.Text = "Очистити";
            this.BoxesClearButton.UseVisualStyleBackColor = true;
            this.BoxesClearButton.Click += new System.EventHandler(this.AllClearButton_Click);
            // 
            // WindowSplit
            // 
            this.WindowSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowSplit.Location = new System.Drawing.Point(12, 12);
            this.WindowSplit.Name = "WindowSplit";
            // 
            // WindowSplit.Panel1
            // 
            this.WindowSplit.Panel1.Controls.Add(this.OwnQueryCheck);
            this.WindowSplit.Panel1.Controls.Add(this.OperationBox);
            this.WindowSplit.Panel1.Controls.Add(this.OrderBox);
            this.WindowSplit.Panel1.Controls.Add(this.OrderLabel);
            this.WindowSplit.Panel1.Controls.Add(this.BoxesClearButton);
            this.WindowSplit.Panel1.Controls.Add(this.OwnQueryBox);
            this.WindowSplit.Panel1.Controls.Add(this.label9);
            this.WindowSplit.Panel1.Controls.Add(this.ExecuteButton);
            this.WindowSplit.Panel1.Controls.Add(this.GroupBox);
            this.WindowSplit.Panel1.Controls.Add(this.GroupLabel);
            this.WindowSplit.Panel1.Controls.Add(this.WhereBox);
            this.WindowSplit.Panel1.Controls.Add(this.WhereLabel);
            this.WindowSplit.Panel1.Controls.Add(this.FromBox);
            this.WindowSplit.Panel1.Controls.Add(this.FromIntoLabel);
            this.WindowSplit.Panel1.Controls.Add(this.SelectBox);
            // 
            // WindowSplit.Panel2
            // 
            this.WindowSplit.Panel2.Controls.Add(this.EditButton);
            this.WindowSplit.Panel2.Controls.Add(this.ClearButton);
            this.WindowSplit.Panel2.Controls.Add(this.StatusBox);
            this.WindowSplit.Panel2.Controls.Add(this.TableGrid);
            this.WindowSplit.Panel2.Controls.Add(this.label6);
            this.WindowSplit.Size = new System.Drawing.Size(996, 466);
            this.WindowSplit.SplitterDistance = 331;
            this.WindowSplit.TabIndex = 9;
            // 
            // OwnQueryCheck
            // 
            this.OwnQueryCheck.AutoSize = true;
            this.OwnQueryCheck.Location = new System.Drawing.Point(6, 214);
            this.OwnQueryCheck.Name = "OwnQueryCheck";
            this.OwnQueryCheck.Size = new System.Drawing.Size(172, 26);
            this.OwnQueryCheck.TabIndex = 19;
            this.OwnQueryCheck.Text = "Власний запит:";
            this.OwnQueryCheck.UseVisualStyleBackColor = true;
            // 
            // OperationBox
            // 
            this.OperationBox.ForeColor = System.Drawing.Color.Blue;
            this.OperationBox.FormattingEnabled = true;
            this.OperationBox.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.OperationBox.Location = new System.Drawing.Point(0, 3);
            this.OperationBox.Name = "OperationBox";
            this.OperationBox.Size = new System.Drawing.Size(93, 30);
            this.OperationBox.TabIndex = 17;
            this.OperationBox.SelectedIndexChanged += new System.EventHandler(this.OperationChanged_Event);
            // 
            // OrderBox
            // 
            this.OrderBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderBox.Location = new System.Drawing.Point(96, 142);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.PlaceholderText = "сортувати за | як";
            this.OrderBox.Size = new System.Drawing.Size(232, 29);
            this.OrderBox.TabIndex = 4;
            this.OrderBox.Tag = "";
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.ForeColor = System.Drawing.Color.Blue;
            this.OrderLabel.Location = new System.Drawing.Point(3, 144);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(90, 22);
            this.OrderLabel.TabIndex = 16;
            this.OrderLabel.Text = "ORDER BY";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(569, 277);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(45, 45);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "🖉";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(613, 277);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(45, 45);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "✖";
            this.ClearButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBox.BackColor = System.Drawing.SystemColors.Window;
            this.StatusBox.Location = new System.Drawing.Point(3, 328);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusBox.Size = new System.Drawing.Size(655, 135);
            this.StatusBox.TabIndex = 9;
            this.StatusBox.Text = "-Transaction status-";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 490);
            this.Controls.Add(this.WindowSplit);
            this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DbExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).EndInit();
            this.WindowSplit.Panel1.ResumeLayout(false);
            this.WindowSplit.Panel1.PerformLayout();
            this.WindowSplit.Panel2.ResumeLayout(false);
            this.WindowSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowSplit)).EndInit();
            this.WindowSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TableGrid;
        private System.Windows.Forms.TextBox SelectBox;
        private System.Windows.Forms.Label FromIntoLabel;
        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.Label WhereLabel;
        private System.Windows.Forms.TextBox WhereBox;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.TextBox GroupBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OwnQueryBox;
        private System.Windows.Forms.SplitContainer WindowSplit;
        private System.Windows.Forms.TextBox OrderBox;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.ContextMenuStrip FromTableMenu;
        private System.Windows.Forms.ComboBox OperationBox;
        private System.Windows.Forms.CheckBox OwnQueryCheck;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BoxesClearButton;
        private System.Windows.Forms.ContextMenuStrip ColumnsMenu;
    }
}