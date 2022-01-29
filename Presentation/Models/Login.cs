using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class Login
    {
        #region Properties

        [Required] public int CardId { get; set; }

        [Required] public string Password { get; set; }

        #endregion
    }
}