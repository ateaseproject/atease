using System.Linq;
using System.Linq.Expressions;

namespace Achehre.Framework.Extenstions.Linq
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string propertyName)

        {
            return (IQueryable<T>) OrderBy((IQueryable) source, propertyName);
        }

        public static IQueryable OrderBy(this IQueryable source, string propertyName)

        {
            var x = Expression.Parameter(source.ElementType, "x");

            var selector = Expression.Lambda(Expression.PropertyOrField(x, propertyName), x);

            return source.Provider.CreateQuery(
                Expression.Call(typeof(Queryable), "OrderBy",
                    new[] {source.ElementType, selector.Body.Type},
                    source.Expression, selector
                ));
        }

        public static IQueryable<T> OrderDescendingBy<T>(this IQueryable<T> source, string propertyName)

        {
            return (IQueryable<T>) OrderDescendingBy((IQueryable) source, propertyName);
        }

        public static IQueryable OrderDescendingBy(this IQueryable source, string propertyName)

        {
            var x = Expression.Parameter(source.ElementType, "x");

            var selector = Expression.Lambda(Expression.PropertyOrField(x, propertyName), x);

            return source.Provider.CreateQuery(
                Expression.Call(typeof(Queryable), "OrderByDescending",
                    new[] {source.ElementType, selector.Body.Type},
                    source.Expression, selector
                ));
        }
    }
}