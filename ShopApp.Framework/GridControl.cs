using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Framework
{
    public class GridControl<TModel>
    {
        DataGridView grid;
        BindingSource bindingSource;
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
