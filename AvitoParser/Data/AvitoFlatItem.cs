﻿using System.Collections.Generic;

namespace MyCompany.Avito.Parser.Data {
   internal class AvitoFlatItem {
      public string Title { get;set;}
      public int Price { get;set;}
      public string Desciption { get; set;}
      public string Address { get;set;}
      public Dictionary<string, string> Params { get;set;}
      public string SellerName { get; set;}
   }
}
