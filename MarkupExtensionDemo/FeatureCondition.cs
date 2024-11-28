using System;
using System.Windows.Markup;

namespace MarkupExtensionDemo
{
    public class FeatureCondition : MarkupExtension
    {
        public object WhenEnabled { get; set; }
        public object WhenDisabled { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
#if fix_issue_001
                return WhenEnabled;
#else
            return WhenDisabled;
#endif
        }
    }
}