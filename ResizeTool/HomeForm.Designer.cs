namespace ResizeTool
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.resultedPictureBox = new System.Windows.Forms.PictureBox();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.browseUsersButton = new System.Windows.Forms.Button();
            this.browseDevelopersButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.resizeCurrentButton = new System.Windows.Forms.Button();
            this.horizontalSeamsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.verticalSeamsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.rowsWorkButton = new System.Windows.Forms.Button();
            this.columnsWorkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.saveButton, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.resultedPictureBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.originalPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonsPanel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(784, 307);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(395, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(386, 44);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "S a v e";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resultedPictureBox
            // 
            this.resultedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultedPictureBox.Location = new System.Drawing.Point(395, 3);
            this.resultedPictureBox.Name = "resultedPictureBox";
            this.resultedPictureBox.Size = new System.Drawing.Size(386, 251);
            this.resultedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resultedPictureBox.TabIndex = 1;
            this.resultedPictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(386, 251);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.browseUsersButton);
            this.buttonsPanel.Controls.Add(this.browseDevelopersButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 260);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(386, 44);
            this.buttonsPanel.TabIndex = 4;
            // 
            // browseUsersButton
            // 
            this.browseUsersButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.browseUsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseUsersButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.browseUsersButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseUsersButton.ForeColor = System.Drawing.Color.White;
            this.browseUsersButton.Location = new System.Drawing.Point(194, 0);
            this.browseUsersButton.Name = "browseUsersButton";
            this.browseUsersButton.Size = new System.Drawing.Size(192, 44);
            this.browseUsersButton.TabIndex = 4;
            this.browseUsersButton.Text = "Browse For Users";
            this.browseUsersButton.UseVisualStyleBackColor = false;
            this.browseUsersButton.Click += new System.EventHandler(this.browseUsersButton_Click);
            this.browseUsersButton.MouseEnter += new System.EventHandler(this.browseUsersButton_MouseEnter);
            this.browseUsersButton.MouseLeave += new System.EventHandler(this.browseUsersButton_MouseLeave);
            // 
            // browseDevelopersButton
            // 
            this.browseDevelopersButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.browseDevelopersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseDevelopersButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.browseDevelopersButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseDevelopersButton.ForeColor = System.Drawing.Color.White;
            this.browseDevelopersButton.Location = new System.Drawing.Point(0, 0);
            this.browseDevelopersButton.Name = "browseDevelopersButton";
            this.browseDevelopersButton.Size = new System.Drawing.Size(196, 44);
            this.browseDevelopersButton.TabIndex = 2;
            this.browseDevelopersButton.Text = "Browse For Developers";
            this.browseDevelopersButton.UseVisualStyleBackColor = false;
            this.browseDevelopersButton.Click += new System.EventHandler(this.browseDevelopersButton_Click);
            this.browseDevelopersButton.MouseEnter += new System.EventHandler(this.browseDevelopersButton_MouseEnter);
            this.browseDevelopersButton.MouseLeave += new System.EventHandler(this.browseDevelopersButton_MouseLeave);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox.BackColor = System.Drawing.Color.Crimson;
            this.groupBox.Controls.Add(this.resizeCurrentButton);
            this.groupBox.Controls.Add(this.horizontalSeamsText);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.verticalSeamsText);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Enabled = false;
            this.groupBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox.Location = new System.Drawing.Point(211, 378);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(356, 155);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Resize Settings";
            this.groupBox.Visible = false;
            // 
            // resizeCurrentButton
            // 
            this.resizeCurrentButton.BackColor = System.Drawing.Color.Crimson;
            this.resizeCurrentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resizeCurrentButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resizeCurrentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resizeCurrentButton.FlatAppearance.BorderSize = 0;
            this.resizeCurrentButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizeCurrentButton.ForeColor = System.Drawing.Color.Yellow;
            this.resizeCurrentButton.Location = new System.Drawing.Point(3, 108);
            this.resizeCurrentButton.Name = "resizeCurrentButton";
            this.resizeCurrentButton.Size = new System.Drawing.Size(350, 44);
            this.resizeCurrentButton.TabIndex = 5;
            this.resizeCurrentButton.Text = "Resize Current";
            this.resizeCurrentButton.UseVisualStyleBackColor = false;
            this.resizeCurrentButton.Click += new System.EventHandler(this.resizeCurrentButton_Click);
            this.resizeCurrentButton.MouseEnter += new System.EventHandler(this.resizeCurrentButton_MouseEnter);
            this.resizeCurrentButton.MouseLeave += new System.EventHandler(this.resizeCurrentButton_MouseLeave);
            // 
            // horizontalSeamsText
            // 
            this.horizontalSeamsText.BackColor = System.Drawing.Color.Crimson;
            this.horizontalSeamsText.Enabled = false;
            this.horizontalSeamsText.ForeColor = System.Drawing.Color.Gold;
            this.horizontalSeamsText.Location = new System.Drawing.Point(281, 69);
            this.horizontalSeamsText.MaxLength = 4;
            this.horizontalSeamsText.Name = "horizontalSeamsText";
            this.horizontalSeamsText.Size = new System.Drawing.Size(60, 34);
            this.horizontalSeamsText.TabIndex = 3;
            this.horizontalSeamsText.Text = "0";
            this.horizontalSeamsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Horizontal Seams to Remove: ";
            // 
            // verticalSeamsText
            // 
            this.verticalSeamsText.BackColor = System.Drawing.Color.Crimson;
            this.verticalSeamsText.ForeColor = System.Drawing.Color.Gold;
            this.verticalSeamsText.Location = new System.Drawing.Point(282, 29);
            this.verticalSeamsText.MaxLength = 4;
            this.verticalSeamsText.Name = "verticalSeamsText";
            this.verticalSeamsText.Size = new System.Drawing.Size(60, 34);
            this.verticalSeamsText.TabIndex = 1;
            this.verticalSeamsText.Text = "1";
            this.verticalSeamsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Vertical Seams to Remove: ";
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsButton.BackColor = System.Drawing.Color.Crimson;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.Yellow;
            this.settingsButton.Location = new System.Drawing.Point(211, 329);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(356, 44);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "M A N I P U L A T E  S E T T I N G S";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // rowsWorkButton
            // 
            this.rowsWorkButton.BackColor = System.Drawing.Color.DimGray;
            this.rowsWorkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rowsWorkButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsWorkButton.ForeColor = System.Drawing.Color.White;
            this.rowsWorkButton.Location = new System.Drawing.Point(3, 363);
            this.rowsWorkButton.Name = "rowsWorkButton";
            this.rowsWorkButton.Size = new System.Drawing.Size(85, 44);
            this.rowsWorkButton.TabIndex = 5;
            this.rowsWorkButton.Text = "Rows";
            this.rowsWorkButton.UseVisualStyleBackColor = false;
            this.rowsWorkButton.Click += new System.EventHandler(this.rowsWorkButton_Click);
            this.rowsWorkButton.MouseEnter += new System.EventHandler(this.rowsWorkButton_MouseEnter);
            this.rowsWorkButton.MouseLeave += new System.EventHandler(this.rowsWorkButton_MouseLeave);
            // 
            // columnsWorkButton
            // 
            this.columnsWorkButton.BackColor = System.Drawing.Color.Black;
            this.columnsWorkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.columnsWorkButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsWorkButton.ForeColor = System.Drawing.Color.White;
            this.columnsWorkButton.Location = new System.Drawing.Point(3, 313);
            this.columnsWorkButton.Name = "columnsWorkButton";
            this.columnsWorkButton.Size = new System.Drawing.Size(85, 44);
            this.columnsWorkButton.TabIndex = 6;
            this.columnsWorkButton.Text = "Columns";
            this.columnsWorkButton.UseVisualStyleBackColor = false;
            this.columnsWorkButton.Click += new System.EventHandler(this.columnsWorkButton_Click);
            this.columnsWorkButton.MouseEnter += new System.EventHandler(this.columnsWorkButton_MouseEnter);
            this.columnsWorkButton.MouseLeave += new System.EventHandler(this.columnsWorkButton_MouseLeave);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Crimson;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(3, 456);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 44);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            this.clearButton.MouseEnter += new System.EventHandler(this.clearButton_MouseEnter);
            this.clearButton.MouseLeave += new System.EventHandler(this.clearButton_MouseLeave);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.columnsWorkButton);
            this.Controls.Add(this.rowsWorkButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 640);
            this.MinimumSize = new System.Drawing.Size(800, 640);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResizeTool";
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox resultedPictureBox;
        private System.Windows.Forms.Button browseDevelopersButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox horizontalSeamsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox verticalSeamsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button resizeCurrentButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button browseUsersButton;
        private System.Windows.Forms.Button rowsWorkButton;
        private System.Windows.Forms.Button columnsWorkButton;
        private System.Windows.Forms.Button clearButton;
    }
}

