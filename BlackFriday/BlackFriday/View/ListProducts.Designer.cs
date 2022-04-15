
namespace BlackFriday
{
    partial class ListProducts
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
            this.listProdGrid = new System.Windows.Forms.DataGridView();
            this.blackFridayCheckBox = new System.Windows.Forms.CheckBox();
            this.okListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listProdGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listProdGrid
            // 
            this.listProdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProdGrid.Location = new System.Drawing.Point(37, 41);
            this.listProdGrid.Name = "listProdGrid";
            this.listProdGrid.RowHeadersWidth = 51;
            this.listProdGrid.RowTemplate.Height = 29;
            this.listProdGrid.Size = new System.Drawing.Size(678, 359);
            this.listProdGrid.TabIndex = 0;
            // 
            // blackFridayCheckBox
            // 
            this.blackFridayCheckBox.AutoSize = true;
            this.blackFridayCheckBox.Location = new System.Drawing.Point(566, 12);
            this.blackFridayCheckBox.Name = "blackFridayCheckBox";
            this.blackFridayCheckBox.Size = new System.Drawing.Size(110, 24);
            this.blackFridayCheckBox.TabIndex = 1;
            this.blackFridayCheckBox.Text = "Black Friday";
            this.blackFridayCheckBox.UseVisualStyleBackColor = true;
            this.blackFridayCheckBox.CheckedChanged += new System.EventHandler(this.blackFridayCheckBox_CheckedChanged);
            // 
            // okListButton
            // 
            this.okListButton.Location = new System.Drawing.Point(556, 409);
            this.okListButton.Name = "okListButton";
            this.okListButton.Size = new System.Drawing.Size(159, 29);
            this.okListButton.TabIndex = 2;
            this.okListButton.Text = "Ok";
            this.okListButton.UseVisualStyleBackColor = true;
            this.okListButton.Click += new System.EventHandler(this.okListButton_Click);
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 459);
            this.Controls.Add(this.okListButton);
            this.Controls.Add(this.blackFridayCheckBox);
            this.Controls.Add(this.listProdGrid);
            this.Name = "ListProducts";
            this.Text = "ListProducts";
            ((System.ComponentModel.ISupportInitialize)(this.listProdGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listProdGrid;
        private System.Windows.Forms.CheckBox blackFridayCheckBox;
        private System.Windows.Forms.Button okListButton;
    }
}