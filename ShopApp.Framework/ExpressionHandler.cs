using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Framework
{
   public class ExpressionHandler:ExpressionVisitor
    {
        List<string> visitedProperties = new List<string>();
        public string GetPropertyName(Expression expression)
        {
            visitedProperties.Clear();
            Visit(expression);
            visitedProperties.Reverse();
            return string.Join(".", visitedProperties);

        }
        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Member is PropertyInfo)
                visitedProperties.Add(node.Member.Name);
            return base.VisitMember(node);
        }
    }
}
