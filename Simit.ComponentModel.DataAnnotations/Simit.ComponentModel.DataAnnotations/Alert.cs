namespace Minovex.ComponentModel.DataAnnotations
{
    public sealed class Alert
    {
        #region Public Enums
        public enum Type
        {
            Success,
            Info,
            Warning,
            Error
        }
        #endregion

        #region Public Properties
        public string Meesage { get; set; }
        public Type AlertType { get; set; }
        #endregion
    }
}
