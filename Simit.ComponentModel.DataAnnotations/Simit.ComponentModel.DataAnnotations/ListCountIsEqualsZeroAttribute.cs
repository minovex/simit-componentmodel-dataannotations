namespace Simit.ComponentModel.DataAnnotations
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    #endregion

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class ListCountIsEqualsZeroAttribute : AlertMessageAttribute
    {
        #region Public Methods
        public override bool IsValid(object value)
        {
            return (value == null || ((int)value.GetType().GetProperty("Count").GetValue(value, null)) == 0);
        }
        #endregion

        #region Public Properties
        public override Type ExpectedType
        {
            get { return typeof(List<>); }
        }
        #endregion
    }
}
