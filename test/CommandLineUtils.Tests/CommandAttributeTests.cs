// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;

namespace McMaster.Extensions.CommandLineUtils.Tests
{
    public class CommandAttributeTests
    {
        [Command(ResponseFileHandling = ResponseFileHandling.ParseArgsAsLineSeparated, AllowArgumentSeparator = true, ThrowOnUnexpectedArgument = false)]
        private class ParsingOptions
        { }

        [Fact]
        public void HandlesParsingOptionsAttribute()
        {
            var app = new CommandLineApplication<ParsingOptions>();
            app.Conventions.UseCommandAttribute();

            Assert.Equal(ResponseFileHandling.ParseArgsAsLineSeparated, app.ResponseFileHandling);
            Assert.True(app.AllowArgumentSeparator);
            Assert.False(app.ThrowOnUnexpectedArgument);
        }
    }
}
