namespace EntityFrameworkProject
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.tbxProductStockAmountAdd = new System.Windows.Forms.TextBox();
            this.lblProductStockAmountAdd = new System.Windows.Forms.Label();
            this.tbxProductUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.lblProductUnitPriceAdd = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.gbxProductUpdateOrDelete = new System.Windows.Forms.GroupBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.tbxProductStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblProductStockAmountUpdate = new System.Windows.Forms.Label();
            this.tbxProductUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblProductUnitPriceUpdate = new System.Windows.Forms.Label();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.tbxProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdateOrDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(17, 24);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowTemplate.Height = 25;
            this.dgwProducts.Size = new System.Drawing.Size(878, 291);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(57, 27);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(42, 15);
            this.lblProductNameAdd.TabIndex = 1;
            this.lblProductNameAdd.Text = "Name:";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.tbxProductStockAmountAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductStockAmountAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.btnProductAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(164, 321);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(285, 189);
            this.gbxProductAdd.TabIndex = 2;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Product Add";
            // 
            // tbxProductStockAmountAdd
            // 
            this.tbxProductStockAmountAdd.Location = new System.Drawing.Point(105, 91);
            this.tbxProductStockAmountAdd.Name = "tbxProductStockAmountAdd";
            this.tbxProductStockAmountAdd.Size = new System.Drawing.Size(174, 23);
            this.tbxProductStockAmountAdd.TabIndex = 7;
            // 
            // lblProductStockAmountAdd
            // 
            this.lblProductStockAmountAdd.AutoSize = true;
            this.lblProductStockAmountAdd.Location = new System.Drawing.Point(13, 91);
            this.lblProductStockAmountAdd.Name = "lblProductStockAmountAdd";
            this.lblProductStockAmountAdd.Size = new System.Drawing.Size(86, 15);
            this.lblProductStockAmountAdd.TabIndex = 6;
            this.lblProductStockAmountAdd.Text = "Stock Amount:";
            // 
            // tbxProductUnitPriceAdd
            // 
            this.tbxProductUnitPriceAdd.Location = new System.Drawing.Point(105, 56);
            this.tbxProductUnitPriceAdd.Name = "tbxProductUnitPriceAdd";
            this.tbxProductUnitPriceAdd.Size = new System.Drawing.Size(174, 23);
            this.tbxProductUnitPriceAdd.TabIndex = 5;
            // 
            // lblProductUnitPriceAdd
            // 
            this.lblProductUnitPriceAdd.AutoSize = true;
            this.lblProductUnitPriceAdd.Location = new System.Drawing.Point(38, 59);
            this.lblProductUnitPriceAdd.Name = "lblProductUnitPriceAdd";
            this.lblProductUnitPriceAdd.Size = new System.Drawing.Size(61, 15);
            this.lblProductUnitPriceAdd.TabIndex = 4;
            this.lblProductUnitPriceAdd.Text = "Unit Price:";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(145, 120);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(92, 40);
            this.btnProductAdd.TabIndex = 3;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(105, 24);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(174, 23);
            this.tbxProductNameAdd.TabIndex = 2;
            // 
            // gbxProductUpdateOrDelete
            // 
            this.gbxProductUpdateOrDelete.Controls.Add(this.lblProductId);
            this.gbxProductUpdateOrDelete.Controls.Add(this.tbxProductId);
            this.gbxProductUpdateOrDelete.Controls.Add(this.btnProductDelete);
            this.gbxProductUpdateOrDelete.Controls.Add(this.tbxProductStockAmountUpdate);
            this.gbxProductUpdateOrDelete.Controls.Add(this.lblProductStockAmountUpdate);
            this.gbxProductUpdateOrDelete.Controls.Add(this.tbxProductUnitPriceUpdate);
            this.gbxProductUpdateOrDelete.Controls.Add(this.lblProductUnitPriceUpdate);
            this.gbxProductUpdateOrDelete.Controls.Add(this.btnProductUpdate);
            this.gbxProductUpdateOrDelete.Controls.Add(this.tbxProductNameUpdate);
            this.gbxProductUpdateOrDelete.Controls.Add(this.lblProductNameUpdate);
            this.gbxProductUpdateOrDelete.Location = new System.Drawing.Point(479, 321);
            this.gbxProductUpdateOrDelete.Name = "gbxProductUpdateOrDelete";
            this.gbxProductUpdateOrDelete.Size = new System.Drawing.Size(298, 189);
            this.gbxProductUpdateOrDelete.TabIndex = 8;
            this.gbxProductUpdateOrDelete.TabStop = false;
            this.gbxProductUpdateOrDelete.Text = "Product Update/Delete";
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(200, 147);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(92, 40);
            this.btnProductDelete.TabIndex = 8;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // tbxProductStockAmountUpdate
            // 
            this.tbxProductStockAmountUpdate.Location = new System.Drawing.Point(105, 118);
            this.tbxProductStockAmountUpdate.Name = "tbxProductStockAmountUpdate";
            this.tbxProductStockAmountUpdate.Size = new System.Drawing.Size(187, 23);
            this.tbxProductStockAmountUpdate.TabIndex = 7;
            // 
            // lblProductStockAmountUpdate
            // 
            this.lblProductStockAmountUpdate.AutoSize = true;
            this.lblProductStockAmountUpdate.Location = new System.Drawing.Point(13, 118);
            this.lblProductStockAmountUpdate.Name = "lblProductStockAmountUpdate";
            this.lblProductStockAmountUpdate.Size = new System.Drawing.Size(86, 15);
            this.lblProductStockAmountUpdate.TabIndex = 6;
            this.lblProductStockAmountUpdate.Text = "Stock Amount:";
            // 
            // tbxProductUnitPriceUpdate
            // 
            this.tbxProductUnitPriceUpdate.Location = new System.Drawing.Point(105, 83);
            this.tbxProductUnitPriceUpdate.Name = "tbxProductUnitPriceUpdate";
            this.tbxProductUnitPriceUpdate.Size = new System.Drawing.Size(187, 23);
            this.tbxProductUnitPriceUpdate.TabIndex = 5;
            // 
            // lblProductUnitPriceUpdate
            // 
            this.lblProductUnitPriceUpdate.AutoSize = true;
            this.lblProductUnitPriceUpdate.Location = new System.Drawing.Point(38, 86);
            this.lblProductUnitPriceUpdate.Name = "lblProductUnitPriceUpdate";
            this.lblProductUnitPriceUpdate.Size = new System.Drawing.Size(61, 15);
            this.lblProductUnitPriceUpdate.TabIndex = 4;
            this.lblProductUnitPriceUpdate.Text = "Unit Price:";
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(105, 147);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(92, 40);
            this.btnProductUpdate.TabIndex = 3;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(105, 51);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(187, 23);
            this.tbxProductNameUpdate.TabIndex = 2;
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(57, 54);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(42, 15);
            this.lblProductNameUpdate.TabIndex = 1;
            this.lblProductNameUpdate.Text = "Name:";
            // 
            // tbxProductId
            // 
            this.tbxProductId.Location = new System.Drawing.Point(105, 22);
            this.tbxProductId.Name = "tbxProductId";
            this.tbxProductId.Size = new System.Drawing.Size(187, 23);
            this.tbxProductId.TabIndex = 9;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(79, 27);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(20, 15);
            this.lblProductId.TabIndex = 10;
            this.lblProductId.Text = "Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(907, 510);
            this.Controls.Add(this.gbxProductUpdateOrDelete);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Entity Framework Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdateOrDelete.ResumeLayout(false);
            this.gbxProductUpdateOrDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwProducts;
        private Label lblProductNameAdd;
        private GroupBox gbxProductAdd;
        private TextBox tbxProductStockAmountAdd;
        private Label lblProductStockAmountAdd;
        private TextBox tbxProductUnitPriceAdd;
        private Label lblProductUnitPriceAdd;
        private Button btnProductAdd;
        private TextBox tbxProductNameAdd;
        private GroupBox gbxProductUpdateOrDelete;
        private Button btnProductDelete;
        private TextBox tbxProductStockAmountUpdate;
        private Label lblProductStockAmountUpdate;
        private TextBox tbxProductUnitPriceUpdate;
        private Label lblProductUnitPriceUpdate;
        private Button btnProductUpdate;
        private TextBox tbxProductNameUpdate;
        private Label lblProductNameUpdate;
        private Label lblProductId;
        private TextBox tbxProductId;
    }
}