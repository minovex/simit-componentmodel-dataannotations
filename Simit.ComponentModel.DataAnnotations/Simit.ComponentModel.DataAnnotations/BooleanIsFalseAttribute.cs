namespace Minovex.ComponentModel.DataAnnotations
{
    #region Using Directves
    using System;
    #endregion

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class BooleanIsFalseAttribute : AlertMessageAttribute
    {
        #region Public Methods
        public override bool IsValid(object value)
        {
            return (bool)value == false;
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
