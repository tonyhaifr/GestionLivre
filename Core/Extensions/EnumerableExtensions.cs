using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Core.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Crée une collection de SelectListItems à partir d'une collection d'éléments T.
        /// </summary>
        /// <typeparam name="T">Classe générique</typeparam>
        /// <typeparam name="TTextProperty">Texte</typeparam>
        /// <typeparam name="TValueProperty">Valeur</typeparam>
        /// <param name="instance">Collection de T</param>
        /// <param name="text">Texte</param>
        /// <param name="value">Valeur</param>
        /// <param name="selectedItem">Sélection par défaut</param>
        /// <returns>SelectListItems</returns>
        public static IEnumerable<SelectListItem> ToSelectList<T, TTextProperty, TValueProperty>(this IEnumerable<T> instance, Func<T, TTextProperty> text, Func<T, TValueProperty> value, Func<T, bool> selectedItem = null)
        {
            return instance.Select(x => new SelectListItem
            {
                Text = Convert.ToString(text(x)),
                Value = Convert.ToString(value(x)),
                Selected = selectedItem != null && selectedItem(x)
            });
        }

        /// <summary>
        /// Crée une collection de AttributeSelectListItems à partir d'une collection d'éléments T.
        /// </summary>
        /// <typeparam name="T">Classe générique</typeparam>
        /// <typeparam name="TTextProperty">Texte</typeparam>
        /// <typeparam name="TValueProperty">Valeur</typeparam>
        /// <typeparam name="TAttributeProperty">Attributs</typeparam>
        /// <param name="instance">Collection de T</param>
        /// <param name="text">Texte</param>
        /// <param name="value">Valeur</param>
        /// <param name="htmlAttributes">Attributs</param>
        /// <param name="selectedItem">Sélection par défaut</param>
        /// <returns>AttributeSelectListItems</returns>
        public static IEnumerable<ExtendedSelectListItem> ToAttributeSelectList<T, TTextProperty, TValueProperty, TAttributeProperty>(this IEnumerable<T> instance, Func<T, TTextProperty> text, Func<T, TValueProperty> value, Func<T, TAttributeProperty> htmlAttributes = null, Func<T, bool> selectedItem = null)
        {
            return instance.Select(x => new ExtendedSelectListItem
            {
                Text = Convert.ToString(text(x)),
                Value = Convert.ToString(value(x)),
                Selected = selectedItem != null && selectedItem(x),
                HtmlAttributes = htmlAttributes != null ? (object)htmlAttributes(x) : null
            });
        }
    }
 
}
