using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RecipeManager.Models;
using Microsoft.EntityFrameworkCore;

namespace RecipeManager
{
    public partial class Form1 : Form
    {
        private RecipeManagerContext context;

        public Form1()
        {
            InitializeComponent();
        }

        public void LoadDatabase()
        {
            context = new RecipeManagerContext();
            context.Recipes.Include(r => r.Ingredients).Include(r => r.Steps).Load();
            recipeBindingSource.DataSource = context.Recipes.Local.ToBindingList();
        }

        public void SaveDatabase()
        {
            ingredientsDataGridView.EndEdit();
            stepsDataGridView.EndEdit();

            ingredientsBindingSource.EndEdit();
            stepsBindingSource.EndEdit();

            recipeBindingSource.EndEdit();

            context.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDatabase();
        }

        private void recipeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveDatabase();
            LoadDatabase();
        }

        private void recipeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Recipe current = (Recipe)recipeBindingSource.Current;
            if (current == null)
            {
                recipeGroupBox.Enabled = false;
                stepsGroupBox.Enabled = false;
                ingredientsGroupBox.Enabled = false;
                return;
            }

            if (current.RecipeId==0)
            {
                recipeGroupBox.Enabled = true;
                stepsGroupBox.Enabled = false;
                ingredientsGroupBox.Enabled = false;
                return;
            }

            recipeGroupBox.Enabled = true;
            stepsGroupBox.Enabled = true;
            ingredientsGroupBox.Enabled = true;
            return;

        }
    }
}
