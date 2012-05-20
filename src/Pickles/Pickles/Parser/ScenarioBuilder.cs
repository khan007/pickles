﻿#region License

/*
    Copyright [2011] [Jeffrey Cameron]

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

#endregion

using System.Collections.Generic;

namespace Pickles.Parser
{
    internal class ScenarioBuilder
    {
        private readonly List<Step> steps;
        private readonly List<string> tags;
        private string description;
        private string name;

        public ScenarioBuilder()
        {
            steps = new List<Step>();
            tags = new List<string>();
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public void AddStep(Step step)
        {
            steps.Add(step);
        }

        public void AddTags(List<string> tags)
        {
            this.tags.AddRange(tags);
        }

        public Scenario GetResult()
        {
            return new Scenario
                       {
                           Name = name,
                           Description = description,
                           Steps = new List<Step>(steps),
                           Tags = new List<string>(tags)
                       };
        }
    }
}