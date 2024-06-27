namespace SepiolInjector
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            printPreviewDialog1 = new PrintPreviewDialog();
            fileList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            selectDllButton = new Button();
            processList = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            processSearch = new TextBox();
            label1 = new Label();
            injectButton = new Button();
            refreshButton = new Button();
            SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // fileList
            // 
            fileList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            fileList.FullRowSelect = true;
            fileList.Location = new Point(12, 12);
            fileList.Name = "fileList";
            fileList.Size = new Size(300, 133);
            fileList.TabIndex = 4;
            fileList.UseCompatibleStateImageBehavior = false;
            fileList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "File Name";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Path";
            columnHeader2.Width = 200;
            // 
            // selectDllButton
            // 
            selectDllButton.Location = new Point(12, 151);
            selectDllButton.Name = "selectDllButton";
            selectDllButton.Size = new Size(145, 23);
            selectDllButton.TabIndex = 6;
            selectDllButton.Text = "Select dll";
            selectDllButton.UseVisualStyleBackColor = true;
            selectDllButton.Click += selectDllButton_Click;
            // 
            // processList
            // 
            processList.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            processList.FullRowSelect = true;
            processList.Location = new Point(318, 12);
            processList.Name = "processList";
            processList.Size = new Size(154, 192);
            processList.TabIndex = 8;
            processList.UseCompatibleStateImageBehavior = false;
            processList.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "Name";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 0;
            columnHeader4.Text = "PID";
            columnHeader4.Width = 50;
            // 
            // processSearch
            // 
            processSearch.Location = new Point(395, 210);
            processSearch.Name = "processSearch";
            processSearch.Size = new Size(77, 23);
            processSearch.TabIndex = 10;
            processSearch.TextChanged += processSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 213);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 9;
            label1.Text = "Filter Name:";
            // 
            // injectButton
            // 
            injectButton.Location = new Point(167, 151);
            injectButton.Name = "injectButton";
            injectButton.Size = new Size(145, 23);
            injectButton.TabIndex = 11;
            injectButton.Text = "Inject";
            injectButton.UseVisualStyleBackColor = true;
            injectButton.Click += injectButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(167, 181);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(145, 23);
            refreshButton.TabIndex = 12;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 241);
            Controls.Add(refreshButton);
            Controls.Add(injectButton);
            Controls.Add(processSearch);
            Controls.Add(label1);
            Controls.Add(processList);
            Controls.Add(selectDllButton);
            Controls.Add(fileList);
            MaximumSize = new Size(500, 280);
            MinimumSize = new Size(500, 280);
            Name = "Form1";
            Text = "SepiolInjector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PrintPreviewDialog printPreviewDialog1;
        private ListView fileList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button selectDllButton;
        private ListView processList;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox processSearch;
        private Label label1;
        private Button injectButton;
        private Button refreshButton;
    }
}
