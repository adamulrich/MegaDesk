﻿namespace MegaDesk
{
    partial class SearchQuotes
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
            this.cbo_MaterialType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_MaterialType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbo_MaterialType
            // 
            this.cbo_MaterialType.FormattingEnabled = true;
            this.cbo_MaterialType.Location = new System.Drawing.Point(188, 40);
            this.cbo_MaterialType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_MaterialType.Name = "cbo_MaterialType";
            this.cbo_MaterialType.Size = new System.Drawing.Size(180, 28);
            this.cbo_MaterialType.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 103);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1232, 818);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_MaterialType
            // 
            this.lbl_MaterialType.AutoSize = true;
            this.lbl_MaterialType.Location = new System.Drawing.Point(18, 45);
            this.lbl_MaterialType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaterialType.Name = "lbl_MaterialType";
            this.lbl_MaterialType.Size = new System.Drawing.Size(103, 20);
            this.lbl_MaterialType.TabIndex = 2;
            this.lbl_MaterialType.Text = "Material Type";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 923);
            this.Controls.Add(this.lbl_MaterialType);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cbo_MaterialType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SearchQuotes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Search Quotes by Material Type";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_MaterialType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_MaterialType;
    }
}