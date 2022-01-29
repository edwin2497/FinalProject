using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class Logout
    {

        #region Properties

        [Required] public bool  LogOut { get; set; }

        #endregion
    }
}