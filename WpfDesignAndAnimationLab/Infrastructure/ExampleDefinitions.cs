﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDesignAndAnimationLab.AnimationDemos.OutlinedText;

namespace WpfDesignAndAnimationLab.Infrastructure
{
    public class ExampleDefinitions
    {
        public static ExampleDefinition[] Definitions { get; } = {
             new ExampleDefinition("Outlined Text",null,
                new ExampleDefinitionItem("Demo1",typeof(Demo1Page)),
                new ExampleDefinitionItem("Demo2",typeof(Demo2Page)),
                new ExampleDefinitionItem("Demo3",typeof(Demo3Page)),
                new ExampleDefinitionItem("Demo4",typeof(Demo4Page)),
                new ExampleDefinitionItem("Demo5",typeof(Demo5Page)),
                new ExampleDefinitionItem("Demo6",typeof(Demo6Page)),
                new ExampleDefinitionItem("Demo7",typeof(Demo7Page)),
                new ExampleDefinitionItem("Demo8",typeof(Demo8Page))
              ),

            new ExampleDefinition("Demo",null,typeof(OutlinedTextDemoPage)),
            new ExampleDefinition("Demo",null,typeof(OutlinedTextDemoPage)),
            new ExampleDefinition("Demo",null,typeof(OutlinedTextDemoPage)),
            new ExampleDefinition("Demo",null,typeof(OutlinedTextDemoPage)),
            new ExampleDefinition("Demo",null,typeof(OutlinedTextDemoPage)),
        };
    }

}