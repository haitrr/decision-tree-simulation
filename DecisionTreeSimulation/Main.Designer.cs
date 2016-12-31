namespace DecisionTreeSimulation
{
    partial class Main
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.addClause_Button = new System.Windows.Forms.Button();
            this.removeClause_Button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.inputClause_TextBox = new System.Windows.Forms.TextBox();
            this.buildDecisionTree_Button = new System.Windows.Forms.Button();
            this.graph_Panel = new DecisionTreeSimulation.DoubleBufferedPanel();
            this.open_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 30);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(401, 511);
            this.dataGrid.TabIndex = 0;
            // 
            // addClause_Button
            // 
            this.addClause_Button.Location = new System.Drawing.Point(175, 1);
            this.addClause_Button.Name = "addClause_Button";
            this.addClause_Button.Size = new System.Drawing.Size(70, 23);
            this.addClause_Button.TabIndex = 1;
            this.addClause_Button.Text = "Add Clause";
            this.addClause_Button.UseVisualStyleBackColor = true;
            this.addClause_Button.Click += new System.EventHandler(this.addClause_Button_Click);
            // 
            // removeClause_Button
            // 
            this.removeClause_Button.Location = new System.Drawing.Point(251, 1);
            this.removeClause_Button.Name = "removeClause_Button";
            this.removeClause_Button.Size = new System.Drawing.Size(92, 23);
            this.removeClause_Button.TabIndex = 2;
            this.removeClause_Button.Text = "Remove Clause";
            this.removeClause_Button.UseVisualStyleBackColor = true;
            this.removeClause_Button.Click += new System.EventHandler(this.removeClause_Button_Click);
            // 
            // reset_Button
            // 
            this.reset_Button.Location = new System.Drawing.Point(349, 1);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(52, 23);
            this.reset_Button.TabIndex = 3;
            this.reset_Button.Text = "Reset";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // inputClause_TextBox
            // 
            this.inputClause_TextBox.Location = new System.Drawing.Point(12, 3);
            this.inputClause_TextBox.Name = "inputClause_TextBox";
            this.inputClause_TextBox.Size = new System.Drawing.Size(157, 20);
            this.inputClause_TextBox.TabIndex = 4;
            // 
            // buildDecisionTree_Button
            // 
            this.buildDecisionTree_Button.Location = new System.Drawing.Point(806, 0);
            this.buildDecisionTree_Button.Name = "buildDecisionTree_Button";
            this.buildDecisionTree_Button.Size = new System.Drawing.Size(132, 23);
            this.buildDecisionTree_Button.TabIndex = 5;
            this.buildDecisionTree_Button.Text = "Build Decision Tree";
            this.buildDecisionTree_Button.UseVisualStyleBackColor = true;
            this.buildDecisionTree_Button.Click += new System.EventHandler(this.buildDecisionTree_Button_Click);
            // 
            // graph_Panel
            // 
            this.graph_Panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.graph_Panel.Location = new System.Drawing.Point(417, 30);
            this.graph_Panel.Name = "graph_Panel";
            this.graph_Panel.Size = new System.Drawing.Size(863, 511);
            this.graph_Panel.TabIndex = 6;
            this.graph_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_Panel_Paint);
            // 
            // open_Button
            // 
            this.open_Button.Location = new System.Drawing.Point(407, 1);
            this.open_Button.Name = "open_Button";
            this.open_Button.Size = new System.Drawing.Size(75, 23);
            this.open_Button.TabIndex = 7;
            this.open_Button.Text = "Open";
            this.open_Button.UseVisualStyleBackColor = true;
            this.open_Button.Click += new System.EventHandler(this.open_Button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 542);
            this.Controls.Add(this.open_Button);
            this.Controls.Add(this.graph_Panel);
            this.Controls.Add(this.buildDecisionTree_Button);
            this.Controls.Add(this.inputClause_TextBox);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.removeClause_Button);
            this.Controls.Add(this.addClause_Button);
            this.Controls.Add(this.dataGrid);
            this.Name = "Main";
            this.Text = "Decision Tree Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button addClause_Button;
        private System.Windows.Forms.Button removeClause_Button;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.TextBox inputClause_TextBox;
        private System.Windows.Forms.Button buildDecisionTree_Button;
        private DoubleBufferedPanel graph_Panel;
        private System.Windows.Forms.Button open_Button;
    }
}

