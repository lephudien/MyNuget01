﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndSoftTestNuget01
{

  public class CheckMFAResponse
  {
    public string AuthorizationStatus { get; set; }
    public string CustomId { get; set; }
  }

  public class NugetMain
  {

    public static void TestJSON()
    { 
      
    }


    public CheckMFAResponse GetResponse()
    {
      string sFileContent = "{\"AuthorizationStatus\":\"Invalid\",\"CustomId\":\"\"}";

      //var serializer = new Newtonsoft.Json.Serialization.j
      var test = Newtonsoft.Json.JsonConvert.DeserializeObject<CheckMFAResponse>(
                 sFileContent,
                 new Newtonsoft.Json.JsonSerializerSettings
                 {
                   ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
                   Formatting = Newtonsoft.Json.Formatting.Indented
                 });

      return test;
    }
  }
}
