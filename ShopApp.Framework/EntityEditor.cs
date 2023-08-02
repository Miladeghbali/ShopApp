using ShopApp.Framework.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Framework
{
   public  class EntityEditor<TEntity>:ViewBase where TEntity:class,new()
    {
        public List<EntityEditorControl> createdControls = new List<EntityEditorControl>();
        public TEntity Entity { get; set; }
        private TEntity entityCopy;
        public EntityEditor()
        {
            Entity = new TEntity();
            AddAction("تائید", btn => CloseView(System.Windows.Forms.DialogResult.OK));
            AddAction("صرفنظر", btn => 
            {
                var entityProperties = typeof(TEntity).GetProperties();
                foreach (var property in entityProperties)
                {
                    property.SetValue(Entity, property.GetValue(entityCopy));
                }
                CloseView(System.Windows.Forms.DialogResult.Cancel);
            });
            Load += (sender, e) =>
            {
                entityCopy = new TEntity();
                var entityProperties = typeof(TEntity).GetProperties();
                foreach (var property in entityProperties)
                {
                    property.SetValue(entityCopy, property.GetValue(Entity));
                }
            };
        }

        protected TextBox  TextBox<TProperty>(Expression<Func<TEntity,TProperty>> selector, string title,bool multiline=false)
        {
            var label = new Label();
            label.Text = title;
            label.AutoSize = true;
            var textBox = new TextBox();
            this.Controls.Add(label);
            this.Controls.Add(textBox);
            textBox.DataBindings.Add("Text", Entity, new ExpressionHandler().GetPropertyName(selector));
            textBox.Left = 20;
            textBox.Top = 10;
            textBox.Width = 200;
            textBox.Multiline = true;
            if (multiline)
            {
                textBox.ScrollBars = ScrollBars.Vertical;
                textBox.Height = 150;               
            }
            createdControls.Add(new EntityEditorControl()
            {
                Label = label,
                Control = textBox,
                Priority = createdControls.Count+1
            }) ;
            
            return textBox;
        }
        protected TextBox TextBox( string title, bool multiline = false)
        {
            var label = new Label();
            label.Text = title;
            label.AutoSize = true;
            var textBox = new TextBox();
            this.Controls.Add(label);
            this.Controls.Add(textBox);            
            textBox.Left = 20;
            textBox.Top = 10;
            textBox.Width = 200;
            textBox.Multiline = true;
            if (multiline)
            {
                textBox.ScrollBars = ScrollBars.Vertical;
                textBox.Height = 150;
            }
            createdControls.Add(new EntityEditorControl()
            {
                Label = label,
                Control = textBox,
                Priority = createdControls.Count + 1
            });

            return textBox;
        }
        protected Dropdown DatePicker(Expression<Func<TEntity,DateTime>> selector,string title)
        {
            var label = new Label();
            label.Text = title;
            label.AutoSize = true;           
            var propertyName = new ExpressionHandler().GetPropertyName(selector);
            var dropdown1 = new Framework.Dropdown();
            dropdown1.Value = selector.Compile()(Entity).ToString("yyyy/MM/dd");
            dropdown1.RightToLeft = RightToLeft.No;
            dropdown1.InputMask = "0000/00/00";
            dropdown1.Tag = selector.Compile()(Entity);
            dropdown1.OnValueChanged += (obj, args) =>
            {
                dropdown1.Tag = dropdown1.Value.ConvertToDate();
                Entity.GetType().GetProperty(propertyName).SetValue(Entity, dropdown1.Tag);
            };
            dropdown1.GetDropdownControl += () =>
            {
                var picker = new Framework.DateTimePicker();
                picker.OnDateDoubleClick += (obj, args) =>
                {
                    dropdown1.CloseDropdown();
                };
                if (dropdown1.Tag != null)
                {
                    picker.SelectedDate = (DateTime)dropdown1.Tag;
                }
                picker.OnSelectedDateChanged += (s, args) =>
                {
                    dropdown1.Value = picker.SelectedDate.ToString("yyyy/MM/dd");
                    dropdown1.Tag = picker.SelectedDate;
                    Entity.GetType().GetProperty(propertyName).SetValue(Entity, dropdown1.Tag);
                };
                return picker;
            };
            this.Controls.Add(label);
            this.Controls.Add(dropdown1);
            createdControls.Add(new EntityEditorControl()
            {
                Label = label,
                Control = dropdown1,
                Priority = createdControls.Count + 1
            });
            return dropdown1;
        }
        protected ComboBox ComboBox<TProperty,TComboItem>(Expression<Func<TEntity, TProperty>> selector, string title,List<TComboItem> items,
            Expression<Func<TComboItem,string>> displaySelector, Expression<Func<TComboItem, TProperty>> valueSelector)
            {
            var expressionHandler = new ExpressionHandler();
            var label = new Label();
            label.AutoSize = true;
            label.Text = title;
            this.Controls.Add(label);
            var comboBox = new ComboBox();
            this.Controls.Add(comboBox);
            comboBox.DataBindings.Add("SelectedValue", Entity, expressionHandler.GetPropertyName(selector));
            comboBox.DataSource = items;
            comboBox.DisplayMember = expressionHandler.GetPropertyName(displaySelector);
            comboBox.ValueMember = expressionHandler.GetPropertyName(valueSelector);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            createdControls.Add(new EntityEditorControl()
            {
                Label = label,
                Control = comboBox,
                Priority = createdControls.Count + 1
            });
            return comboBox;
        }
        public ComboBox TrueFalseComboBox(Expression<Func<TEntity, bool>> selector,string title)
        {
            List<ComboItem<bool>> items = new List<ComboItem<bool>>();
            items.Add(new ComboItem<bool>() { Display = "بله", Value = true });
            items.Add(new ComboItem<bool>() { Display = "خیر", Value = false });
            return ComboBox(selector, title, items, item => item.Display, item => item.Value);
        }
        protected void AdjustControls()
        {
            ((Form)this.Parent).Width = 800;
            var currentTop = 10;
            var maximumLabelWidth = createdControls.Select(c => c.Label).Max(l => l.Width);
            foreach (var item in createdControls.OrderBy(c=>c.Priority))
            {
                item.Label.Left = (this.Width - item.Label.Width)-10;
                item.Label.Top = (currentTop+3);                
                item.Control.Width = (this.Width) - 10 - maximumLabelWidth - 20;
                item.Control.Left =10;
                item.Control.Top = currentTop + 10;
                currentTop += item.Control.Height + 10;
            }
            ((Form)this.Parent).Activated += (form, e) =>
            {
                createdControls.OrderBy(c => c.Priority).First().Control.Focus();
            };
           
            ((Form)this.Parent).Height = currentTop + 80;
        }
        public class EntityEditorControl
        {
            public Label Label { get; set; }
            public Control Control { get; set; }
            public int Priority { get; set; }
        }
        public class ComboItem<TValue>
        {
            public string Display { get; set; }
            public TValue Value { get; set; }
        }

   }
}
