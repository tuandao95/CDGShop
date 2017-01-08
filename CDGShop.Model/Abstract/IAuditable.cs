﻿using System;

namespace CDGShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }

        string CreatedBy { set; get; }

        DateTime? UpdateDate { set; get; }

        string UpdateBy { set; get; }

        string MetaKeyword { set; get; }

        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}