﻿using WpfDesignAndAnimationLab.Demos.ArcProgresses;
using WpfDesignAndAnimationLab.Demos.ColumnProgressBars;
using WpfDesignAndAnimationLab.Demos.FancyTexts;
using WpfDesignAndAnimationLab.Demos.InnerShadows;
using WpfDesignAndAnimationLab.Demos.NintendoSwitchLoadings;
using WpfDesignAndAnimationLab.Demos.OutlinedText;
using WpfDesignAndAnimationLab.Demos.ProgressRings;
using WpfDesignAndAnimationLab.Demos.RainbowButtons;
using WpfDesignAndAnimationLab.Demos.RainbowTexts;
using WpfDesignAndAnimationLab.Demos.TextAndShadows;
using WpfDesignAndAnimationLab.Demos.TextEffects;
using WpfDesignAndAnimationLab.Demos.TextShapes;

namespace WpfDesignAndAnimationLab.Infrastructure
{
    public class ExampleDefinitions
    {
        public static ExampleDefinition[] Definitions { get; } = {
             new ExampleDefinition("Outlined Text",null,
                new ExampleDefinitionItem("Main",typeof(Demo1Page)),
                new ExampleDefinitionItem("Buttons",typeof(OutlinedTextButtonDemo)),
                new ExampleDefinitionItem("Demo5",typeof(Demo5Page)),
                new ExampleDefinitionItem("Demo6",typeof(Demo6Page)),
                new ExampleDefinitionItem("Demo7",typeof(Demo7Page)),
                new ExampleDefinitionItem("Demo8",typeof(Demo8Page))

              ),

            new ExampleDefinition("Fancy Text",null,typeof(FancyTextDemoPage)),
            new ExampleDefinition("TextShape",null,
                new ExampleDefinitionItem("Main",typeof(TextShapeDemo1Page)),
                new ExampleDefinitionItem("StrokeDashOffset ",typeof(TextShapeDemo2Page)),
                new ExampleDefinitionItem("Demo9",typeof(TextShapeDemo3Page))),

              new ExampleDefinition("InnerShadow",null,typeof(InnerShadow)),

               new ExampleDefinition("ArcProgressBar",null,
                new ExampleDefinitionItem("Basic",typeof(ArcProgressDemo)),
                new ExampleDefinitionItem("Design ",typeof(ArcProgressDesignDemo))),

                 new ExampleDefinition("TextAndShadows",null,
                new ExampleDefinitionItem("Demo1",typeof(TextAndShadowDemo1)),
                 new ExampleDefinitionItem("Demo2",typeof(TextAndShadowDemo2))
                ),

               new ExampleDefinition("RainbowText",null,
                new ExampleDefinitionItem("Basic",typeof(RainbowTextDemo1)),
                new ExampleDefinitionItem("Animation",typeof(RainbowTextWithAnimation)),
                new ExampleDefinitionItem("Wave",typeof(RainbowTextWithWave)),
                new ExampleDefinitionItem("Random",typeof(RainbowTextWithRandom))),

                 new ExampleDefinition("ColumnProgressBar",null,
                new ExampleDefinitionItem("ColumnProgressBar",typeof(ColumnProgressBarDemo))
                     ),

                 new ExampleDefinition("RainbowButton",null,
                new ExampleDefinitionItem("Apple",typeof(RainbowAppleButton)),
                 new ExampleDefinitionItem("With Glow",typeof(RainbowAppleButtonWithGlow))
                     ),

                    new ExampleDefinition("Nintendo Switch",null,
                 new ExampleDefinitionItem("Loading",typeof(NintendoSwitchLoading)),
                   new ExampleDefinitionItem("eShop",typeof(NintendoEShopLoading))
                     ),
                    new ExampleDefinition("TextEffect",null,
                new ExampleDefinitionItem("Basic",typeof(TextEffectsBasicDemo))
                        ),

                        new ExampleDefinition("Progress Ring",null,
                new ExampleDefinitionItem("Basic",typeof(ProgressRingBasicDemo))
                        )


        };
    }
}
