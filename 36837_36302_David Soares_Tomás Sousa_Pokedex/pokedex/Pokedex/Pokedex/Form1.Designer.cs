namespace Pokedex
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.dgv_stats = new System.Windows.Forms.DataGridView();
            this.dgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_defense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_attack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_spDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_totalStats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stats)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(53, 7);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(365, 14);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(34, 13);
            this.lbl_Type.TabIndex = 6;
            this.lbl_Type.Text = "Type:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(365, 50);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(41, 13);
            this.lbl_weight.TabIndex = 7;
            this.lbl_weight.Text = "weight:";
            // 
            // dgv_stats
            // 
            this.dgv_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_hp,
            this.dgv_speed,
            this.dgv_defense,
            this.dgv_attack,
            this.dgv_spDefense,
            this.dgv_totalStats});
            this.dgv_stats.Location = new System.Drawing.Point(43, 142);
            this.dgv_stats.Name = "dgv_stats";
            this.dgv_stats.Size = new System.Drawing.Size(745, 296);
            this.dgv_stats.TabIndex = 8;
            this.dgv_stats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv_id
            // 
            this.dgv_id.HeaderText = "id";
            this.dgv_id.Name = "dgv_id";
            // 
            // dgv_hp
            // 
            this.dgv_hp.HeaderText = "hp";
            this.dgv_hp.Name = "dgv_hp";
            // 
            // dgv_speed
            // 
            this.dgv_speed.HeaderText = "speed";
            this.dgv_speed.Name = "dgv_speed";
            // 
            // dgv_defense
            // 
            this.dgv_defense.HeaderText = "defense";
            this.dgv_defense.Name = "dgv_defense";
            // 
            // dgv_attack
            // 
            this.dgv_attack.HeaderText = "attack";
            this.dgv_attack.Name = "dgv_attack";
            // 
            // dgv_spDefense
            // 
            this.dgv_spDefense.HeaderText = "spDefense";
            this.dgv_spDefense.Name = "dgv_spDefense";
            // 
            // dgv_totalStats
            // 
            this.dgv_totalStats.HeaderText = "totalStats";
            this.dgv_totalStats.Name = "dgv_totalStats";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_stats);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.DataGridView dgv_stats;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_hp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_defense;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_attack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_spDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_totalStats;
    }
}

