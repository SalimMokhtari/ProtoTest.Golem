﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using ProtoTest.Golem.Core;

namespace ProtoTest.Golem.WebDriver
{
    public class Components<T> : IEnumerable<T> where T : BaseComponent, new()
    {
       private ElementCollection RootElements;

        public Components()
        {
        }

        public Components(OpenQA.Selenium.By by) 
        {
            this.RootElements = new ElementCollection(by);

        }
       public IEnumerator<T> GetEnumerator()
        {
            foreach (var ele in RootElements)
            {
                var el = new T();
                el.root = ele;
                yield return el;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
