using System;
using System.Collections.Generic;
using System.Linq;
using PatternsInAction.Master;

namespace PatternsInAction
{
    public class Service
    {
        public static Dictionary<PatternsTypes, string> GetTitlePatternType()
        {
            return new Dictionary<PatternsTypes, string>
            {
                { PatternsTypes.CreationalPatterns, "Creational Patterns" },
                { PatternsTypes.StructuralPatterns, "Structural Patterns" },
                { PatternsTypes.BehavioralPatterns, "Behavioral Patterns" }
            };
        }

        public static KeyValuePair<PatternsTypes, Action> GetActionPatternType(PatternsTypes patternType)
        {
            return new Dictionary<PatternsTypes, Action>
            {
                { PatternsTypes.CreationalPatterns, CreationalPatterns.Show },
                { PatternsTypes.StructuralPatterns, StructuralPatterns.Show },
                { PatternsTypes.BehavioralPatterns, BehavioralPatterns.Show }
            }.First(pattern => pattern.Key == patternType);
        }
    }
}