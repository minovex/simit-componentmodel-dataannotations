namespace Minovex.ComponentModel.DataAnnotations
{
    #region Using Directives
    using System;
    #endregion

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class BooleanIsTrueAttribute : AlertMessageAttribute
    {
        #region Public Methods
        public override bool IsValid(object value)
        {
            return (bool)value == true;
        }
        #endregion

        #region Public Properties

        public override Type ExpectedType
        {
            get { return typeof(bool); }
        }
        #endregion
    }
}
