namespace MegaDesk
{
    partial class AddQuote
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
            this.customer_name = new System.Windows.Forms.Label();
            this.desk_width = new System.Windows.Forms.Label();
            this.desk_depth = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.Label();
            this.desktop_surface = new System.Windows.Forms.Label();
            this.delivery_option = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.desktop_surface_combo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.getquote_btn = new System.Windows.Forms.Button();
            this.deskwidthinput = new System.Windows.Forms.TextBox();
            this.deskdepthinput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.Location = new System.Drawing.Point(46, 40);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(82, 13);
            this.customer_name.TabIndex = 0;
            this.customer_name.Text = "&Customer Name";
            // 
            // desk_width
            // 
            this.desk_width.AutoSize = true;
            this.desk_width.Location = new System.Drawing.Point(46, 76);
            this.desk_width.Name = "desk_width";
            this.desk_width.Size = new System.Drawing.Size(75, 13);
            this.desk_width.TabIndex = 1;
            this.desk_width.Text = "Width of Desk";
            // 
            // desk_depth
            // 
            this.desk_depth.AutoSize = true;
            this.desk_depth.Location = new System.Drawing.Point(46, 111);
            this.desk_depth.Name = "desk_depth";
            this.desk_depth.Size = new System.Drawing.Size(76, 13);
            this.desk_depth.TabIndex = 2;
            this.desk_depth.Text = "Depth of Desk";
            // 
            // drawers
            // 
            this.drawers.AutoSize = true;
            this.drawers.Location = new System.Drawing.Point(46, 143);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(98, 13);
            this.drawers.TabIndex = 3;
            this.drawers.Text = "Number of Drawers";
            // 
            // desktop_surface
            // 
            this.desktop_surface.AutoSize = true;
            this.desktop_surface.Location = new System.Drawing.Point(46, 179);
            this.desktop_surface.Name = "desktop_surface";
            this.desktop_surface.Size = new System.Drawing.Size(87, 13);
            this.desktop_surface.TabIndex = 4;
            this.desktop_surface.Text = "Desktop Surface";
            // 
            // delivery_option
            // 
            this.delivery_option.AutoSize = true;
            this.delivery_option.Location = new System.Drawing.Point(46, 211);
            this.delivery_option.Name = "delivery_option";
            this.delivery_option.Size = new System.Drawing.Size(84, 13);
            this.delivery_option.TabIndex = 5;
            this.delivery_option.Text = "Delivery Options";
            this.delivery_option.Click += new System.EventHandler(this.delivery_option_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(211, 109);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "inches";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(211, 74);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "inches";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(211, 141);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown3.TabIndex = 11;
            // 
            // desktop_surface_combo
            // 
            this.desktop_surface_combo.FormattingEnabled = true;
            this.desktop_surface_combo.Location = new System.Drawing.Point(211, 176);
            this.desktop_surface_combo.Name = "desktop_surface_combo";
            this.desktop_surface_combo.Size = new System.Drawing.Size(121, 21);
            this.desktop_surface_combo.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Standard Delivery(14 days)",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.comboBox1.Location = new System.Drawing.Point(211, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(211, 37);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(147, 20);
            this.customerName.TabIndex = 14;
            // 
            // getquote_btn
            // 
            this.getquote_btn.Location = new System.Drawing.Point(182, 339);
            this.getquote_btn.Name = "getquote_btn";
            this.getquote_btn.Size = new System.Drawing.Size(75, 23);
            this.getquote_btn.TabIndex = 15;
            this.getquote_btn.Text = "Get Quote";
            this.getquote_btn.UseVisualStyleBackColor = true;
            this.getquote_btn.Click += new System.EventHandler(this.getquote_btn_Click);
            // 
            // deskwidthinput
            // 
            this.deskwidthinput.Location = new System.Drawing.Point(455, 69);
            this.deskwidthinput.Name = "deskwidthinput";
            this.deskwidthinput.Size = new System.Drawing.Size(100, 20);
            this.deskwidthinput.TabIndex = 16;
            this.deskwidthinput.Validating += new System.ComponentModel.CancelEventHandler(this.deskwidthinput_Validating);
            // 
            // deskdepthinput
            // 
            this.deskdepthinput.Location = new System.Drawing.Point(455, 104);
            this.deskdepthinput.Name = "deskdepthinput";
            this.deskdepthinput.Size = new System.Drawing.Size(103, 20);
            this.deskdepthinput.TabIndex = 17;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deskdepthinput);
            this.Controls.Add(this.deskwidthinput);
            this.Controls.Add(this.getquote_btn);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.desktop_surface_combo);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.delivery_option);
            this.Controls.Add(this.desktop_surface);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.desk_depth);
            this.Controls.Add(this.desk_width);
            this.Controls.Add(this.customer_name);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customer_name;
        private System.Windows.Forms.Label desk_width;
        private System.Windows.Forms.Label desk_depth;
        private System.Windows.Forms.Label drawers;
        private System.Windows.Forms.Label desktop_surface;
        private System.Windows.Forms.Label delivery_option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Button getquote_btn;
        private System.Windows.Forms.TextBox deskwidthinput;
        private System.Windows.Forms.TextBox deskdepthinput;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.NumericUpDown numericUpDown2;
        public System.Windows.Forms.NumericUpDown numericUpDown3;
        public System.Windows.Forms.ComboBox desktop_surface_combo;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}