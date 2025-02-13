using Avalonia.VisualTree;
using System.Linq;

namespace Aura.UI.Extensions
{
    public static class VisualExtensions
    {
        public static T GetParentTOfVisual<T>(this IVisual visual) where T : class
        {
            return visual.GetSelfAndVisualAncestors().OfType<T>().FirstOrDefault<T>();
        }
    }
}