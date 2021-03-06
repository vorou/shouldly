﻿using Shouldly.Tests.TestHelpers;

namespace Shouldly.Tests.ShouldNotBeOneOf
{
    public class EnumScenario : ShouldlyShouldTestScenario
    {
        protected override void ShouldThrowAWobbly()
        {
            SomeFlags.Val1.ShouldNotBeOneOf(SomeFlags.Val1);
        }

        protected override string ChuckedAWobblyErrorMessage
        {
            get { return "SomeFlags.Val1 should not be one of [SomeFlags.Val1] but was SomeFlags.Val1"; }
        }

        protected override void ShouldPass()
        {
            SomeFlags.Val1.ShouldNotBeOneOf(SomeFlags.Val2, SomeFlags.Val3);
        }
    }
}