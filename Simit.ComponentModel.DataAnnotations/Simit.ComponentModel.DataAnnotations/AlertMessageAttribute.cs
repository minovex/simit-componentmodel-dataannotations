namespace Simit.ComponentModel.DataAnnotations
{
    #region Using Directives
    using System;
    #endregion

    public abstract class AlertMessageAttribute : Attribute
    {
        #region Public Enums
        public enum HttpMethod
        {
            GET = 1,
            POST = 2,
            PUT = 4,
            DELETE = 8,
            HEAD = 16,
            PATCH = 32,
            OPTIONS = 64
        }
        #endregion

        #region Public Properties
        public string MessageResourceName { get; set; }
        public Type MessageResourceType { get; set; }
        public bool ForNextPage { get; set; }

        public string Message { get; set; }

        public Alert.Type Type { get; set; }
        public HttpMethod ForHttpMethod { get; set; }

        public string PropertyName { get; set; }
        public abstract Type ExpectedType { get; }
        #endregion

        #region Public Constructor
        protected AlertMessageAttribute()
        {
            this.ForNextPage = false;
        }
        #endregion

        #region Public Methods
        public abstract bool IsValid(object value);
        #endregion
    }
}
