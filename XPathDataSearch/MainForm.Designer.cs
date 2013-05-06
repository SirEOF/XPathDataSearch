namespace XPathDataSearch
{
    partial class MainForm
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
            this.xpath_textbox = new System.Windows.Forms.TextBox();
            this.query_button = new System.Windows.Forms.Button();
            this.result_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.columns_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.file_textbox = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.namespace_grid = new System.Windows.Forms.DataGridView();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namespace_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // xpath_textbox
            // 
            this.xpath_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xpath_textbox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpath_textbox.Location = new System.Drawing.Point(12, 160);
            this.xpath_textbox.Name = "xpath_textbox";
            this.xpath_textbox.Size = new System.Drawing.Size(677, 20);
            this.xpath_textbox.TabIndex = 0;
            // 
            // query_button
            // 
            this.query_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.query_button.Location = new System.Drawing.Point(12, 321);
            this.query_button.Name = "query_button";
            this.query_button.Size = new System.Drawing.Size(75, 26);
            this.query_button.TabIndex = 1;
            this.query_button.Text = "Run";
            this.query_button.UseVisualStyleBackColor = true;
            this.query_button.Click += new System.EventHandler(this.query_button_Click);
            // 
            // result_grid
            // 
            this.result_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_grid.Location = new System.Drawing.Point(12, 353);
            this.result_grid.Name = "result_grid";
            this.result_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_grid.Size = new System.Drawing.Size(677, 397);
            this.result_grid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select:";
            // 
            // columns_grid
            // 
            this.columns_grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columns_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columns_grid.Location = new System.Drawing.Point(12, 199);
            this.columns_grid.Name = "columns_grid";
            this.columns_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns_grid.Size = new System.Drawing.Size(677, 116);
            this.columns_grid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File:";
            // 
            // file_textbox
            // 
            this.file_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_textbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_textbox.Location = new System.Drawing.Point(44, 16);
            this.file_textbox.Name = "file_textbox";
            this.file_textbox.Size = new System.Drawing.Size(564, 22);
            this.file_textbox.TabIndex = 6;
            // 
            // browse_button
            // 
            this.browse_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browse_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_button.Location = new System.Drawing.Point(614, 12);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 26);
            this.browse_button.TabIndex = 8;
            this.browse_button.Text = "Browse...";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Namespaces:";
            // 
            // namespace_grid
            // 
            this.namespace_grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namespace_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namespace_grid.Location = new System.Drawing.Point(12, 57);
            this.namespace_grid.Name = "namespace_grid";
            this.namespace_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namespace_grid.Size = new System.Drawing.Size(677, 84);
            this.namespace_grid.TabIndex = 9;
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(93, 321);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 26);
            this.save_button.TabIndex = 11;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_button.Location = new System.Drawing.Point(174, 321);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 26);
            this.load_button.TabIndex = 12;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 762);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namespace_grid);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.file_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.columns_grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_grid);
            this.Controls.Add(this.query_button);
            this.Controls.Add(this.xpath_textbox);
            this.Name = "MainForm";
            this.Text = "XPath Data Search";
            ((System.ComponentModel.ISupportInitialize)(this.result_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columns_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namespace_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xpath_textbox;
        private System.Windows.Forms.Button query_button;
        private System.Windows.Forms.DataGridView result_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView columns_grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox file_textbox;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView namespace_grid;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
    }
}

