﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RothburyDrive.Pages
{
    public class GalleryModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Further images of Rothbury Drive @ NE63 8TJ";
        }
    }
}