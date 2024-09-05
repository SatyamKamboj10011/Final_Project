namespace Form_Loading
{
    partial class FormCart
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
            this.tabOrderForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.dudProducts = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblltemsOrdered = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtMailingLabel = new System.Windows.Forms.TextBox();
            this.tabOrderForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrderForm
            // 
            this.tabOrderForm.Controls.Add(this.tabPage1);
            this.tabOrderForm.Controls.Add(this.tabPage2);
            this.tabOrderForm.Controls.Add(this.tabPage3);
            this.tabOrderForm.Location = new System.Drawing.Point(244, 56);
            this.tabOrderForm.Name = "tabOrderForm";
            this.tabOrderForm.SelectedIndex = 0;
            this.tabOrderForm.Size = new System.Drawing.Size(790, 571);
            this.tabOrderForm.TabIndex = 0;
            this.tabOrderForm.SelectedIndexChanged += new System.EventHandler(this.tabShoppingCart_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnNewOrder);
            this.tabPage1.Controls.Add(this.lblltemsOrdered);
            this.tabPage1.Controls.Add(this.btnAddToOrder);
            this.tabPage1.Controls.Add(this.dudProducts);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtOrderAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(122, 406);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(123, 38);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // dudProducts
            // 
            this.dudProducts.Location = new System.Drawing.Point(297, 413);
            this.dudProducts.Name = "dudProducts";
            this.dudProducts.Size = new System.Drawing.Size(162, 26);
            this.dudProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Address";
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Location = new System.Drawing.Point(49, 78);
            this.txtOrderAddress.Multiline = true;
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.Size = new System.Drawing.Size(676, 322);
            this.txtOrderAddress.TabIndex = 0;
            this.txtOrderAddress.TextChanged += new System.EventHandler(this.txtOrderAddress_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotalCost);
            this.tabPage2.Controls.Add(this.lstProducts);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shopping Cart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtMailingLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(782, 538);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mailing Label";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblltemsOrdered
            // 
            this.lblltemsOrdered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblltemsOrdered.Location = new System.Drawing.Point(297, 487);
            this.lblltemsOrdered.Name = "lblltemsOrdered";
            this.lblltemsOrdered.Size = new System.Drawing.Size(186, 27);
            this.lblltemsOrdered.TabIndex = 4;
            this.lblltemsOrdered.Text = "Items Ordered: 0";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(122, 480);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(123, 34);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(599, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 20;
            this.lstProducts.Location = new System.Drawing.Point(126, 46);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(503, 264);
            this.lstProducts.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(291, 365);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(132, 34);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // txtMailingLabel
            // 
            this.txtMailingLabel.Enabled = false;
            this.txtMailingLabel.Location = new System.Drawing.Point(51, 35);
            this.txtMailingLabel.Multiline = true;
            this.txtMailingLabel.Name = "txtMailingLabel";
            this.txtMailingLabel.Size = new System.Drawing.Size(667, 343);
            this.txtMailingLabel.TabIndex = 0;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Form_Loading.Properties.Resources.paper_1074131_19201;
            this.ClientSize = new System.Drawing.Size(1260, 731);
            this.Controls.Add(this.tabOrderForm);
            this.Name = "FormCart";
            this.Text = "FormCart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.tabOrderForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrderForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtOrderAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudProducts;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblltemsOrdered;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtMailingLabel;
    }
}