﻿using System;
using System.Collections.Generic;

namespace ASPNetCoreInventory.Models;

public partial class Category
{
    public int CategoryID { get; set; }

    public string CategoryName { get; set; } = null!;

    public int? CategoryStatus { get; set; }
}
