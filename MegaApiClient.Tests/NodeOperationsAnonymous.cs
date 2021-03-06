﻿using CG.Web.MegaApiClient.Tests.Context;
using Xunit;
using Xunit.Abstractions;

namespace CG.Web.MegaApiClient.Tests
{
  [Collection("AnonymousLoginTests")]
  public class NodeOperationsAnonymous : NodeOperations
  {
    public NodeOperationsAnonymous(AnonymousTestContext context, ITestOutputHelper testOutputHelper)
      : base(context, testOutputHelper)
    {
    }
  }
}
