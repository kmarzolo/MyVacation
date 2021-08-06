
namespace MyVacation
{
    partial class FlightForm
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
            this.LoginUserLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.DeltaLabel = new System.Windows.Forms.Label();
            this.SpiritLabel = new System.Windows.Forms.Label();
            this.UnitedAirLabel = new System.Windows.Forms.Label();
            this.SWAirLabel = new System.Windows.Forms.Label();
            this.JetBlueLabel = new System.Windows.Forms.Label();
            this.AmAirLabel = new System.Windows.Forms.Label();
            this.DeltaBuy = new System.Windows.Forms.Button();
            this.SpiritBuy = new System.Windows.Forms.Button();
            this.UABuy = new System.Windows.Forms.Button();
            this.SWBuy = new System.Windows.Forms.Button();
            this.JetBlueBuy = new System.Windows.Forms.Button();
            this.AABuy = new System.Windows.Forms.Button();
            this.DeltaPrice = new System.Windows.Forms.Label();
            this.SpiritPrice = new System.Windows.Forms.Label();
            this.UAPrice = new System.Windows.Forms.Label();
            this.SWPrice = new System.Windows.Forms.Label();
            this.JetBluePrice = new System.Windows.Forms.Label();
            this.AAPrice = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginUserLabel
            // 
            this.LoginUserLabel.AutoSize = true;
            this.LoginUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginUserLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUserLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginUserLabel.Name = "LoginUserLabel";
            this.LoginUserLabel.Size = new System.Drawing.Size(222, 42);
            this.LoginUserLabel.TabIndex = 0;
            this.LoginUserLabel.Text = "User: Guest";
            this.LoginUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FlightLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoginUserLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeltaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SpiritLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UnitedAirLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SWAirLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.JetBlueLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.AmAirLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.DeltaBuy, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SpiritBuy, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.UABuy, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.SWBuy, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.JetBlueBuy, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.AABuy, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.DeltaPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SpiritPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UAPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SWPrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.JetBluePrice, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.AAPrice, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(69, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 295);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FlightLabel
            // 
            this.FlightLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.FlightLabel, 2);
            this.FlightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlightLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightLabel.Location = new System.Drawing.Point(231, 0);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(322, 42);
            this.FlightLabel.TabIndex = 2;
            this.FlightLabel.Text = "ExampleFlight";
            this.FlightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeltaLabel
            // 
            this.DeltaLabel.AutoSize = true;
            this.DeltaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeltaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeltaLabel.Location = new System.Drawing.Point(3, 42);
            this.DeltaLabel.Name = "DeltaLabel";
            this.DeltaLabel.Size = new System.Drawing.Size(222, 42);
            this.DeltaLabel.TabIndex = 3;
            this.DeltaLabel.Text = "Delta";
            this.DeltaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpiritLabel
            // 
            this.SpiritLabel.AutoSize = true;
            this.SpiritLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpiritLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpiritLabel.Location = new System.Drawing.Point(3, 84);
            this.SpiritLabel.Name = "SpiritLabel";
            this.SpiritLabel.Size = new System.Drawing.Size(222, 42);
            this.SpiritLabel.TabIndex = 4;
            this.SpiritLabel.Text = "Spirit";
            this.SpiritLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitedAirLabel
            // 
            this.UnitedAirLabel.AutoSize = true;
            this.UnitedAirLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitedAirLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitedAirLabel.Location = new System.Drawing.Point(3, 126);
            this.UnitedAirLabel.Name = "UnitedAirLabel";
            this.UnitedAirLabel.Size = new System.Drawing.Size(222, 42);
            this.UnitedAirLabel.TabIndex = 5;
            this.UnitedAirLabel.Text = "United Airlines";
            this.UnitedAirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SWAirLabel
            // 
            this.SWAirLabel.AutoSize = true;
            this.SWAirLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SWAirLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWAirLabel.Location = new System.Drawing.Point(3, 168);
            this.SWAirLabel.Name = "SWAirLabel";
            this.SWAirLabel.Size = new System.Drawing.Size(222, 42);
            this.SWAirLabel.TabIndex = 6;
            this.SWAirLabel.Text = "Southwest Airlines";
            this.SWAirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JetBlueLabel
            // 
            this.JetBlueLabel.AutoSize = true;
            this.JetBlueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JetBlueLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JetBlueLabel.Location = new System.Drawing.Point(3, 210);
            this.JetBlueLabel.Name = "JetBlueLabel";
            this.JetBlueLabel.Size = new System.Drawing.Size(222, 42);
            this.JetBlueLabel.TabIndex = 7;
            this.JetBlueLabel.Text = "JetBlue";
            this.JetBlueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmAirLabel
            // 
            this.AmAirLabel.AutoSize = true;
            this.AmAirLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmAirLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmAirLabel.Location = new System.Drawing.Point(3, 252);
            this.AmAirLabel.Name = "AmAirLabel";
            this.AmAirLabel.Size = new System.Drawing.Size(222, 43);
            this.AmAirLabel.TabIndex = 8;
            this.AmAirLabel.Text = "American Airlines";
            this.AmAirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeltaBuy
            // 
            this.DeltaBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeltaBuy.AutoSize = true;
            this.DeltaBuy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeltaBuy.Location = new System.Drawing.Point(468, 51);
            this.DeltaBuy.Name = "DeltaBuy";
            this.DeltaBuy.Size = new System.Drawing.Size(75, 24);
            this.DeltaBuy.TabIndex = 0;
            this.DeltaBuy.Text = "Buy";
            this.DeltaBuy.UseVisualStyleBackColor = true;
            this.DeltaBuy.Click += new System.EventHandler(this.DeltaBuy_Click);
            // 
            // SpiritBuy
            // 
            this.SpiritBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpiritBuy.AutoSize = true;
            this.SpiritBuy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpiritBuy.Location = new System.Drawing.Point(468, 93);
            this.SpiritBuy.Name = "SpiritBuy";
            this.SpiritBuy.Size = new System.Drawing.Size(75, 24);
            this.SpiritBuy.TabIndex = 1;
            this.SpiritBuy.Text = "Buy";
            this.SpiritBuy.UseVisualStyleBackColor = true;
            this.SpiritBuy.Click += new System.EventHandler(this.SpiritBuy_Click);
            // 
            // UABuy
            // 
            this.UABuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UABuy.AutoSize = true;
            this.UABuy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UABuy.Location = new System.Drawing.Point(468, 135);
            this.UABuy.Name = "UABuy";
            this.UABuy.Size = new System.Drawing.Size(75, 24);
            this.UABuy.TabIndex = 2;
            this.UABuy.Text = "Buy";
            this.UABuy.UseVisualStyleBackColor = true;
            this.UABuy.Click += new System.EventHandler(this.UABuy_Click);
            // 
            // SWBuy
            // 
            this.SWBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SWBuy.AutoSize = true;
            this.SWBuy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWBuy.Location = new System.Drawing.Point(468, 177);
            this.SWBuy.Name = "SWBuy";
            this.SWBuy.Size = new System.Drawing.Size(75, 24);
            this.SWBuy.TabIndex = 3;
            this.SWBuy.Text = "Buy";
            this.SWBuy.UseVisualStyleBackColor = true;
            this.SWBuy.Click += new System.EventHandler(this.SWBuy_Click);
            // 
            // JetBlueBuy
            // 
            this.JetBlueBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.JetBlueBuy.AutoSize = true;
            this.JetBlueBuy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JetBlueBuy.Location = new System.Drawing.Point(468, 219);
            this.JetBlueBuy.Name = "JetBlueBuy";
            this.JetBlueBuy.Size = new System.Drawing.Size(75, 24);
            this.JetBlueBuy.TabIndex = 4;
            this.JetBlueBuy.Text = "Buy";
            this.JetBlueBuy.UseVisualStyleBackColor = true;
            this.JetBlueBuy.Click += new System.EventHandler(this.JetBlueBuy_Click);
            // 
            // AABuy
            // 
            this.AABuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AABuy.AutoSize = true;
            this.AABuy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AABuy.Location = new System.Drawing.Point(468, 261);
            this.AABuy.Name = "AABuy";
            this.AABuy.Size = new System.Drawing.Size(75, 24);
            this.AABuy.TabIndex = 5;
            this.AABuy.Text = "Buy";
            this.AABuy.UseVisualStyleBackColor = true;
            this.AABuy.Click += new System.EventHandler(this.AABuy_Click);
            // 
            // DeltaPrice
            // 
            this.DeltaPrice.AutoSize = true;
            this.DeltaPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeltaPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeltaPrice.Location = new System.Drawing.Point(231, 42);
            this.DeltaPrice.Name = "DeltaPrice";
            this.DeltaPrice.Size = new System.Drawing.Size(222, 42);
            this.DeltaPrice.TabIndex = 15;
            this.DeltaPrice.Text = "Delta Price";
            this.DeltaPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpiritPrice
            // 
            this.SpiritPrice.AutoSize = true;
            this.SpiritPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpiritPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpiritPrice.Location = new System.Drawing.Point(231, 84);
            this.SpiritPrice.Name = "SpiritPrice";
            this.SpiritPrice.Size = new System.Drawing.Size(222, 42);
            this.SpiritPrice.TabIndex = 16;
            this.SpiritPrice.Text = "Spirit Price";
            this.SpiritPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UAPrice
            // 
            this.UAPrice.AutoSize = true;
            this.UAPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UAPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UAPrice.Location = new System.Drawing.Point(231, 126);
            this.UAPrice.Name = "UAPrice";
            this.UAPrice.Size = new System.Drawing.Size(222, 42);
            this.UAPrice.TabIndex = 17;
            this.UAPrice.Text = "UA Price";
            this.UAPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SWPrice
            // 
            this.SWPrice.AutoSize = true;
            this.SWPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SWPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWPrice.Location = new System.Drawing.Point(231, 168);
            this.SWPrice.Name = "SWPrice";
            this.SWPrice.Size = new System.Drawing.Size(222, 42);
            this.SWPrice.TabIndex = 18;
            this.SWPrice.Text = "SW Price";
            this.SWPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JetBluePrice
            // 
            this.JetBluePrice.AutoSize = true;
            this.JetBluePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JetBluePrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JetBluePrice.Location = new System.Drawing.Point(231, 210);
            this.JetBluePrice.Name = "JetBluePrice";
            this.JetBluePrice.Size = new System.Drawing.Size(222, 42);
            this.JetBluePrice.TabIndex = 19;
            this.JetBluePrice.Text = "JetBlue Price";
            this.JetBluePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AAPrice
            // 
            this.AAPrice.AutoSize = true;
            this.AAPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AAPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAPrice.Location = new System.Drawing.Point(231, 252);
            this.AAPrice.Name = "AAPrice";
            this.AAPrice.Size = new System.Drawing.Size(222, 43);
            this.AAPrice.TabIndex = 20;
            this.AAPrice.Text = "AA Price";
            this.AAPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(314, 378);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 447);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FlightForm";
            this.Text = "FlightForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginUserLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label FlightLabel;
        private System.Windows.Forms.Label DeltaLabel;
        private System.Windows.Forms.Label SpiritLabel;
        private System.Windows.Forms.Label UnitedAirLabel;
        private System.Windows.Forms.Label SWAirLabel;
        private System.Windows.Forms.Label JetBlueLabel;
        private System.Windows.Forms.Label AmAirLabel;
        private System.Windows.Forms.Button DeltaBuy;
        private System.Windows.Forms.Button SpiritBuy;
        private System.Windows.Forms.Button UABuy;
        private System.Windows.Forms.Button SWBuy;
        private System.Windows.Forms.Button JetBlueBuy;
        private System.Windows.Forms.Button AABuy;
        private System.Windows.Forms.Label DeltaPrice;
        private System.Windows.Forms.Label SpiritPrice;
        private System.Windows.Forms.Label UAPrice;
        private System.Windows.Forms.Label SWPrice;
        private System.Windows.Forms.Label JetBluePrice;
        private System.Windows.Forms.Label AAPrice;
        private System.Windows.Forms.Button CancelButton;
    }
}