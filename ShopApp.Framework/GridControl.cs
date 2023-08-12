using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Framework
{
    public class GridControlButtomModel
    {
        public string Text { get; set; }
        public Action<DataGridViewRow> OnClick { get; set; }
    }
    public class GridControl<TModel>
    {
        DataGridView grid;
        BindingSource bindingSource;

        Dictionary<int, GridControlButtomModel> gridButtons = new Dictionary<int, GridControlButtomModel>();

        public bool AllowAddRows {
            get { return grid.AllowUserToAddRows; }
            set { grid.AllowUserToAddRows=value; }
        }
        public bool AllowDeleteRows
        {
            get { return grid.AllowUserToDeleteRows; }
            set { grid.AllowUserToDeleteRows = value; }
        }
        public DataGridViewEditMode EditMode
        {
            get { return grid.EditMode; }
            set { grid.EditMode = value; }
        }
        public GridControl(Control container)
        {
            grid =new DataGridView();
            container.Controls.Add(grid);
            grid.Dock = DockStyle.Fill;
            grid.AutoGenerateColumns = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = true;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowPrePaint += Grid_RowPrePaint;
            grid.CellContentClick += Grid_CellContentClick;
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridButtons.ContainsKey(e.ColumnIndex))
            {
                gridButtons[e.ColumnIndex].OnClick(grid.Rows[e.RowIndex]);
            }
        }

        private void Grid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (var  item in gridButtons)
            {
                grid.Rows[e.RowIndex].Cells[item.Key].Value = item.Value.Text;
            }
        }

        public GridControl<TModel> AddButtonColumn(string title,Action<DataGridViewRow> onClick)
        {
            grid.Columns.Add(new DataGridViewButtonColumn()
            {
                Text=title

            });
            gridButtons.Add(grid.Columns.Count - 1, new GridControlButtomModel()
            {
                Text = title,
                OnClick = onClick
            });
            return this;
        }

        public  GridControl<TModel> AddTextBoxColumn<TProperty>(Expression<Func<TModel,TProperty>>selector,string title)
        {
            var propertyName = new ExpressionHandler().GetPropertyName(selector);
            grid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText=title,
                DataPropertyName=propertyName
            });
            return this;
        }
        public GridControl<TModel> setDataSource(IEnumerable<TModel> dataSource)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            grid.DataSource = bindingSource;
            bindingSource.ResetBindings(true);
            return this;
        }
        public void RemoveCurrent()
        {
            bindingSource.RemoveCurrent();
            ResetBindings();
        }
        public void AddItem(TModel item)
        {
            bindingSource.Add(item);
            ResetBindings();
        }
        public void ResetBindings()
        {
            bindingSource?.ResetBindings(true);
        }
        public TModel CurrentItem
        {
            get
            {
                return (TModel)bindingSource?.Current;
            }
        }
    }
}
