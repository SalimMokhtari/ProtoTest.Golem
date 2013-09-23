﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Golem.Framework;
using Golem.PageObjects.Cael;

namespace Golem.Tests.Cael
{
   public class SmokeTests : TestBaseClass
    {
       public void SmokeTest()
       {
           OpenPage<HomePage>(@"http://lcdev.bluemodus.com/").
               GoToLoginPage().
               Login(UserTests.email, UserTests.password);
       }
    }
}