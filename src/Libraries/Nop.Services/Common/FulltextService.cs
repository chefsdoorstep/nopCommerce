using Nop.Data;

namespace Nop.Services.Common
{
    /// <summary>
    /// Full-Text service
    /// </summary>
    public partial class FulltextService : IFulltextService
    {
        #region Fields

        private INopDataProvider _dataProvider;

        #endregion

        #region Ctor

        public FulltextService(INopDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets value indicating whether Full-Text is supported
        /// </summary>
        /// <returns>Result</returns>
        public virtual bool IsFullTextSupported()
        {
            return _dataProvider.IsFullTextSupported();
        }

        /// <summary>
        /// Enable Full-Text support
        /// </summary>
        public virtual void EnableFullText()
        {
            _dataProvider.FullTextEnable();
        }

        /// <summary>
        /// Disable Full-Text support
        /// </summary>
        public virtual void DisableFullText()
        {
            _dataProvider.FullTextDisable();
        }

        #endregion
    }
}