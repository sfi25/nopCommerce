using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.Common
{
    public partial class LogoModel : BaseNopModel
    {
        public bool HasCustomLogo { get; set; }
        public string StoreName { get; set; }

        public string LogoPath { get; set; }
    }
}